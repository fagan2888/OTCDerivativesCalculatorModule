#include "qlStructuredProductPayoffFactory.hpp"
#include <xmlFactory/Factory/Etc/qlTermstructureFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/Component/qlEventCheckFactory.hpp>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunction.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/pathinformation.hpp>
#include <xmlFactory/Factory/Etc/qlCalendarFactory.hpp>
#include <ql/time/calendar.hpp>

namespace XmlFactory {

qlStructuredProductPayoffFactory::qlStructuredProductPayoffFactory()
{
	
}
		
void qlStructuredProductPayoffFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::StructuredProductPayoff>& spp)
{
	
	boost::shared_ptr<QuantLib::StructuredProductPayoff> structuredProductPayoff;

	qlCalendarFactory cf = qlCalendarFactory();
	PathInformation::instance().setCalendar(cf.calendar("KOR"));

	//----------------------EventCheck-----------------------------------------------
	std::vector<boost::shared_ptr<QuantLib::IEventCheck>> ql_ecList;

	const std::vector<boost::shared_ptr<FpmlSerialized::EventCheck>>& serial_ecList 
					= spp->getEventSchedule()->getEventCheck();
	
	qlEventCheckFactory ql_ecf = qlEventCheckFactory();

	for(Size i=0;i<serial_ecList.size();++i){
		ql_ecf.setSerialClass(serial_ecList[i]);
		ql_ecList.push_back(ql_ecf.getIEC());
	}

	structuredProductPayoff_ = boost::shared_ptr<QuantLib::StructuredProductPayoff>(
							new QuantLib::StructuredProductPayoff(ql_ecList,cf.calendar("KOR")));


}

boost::shared_ptr<QuantLib::StructuredProductPayoff> qlStructuredProductPayoffFactory::getSPP()
{
	
	QL_REQUIRE(structuredProductPayoff_,"structuredProductPayoff is null");

	return structuredProductPayoff_;
}

}

