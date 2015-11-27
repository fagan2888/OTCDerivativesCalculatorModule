#include "vanillaStandardStreamPricer.hpp"
#include <src/util/DateHelper.hpp>
#include <iostream>

namespace QuantLib {

VanillaStandardStreamPricer::VanillaStandardStreamPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerList)
: eventTriggerList_(eventTriggerList)
{
	//pastEventOcc_ = barrierInfo_->pastEventOcc();
}

void VanillaStandardStreamPricer::initialize(const TimeGrid& timeGrid,
							   const boost::shared_ptr<YieldTermStructure>& discountCurve,
							   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->eventTriggerInfoListNum_ = eventTriggerList_.size();

	for ( Size i=0 ; i<eventTriggerList_.size() ; i++)
	{
		this->eventTriggerList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

}

Real VanillaStandardStreamPricer::calculate(const MultiPath& path,Size endPosition) const
{
	Real value = 0.0;
	for ( Size i=0 ; i<eventTriggerList_.size() ; i++)
	{
		//std::cout << eventTriggerList_[i]->payoff(path) << std::endl;
		value += eventTriggerList_[i]->payoff(path,endPosition);
	}

	return value;
}

std::vector<Date> VanillaStandardStreamPricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,eventTriggerList_[i]->fixingDates());
	}

	return fixingDates;

}

std::vector<Date> VanillaStandardStreamPricer::payoffDates() const
{
	std::vector<Date> payoffDates;
	//payoffDates.push_back(this->eventTriggerInfo_->payoffDates());
	return payoffDates;
}

void VanillaStandardStreamPricer::reset() const
{

}

}

