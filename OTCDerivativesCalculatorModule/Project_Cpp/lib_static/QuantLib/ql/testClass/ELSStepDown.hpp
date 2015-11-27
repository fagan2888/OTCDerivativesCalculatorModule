#ifndef quantlib_testClass_ELS_ESLStepDown_hpp
#define quantlib_testClass_ELS_ESLStepDown_hpp

#include <ql/testClass/EquityLinkedSecurity.hpp>
#include <ql/testClass/checkKIType.hpp>

namespace QuantLib {

class ELSStepDown : public EquityLinkedSecurity
{
	public:

		ELSStepDown(Real notional,
					const Date& issueDate,
					Natural settlementDays,
					//const std::vector<boost::shared_ptr<Index>>& refIndex,
					const std::vector<Real>& initialValue,
					const std::vector<Date>& autoCallDates,
					std::vector<Real>& earlyExTriggers,
					std::vector<Real>& redemCoupon,
					const std::vector<Real>& KIbarrier,
					CheckKIType checkKIType,
					const DayCounter& daycount,
					const Calendar& calendar
					);


		ELSStepDown(Real notional,
					const Date& issueDate,
					Natural settlementDays,
					//const std::vector<boost::shared_ptr<Index>>& refIndex,
					const std::vector<Real>& initialValue,
					const std::vector<Date>& autoCallDates,
					std::vector<Real>& earlyExTriggers,
					std::vector<Real>& redemCoupons,
					const std::vector<Real>& KIbarrier,
					CheckKIType checkKIType,
					const DayCounter& daycount,
					const Calendar& calendar,
					bool pastKIEvent);


		class arguments;
        class results;
        class engine;

		//Instrument interface
		void setupArguments(PricingEngine::arguments*) const;
		void fetchResults(const PricingEngine::results* r) const;


		std::string decription() const{return "ELSStepDown";}
		std::vector<Real> KIbarrier() const{return KIbarrier_;}
		//Real KIbarrierTriggers() const{return KIbarrierTriggers_;}
		bool KIflag() const{return KIflag_;}
		Date KIDate() const{return KIDate_;}

	protected:

		//Input argument

		std::vector<Real> earlyExTriggers_;
		std::vector<Real> KIbarrierTriggers_;
		std::vector<Real> initialValues_;
		mutable Date KIDate_;
		Real coupon_;
		std::vector<Real> KIbarrier_;
		std::vector<Real> redemCoupon_;
		std::vector<Date> autoCallDates_;
		//calculated parameter
		bool KIflag_;
		CheckKIType checkKIType_;
		Size pastKICount_;

};

class ELSStepDown::arguments : public EquityLinkedSecurity::arguments {
    public:

		std::vector<Real> redemCoupon;
		std::vector<Real> KIbarrier;
		Size pastKICount;
		CheckKIType checkKIType;
		std::vector<Real> earlyExTriggers;
		
		bool KIflag;

};

class ELSStepDown::results : public EquityLinkedSecurity::results {
    public:
		//Leg expectedCashflows;

		// UnfundedSwap에 사용할 목적으로 만듬.
		std::vector<Real> earlyExProbability;
		

     
};


class ELSStepDown::engine : public GenericEngine<ELSStepDown::arguments,
                                                 ELSStepDown::results> {
};

}

#endif