// Calculation.hpp 
#ifndef factory_qlexcel_fixedCouponScheduleListFactory_hpp
#define factory_qlexcel_fixedCouponScheduleListFactory_hpp

#include <GenClass\RiskMonitor-0-1\Excel_fixedCouponScheduleList.hpp>
#include <ql/time/schedule.hpp>
#include <ql/cashflow.hpp>

using namespace FpmlSerialized;

namespace XmlFactory {

	class qlexcel_fixedCouponScheduleListFactory{

		public:
			qlexcel_fixedCouponScheduleListFactory();

			boost::shared_ptr<QuantLib::Leg> qlLeg(
				const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponScheduleList>& ql_e_fcsl);
			//boost::shared_ptr<QuantLib::FixedRateCoupon> fixedRateCoupon(const boost::shared_ptr<FpmlSerialized::CalculationPeriod>& cp);
			//boost::shared_ptr<QuantLib::SimpleCashFlow> simpleCashFlow(QuantLib::Real amount, QuantLib::Date paymentDate);

			private:

				//boost::shared_ptr<FpmlSerialized::Excel_fixedCouponScheduleList> ql_e_fcsl_;
				//boost::shared_ptr<QuantLib::Leg> ql_leg_;
	};

}
#endif