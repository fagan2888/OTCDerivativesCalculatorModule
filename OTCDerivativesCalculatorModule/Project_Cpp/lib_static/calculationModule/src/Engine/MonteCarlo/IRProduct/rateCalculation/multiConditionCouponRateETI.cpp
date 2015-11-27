#include "MultiConditionCouponRateETI.hpp"

namespace QuantLib {

MultiConditionCouponRateETI::MultiConditionCouponRateETI(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalcList,
										const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalcList,
										QuantLib::DayCounter dayCounter,
										const Date& calculationStartDate,
										const Date& calculationEndDate,
										//const boost::shared_ptr<FixingDateInfo>& calculationStartDateInfo,
										//const boost::shared_ptr<FixingDateInfo>& calculationEndDateInfo,
										const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										bool isExpired,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter,calculationStartDate,calculationEndDate,usingVariableInfoList), 
  eventCalcList_(eventCalcList), returnCalcList_(returnCalcList)
{
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;
}

void MultiConditionCouponRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i=0 ; i < this->eventCalcList_.size() ; ++i )
	{
		this->eventCalcList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	for ( Size i=0 ; i < this->returnCalcList_.size() ; ++i )
	{
		this->returnCalcList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	RateCalculation::setYearFracValues(timeGrid);

	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

}

bool MultiConditionCouponRateETI::pastEventOcc()
{
	return true;
}

bool MultiConditionCouponRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	bool tf = true;//this->eventCal_->checkEvent(path);

	return tf;
}

Real MultiConditionCouponRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	//Real discount = payoffDateInfo_->discount();

	for ( Size i=0 ; i<this->eventCalcList_.size() ; i++)
	{
		bool tf = this->eventCalcList_[i]->checkEvent(path,endPosition);

		if ( tf ) 
		{ 
			value += this->returnCalcList_[i]->calculate(path,endPosition); 
		}
	}

	//value = value * discount * couponYearFraction_;
	value = value * couponYearFraction_;

	return value;
}

//Real MultiConditionCouponRateETI::payoffImplEarlyEx(const MultiPath& path,Size endPosition)
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


std::vector<Date> MultiConditionCouponRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	
	//helper.mergeDates(fixingDates,this->eventCal_->fixingDates());
	helper.mergeDates(fixingDates,this->returnCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> MultiConditionCouponRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}


}

