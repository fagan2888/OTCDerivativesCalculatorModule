#include "CompositeSumOptionPricer.hpp"

namespace QuantLib {

CompositeSumOptionPricer::CompositeSumOptionPricer(//const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
												   //const boost::shared_ptr<ReferenceCalculation> referenceCal,
												   Real notionalPayment,
												   const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo, // notional pay용 나머지는 각각의 안에 있음.
												   const std::vector<boost::shared_ptr<EventTriggerInfo>>& optionList)
: optionList_(optionList), notionalPayment_(notionalPayment) ,payoffDateInfo_(payoffDateInfo) //fixingDateInfo_(fixingDateInfo)
{
	//pastEventOcc_ = barrierInfo_->pastEventOcc();
	this->optionListNum_ = optionList.size();
}

void CompositeSumOptionPricer::initializeImpl(const TimeGrid& timeGrid,
							   const boost::shared_ptr<YieldTermStructure>& discountCurve,
							   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//this->referenceCal_->initialize(timeGrid,discountCurve);

	for (Size i=0 ; i < optionListNum_ ; i++)
	{
		optionList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	Date today = Settings::instance().evaluationDate();
	
	DayCounter dayCounter = Actual365Fixed();
	
	//this->discount_ = Array(1);

	//double payoffTime = dayCounter.yearFraction( today , payoffDateInfo_-> );
	//payoffDatePositions_[0] = timeGrid.closestIndex(payoffTime);

	//discount_[0] = discountCurve->discount(payoffTime);
	
}

Real CompositeSumOptionPricer::calculate(const MultiPath& path,Size endPosition) const
{
	Real value = 0.0;
	Real discount = this->payoffDateInfo_->discount();

	for (Size i=0 ; i < optionListNum_ ; i++)
	{
		value += optionList_[i]->payoff(path,endPosition);
	}

	value += this->notionalPayment_ * discount;

	return value;
}

std::vector<Date> CompositeSumOptionPricer::fixingDates() const
{
	std::vector<Date> fixingDates;


	return fixingDates;

}

std::vector<Date> CompositeSumOptionPricer::payoffDates() const
{
	std::vector<Date> payoffDates;


	return payoffDates;
}

void CompositeSumOptionPricer::resetImpl() const
{

}

}

