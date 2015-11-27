#include "redemptionNotionalETI.hpp"

namespace QuantLib {

RedemptionNotionalETI::RedemptionNotionalETI(Real notionalAmount,
											 const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo,
											 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), notionalAmount_(notionalAmount)
{
	this->payoffDateInfo_ = payoffDateInfo;
}

void RedemptionNotionalETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
}

bool RedemptionNotionalETI::pastEventOcc()
{
	return true;
}

bool RedemptionNotionalETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
}

Real RedemptionNotionalETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	return this->notionalAmount_ * this->payoffDateInfo_->discount();
}

std::vector<Date> RedemptionNotionalETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	return fixingDates;
}

std::vector<Date> RedemptionNotionalETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

