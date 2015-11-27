#include "qlexcel_fixedCouponScheduleListFactory.hpp"
#include <Factory\Etc\\qlCashFlowFactory.hpp>

namespace XmlFactory {

qlexcel_fixedCouponScheduleListFactory::qlexcel_fixedCouponScheduleListFactory()
{

}

boost::shared_ptr<QuantLib::Leg> qlexcel_fixedCouponScheduleListFactory::qlLeg(
	const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponScheduleList>& ql_e_fcsl)
{

	const boost::shared_ptr<QuantLib::Leg>& leg = boost::shared_ptr<QuantLib::Leg>(new QuantLib::Leg());

	const std::vector<boost::shared_ptr<Excel_couponSchedule>>& xml_e_csList
		= ql_e_fcsl->getExcel_couponSchedule();

	qlCashFlowFactory qlcff = qlCashFlowFactory();
	
	for (Size i=0 ;i < xml_e_csList.size() ; i++)
	{
		leg->push_back( qlcff.cashFlow(xml_e_csList[i]) );
		
	}
	
	return leg;
}


}