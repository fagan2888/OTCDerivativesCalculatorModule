#include "ReferenceEventCal.hpp"

namespace QuantLib {

ReferenceEventCal::ReferenceEventCal(const std::string& refEventName,
									 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), refEventName_(refEventName)
{
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void ReferenceEventCal::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	refEventOccPtr_ = pathGenFactory->getValueTypeReference(this->refEventName_);
}

Real ReferenceEventCal::accrualNum(const MultiPath& path,Size endPosition)
{
	return 0.0;
}


bool ReferenceEventCal::pastEventOcc()
{
	return true;
}

bool ReferenceEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;
	
	if (refEventOccPtr_->value_ > 0 )
	{
		tf = true;
	}

	return tf;
}

std::vector<Date> ReferenceEventCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	//helper.mergeDates(fixingDates,this->returnCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> ReferenceEventCal::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}


Real ReferenceEventCal::payoff(const MultiPath& path)
{
	return 0.0;
}

bool ReferenceEventCal::inRange(const std::valarray<Real>& val)
{
	return false;
}

}

