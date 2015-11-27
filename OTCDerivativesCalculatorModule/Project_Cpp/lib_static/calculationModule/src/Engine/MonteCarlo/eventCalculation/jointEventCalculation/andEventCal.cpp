#include "AndEventCal.hpp"

namespace QuantLib {

AndEventCal::AndEventCal(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
						const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: JointEventCalculation(eventCalList,usingVariableInfoList)
{

}

bool AndEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	for ( Size i = 0 ; i < eventNum_ ; i++ )
	{
		if ( !this->eventCalList_[i]->checkEvent(path) )
		{
			return false;
		}
	}

	return true;

}

}