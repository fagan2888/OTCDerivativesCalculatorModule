#include "VanillaCallETI.hpp"


namespace QuantLib {

VanillaCallETI::VanillaCallETI(double partiRate,
						const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
						const boost::shared_ptr<ReferenceCalculation>& referenceCal,
						double strike,
						double lowerBound,
						const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), partiRate_(partiRate), referenceCal_(referenceCal),
  strike_(strike), lowerBound_(lowerBound)
{
	this->payoffDateInfo_ = payoffDateInfo;
}

void VanillaCallETI::initializeImpl(const TimeGrid& timeGrid,
							   const boost::shared_ptr<YieldTermStructure>& discountCurve,
							   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

bool VanillaCallETI::pastEventOcc()
{
	return false;
}

bool VanillaCallETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return false;
}

Real VanillaCallETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	// 우선 max로 잡아놓자
	//value = std::max(referenceCal_->calculate(path),lowerBound_);
	
	//value = std::max(referenceCal_->calculate(path),lowerBound_);

	return value;
}

std::vector<Date> VanillaCallETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(fixingDates,this->referenceCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> VanillaCallETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

