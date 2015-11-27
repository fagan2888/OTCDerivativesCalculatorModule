#include "AtLeastEventCal.hpp"

namespace QuantLib {

AtLeastEventCal::AtLeastEventCal(Size num,
							   const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
							   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: JointEventCalculation(eventCalList,usingVariableInfoList)
{

}

bool AtLeastEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	return true;
}

}