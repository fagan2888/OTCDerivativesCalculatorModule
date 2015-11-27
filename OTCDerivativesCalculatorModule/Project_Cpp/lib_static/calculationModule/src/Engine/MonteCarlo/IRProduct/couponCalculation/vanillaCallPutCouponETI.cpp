#include "vanillaCallPutCouponETI.hpp"

namespace QuantLib {

VanillaCallPutCouponETI::VanillaCallPutCouponETI(
								bool callPut,
								Real partiRate,
								Real strike,
								Real spread,
								const boost::shared_ptr<ReferenceCalculation>& refCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								bool isExpired,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: CouponCalculation(usingVariableInfoList), callPut_(callPut), partiRate_(partiRate), strike_(strike), 
  spread_(spread)
{
	this->referenceCal_ = refCal;
	this->payoffDateInfo_ = payoffDateInfo;

	this->isExpired_ = isExpired;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void VanillaCallPutCouponETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//this->returnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->referenceCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

bool VanillaCallPutCouponETI::pastEventOcc()
{
	return true;
}

bool VanillaCallPutCouponETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
}

Real VanillaCallPutCouponETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real v = 0.0;

	Real calVal = 0.0;

	Real refCalVal = referenceCal_->calculate(path,endPosition);;

	if ( this->callPut_ ) // call
	{
		calVal = refCalVal - this->strike_;

		if ( calVal < 0 )
		{
			calVal = 0;
		}
	}
	else // put
	{
		calVal = this->strike_ - refCalVal ;

		if ( calVal < 0 )
		{
			calVal = 0;
		}
	}
	
	v = this->partiRate_ * calVal + this->spread_;
		
	//return v * this->payoffDateInfo_->discount();
	return v;
}
std::vector<Date> VanillaCallPutCouponETI::fixingDates() const
{
	 return this->returnCal_->fixingDates();
}

std::vector<Date> VanillaCallPutCouponETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}

}

