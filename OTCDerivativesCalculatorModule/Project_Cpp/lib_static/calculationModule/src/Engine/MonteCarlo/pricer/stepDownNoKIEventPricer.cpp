#include "stepDownNoKIEventPricer.hpp"
#include <src/util/DateHelper.hpp>

namespace QuantLib {

StepDownNoKIEventPricer::StepDownNoKIEventPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerList,
												 const boost::shared_ptr<EventTriggerInfo>& noAutoCallTrigger)
: eventTriggerList_(eventTriggerList), noAutoCallTrigger_(noAutoCallTrigger)

{
			
}

void StepDownNoKIEventPricer::initializeImpl(const TimeGrid& timeGrid,
									   const boost::shared_ptr<YieldTermStructure>& discountCurve,
									   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//this->discount_ = Array(eventTriggerList_.size(),1.0);

	//for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	//{
	//	eventTriggerList_[i]->initialize(timeGrid,discountCurve);

	//	if ( eventTriggerList_[i]->isExpired() )
	//	{
	//		remainEventPosition_ = i + 1;
	//		this->discount_[i] = 1.0;
	//	}else
	//	{
	//		this->discount_[i] = discountCurve_->discount(eventTriggerList_[i]->payoffDate());
	//	}
	//}

	remainEventPosition_ = 0;

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		this->eventTriggerList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);

		bool kk = eventTriggerList_[i]->isExpired();

		if ( eventTriggerList_[i]->isExpired() )
		{
			remainEventPosition_ = i + 1;
		}
	}

	this->noAutoCallTrigger_->initialize(timeGrid,discountCurve,pathGenFactory);

}

Real StepDownNoKIEventPricer::calculate(const MultiPath& path,Size endPosition) const
{
	
	//for ( Size i=0 ; i < path.assetNumber() ; i++)
	//{
	//	for ( Size j=0 ; j < path.pathSize() ; j++)
	//	{
	//		std::cout << path[i][j] << " : ";
	//	}
	//	std::cout << std::endl;
	//}
	//std::cout << std::endl;

	bool autoCall = false;

	value_ = 0.0;

	for ( Size i = remainEventPosition_ ; i < eventTriggerList_.size() ; i++ )
	{
		value_ += eventTriggerList_[i]->payoff(path,endPosition);
		
		autoCall = eventTriggerList_[i]->autoCallEvent();	

		if(autoCall)
		{
			autoCallEventPosition_ = eventTriggerList_[i]->autoCallEventPosition();
			//value = value * this->discount_[i];
			break;
		}
	}

	if(!autoCall)
	{
		value_ += noAutoCallTrigger_->payoff(path,endPosition);
	}

	return value_;
}

std::vector<Date> StepDownNoKIEventPricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,eventTriggerList_[i]->fixingDates());

	}

	helper.mergeDates(fixingDates,this->noAutoCallTrigger_->fixingDates());

	return fixingDates;
}

std::vector<Date> StepDownNoKIEventPricer::payoffDates() const
{
	std::vector<Date> payoffDates;

	//for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	//{
	//	payoffDates.push_back(eventTriggerList_[i]->payoffDate());
	//}

	////payoffDates.push_back(this->kiBarrierEventTrigger_->payoffDate());
	////payoffDates.push_back(this->nonOccBarrierEventTrigger_->payoffDate());
	//
	//DateHelper helper = DateHelper ();

	//std::vector<Date> results = helper.removeDuplicateDate(payoffDates);

	return payoffDates;
}

void StepDownNoKIEventPricer::resetImpl() const
{

	
}

Size StepDownNoKIEventPricer::autoCallEventPosition()
{
	return this->autoCallEventPosition_;
}

Real StepDownNoKIEventPricer::autoCallPayoff(Size position)
{
	return value_;
}

}
