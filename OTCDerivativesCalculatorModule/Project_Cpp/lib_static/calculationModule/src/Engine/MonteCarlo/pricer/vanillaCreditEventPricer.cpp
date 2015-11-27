#include "vanillaCreditEventPricer.hpp"

namespace QuantLib {

VanillaCreditEventPricer::VanillaCreditEventPricer(
				const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerInfoList,
				//const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<DefaultProbabilityTermStructure>& defaultCurve)
: eventTriggerInfoList_(eventTriggerInfoList) ,defaultCurve_(defaultCurve) //, discountCurve_(discountCurve)
{
	//pastEventOcc_ = barrierInfo_->pastEventOcc();
}

void VanillaCreditEventPricer::initializeImpl(const TimeGrid& timeGrid,
							   const boost::shared_ptr<YieldTermStructure>& discountCurve,
							   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i=0 ; i < eventTriggerInfoList_.size() ; i++)
	{
		this->eventTriggerInfoList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}
}

Real VanillaCreditEventPricer::calculate(const MultiPath& path,Size endPosition) const
{
	Real value = 0.0;

	Real defaultTime = 0.0;

	for ( Size i=0 ; i < eventTriggerInfoList_.size() ; i++)
	{
		value += eventTriggerInfoList_[i]->payoff(path,endPosition) * 
			defaultCurve_->survivalProbability(defaultTime * 0.5);

		// 1 - survivalProbability 전체 이자.

		//eventTriggerInfoList_[i]->
	}

	return value;
}

std::vector<Date> VanillaCreditEventPricer::fixingDates() const
{
	std::vector<Date> payoffDates;
	
	//for ( Size i=0 ; i < eventTriggerInfoList_.size() ; i++)
	//{
	//	payoffDates
	//}

	return this->eventTriggerInfoList_[0]->fixingDates();

}

std::vector<Date> VanillaCreditEventPricer::payoffDates() const
{
	std::vector<Date> payoffDates;
	//payoffDates.push_back(this->eventTriggerInfo_->payoffDates());
	return payoffDates;
}

void VanillaCreditEventPricer::resetImpl() const
{

}

}

