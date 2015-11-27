#include "vanillaCouponETI.hpp"

namespace QuantLib {

VanillaCouponETI::VanillaCouponETI(Real gearing,
								Real spread,
								const boost::shared_ptr<ReturnCalculation>& returnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								bool isExpired,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: CouponCalculation(usingVariableInfoList), gearing_(gearing), spread_(spread)
{
	this->returnCal_ = returnCal;
	this->payoffDateInfo_ = payoffDateInfo;

	this->isExpired_ = isExpired;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void VanillaCouponETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->returnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

bool VanillaCouponETI::pastEventOcc()
{
	return true;
}

bool VanillaCouponETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
}

Real VanillaCouponETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real v = this->gearing_ * returnCal_->calculate(path,endPosition) + this->spread_;
		
	//return v * this->payoffDateInfo_->discount();
	return v ;
}
std::vector<Date> VanillaCouponETI::fixingDates() const
{
	 return this->returnCal_->fixingDates();
}

std::vector<Date> VanillaCouponETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}

}

