#ifndef quantlib_testClass_ELS_ELSStepDownMonthlyR_hpp
#define quantlib_testClass_ELS_ELSStepDownMonthlyR_hpp

#include <ql/testClass/ELSStepDown.hpp>

namespace QuantLib {

class ELSStepDownMonthlyR : public ELSStepDown
{
	public:
		ELSStepDownMonthlyR(Real notional,
					const Date& issueDate,
					Natural settlementDays,
					//const std::vector<boost::shared_ptr<Index>>& refIndex,
					const std::vector<boost::shared_ptr<StockIndex>>& refIndex,
					const Schedule& schedule,
					std::vector<Real>& earlyExTriggers,
					std::vector<Real>& redemCoupon,
					Real KILossCoupon,
					const std::vector<Real>& KIbarrier,
					CheckKIType checkKIType,
					const DayCounter& daycount,
					const Calendar& calendar
					);

		class arguments;
        class results;
        class engine;

		//Instrument interface
		void setupArguments(PricingEngine::arguments*) const;
		void fetchResults(const PricingEngine::results* r) const;
		virtual std::vector<Date> fixingExDates() const{return fixingExDates_;};

		std::string decription() const{return "ELSStepDownMonthlyR";}

	protected:

		bool checkKI();


	private:

		Real KILossCoupon_;
		CheckKIType checkKIType_;
		std::vector<Date> fixingExDates_;

};

class ELSStepDownMonthlyR::arguments : public ELSStepDown::arguments {
    public:

		Real KILossCoupon;

};

class ELSStepDownMonthlyR::results : public ELSStepDown::results {
    public:
		//Leg expectedCashflows;

		// UnfundedSwap에 사용할 목적으로 만듬.
		std::vector<Real> earlyExProbability;
		

     
};


class ELSStepDownMonthlyR::engine : public GenericEngine<ELSStepDownMonthlyR::arguments,
                                                 ELSStepDownMonthlyR::results> {
};

}

#endif