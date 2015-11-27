// Calculation.hpp 
#ifndef factory_qlCashFlowFactory_hpp
#define factory_qlCashFlowFactory_hpp

#include <FpmlSerialized/GenClass/fpml-ird-5-4/Swap.hpp>
#include <FpmlSerialized/GenClass/fpml-ird-5-4/PaymentCalculationPeriod.hpp>

#include <ql/indexes/interestrateindex.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/cashflow.hpp>
#include <ql/cashflows/floatingratecoupon.hpp>
#include <ql/cashflows/fixedratecoupon.hpp>
#include <ql/cashflows/simplecashflow.hpp>

using namespace FpmlSerialized;

namespace XmlFactory {

	class qlCashFlowFactory{

		public:
			//make QuantLib::CashFlow interface from Fpml::Serialize::PaymentCalculationPeriod
			//
			qlCashFlowFactory(const boost::shared_ptr<PaymentCalculationPeriod>& pcp,
							  const boost::shared_ptr<QuantLib::InterestRateIndex> irIndex,
							  const boost::shared_ptr<QuantLib::DayCounter> dayCounter);

			boost::shared_ptr<QuantLib::CashFlow> getCashFlow();
			boost::shared_ptr<QuantLib::FloatingRateCoupon> floatingRateCoupon(const boost::shared_ptr<FpmlSerialized::CalculationPeriod>& cp);
			boost::shared_ptr<QuantLib::FixedRateCoupon> fixedRateCoupon(const boost::shared_ptr<FpmlSerialized::CalculationPeriod>& cp);
			boost::shared_ptr<QuantLib::SimpleCashFlow> simpleCashFlow(QuantLib::Real amount, QuantLib::Date paymentDate);

			private:
				boost::shared_ptr<FpmlSerialized::PaymentCalculationPeriod> pcp_;
				boost::shared_ptr<QuantLib::InterestRateIndex> irIndex_;
				boost::shared_ptr<QuantLib::DayCounter> dayCounter_;

	};

}
#endif