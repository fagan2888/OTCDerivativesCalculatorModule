#include "JointEventCalculation.hpp"

namespace QuantLib {

JointEventCalculation::JointEventCalculation(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
											 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), eventCalList_(eventCalList)
{

}

void JointEventCalculation::initializeImpl(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//single Event
	for( Size i=0 ; i<eventCalList_.size() ; i++)
	{
		this->eventCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

}

}