#include "MultiConditionAccrualCouponRateETI.hpp"

namespace QuantLib {

MultiConditionAccrualCouponRateETI::MultiConditionAccrualCouponRateETI(
										const DayCounter& dayCounter,
										const std::vector<boost::shared_ptr<Range1D>>& range1DList,
										const std::vector<boost::shared_ptr<ReferenceCalculation>>& refCalcList,
										const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalcList,
										Real accrualDateNum,
										const boost::shared_ptr<DateInformation>& dateInfo, // interval ¿ë.
										const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										bool isExpired,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter, dateInfo->fixingDates()[0] ,dateInfo->fixingDates()[dateInfo->fixingDates().size()-1],usingVariableInfoList),
  range1DList_(range1DList), refCalcList_(refCalcList), returnCalcList_(returnCalcList),
  accrualDateNum_(accrualDateNum), dateInfo_(dateInfo)
{
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;
}

void MultiConditionAccrualCouponRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->setYearFracValues(timeGrid);

	for ( Size i=0 ; i < this->refCalcList_.size() ; ++i )
	{
		this->refCalcList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	for ( Size i=0 ; i < this->returnCalcList_.size() ; ++i )
	{
		this->returnCalcList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->dateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->fixingDatePosition_ = this->dateInfo_->fixingDatePositions();
}

bool MultiConditionAccrualCouponRateETI::pastEventOcc()
{
	return true;
}

bool MultiConditionAccrualCouponRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	//bool tf = this->eventCal_->checkEvent(path);
	
	bool tf = true;

	return tf;
}

Real MultiConditionAccrualCouponRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	//Real discount = payoffDateInfo_->discount();

	const std::valarray<Size>& v = this->fixingDatePosition_;

	for ( Size i = 0 ; i < v.size() ; i++ )
	{
		for ( Size rng = 0 ; rng < this->range1DList_.size() ;rng++ ) 
		{
			double refCal = this->refCalcList_[rng]->calSlice(path,v[i]);

			bool tf = this->range1DList_[rng]->eventOcc(refCal);
			
			if ( tf ) 
			{ 
				value += this->returnCalcList_[rng]->calSlice(path,v[i]);
			}
		}

	}

	//value = ( value / this->accrualDateNum_ ) * discount * this->couponYearFraction_;
	value = ( value / this->accrualDateNum_ ) * this->couponYearFraction_;

	return value;
}

//Real MultiConditionAccrualCouponRateETI::payoffImplEarlyEx(const MultiPath& path,Size endPosition)
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


std::vector<Date> MultiConditionAccrualCouponRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	
	//helper.mergeDates(fixingDates,this->eventCal_->fixingDates());
	//helper.mergeDates(fixingDates,this->returnCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> MultiConditionAccrualCouponRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}


}

