#include "EventCalculationInfo.hpp"

namespace QuantLib {

EventCalculationInfo::EventCalculationInfo(const std::vector<boost::shared_ptr<EventCalculation>>& eventList,
								 const boost::shared_ptr<JointSimpleCalculation>& jointSimpleCal,
								 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), eventList_(eventList), jointSimpleCal_(jointSimpleCal)
{
}

void EventCalculationInfo::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i=0 ; i<eventList_.size() ; i++)
	{
		eventList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->eventNum_ = eventList_.size();
	this->calValArr_ = std::valarray<double>(this->eventNum_);
}

Real EventCalculationInfo::accrualNum(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

bool EventCalculationInfo::pastEventOcc()
{
	return true;
}

bool EventCalculationInfo::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	for( Size i=0 ;i < eventNum_ ; ++i )
	{
		this->calValArr_[i] = this->eventList_[i]->checkEvent(path,endPosition);
	}

	return jointSimpleCal_->jointCal(calValArr_);

}

std::vector<Date> EventCalculationInfo::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	//helper.mergeDates(fixingDates,this->returnCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> EventCalculationInfo::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

}

