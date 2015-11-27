#include "RangeFloatingAccrualRateETI.hpp"

namespace QuantLib {

RangeFloatingAccrualRateETI::RangeFloatingAccrualRateETI(const boost::shared_ptr<EventCalculation>& eventCal,
											const boost::shared_ptr<ReturnCalculation>& returnCal,
											const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
											const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
											bool isExpired,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: CouponCalculation(usingVariableInfoList), eventCal_(eventCal), complementReturnCal_(complementReturnCal)
{
	this->returnCal_ = returnCal;
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;
}

void RangeFloatingAccrualRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->eventCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->returnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->complementReturnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

}

bool RangeFloatingAccrualRateETI::pastEventOcc()
{
	return true;
}

bool RangeFloatingAccrualRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	bool tf = this->eventCal_->checkEvent(path);

	return tf;
}

Real RangeFloatingAccrualRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	bool tf = this->eventCal_->checkEvent(path,endPosition);
	//Real discout = payoffDateInfo_->discount();

	if ( tf )
	{
		//value = returnCal_->calculate(path,endPosition) * discout;
		value = returnCal_->calculate(path,endPosition) ;
	}
	else 
	{
		//value = complementReturnCal_->calculate(path,endPosition) * discout;
		value = complementReturnCal_->calculate(path,endPosition) ;
	}

	return value;
}

//Real RangeFloatingAccrualRateETI::payoffImplEarlyEx(const MultiPath& path,Size endPosition)
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


std::vector<Date> RangeFloatingAccrualRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	
	helper.mergeDates(fixingDates,this->eventCal_->fixingDates());
	helper.mergeDates(fixingDates,this->returnCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> RangeFloatingAccrualRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}


}

