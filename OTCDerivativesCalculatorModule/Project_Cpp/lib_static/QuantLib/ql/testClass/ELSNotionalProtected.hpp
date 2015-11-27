#ifndef quantlib_testClass_ELS_NotionalProtected_hpp
#define quantlib_testClass_ELS_NotionalProtected_hpp

#include <ql/testClass/EquityLinkedSecurity.hpp>

namespace QuantLib {

class ELSNotionalProtected : public EquityLinkedSecurity
{
	public:
		ELSNotionalProtected(Real notional,
					const Date& issueDate,
					Natural settlementDays,
					const std::vector<boost::shared_ptr<StockIndex>> refIndex,
					const Schedule& schedule,
					std::vector<Real>& earlyExTriggers,
					Real redemCoupon,
					const DayCounter& daycount,
					const Calendar& calendar
					);

		class arguments;
        class results;
        class engine;

		//Instrument interface
		void setupArguments(PricingEngine::arguments*) const;
		void fetchResults(const PricingEngine::results* r) const;


		std::string decription() const{return "ELSNotionalProtected";}
		//Real KIbarrierTriggers() const{return KIbarrierTriggers_;}

	private:
		//Input argument

		std::vector<Real> earlyExTriggers_;
		Real coupon_;
		Real redemCoupon_;
		Schedule scheldule_;	

};

class ELSNotionalProtected::arguments : public EquityLinkedSecurity::arguments {
    public:

		Real redemCoupon;
		std::vector<Real> earlyExTriggers;

};

class ELSNotionalProtected::results : public EquityLinkedSecurity::results {
    public:
		//Leg expectedCashflows;
     
};


class ELSNotionalProtected::engine : public GenericEngine<ELSNotionalProtected::arguments,
                                                 ELSNotionalProtected::results> {
};

}

#endif