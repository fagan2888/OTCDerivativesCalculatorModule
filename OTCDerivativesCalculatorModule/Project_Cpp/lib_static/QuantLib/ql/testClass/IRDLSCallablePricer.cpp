#include <ql/testClass/IRDLSCallablePricer.hpp>
#include <fstream>

namespace QuantLib {

    IRDLSCallablePricer::PathInfo::PathInfo(Size numberOfTimes)
        : payments(numberOfTimes, 0.0),
          exercises(numberOfTimes, 0.0),
          states(numberOfTimes) {
    }

    Size IRDLSCallablePricer::PathInfo::pathLength() const {
        return states.size();
    }


    IRDLSCallablePricer::IRDLSCallablePricer(
        const boost::shared_ptr<PayoffLeg>& payoff,
        const std::vector<Size> & timePositions,
        const boost::shared_ptr<StochasticProcessArray>& process,
        const Array & discounts,
		std::vector<Statistics>& additionalStats,
        Size polynomOrder,
        LsmBasisSystem::PolynomType polynomType)
    : calibrationPhase_(true),
      payoff_(payoff),
      coeff_     (new Array[timePositions.size() - 1]),
      lowerBounds_(new Real[timePositions.size()]),
      timePositions_(timePositions),
	  process_(process),
      dF_        (discounts),
	  additionalStats_(additionalStats),
	  earlyExProbability_(additionalStats.size()),
      v_         (LsmBasisSystem::multiPathBasisSystem(process->size(),
                                                       polynomOrder,
                                                       polynomType)) {
        QL_REQUIRE(   polynomType == LsmBasisSystem::Monomial
                   || polynomType == LsmBasisSystem::Laguerre
                   || polynomType == LsmBasisSystem::Hermite
                   || polynomType == LsmBasisSystem::Hyperbolic
                   || polynomType == LsmBasisSystem::Chebyshev2nd,
                   "insufficient polynom type");
		dummydF_=Array(discounts.size(),1.0);
		
		for(Size i=1;i<discounts.size();++i)
			dummydF_[i]=discounts[i-1];

	  	Matrix corr = process_->correlation();
  		chol_=CholeskyDecomposition(corr);
		
		corrCoff_=Array(2);
		corrCoff_[0]=chol_[1][0];
		corrCoff_[1]=chol_[1][1];
		expectedBondPrice_=0.0;
		indexType_=payoff_->indexType();

    }

    /*
      Extract the relevant information from the whole path
     */
	void IRDLSCallablePricer::transformPath(const std::vector<Real>& rand,Size simul)
    const {

		std::vector<Real>::const_iterator randSeqIter = rand.begin();
		
		//if (!calibrationPhase_) {randSeqIter=randSeqIter+paths_.size();}
		const Size numberOfAssets = process_->size();
        const Size numberOfTimes = timePositions_.size();
		Size maxNum=rand.size()/(numberOfTimes*numberOfAssets);
		Real nominal=payoff_->nominal();

		std::vector<std::vector<Array>> paths(numberOfAssets);

		Array initial_r0=process_->initialValues(); //한방에 나오나?
		
		//----------------- corr부분 3이상의 경우 수정 요망 --------------------
		std::vector<std::vector<Real>> randz(numberOfAssets);
		
		//for(Size i=0;i<numberOfAssets;++i){
		//	if(calibrationPhase_){
		//		/*randz[i]=std::vector<Real>(rand.begin()+(numberOfTimes*simul)*i + ,
		//								   rand.begin()+(numberOfTimes*simul)*(i+1) + );*/
		//		randz[i]=std::vector<Real>(rand.begin()+maxNum*numberOfTimes*i,
		//								   rand.begin()+maxNum*numberOfTimes*i+simul*numberOfTimes );
		//	}
		//	else{
		//		randz[i]=std::vector<Real>(rand.begin()+maxNum*numberOfTimes*i+(paths_.size()*numberOfTimes),
		//								   rand.begin()+maxNum*numberOfTimes*(i+1)); //path_ 다시 돌때 비어있어야함.
		//	}
		//}
		for(Size i=0;i<numberOfAssets;++i){
			randz[i]=std::vector<Real>(rand.begin()+(numberOfTimes*simul)*i,rand.begin()+(numberOfTimes*simul)*(i+1));
		
		}

		if(numberOfAssets==2){
			for(Size i=0;i<simul*numberOfTimes;++i){
				randz[1][i]=corrCoff_[0]*randz[0][i]+corrCoff_[1]*randz[1][i];
			}
		}
		//----------------------------------------------------------------------
		
		for(Size i=0;i<numberOfAssets;++i){
			paths[i]=std::vector<Array>(simul,Array(numberOfTimes, Null<Real>()));
			for(Size j=0;j<simul;++j){	
				paths[i][j][0]=initial_r0[i];
			}
			process_->process(i)->indexAdjustment(paths[i],randz[i],indexType_[i]);
			
		}
		
		std::vector<Array> path(numberOfAssets);

		//std::ofstream fout;
		//fout.open("LS");


		for(Size k=0;k<simul;++k){
			for(Size j=0;j<numberOfAssets;++j){
				path[j]=paths[j][k];
			}

			PathInfo info(numberOfTimes);//있어야하나..?

			payoff_->value(path, info.payments, info.exercises, info.states);
		
			Real discountedBondValue=0.0;

			for(Size i=1;i<numberOfTimes;i++){
				discountedBondValue = std::inner_product(info.payments.begin()+i,info.payments.end(),
														dF_.begin()+i,nominal*dF_.back())/dummydF_[i];
				info.exercises[i-1] = std::max( discountedBondValue - nominal, 0.0);
			}

			expectedBondPrice_+=(std::inner_product(info.payments.begin(),info.payments.end(),
														dF_.begin(),nominal*dF_.back()));;
			//fout << (std::inner_product(info.payments.begin(),info.payments.end(),
			//	dF_.begin(),nominal*dF_.back()))<< std::endl;
			paths_.push_back(info); //복사 됨/.

			/*for(Size i=0;i<numberOfTimes;i++){
				additionalStats_[i].add(info.payments[i]);
			}*/

		}

		//if (!calibrationPhase_) {expectedBondPrice_=expectedBondPrice_/paths_.size();}
		expectedBondPrice_=expectedBondPrice_/paths_.size();
		

//		return paths_;
    }

	Real IRDLSCallablePricer::values(const std::vector<Real>& rand,Size simul) const {
		

        if (calibrationPhase_) {
            transformPath(rand,simul);
            return 0.0;
        }

		Real value=0.0;
		Real nominal=payoff_->nominal();
		const Size len = paths_[0].pathLength();
		//const Size pathNum=paths_.size();
		for(Size k=0;k<simul;++k){
			PathInfo& path=paths_[k];
			// exercise at time t, cancels all payment AFTER t
			
			
			Real price = 0.0;
			Size exerciseTimeFlag=len - 1;

			// this is the last event date
			{
				const Real payoff = path.payments[len - 1];
				const Real exercise = path.exercises[len - 1];
				const Array & states = path.states[len - 1];
				const bool canExercise = true;//!states.empty();
					price += exercise;
			}

			for (Integer i = len - 2; i >= 0; --i) {
				price *= dF_[i + 1] / dF_[i];

				const Real exercise = path.exercises[i];
				const Array & states = path.states[i];
				const bool canExercise = true;//!states.empty();

				if (canExercise) {
					
					if (!coeff_[i].empty() && exercise > 0.0) {//lowerBounds_[i]) {
	                    
						Real continuationValue = 0.0;

						for (Size l = 0; l < v_.size(); ++l) {
							continuationValue += coeff_[i][l] * v_[l](states);
						}
	                    
						if ( exercise > continuationValue) {
							price = exercise;
							exerciseTimeFlag=i;
						}
					}
				}
			}

			earlyExProbability_[exerciseTimeFlag] += 1.0;

			for(Size i = 0;i<len;++i){
				if(i<exerciseTimeFlag){
					additionalStats_[i].add(path.payments[i]);
				}
				else if(i==exerciseTimeFlag){
					additionalStats_[i].add(path.payments[i]+nominal);
				}
				else{
					additionalStats_[i].add(0.0);
				}
			}
			value+=price * dF_[0];
		}
        return value/simul;
    }

    void IRDLSCallablePricer::calibrate(Size nCalibrationSamples_) {
        
		const Size n = nCalibrationSamples_;//paths_.size(); // number of paths
        Array prices(n, 0.0), exercise(n, 0.0);

        const Size basisDimension = process_->size();

        const Size len = paths_[0].pathLength();

        /*
          We try to estimate the lower bound of the continuation value,
          so that only itm paths contribute to the regression.
         */
		const bool canExercise = true;//!states.empty();
        for (Size j = 0; j < n; ++j) {
            const Real payoff = paths_[j].payments[len - 1];
            const Real exercise = paths_[j].exercises[len - 1];
            const Array & states = paths_[j].states[len - 1];
            

            // at the end the continuation value is 0.0
            if (canExercise && exercise > 0.0)
                prices[j] += exercise;
            //prices[j] += payoff;
        }

        lowerBounds_[len - 1] = *std::min_element(prices.begin(), prices.end());

        std::vector<bool> lsExercise(n);

        for (Integer i = len - 2 ; i >= 0; --i) {
            std::vector<Real>  y;
            std::vector<Array> x;

            // prices are discounted up to time i
            const Real discountRatio = dF_[i + 1] / dF_[i];
            prices *= discountRatio;
            lowerBounds_[i + 1] *= discountRatio;

            //roll back step
            for (Size j = 0; j < n; ++j) {
                exercise[j] = paths_[j].exercises[i];

                // If states is empty, no exercise in this path
                // and the path will not partecipate to the Lesat Square regression

                const Array & states = paths_[j].states[i];
                QL_REQUIRE(states.empty() || states.size() == basisDimension, 
                           "Invalid size of basis system");

                // only paths that could potentially create exercise opportunities
                // partecipate to the regression

                // if exercise is lower than minimum continuation value, no point in considering it
				if (canExercise && exercise[j] > 0.0 ) {//lowerBounds_[i + 1]) {
                    x.push_back(states);
                    y.push_back(prices[j]);
                }

				//const Real payoff = paths_[j].payments[i];
				//prices[j] += payoff;	

            }
	/*		Real a[3];
			Real b[3];
			Real c[3];*/

            if (v_.size() <=  x.size()) {
                coeff_[i] = LinearLeastSquaresRegression<Array>(x, y, v_)
                                                            .coefficients();
			/*	a[0]=coeff_[i][0];
				a[1]=coeff_[i][1];
				a[2]=coeff_[i][2];*/
            }
            else {
            // if number of itm paths is smaller then the number of
            // calibration functions -> never exercise
 //---------------------수정해야함               QL_TRACE("Not enough itm paths: default decision is NEVER");
                coeff_[i] = Array(0);
            }

            /* attempt to avoid static arbitrage given by always or never exercising.

               always is absolute: regardless of the lowerBoundContinuationValue_ (this could be changed)
               but it still honours "canExercise"
             */

		}
        // remove calibration paths
        //paths_.clear();
        // entering the calculation phase
		calibrationPhase_ = false;
		//expectedBondPrice_=0.0;
		
	}

}











//if(numberOfAssets==2){
//				evolveRate[0]=process_->process(0)->evolveSaved(initial_r0[0],*randSeqIter,1);
//				path[0][0] = process_->process(0)->indexAdjustment(evolveRate[0],1,indexType_[0]);
//				evolveRate[1]=process_->process(1)->evolveSaved(initial_r0[1],corrCoff_[0]*(*randSeqIter)+corrCoff_[1]*(*(randSeqIter+1)),1);
//				path[1][0] = process_->process(1)->indexAdjustment(evolveRate[1],1,indexType_[1]);
//				
//
//				for (Size i = 1; i <numberOfTimes; ++i) {
//					//convert instantanious Rate -> Spot Rate
//					randSeqIter++;
//					randSeqIter++;
//
//					evolveRate[0]=process_->process(0)->evolveSaved(evolveRate[0],*randSeqIter,i+1);
//					path[0][i] = process_->process(0)->indexAdjustment(evolveRate[0],i+1,indexType_[0]);
//
//					evolveRate[1]=process_->process(1)->evolveSaved(evolveRate[1],corrCoff_[0]*(*randSeqIter)+corrCoff_[1]*(*(randSeqIter+1)),i+1);
//					path[1][i] = process_->process(1)->indexAdjustment(evolveRate[1],i+1,indexType_[1]);
//					
//				}
//				
//				randSeqIter++;
//				randSeqIter++;
//			}else{QL_REQUIRE(numberOfAssets==2,"IndexNum must be two");}