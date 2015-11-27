#ifndef quantlib_copulasurvivalrate_hpp
#define quantlib_copulasurvivalrate_hpp

#include <ql/termstructures/defaulttermstructure.hpp>
#include <ql/experimental/credit/onefactorgaussiancopula.hpp>
#include <ql/termstructures/credit/interpolatedsurvivalprobabilitycurve.hpp>
#include <ql/termstructures/credit/survivalprobabilitystructure.hpp>
#include <ql/termstructures/credit/copulahazardrate.hpp>
#include <ql/termstructures/all.hpp>
#include <ql/termstructures/credit/all.hpp>

namespace QuantLib{
	/*HazardRateTS�� �޾Ƽ� �� ��쿡�� ���� ������,
	 DefaultProb �Ǵ� SurvivalProb ���� template�� ��������
	 ��Ը� ������ �ʿ��Ͽ� ���Ŀ� �ۼ�*/

	//Average HazardRate�� ������ �ȴ�� forward�� spread ���ؼ� harzardRate�� �޾ƾ���.
	
	template<class TraitProb,class Interpolator>
	class CopulaSurvivalProb : public InterpolatedSurvivalProbabilityCurve<Interpolator> {
	public:
		typedef boost::shared_ptr<InterpolatedSurvivalProbabilityCurve<Interpolator> > base_curve;
		CopulaSurvivalProb(
				//const std::vector<Handle<base_curve> >& probabilities,
				//const std::vector<Date>& dates,
				const std::vector<boost::shared_ptr<DefaultProbabilityTermStructure>>& probabilities,
				const Handle<Quote>& correlation,
				Size n=1,
				Real maximum = 5.0, Size integrationsSteps=50)
				//: InterpolatedSurvivalProbabilityCurve<Interpolator>(probabilities[0]->referenceDate(),probabilities[0]->dayCounter()),
				: InterpolatedSurvivalProbabilityCurve<Interpolator>(probabilities[0]->referenceDate(),probabilities[0]->dayCounter()),
				probabilities_(probabilities),n_(n),max_(maximum) 
		{
					
			copula_=boost::shared_ptr<OneFactorGaussianCopula>(new OneFactorGaussianCopula(correlation,maximum,integrationsSteps));
				
			for(Size i=0;i<probabilities.size();i++){
				registerWith(probabilities[i]);
			}
			//dates_=dates;
			registerWith(correlation);
			//initialize();
					
			//referenceDate�� ���ƾ���
			//calendar�� ���ƾ���
			//������ �Լ� �����ؾ���.

		}

		Probability defaultProbability(const Date& d) const; 
		
		void initialize(const std::vector<Date>& dates);

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


	template<class TraitProb,class Interpolator>
	Probability CopulaSurvivalProb<TraitProb,Interpolator>::defaultProbability(const Date& d) const 
	{
		if (d <= probabilities_.front()->referenceDate())
			return 0.0;

		std::vector<Real> defProb(probabilities_.size());

		for (Size j = 0; j < probabilities_.size(); j++)
			defProb[j] = probabilities_[j]->defaultProbability(d);

		TraitProb op(n_);
		
		return copula_->integral(op, defProb);
	}
	template<class TraitProb,class Interpolator>
	void CopulaSurvivalProb<TraitProb,Interpolator>::calculate() const
	{
		//(����)�Է¹޴� TermStructure�� ���� referencedate�� �߰��Ǿ� ���Ƿ� ������.
		Size dataSize=dates_.size();
		data_.resize(dataSize);
		for(Size i=0;i<dataSize;i++)
		{
			this->data_[i]=1-defaultProbability(dates_[i]);
		}
	}
	
	template<class TraitProb,class Interpolator>
	void CopulaSurvivalProb<TraitProb,Interpolator>::performCalculations() const
	{
		calculate();
		
	}
	
    template <class TraitProb,class Interpolator>
    void CopulaSurvivalProb<TraitProb,Interpolator>::initialize(const std::vector<Date>& dates)
    {
		dates_ = dates;
		calculate();
		InterpolatedSurvivalProbabilityCurve<Interpolator>::initialize();
		//calculationFlag_ = true;
    }

}
#endif