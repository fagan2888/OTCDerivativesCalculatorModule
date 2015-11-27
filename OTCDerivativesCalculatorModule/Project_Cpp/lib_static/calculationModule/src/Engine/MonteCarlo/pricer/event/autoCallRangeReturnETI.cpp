#include "SimpleRangeReturnETI.hpp"
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <iostream>

namespace QuantLib {

SimpleRangeReturnETI::SimpleRangeReturnETI(const boost::shared_ptr<EventTriggerInfo>& rangeEvent,
													const Date& payoffDate,
													Real constReturn,
													bool isExpired)
: EventTriggerInfo(), rangeEvent_(rangeEvent),  constReturn_(constReturn)
{
	this->payoffDates_.push_back(payoffDate);
	this->isExpired_ = isExpired;

	payoffDatePositions_ = std::valarray<Size>(payoffDates_.size());
}

bool SimpleRangeReturnETI::autoCallEvent(const MultiPath& path)
{
	return false;
}

void SimpleRangeReturnETI::initialize(const TimeGrid& timeGrid,
													 const boost::shared_ptr<YieldTermStructure>& discountCurve,
													 const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	rangeEvent_->initialize(timeGrid,discountCurve,pathGenFactory);

	Date today = Settings::instance().evaluationDate();
	
	DayCounter dayCounter = Actual365Fixed();
	
	discount_ = Array(this->payoffDates_.size());

	double payoffTime = dayCounter.yearFraction( today , payoffDates_[0] );
	payoffDatePositions_[0] = timeGrid.closestIndex(payoffTime);
	
	discount_[0] = discountCurve->discount(payoffTime);
	assetNum_ = pathGenFactory->numAssets();

}

bool SimpleRangeReturnETI::pastEventOcc()
{
	return false;
}

bool SimpleRangeReturnETI::checkEvent(const MultiPath& path)
{
	return true;
	//return rangeEvent_->checkEvent(path);

}

Real SimpleRangeReturnETI::payoff(const MultiPath& path)
{
	if ( rangeEvent_->checkEvent(path) )
	{
		return constReturn_ * discount_[0];
	}
	else
	{
		return 0.0;
	}
}

}