#include "constantPayoffETI.hpp"

namespace QuantLib {

ConstantPayoffETI::ConstantPayoffETI(double unit,
						   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
						   double constValue,
						   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), unit_(unit), constValue_(constValue)
{
	this->payoffDateInfo_ = payoffDateInfo;
}

void ConstantPayoffETI::initializeImpl(const TimeGrid& timeGrid,
							   const boost::shared_ptr<YieldTermStructure>& discountCurve,
							   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

bool ConstantPayoffETI::pastEventOcc()
{
	return false;
}

bool ConstantPayoffETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return false;
}

Real ConstantPayoffETI::payoffImpl(const MultiPath& path,Size endPosition)
{

	// 우선 max로 잡아놓자
	//value = std::max(referenceCal_->calculate(path),lowerBound_);
	
	//value = std::max(referenceCal_->calculate(path),lowerBound_);

	return constValue_ * payoffDateInfo_->discount();
}

std::vector<Date> ConstantPayoffETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	return fixingDates;
}

std::vector<Date> ConstantPayoffETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

