#include "MultiConditionMultiRngAccrualCouponRateETI.hpp"

namespace QuantLib {

MultiConditionMultiRngAccrualCouponRateETI::MultiConditionMultiRngAccrualCouponRateETI(
										const DayCounter& dayCounter,
										const std::vector<boost::shared_ptr<RangeND>>& rangeNDList,
										const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalcList,
										Real accrualDateNum, // 이건 accrual된 rate를 떨굴때만 사용함.
										const boost::shared_ptr<DateInformation>& dateInfo, // interval 용.
										const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										bool isExpired,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter, dateInfo->fixingDates()[0] ,dateInfo->fixingDates()[dateInfo->fixingDates().size()-1],usingVariableInfoList),
  rangeNDList_(rangeNDList), returnCalcList_(returnCalcList),
  accrualDateNum_(accrualDateNum), dateInfo_(dateInfo)
{
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;
}

void MultiConditionMultiRngAccrualCouponRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->setYearFracValues(timeGrid);

	for ( Size i=0 ; i < this->rangeNDList_.size() ; ++i )
	{
		this->rangeNDList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	for ( Size i=0 ; i < this->returnCalcList_.size() ; ++i )
	{
		this->returnCalcList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->dateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->fixingDatePosition_ = this->dateInfo_->fixingDatePositions();

	this->convertedAccrualDateNumFactor_ = static_cast<double>(this->fixingDatePosition_.size()); 
}

bool MultiConditionMultiRngAccrualCouponRateETI::pastEventOcc()
{
	return true;
}

bool MultiConditionMultiRngAccrualCouponRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	//bool tf = this->eventCal_->checkEvent(path);
	
	bool tf = true;

	return tf;
}

Real MultiConditionMultiRngAccrualCouponRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	//Real discount = payoffDateInfo_->discount();
	
	const std::valarray<Size>& v = this->fixingDatePosition_;

	for ( Size i = 0 ; i < v.size() ; i++ )
	{
		for ( Size rng = 0 ; rng < this->rangeNDList_.size() ;rng++ ) 
		{
			bool tf = this->rangeNDList_[rng]->eventOccSlice(path,v[i]);
			
			if ( tf ) 
			{ 
				value += this->returnCalcList_[rng]->calSlice(path,v[i]);
			}
		}

	}

	//value = ( value / this->convertedAccrualDateNumFactor_ ) * discount * this->couponYearFraction_;
	value = ( value / this->convertedAccrualDateNumFactor_ ) * this->couponYearFraction_;

	return value;
}

//Real MultiConditionMultiRngAccrualCouponRateETI::payoffImplEarlyEx(const MultiPath& path,Size endPosition)
//{
//	Real value = 0.0;
//
//	bool tf = this->eventCal_->checkEventEarlyEx(path,endPosition);
//	Real discout = payoffDateInfo_->discount(endPosition);
//
//	if (tf  )
//	{
//		value = returnCal_->calculateEarlyEx(path,endPosition) * discout;
//	}
//	else 
//	{
//		value = complementReturnCal_->calculateEarlyEx(path,endPosition) * discout;
//	}
//
//	return value;
//}


std::vector<Date> MultiConditionMultiRngAccrualCouponRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	
	//helper.mergeDates(fixingDates,this->eventCal_->fixingDates());
	//helper.mergeDates(fixingDates,this->returnCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> MultiConditionMultiRngAccrualCouponRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}


}

