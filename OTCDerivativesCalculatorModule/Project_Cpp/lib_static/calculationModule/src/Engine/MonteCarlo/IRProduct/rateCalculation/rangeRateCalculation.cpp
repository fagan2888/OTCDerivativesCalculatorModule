#include "rangeRateCalculation.hpp"

namespace QuantLib {

RangeRateCalulation::RangeRateCalulation(const DayCounter& dayCounter,
									const Date& calculationStartDate,
									const Date& calculationEndDate,
									const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
									const std::vector<boost::shared_ptr<EventTriggerInfo>>& rangeEventInfoList,
									bool isExpired,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter,calculationStartDate,calculationEndDate,usingVariableInfoList),
  rangeEventInfoList_(rangeEventInfoList)
{
	this->isExpired_ = isExpired;
	couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
	rangeNum_ = rangeEventInfoList.size();

}

void RangeRateCalulation::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->payoffDateInfo_->initialize(timeGrid, discountCurve, pathGenFactory);
}

bool RangeRateCalulation::pastEventOcc()
{
	return true;
}

bool RangeRateCalulation::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
}


Real RangeRateCalulation::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	for ( Size i=0 ; i < rangeNum_ ; i++ )
	{
		if ( this->rangeEventInfoList_[i]->checkEvent(path) )
		{
			Real fixed = this->rangeEventInfoList_[i]->payoff(path,endPosition);
			//value += fixed * couponYearFraction_ * payoffDateInfo_->discount();
			value += fixed * couponYearFraction_ ;
		}
	}

	return value;

}

std::vector<Date> RangeRateCalulation::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < rangeEventInfoList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,rangeEventInfoList_[i]->fixingDates());
	}

	return fixingDates;
}

std::vector<Date> RangeRateCalulation::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < rangeEventInfoList_.size() ; i++ )
	{
		helper.mergeDates(payoffDates,rangeEventInfoList_[i]->payoffDates());
	}

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

