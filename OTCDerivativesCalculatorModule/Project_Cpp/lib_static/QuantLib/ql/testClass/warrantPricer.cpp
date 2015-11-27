#include <ql/testClass/warrantPricer.hpp>
#include <iostream>
namespace QuantLib {

WarrantPricer::WarrantPricer(const std::vector<Time> & times,
					   const boost::shared_ptr<StochasticProcess>& process,
					   const Array & S0,
					   const Array & discounts,
					   Real initialStrikeK_,
					   Size pastFixingNum,
					   Size seed,
					   std::vector<Statistics>& additionalStats,
					   Size polynomOrder,
					   LsmBasisSystem::PolynomType polynomType)
    : calibrationPhase_(true),
	  times_(times), process_(process),S0_(S0),discounts_(discounts),initialStrikeK_(initialStrikeK),
	  pastFixingNum_(pastFixingNum),additionalStats_(additionalStats),seed_(seed),
      coeff_     (new Array[times.size()-1]),
      dF_        (discounts),
      v_         (LsmBasisSystem::pathBasisSystem(polynomOrder,polynomType)) {

          QL_REQUIRE(   polynomType == LsmBasisSystem::Monomial
           || polynomType == LsmBasisSystem::Laguerre
           || polynomType == LsmBasisSystem::Hermite
           || polynomType == LsmBasisSystem::Hyperbolic
           || polynomType == LsmBasisSystem::Chebyshev2nd,
           "insufficient polynom type");

			const Size numberOfTimes=times.size()
			driftDt_.resize(numberOfTimes);
			sigmaDt_.resize(numberOfTimes);

			driftDt_[0]=process_->process(i)->drift(times_[0],1.0) * times_[0];
			sigmaDt_[0]=process_->diffusion(times_[0],1.0) * process_->diffusion(times_[0],1.0) * (times_[j]-times_[j-1]) * 0.5;

			for(Size j=1;j<numberOfTimes;++j){
				sigmaDt_[j]=process_->diffusion(times_[0],1.0) * process_->diffusion(times_[0],1.0) * (times_[j]-times_[j-1]) * 0.5;
				drift[j]=process_->drift(times_[0],1.0))*(times_[j]-times_[j-1]);
			}
}
		
void WarrantPricer::transformPath(const std::vector<Real>& rand,Size simul) const {

	std::vector<Real>::const_iterator randSeqIter = rand.begin();
	
    const Size numberOfTimes = timePositions_.size();
	
	std::vector<Array> paths;

	Array S0_=process_->initialValues(); //한방에 나오나?

	for(Size k=0;k<simul;++k){
		SumdZ=S0_;
		strikeK=initialStrikeK_;
		PathInfo info(numberOfTimes);

		for(Size i=0;i<numberOfTimes;++i){
			SumdZ*=std::exp(driftDt_+(*randSeqIter)*sigmaDt_[i]);

			++randSeqIter;
			info.states[i]=SumdZ;

			if (SumdZ < strikeK && refixDateFlag == true )
			{
				strikeK=SumdZ;
				info.exercises[i]=std::max(SumdZ-strikeK,0.0);
				
			}
		}

		paths_.push_back(info);

	}

}

Real WarrantPricer::values(const std::vector<Real>& rand,Size simul) const;

    if (calibrationPhase_) {
        transformPath(rand,simul);
        return 0.0;
    }
	
    const Size len = dF_.size();
	for(Size k=0;k<simul;++k){
		const Array& path=paths_[k];

		Real price = path.exercises[len-1];
		for (Size i=len-2; i>0; --i) {
			price*=dF_[i];

			const Real exercise = path.exercises[i];
			if (exercise > 0.0) {
				const Real regValue = path.states[i];

				Real continuationValue = 0.0;
				for (Size l=0; l<v_.size(); ++l) {
					continuationValue += coeff_[i][l] * v_[l](regValue);
				}

				if (continuationValue < exercise) {
					price = exercise;
				}
			}
		}

		return price*dF_[0];
	}
}

void WarrantPricer::calibrate(Size nCalibrationSamples_) {
		
		const Size n = nCalibrationSamples_;
        Array prices(n), exercise(n);
        const Size len = dF_.size();

        for (Size i=0; i<n; ++i)
            prices[i] = paths_[i].exercises[len-1];

        std::vector<Real>      y;
        std::vector<StateType> x;
        for (Size i=len-2; i>0; --i) {
            y.clear();
            x.clear();

            //roll back step
            for (Size j=0; j<n; ++j) {
                exercise[j]=paths_[j].exercises[i];

                if (exercise[j]>0.0) {
                    x.push_back(paths_[j].states[i]);
                    y.push_back(dF_[i]*prices[j]);
                }
            }

            if (v_.size() <=  x.size()) {
                coeff_[i] = LinearLeastSquaresRegression<StateType>(x, y, v_)
                                .coefficients();
            }
            else {
            // if number of itm paths is smaller then the number of
            // calibration functions then early exercise if exerciseValue > 0
                coeff_[i] = Array(v_.size(), 0.0);
            }

            for (Size j=0, k=0; j<n; ++j) {
                prices[j]*=dF_[i];
                if (exercise[j]>0.0) {
                    Real continuationValue = 0.0;
                    for (Size l=0; l<v_.size(); ++l) {
                        continuationValue += coeff_[i][l] * v_[l](x[k]);
                    }
                    if (continuationValue < exercise[j]) {
                        prices[j] = exercise[j];
                    }
                    ++k;
                }
            }
        }

        calibrationPhase_ = false;
    }
}



} //NameSpace QuantLib
