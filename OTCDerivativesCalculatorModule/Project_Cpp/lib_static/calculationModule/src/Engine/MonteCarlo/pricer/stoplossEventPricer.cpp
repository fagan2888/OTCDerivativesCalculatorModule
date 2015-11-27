#include "stoplossEventPricer.hpp"
#include <src/util/DateHelper.hpp>

namespace QuantLib {

StopLossEventPricer::StopLossEventPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerList,
										 const boost::shared_ptr<EventTriggerInfo>& barrierInfoTrigger,
										 const boost::shared_ptr<ReturnCalculation>& returnCalculation,
										 const boost::shared_ptr<FixingDateInfo>& payoffDateInfo)
: eventTriggerList_(eventTriggerList), barrierInfoTrigger_(barrierInfoTrigger), 
  returnCalculation_(returnCalculation), payoffDateInfo_(payoffDateInfo)
{

}

void StopLossEventPricer::initializeImpl(const TimeGrid& timeGrid,
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

	this->maturityPosition_ = timeGrid.size() - 1;

	this->barrierInfoTrigger_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->returnCalculation_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real StopLossEventPricer::calculate(const MultiPath& path,Size endPosition) const
{
	//std::cout << "-------------------------------------" << std::endl;

	bool autoCall = false;

	value_ = 0.0;

	bool barrierEventOcc = barrierInfoTrigger_->checkEvent(path);

	if ( barrierEventOcc )
	{
		autoCallEventPosition_ = barrierInfoTrigger_->autoCallEventPosition();
	}

	// accural payoffDate 또는 autoCallPayoffDate 를 따로 만듬 in eventTrigger
	for ( Size i = remainEventPosition_ ; i < eventTriggerList_.size() ; i++ )
	{
		value_ += eventTriggerList_[i]->autoCallPayoff(path,autoCallEventPosition_);
	}

	//if ( barrierEventOcc )
	//{
	//	value_ += this->returnCalculation_->calculate(path,endPosition) * 
	//		this->payoffDateInfo_->discountAt(barrierInfoTrigger_->eventOccDate());
	//}

	//std::cout << value_ << std::endl;
	return value_;
}

Size StopLossEventPricer::autoCallEventPosition()
{
	return this->autoCallEventPosition_;
}

Real StopLossEventPricer::autoCallPayoff(Size position)
{
	QL_FAIL("not implemeted");
}

std::vector<Date> StopLossEventPricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,eventTriggerList_[i]->fixingDates());
	}

	helper.mergeDates(fixingDates,this->barrierInfoTrigger_->fixingDates());
	helper.mergeDates(fixingDates,this->returnCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> StopLossEventPricer::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		helper.mergeDates(payoffDates,eventTriggerList_[i]->payoffDates());
	}

	helper.mergeDates(payoffDates,this->barrierInfoTrigger_->payoffDates());

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

void StopLossEventPricer::resetImpl() const
{
	this->autoCallEventPosition_ = this->maturityPosition_;
}

}

