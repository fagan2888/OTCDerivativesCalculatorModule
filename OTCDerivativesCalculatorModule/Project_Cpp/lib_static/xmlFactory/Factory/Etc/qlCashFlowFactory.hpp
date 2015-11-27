// Calculation.hpp 
#ifndef factory_qlCashFlowFactory_hpp
#define factory_qlCashFlowFactory_hpp

#include <GenClass\RiskMonitor-0-1\Excel_fixedCouponScheduleList.hpp>
#include <GenClass\RiskMonitor-0-1\Excel_couponSchedule.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/cashflow.hpp>

using namespace FpmlSerialized;

namespace XmlFactory {

	class qlCashFlowFactory{

		public:
			qlCashFlowFactory();

			boost::shared_ptr<QuantLib::CashFlow> cashFlow(
				const boost::shared_ptr<FpmlSerialized::Excel_couponSchedule>& xml_e_fcs);

			boost::shared_ptr<QuantLib::CashFlow> fixedCashFlow(
				const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponSchedule>& xml_e_fcs);

			boost::shared_ptr<QuantLib::Leg> fixedLeg(
				const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponScheduleList>& xml_e_fcsList);

			private:

	};

}
#endif