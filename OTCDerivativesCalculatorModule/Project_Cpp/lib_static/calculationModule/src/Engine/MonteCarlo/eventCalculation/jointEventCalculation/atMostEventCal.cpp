#include "AtMostEventCal.hpp"

namespace QuantLib {

AtMostEventCal::AtMostEventCal(Size num,
							   const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
							   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: JointEventCalculation(eventCalList,usingVariableInfoList)
{

}

bool AtMostEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	return true;
}

}