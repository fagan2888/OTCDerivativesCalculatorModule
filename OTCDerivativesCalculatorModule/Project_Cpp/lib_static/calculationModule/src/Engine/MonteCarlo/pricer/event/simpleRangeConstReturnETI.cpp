#include "SimpleRangeConstReturnETI.hpp"
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <iostream>

namespace QuantLib {

SimpleRangeConstReturnETI::SimpleRangeConstReturnETI(const boost::shared_ptr<EventTriggerInfo>& rangeEvent,
													const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
													Real constReturn,
													bool isExpired,
													const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), rangeEvent_(rangeEvent),  constReturn_(constReturn)
{
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;
}

bool SimpleRangeConstReturnETI::autoCallEvent(const MultiPath& path)
{
	return false;
}

void SimpleRangeConstReturnETI::initializeImpl(const TimeGrid& timeGrid,
													 const boost::shared_ptr<YieldTermStructure>& discountCurve,
													 const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	rangeEvent_->initialize(timeGrid,discountCurve,pathGenFactory);
	payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	assetNum_ = pathGenFactory->numAssets();

}

bool SimpleRangeConstReturnETI::pastEventOcc()
{
	return false;
}

bool SimpleRangeConstReturnETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
	//return rangeEvent_->checkEvent(path);

}

Real SimpleRangeConstReturnETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	if ( rangeEvent_->checkEvent(path) )
	{
		return constReturn_ * payoffDateInfo_->discount();
	}
	else
	{
		return 0.0;
	}
}

std::vector<Date> SimpleRangeConstReturnETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	helper.mergeDates(fixingDates,this->rangeEvent_->fixingDates());

	return fixingDates;
}

std::vector<Date> SimpleRangeConstReturnETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	payoffDates.push_back(payoffDateInfo_->fixingDate());

	return payoffDates;
}

}