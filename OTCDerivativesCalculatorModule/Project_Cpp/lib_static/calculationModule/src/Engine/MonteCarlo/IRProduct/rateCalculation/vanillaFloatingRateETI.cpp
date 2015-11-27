#include "vanillaFloatingRateRTI.hpp"

namespace QuantLib {

VanillaFloatingRateRTI::VanillaFloatingRateRTI(const DayCounter& dayCounter,
											   const Date& calculationStartDate,
											   const Date& calculationEndDate,
											   const Date& paymentDate,
											   Real gearing,
											   Real spread,
											   boost::shared_ptr<EventTriggerInfo> couponCalculation,
											   bool isExpired)
: RateCalculation(dayCounter), calculationStartDate_(calculationStartDate), paymentDate_(paymentDate),
  calculationEndDate_(calculationEndDate), gearing_(gearing), spread(spread), couponCalculation_(couponCalculation)
{
	this->isExpired_ = isExpired;
	couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void VanillaFloatingRateRTI::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->discount_[0] = 0.0;
}

bool VanillaFloatingRateRTI::pastEventOcc()
{
	return true;
}

bool VanillaFloatingRateRTI::checkEvent(const MultiPath& path)
{
	return true;
}

Real VanillaFloatingRateRTI::payoff(const MultiPath& path)
{
	Real rate = couponCalculation_->payoff(path);

	//yearFraction
	return (gearing_ * rate + spread_ ) * couponYearFraction_ * discount_[0];

}

}

