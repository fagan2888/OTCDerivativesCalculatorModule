#ifndef quantlib_testClass_EquitySwap_hpp
#define quantlib_testClass_EquitySwap_hpp

#include <ql/instruments/VanillaSwap.hpp>
#include <ql/testClass/EquityLinkedSecurity.hpp>
#include <ql/testClass/IRDLS.hpp>

namespace QuantLib {

// Engine 작성 없이, 내부에 DiscountSwapEngine을 Default로 하였음.

class EquitySwap : public VanillaSwap
{
	public:
		EquitySwap(Type type,
					Real notional,
					const boost::shared_ptr<EquityLinkedSecurity>& equityLinkedSecurity,
					const boost::shared_ptr<IborIndex>& Index,
					Spread spread,
					const Schedule& schedule,
					bool fundedFlag = false);
		
		EquitySwap(Type type,
					Real notional,
					const boost::shared_ptr<IRDLS>& irdls,
					const boost::shared_ptr<IborIndex>& Index,
					Spread spread,
					const Schedule& schedule,
					bool fundedFlag = false);


		class arguments;
        class results;
        class engine;

		//Instrument interface

		std::string decription() const{return "EquitySwap";}
		void setupArguments(PricingEngine::arguments* args) const;
		Real accrualNPV() const;

	protected:


	private:
		boost::shared_ptr<EquityLinkedSecurity> equityLinkedSecurity_;
		boost::shared_ptr<IRDLS> irdls_;
		std::vector<Real> expectedIRCashFlow_;
		//Real irPartRate_;
		//Real equityPartRate_;
		//Real accrualRate_;
		Real accrualNPV_;
		Leg irleg_;
		bool fundedFlag_;

};

class EquitySwap::arguments : public Swap::arguments {
    public:
		arguments() : type(Receiver),
                      nominal(Null<Real>()) {}
        Type type;
        Real nominal;

        std::vector<Date> fixedResetDates;
        std::vector<Date> fixedPayDates;
        std::vector<Time> floatingAccrualTimes;
        std::vector<Date> floatingResetDates;
        std::vector<Date> floatingFixingDates;
        std::vector<Date> floatingPayDates;

        std::vector<Real> fixedCoupons;
        std::vector<Spread> floatingSpreads;
        std::vector<Real> floatingCoupons;
        void validate() const;

};

class EquitySwap::results : public Swap::results {
    public:
		Rate fairRate;
        Spread fairSpread;
        void reset();
};


class EquitySwap::engine : public GenericEngine<EquitySwap::arguments,
                                                 EquitySwap::results> {
};

}

#endif