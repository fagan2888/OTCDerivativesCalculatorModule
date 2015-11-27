#include "simpleRangeReturnETI.hpp"
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <iostream>

namespace QuantLib {

SimpleRangeReturnETI::SimpleRangeReturnETI(const boost::shared_ptr<EventTriggerInfo>& simpleRangeEvent,
										const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										//bool autoCallFlag,
										bool isExpired,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), simpleRangeEvent_(simpleRangeEvent)
{
	//this->autoCallFlag_ = autoCallFlag;
	this->isExpired_ = isExpired;

	this->payoffDateInfo_ = payoffDateInfo;

	//this->definedVarNameList_.push_back(
}

bool SimpleRangeReturnETI::autoCallEvent(const MultiPath& path)
{
	return false;
}

void SimpleRangeReturnETI::initializeImpl(const TimeGrid& timeGrid,
									const boost::shared_ptr<YieldTermStructure>& discountCurve,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	simpleRangeEvent_->initialize(timeGrid,discountCurve,pathGenFactory);
	payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	assetNum_ = pathGenFactory->numAssets();

}

bool SimpleRangeReturnETI::pastEventOcc()
{
	return false;
}

bool SimpleRangeReturnETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
	//return rangeEvent_->checkEvent(path);

}

Real SimpleRangeReturnETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	//if ( rangeEvent_->checkEvent(path) )
	//{
	//	return constReturn_ * discount_[0];
	//}
	//else
	//{
		return 0.0;
	//}
}

std::vector<Date> SimpleRangeReturnETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	helper.mergeDates(fixingDates,this->simpleRangeEvent_->fixingDates());

	return fixingDates;
}

std::vector<Date> SimpleRangeReturnETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	payoffDates.push_back(payoffDateInfo_->fixingDate());

	return payoffDates;
}

}