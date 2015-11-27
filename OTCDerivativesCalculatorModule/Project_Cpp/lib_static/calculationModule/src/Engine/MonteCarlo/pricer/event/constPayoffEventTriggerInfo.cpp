#include "constPayoffEventTriggerInfo.hpp"

namespace QuantLib {

//ConstPayoffEventTriggerInfo::ConstPayoffEventTriggerInfo(const Date& fixingDate,
//														const Date& payoffDate,
//														Real constReturn)
//: EventTriggerInfo(), constReturn_(constReturn)
//{
//	this->fixingDates_.push_back(fixingDate);
//	this->payoffDates_.push_back(payoffDate);
//
//	fixingDatePositions_ = std::valarray<Size>(fixingDates_.size());
//	payoffDatePositions_ = std::valarray<Size>(payoffDates_.size());
//}


ConstPayoffEventTriggerInfo::ConstPayoffEventTriggerInfo(const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo,
														Real constReturn,
														const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), constReturn_(constReturn)
{
	this->payoffDateInfo_ = payoffDateInfo;
}


void ConstPayoffEventTriggerInfo::initializeImpl(const TimeGrid& timeGrid,
											const boost::shared_ptr<YieldTermStructure>& discountCurve,
											const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	//Date today = Settings::instance().evaluationDate();
	//
	//DayCounter dayCounter = Actual365Fixed();
	
	//discount_ = Array(this->payoffDates_.size());

	//double fixingTime = dayCounter.yearFraction( today , fixingDates_[0] );
	//fixingDatePositions_[0] = timeGrid.closestIndex(fixingTime);
	//
	//double payoffTime = dayCounter.yearFraction( today , payoffDates_[0] );
	//payoffDatePositions_[0] = timeGrid.closestIndex(payoffTime);
	//
	//discount_[0] = discountCurve->discount(payoffTime);

	assetNum_ = pathGenFactory->numAssets();
}

bool ConstPayoffEventTriggerInfo::pastEventOcc()
{
	return pastEventOcc_;
}

bool ConstPayoffEventTriggerInfo::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
}

bool ConstPayoffEventTriggerInfo::autoCallEvent(const MultiPath& path)
{
	return false;
}

Real ConstPayoffEventTriggerInfo::payoffImpl(const MultiPath& path,Size endPosition)
{
	return constReturn_ * payoffDateInfo_->discount();
}

std::vector<Date> ConstPayoffEventTriggerInfo::fixingDates() const
{
	std::vector<Date> fixingDates;

	return fixingDates;
}

std::vector<Date> ConstPayoffEventTriggerInfo::payoffDates() const
{
	std::vector<Date> payoffDates;

	payoffDates.push_back(payoffDateInfo_->fixingDate());

	return payoffDates;
}

}
