#include "qlCashFlowFactory.hpp"
#include <ql/cashflows/all.hpp>
#include <factory\Etc\all.hpp>

namespace XmlFactory {

qlCashFlowFactory::qlCashFlowFactory()
{

}

boost::shared_ptr<QuantLib::CashFlow> cashFlow(
	const boost::shared_ptr<FpmlSerialized::Excel_couponSchedule>& xml_e_fcs)
{
		boost::shared_ptr<QuantLib::CashFlow> cf = boost::shared_ptr<QuantLib::CashFlow>(
		new SimpleCashFlow(100,Date()));

	return cf;
}

boost::shared_ptr<QuantLib::CashFlow> qlCashFlowFactory::fixedCashFlow(
	const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponSchedule>& xml_e_fcs)
{
	boost::shared_ptr<QuantLib::CashFlow> cf = boost::shared_ptr<QuantLib::CashFlow>(
		new SimpleCashFlow(100,Date()));

	return cf;
}
boost::shared_ptr<QuantLib::Leg> fixedLeg(
				const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponScheduleList>& xml_e_fcsList)
{
	qlDayCounterFactory qldcf = qlDayCounterFactory();

	QuantLib::DayCounter dayCounter = qldcf.dayCounter(xml_e_fcsList->getDayCounter()->SValue());


	boost::shared_ptr<QuantLib::Leg> leg = boost::shared_ptr<QuantLib::Leg>(new Leg());

	leg->push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(100,Date())));
	leg->push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(200,Date())));
	leg->push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(300,Date())));
	leg->push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(400,Date())));

	return leg;
}

}
