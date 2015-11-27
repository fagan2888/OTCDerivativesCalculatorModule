#include "rangeEventInfo.hpp"

namespace QuantLib {

RangeEventInfo::RangeEventInfo(const boost::shared_ptr<EventTriggerInfo>& rangeEvent,
							const boost::shared_ptr<EventTriggerInfo>& couponCalculation,
							const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList)
{
	//this->isExpired_ = isExpired;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void RangeEventInfo::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

bool RangeEventInfo::pastEventOcc()
{
	return true;
}

bool RangeEventInfo::checkEvent(const MultiPath& path,Size endPosition)
{
	return this->rangeEvent_->checkEvent(path);
}


Real RangeEventInfo::payoffImpl(const MultiPath& path,Size endPosition)
{
	if ( this->rangeEvent_->checkEvent(path) )
	{
		Real fixed = couponCalculation_->payoff(path,endPosition);
		//return nominal_ * fixed * couponYearFraction_ * discount_[0] ;
		return 0.0;
	}
	else
	{
		return 0.0;
	}
	
}

std::vector<Date> RangeEventInfo::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(fixingDates,this->rangeEvent_->fixingDates());
	helper.mergeDates(fixingDates,this->couponCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> RangeEventInfo::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(payoffDates,this->rangeEvent_->payoffDates());
	helper.mergeDates(payoffDates,this->couponCalculation_->payoffDates());

	return payoffDates;

}

}

