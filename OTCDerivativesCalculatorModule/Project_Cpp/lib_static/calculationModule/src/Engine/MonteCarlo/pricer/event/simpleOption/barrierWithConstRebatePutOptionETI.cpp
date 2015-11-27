#include "BarrierWithConstRebatePutOptionETI.hpp"


namespace QuantLib {

BarrierWithConstRebatePutOptionETI::BarrierWithConstRebatePutOptionETI(double partiRate,
							   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
							   const boost::shared_ptr<ReferenceCalculation>& referenceCal,
							   const boost::shared_ptr<EventTriggerInfo>& barrierInfo,
							   double strike,
							   double lowerBound,
							   double rebateRate,
							   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), partiRate_(partiRate), referenceCal_(referenceCal),
  strike_(strike), lowerBound_(lowerBound), rebateRate_(rebateRate)
{
	this->payoffDateInfo_ = payoffDateInfo;

	//payoffDatePositions_ = std::valarray<Size>(1);
}

void BarrierWithConstRebatePutOptionETI::initializeImpl(const TimeGrid& timeGrid,
												    const boost::shared_ptr<YieldTermStructure>& discountCurve,
												    const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->referenceCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->barrierInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
}

bool BarrierWithConstRebatePutOptionETI::pastEventOcc()
{
	return false;
}

bool BarrierWithConstRebatePutOptionETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return false;
}

Real BarrierWithConstRebatePutOptionETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	if ( this->barrierInfo_->checkEvent(path,endPosition) )
	{
		value = this->rebateRate_;
	}else
	{
		value = std::max(this->strike_ - referenceCal_->calculate(path,endPosition),lowerBound_);
	}

	return value;
}

std::vector<Date> BarrierWithConstRebatePutOptionETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(fixingDates,this->referenceCal_->fixingDates());
	helper.mergeDates(fixingDates,this->barrierInfo_->fixingDates());

	return fixingDates;
}

std::vector<Date> BarrierWithConstRebatePutOptionETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

