#include <ql/testClass/MCELSGeneralEngine.hpp>

namespace QuantLib {

MCELSGeneralEngine::MCELSGeneralEngine(
             const boost::shared_ptr<StochasticProcessArray>& process,
			 const Handle<YieldTermStructure> & discountTS,
             Size maxSamples,
             BigNatural seed)
    : process_(process),discountTS_(discountTS),
      maxSamples_(maxSamples), seed_(seed) {
		QL_REQUIRE(discountTS_->referenceDate() == Settings::instance().evaluationDate(),
					"TS's referenceDate("<< discountTS_->referenceDate() <<") isn't same to evaluationDate("
					<< Settings::instance().evaluationDate() <<")");
        this->registerWith(process_);
		
    }


TimeGrid MCELSGeneralEngine::timeGrid() const {
    const std::vector<Date> & fixings = this->arguments_.fixingDates;
	const Size numberOfFixings = fixings.size();
	std::vector<Date> remainfixings;
	
	Date today = Settings::instance().evaluationDate();
	
	for(Size i=0;i<numberOfFixings;++i){
		if(fixings[i]>today){
			remainfixings.push_back(fixings[i]);
		}
	}

	const Size numberOfRemainFixings = remainfixings.size();

    std::vector<Time> fixingTimes;//(numberOfFixings); //이거 내가 추가한건가..?

    for (Size i = 0; i < numberOfRemainFixings; ++i) {
        //fixingTimes[i] = this->process_->time(fixings[i]);
		if(fixings[i]>today){
			fixingTimes.push_back(discountTS_->dayCounter().yearFraction(
                                       today, remainfixings[i]));
		}
    }

    const Size numberOfTimeSteps = numberOfRemainFixings;//timeSteps_ != Null<Size>() ? timeSteps_ : timeStepsPerYear_ * static_cast<int>(fixingTimes.back());

    //return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
	return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
}

boost::shared_ptr<ELSGeneralPricer> MCELSGeneralEngine::pathPricer() const{

   /*boost::shared_ptr<GeneralizedBlackScholesProcess> process =
		  boost::dynamic_pointer_cast<GeneralizedBlackScholesProcess>(
	                                               process_->process(0));
    QL_REQUIRE(process, "Black-Scholes process required");*/

    TimeGrid theTimeGrid = timeGrid();

    const std::vector<Time> & times = theTimeGrid.mandatoryTimes();
    Size numberOfTimes = times.size();
	Size numAssets = process_->size();
	Size pastFixingNum=this->arguments_.pastFixingDateNum;
	const std::vector<Date> & fixings = this->arguments_.fixingDates;
	const std::vector<boost::shared_ptr<StockIndex>>& refIndex=arguments_.refIndex;
	DayCounter dayCounter = this->arguments_.dayCounter;
	std::vector<Real> initialValues = this->arguments_.initialValues;
	std::vector<Real> dividends = this->arguments_.dividends; // 후에 TS로 수정
	bool KIflag;
	CheckKIType checkKIType=this->arguments_.checkKIType;
	std::vector<Real> redemCoupon= this->arguments_.redemCoupon;
	std::vector<Date> remainfixings;
	
	QL_REQUIRE(numAssets == refIndex.size(), "Index Number must be same ProcessSize");

	//오늘일자를 TS에서 가져옴.
    Date today = Settings::instance().evaluationDate();

	Size numberOfFixings = fixings.size();

	for(Size i=0;i<numberOfFixings;++i){
		if(fixings[i]>today){
			remainfixings.push_back(fixings[i]);
		}
	}

    Size numberOfRemainFixings = remainfixings.size();

	additionalStats_.resize(numberOfTimes+pastFixingNum);
	underlyingValue_.resize(numAssets);
    QL_REQUIRE(numberOfRemainFixings == numberOfTimes, "Invalid dates/times");
	
	// 쿠폰 statistics //추가 조기상환 확률 이딴거.
	//resultStatistics.resize(numberOfTimes);
	
	//sampleAccumulator();
    std::vector<Size> timePositions(numberOfTimes);
    Array discountFactors(numberOfTimes);

    for (Size i = 0; i < numberOfTimes; ++i) {
        //timePositions[i] = theTimeGrid.index(times[i]);
        discountFactors[i] = discountTS_->discount(times[i]);
    }
	Size m=0;
	if(checkKIType==DailyKI){m=6;}
	else if(checkKIType==ContiKI){m=7;}
	else{m=2;}

	Size powM=pow(2.0,static_cast<int>(m));

	Matrix KIbarrierValues_Chg(numAssets,powM*numberOfTimes,0.0);
	Matrix earlyExValues_Chg(numAssets,numberOfTimes,0.0);

	Array x0(numAssets);
	Array KIRedemPayoffs(numAssets);
	Array drift(numAssets);
	Array sigma(numAssets);
	
	const std::vector<Real>& KIbarrierValue = this->arguments_.KIbarrier;
	
	// KI이 없는 경우에 true로 체크함.
	if(KIbarrierValue.front()==0.0){
		KIflag = true;
	}else{
		KIflag = this->arguments_.KIflag;
	}
	
	//Size m=6;


	
	const std::vector<Real>& earlyExValues = this->arguments_.earlyExTriggers;

	for(Size i=0;i<numAssets;++i){
		
		if(process_->process(i)->x0()<0.00001){
			
			x0[i]=std::log((refIndex[i]->fixing(Settings::instance().evaluationDate()))/initialValues[i]);
			underlyingValue_[i]=refIndex[i]->fixing(Settings::instance().evaluationDate());
		}else{
			x0[i]=std::log((process_->process(i)->x0())/initialValues[i]);
			underlyingValue_[i]=process_->process(i)->x0();
		}
		
		sigma[i]=process_->process(i)->diffusion(times[0],1.0) ; // 변동성 조정 필요

		if(process_->process(i)->drift(times[0],1.0)<0.00001){
			drift[i]= discountTS_->zeroRate(times.back(),Compounded,Annual,false) - dividends[i]; //discountTS_->zeroRate(times.back(),Compounded,Annual,false);
		}else{
			drift[i]= process_->process(i)->drift(times[0],1.0) - dividends[i]; //discountTS_->zeroRate(times.back(),Compounded,Annual,false);
		}

		KIRedemPayoffs[i]=exp((drift[i]-0.5*sigma[i]*sigma[i])*times.back());

		//drift 이거 dividend 추가해야함.

		for(Size j=0;j<numberOfTimes;++j){
			earlyExValues_Chg[i][j]=(std::log(earlyExValues[j])-(drift[i]-0.5*sigma[i]*sigma[i])*times[j]);
			
			//for(Size k=0;k<(64*numberOfTimes);++k){
			for(Size k=0;k<powM;++k){
				KIbarrierValues_Chg[i][powM*j+k]=(std::log(KIbarrierValue[i])-(drift[i]-0.5*sigma[i]*sigma[i])*(theTimeGrid[j]+theTimeGrid.dt(j)*static_cast<Real>(k)/static_cast<Real>(powM)));
				
			}
//			std::cout << KIbarrierValues_Chg << std::endl;
//			std::cout << " --------------------------------------------------------------"<< std::endl;
		}
	}
    /*return boost::shared_ptr<ELSPricer>(
                    new ELSStepDownPricer(times,process_,x0,discountFactors,KIRedemPayoffs,earlyExValues_Chg,KIbarrierValues_Chg,
                                  redemCoupon,pastFixingNum,additionalStats_,KIflag));*/

	return boost::shared_ptr<ELSGeneralPricer>(
                    new ELSGeneralPricer(times,process_,x0,underlyingValue_,dividends,discountFactors,
								KIRedemPayoffs,earlyExValues_Chg,KIbarrierValues_Chg,KIbarrierValue,earlyExValues,
                                  redemCoupon,theTimeGrid,pastFixingNum,seed_,additionalStats_,checkKIType,KIflag));
}


}

