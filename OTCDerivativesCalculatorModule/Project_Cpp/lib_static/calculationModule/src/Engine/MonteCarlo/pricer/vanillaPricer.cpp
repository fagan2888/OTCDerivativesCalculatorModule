#include "vanillaPricer.hpp"

namespace QuantLib {

VanillaPricer::VanillaPricer(const boost::shared_ptr<EventTriggerInfo>& eventTriggerInfo,
				const boost::shared_ptr<YieldTermStructure>& discountCurve)
: eventTriggerInfo_(eventTriggerInfo)
{
	//pastEventOcc_ = barrierInfo_->pastEventOcc();
}

void VanillaPricer::initializeImpl(const TimeGrid& timeGrid,
							   const boost::shared_ptr<YieldTermStructure>& discountCurve,
							   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->eventTriggerInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real VanillaPricer::calculate(const MultiPath& path,Size endPosition) const
{
	Real value = 0.0;

	value = eventTriggerInfo_->payoff(path,endPosition);

	return value;
}

std::vector<Date> VanillaPricer::fixingDates() const
{
	std::vector<Date> payoffDates;

	return this->eventTriggerInfo_->fixingDates();

}

std::vector<Date> VanillaPricer::payoffDates() const
{
	std::vector<Date> payoffDates;
	//payoffDates.push_back(this->eventTriggerInfo_->payoffDates());
	return payoffDates;
}

void VanillaPricer::resetImpl() const
{

}

}

