#include "PreConditionEvent.hpp"

namespace QuantLib {

PreConditionEvent::PreConditionEvent(const std::string& refEventName)
{
}

void PreConditionEvent::initialize(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

bool PreConditionEvent::checkEvent()
{
	return true;
}

void PreConditionEvent::reset()
{

}

}