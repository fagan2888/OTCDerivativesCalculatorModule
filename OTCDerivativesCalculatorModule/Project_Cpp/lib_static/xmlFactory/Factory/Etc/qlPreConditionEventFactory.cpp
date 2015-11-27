#include "qlPreConditionEventFactory.hpp"
#include <Factory/Etc/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlPreConditionEventFactory::qlPreConditionEventFactory()
{
}

boost::shared_ptr<QuantLib::PreConditionEvent> qlPreConditionEventFactory::
	preCondiEvent(const boost::shared_ptr<FpmlSerialized::PreConditionEvent>& xml_serial)
{
	boost::shared_ptr<QuantLib::PreConditionEvent> ql_preCondiEvent;


	return ql_preCondiEvent;
}

}

