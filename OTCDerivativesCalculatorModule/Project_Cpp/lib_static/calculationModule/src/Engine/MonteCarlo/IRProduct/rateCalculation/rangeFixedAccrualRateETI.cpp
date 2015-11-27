#include "RangeFixedAccrualRateETI.hpp"

namespace QuantLib {

RangeFixedAccrualRateETI::RangeFixedAccrualRateETI(const DayCounter& dayCounter,
									const Date& calculationStartDate,
									const Date& calculationEndDate,
									const std::vector<Real>& weight,
									const std::vector<boost::shared_ptr<EventCalculation>>& eventCals,
									const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCals,
									const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
									const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
									bool isExpired,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter,calculationStartDate,calculationEndDate,usingVariableInfoList), weight_(weight), 
  eventCals_(eventCals), returnCals_(returnCals), complementReturnCal_(complementReturnCal)
{
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;
}

void RangeFixedAccrualRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->rangeEventSize_ = this->eventCals_.size();

	this->accrualNumArr_ = std::valarray<Real>(this->rangeEventSize_);

	for  ( Size i=0 ; i<this->rangeEventSize_ ; i++)
	{
		this->eventCals_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
		this->returnCals_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}
	
	
	this->complementReturnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

}

bool RangeFixedAccrualRateETI::pastEventOcc()
{
	return true;
}

bool RangeFixedAccrualRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	//bool tf = this->eventCal_->checkEvent(path);
	bool tf = true;

	return tf;
}

Real RangeFixedAccrualRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	//Real discout = payoffDateInfo_->discount();

	for  ( Size i=0 ; i<this->rangeEventSize_ ; i++)
	{
		value = this->accrualNumArr_[i] = this->eventCals_[i]->accrualNum(path,endPosition)
			  * this->returnCals_[i]->calculate(path,endPosition)
			  * this->weight_[i];
	}

	// complementReturnPortion 계산해야함

	//value = complementReturnCal_->calculate(path,endPosition) * discout;

	return value;
}

std::vector<Date> RangeFixedAccrualRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	//DateHelper helper = DateHelper();
	//
	//helper.mergeDates(fixingDates,this->eventCal_->fixingDates());
	//helper.mergeDates(fixingDates,this->returnCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> RangeFixedAccrualRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}


}

