#include "noAutoCallReturnETI.hpp"
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <iostream>

namespace QuantLib {

NoAutoCallReturnETI::NoAutoCallReturnETI(const boost::shared_ptr<QuantLib::ReturnCalculation>& returnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), returnCal_(returnCal)
{
	this->payoffDateInfo_ = payoffDateInfo;
}

bool NoAutoCallReturnETI::autoCallEvent(const MultiPath& path)
{
	return false;
}

void NoAutoCallReturnETI::initializeImpl(const TimeGrid& timeGrid,
													 const boost::shared_ptr<YieldTermStructure>& discountCurve,
													 const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	returnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	
	assetNum_ = pathGenFactory->numAssets();

}

bool NoAutoCallReturnETI::pastEventOcc()
{
	return false;
}

bool NoAutoCallReturnETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
	//return rangeEvent_->checkEvent(path);

}

Real NoAutoCallReturnETI::payoffImpl(const MultiPath& path,Size endPosition)
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

std::vector<Date> NoAutoCallReturnETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	helper.mergeDates(fixingDates,this->returnCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> NoAutoCallReturnETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	payoffDates.push_back(payoffDateInfo_->fixingDate());

	return payoffDates;
}

}