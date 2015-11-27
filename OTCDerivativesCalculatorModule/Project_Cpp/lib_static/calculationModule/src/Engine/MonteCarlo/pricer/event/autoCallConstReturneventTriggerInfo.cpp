#include "autoCallConstReturnEventTriggerInfo.hpp"
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <iostream>

namespace QuantLib {

AutoCallConstReturnEventTriggerInfo::AutoCallConstReturnEventTriggerInfo(const boost::shared_ptr<FixingDateInfo>& fixingDateInfo,
																		const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
																		Real constReturn,
																		//std::vector<Real> basePrice,
																		Real trigger,
																		bool isExpired,
																		const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), constReturn_(constReturn), trigger_(trigger)
{

	this->fixingDateInfo_ = fixingDateInfo;
	this->payoffDateInfo_ = payoffDateInfo;

	this->isExpired_ = isExpired;
	this->autoCallEventFlag_ = false;

}
void AutoCallConstReturnEventTriggerInfo::initializeImpl(const TimeGrid& timeGrid,
													 const boost::shared_ptr<YieldTermStructure>& discountCurve,
													 const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->fixingDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	
	assetNum_ = pathGenFactory->numAssets();

}

bool AutoCallConstReturnEventTriggerInfo::pastEventOcc()
{
	return false;
}

bool AutoCallConstReturnEventTriggerInfo::checkEvent(const MultiPath& path,Size endPosition)
{
	bool eventOcc = true;

	Size position = fixingDatePositions_[0];

	for ( Size i=0 ;i < assetNum_ ; i++)
	{
		//std::cout << path[i][position] << std::endl;
		if (path[i][position] < trigger_ )
			return false;
	}

	return eventOcc;

}

bool AutoCallConstReturnEventTriggerInfo::autoCallEvent(const MultiPath& path)
{
	return autoCallEventFlag_;
}

Real AutoCallConstReturnEventTriggerInfo::payoffImpl(const MultiPath& path,Size endPosition)
{
	if ( this->checkEvent(path,endPosition) )
	{
		autoCallEventFlag_ = true;
		return constReturn_ * this->payoffDateInfo_->discount(endPosition);//discount_[0];
	}else
	{
		this->autoCallEventFlag_ = false;
		return 0.0;
	}
}

void AutoCallConstReturnEventTriggerInfo::reset()
{
	
}

std::vector<Date> AutoCallConstReturnEventTriggerInfo::fixingDates() const
{
	std::vector<Date> fixingDates;

	fixingDates.push_back(this->fixingDateInfo_->fixingDate());

	return fixingDates;
}

std::vector<Date> AutoCallConstReturnEventTriggerInfo::payoffDates() const
{
	std::vector<Date> payoffDates;

	payoffDates.push_back(this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}