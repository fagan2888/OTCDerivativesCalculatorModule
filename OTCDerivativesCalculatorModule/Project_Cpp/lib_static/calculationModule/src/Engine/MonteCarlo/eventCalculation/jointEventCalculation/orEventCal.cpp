#include "OrEventCal.hpp"

namespace QuantLib {

OrEventCal::OrEventCal(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
											 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: JointEventCalculation(eventCalList,usingVariableInfoList)
{

}

bool OrEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	return true;

}

}