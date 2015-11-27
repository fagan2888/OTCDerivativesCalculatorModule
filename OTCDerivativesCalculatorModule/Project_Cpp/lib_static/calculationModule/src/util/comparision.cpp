#include "comparision.hpp"

namespace ComparisonFunction {


bool compETIEventDate(const boost::shared_ptr<QuantLib::EventTriggerInfo>& _first ,
								  const boost::shared_ptr<QuantLib::EventTriggerInfo>& _second)
{
	return ( _first->getEventDate() < _second->getEventDate() );
}

}