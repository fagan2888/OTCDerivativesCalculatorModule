#ifndef quantlib_copulasurvivalratestructure_hpp
#define quantlib_copulasurvivalratestructure_hpp

#include <ql/termstructures/defaulttermstructure.hpp>
#include <ql/experimental/credit/onefactorgaussiancopula.hpp>
#include <ql/termstructures/credit/interpolatedsurvivalprobabilitycurve.hpp>
#include <ql/termstructures/credit/survivalprobabilitystructure.hpp>
#include <ql/termstructures/credit/copulahazardrate.hpp>
#include <ql/time/daycounters/all.hpp>
#include <ql/termstructures/all.hpp>
#include <ql/termstructures/credit/all.hpp>

namespace QuantLib{
	/*HazardRateTS를 받아서 의 경우에만 생각 했으며,
	 DefaultProb 또는 SurvivalProb 까지 template로 받으려면
	 대규모 수정이 필요하여 차후에 작성*/

	//Average HazardRate를 받으면 안대고 forward로 spread 구해서 harzardRate를 받아야함.
	
	template<class TraitProb>
	class CopulaSurvivalProbStructure : public DefaultProbabilityTermStructure {
	public:
		CopulaSurvivalProbStructure(
				const std::vector<boost::shared_ptr<DefaultProbabilityTermStructure>>& probabilities,
				const Handle<Quote>& correlation,
				Size n=1,
				Real maximum = 5.0, Size integrationsSteps=200)
				//: InterpolatedSurvivalProbabilityCurve<Interpolator>(probabilities[0]->referenceDate(),probabilities[0]->dayCounter()),
				: DefaultProbabilityTermStructure(probabilities[0]->referenceDate(),NullCalendar(),SimpleDayCounter()),
				probabilities_(probabilities),n_(n),max_(maximum) 
		{
					
			copula_=boost::shared_ptr<OneFactorGaussianCopula>(new OneFactorGaussianCopula(correlation,maximum,integrationsSteps));
				
			for(Size i=0;i<probabilities.size();i++){
				registerWith(probabilities[i]);
			}
			//dates_=dates;
			registerWith(correlation);

		}

		Probability survivalProbabilityImpl(Time t) const; 
		Real defaultDensityImpl(Time t) const; 
		Date maxDate() const { return probabilities_[0]->maxDate(); }
		
	private:
		//! \name LazyObject interface
        //@{
        void performCalculations() const;
		void calculate() const;
        //@}
		
		//std::vector<boost::shared_ptr<HazardRateStructure>> probabilities_;
		std::vector<boost::shared_ptr<DefaultProbabilityTermStructure>> probabilities_;

		boost::shared_ptr<OneFactorGaussianCopula> copula_;
		Size n_;
		Real max_;
		//bool calculationFlag_;

	};


	template<class TraitProb>
	Probability CopulaSurvivalProbStructure<TraitProb>::survivalProbabilityImpl(Time t) const 
	{
		return 1 - defaultDensityImpl(t);
	}

	template<class TraitProb>
	Real CopulaSurvivalProbStructure<TraitProb>::defaultDensityImpl(Time t) const 
	{
		QL_REQUIRE(t >= 0 , "time must positive");

		std::vector<Real> defProb(probabilities_.size());

		for (Size j = 0; j < probabilities_.size(); j++)
			defProb[j] = probabilities_[j]->defaultProbability(t);

		TraitProb op(n_);
		Real jointProb = copula_->integral(op, defProb);

		return jointProb;
	}

	
}
#endif