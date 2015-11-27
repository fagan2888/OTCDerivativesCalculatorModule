#include "BarrierWithConstRebateCallOptionETI.hpp"
#include <iostream>

namespace QuantLib {

BarrierWithConstRebateCallOptionETI::
	BarrierWithConstRebateCallOptionETI(double partiRate,
										const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										const boost::shared_ptr<ReferenceCalculation>& referenceCal,
										const boost::shared_ptr<EventTriggerInfo>& barrierInfo,
										double strike,
										double lowerBound,
										double rebateRate,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), partiRate_(partiRate), referenceCal_(referenceCal), barrierInfo_(barrierInfo),
  strike_(strike), lowerBound_(lowerBound), rebateRate_(rebateRate)
{
	this->payoffDateInfo_ = payoffDateInfo;
}

void BarrierWithConstRebateCallOptionETI::initializeImpl(const TimeGrid& timeGrid,
													 const boost::shared_ptr<YieldTermStructure>& discountCurve,
													 const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->referenceCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->barrierInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

bool BarrierWithConstRebateCallOptionETI::pastEventOcc()
{
	return false;
}

bool BarrierWithConstRebateCallOptionETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return false;
}

Real BarrierWithConstRebateCallOptionETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	/*Real underValue = referenceCal_->calculate(path);
	std::cout <<underValue << std::endl;*/
	if ( this->barrierInfo_->checkEvent(path) )
	{
		value = this->rebateRate_;
	}else
	{
		value = std::max( partiRate_ * (referenceCal_->calculate(path,endPosition) - this->strike_ ),lowerBound_)
				* this->payoffDateInfo_->discount();
	}

	return value;
}


std::vector<Date> BarrierWithConstRebateCallOptionETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(fixingDates,this->referenceCal_->fixingDates());
	helper.mergeDates(fixingDates,this->barrierInfo_->fixingDates());

	return fixingDates;
}

std::vector<Date> BarrierWithConstRebateCallOptionETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

