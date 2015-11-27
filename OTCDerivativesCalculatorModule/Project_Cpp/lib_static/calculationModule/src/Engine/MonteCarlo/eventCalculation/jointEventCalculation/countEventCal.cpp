#include "CountEventCal.hpp"

namespace QuantLib {

CountEventCal::CountEventCal(Size num,
							 const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
							 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: JointEventCalculation(eventCalList,usingVariableInfoList)
{

}


bool CountEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	return true;

}

}