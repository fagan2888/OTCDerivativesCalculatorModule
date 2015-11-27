#include "simpleRangeEvent.hpp"

namespace QuantLib {

SimpleRangeEvent::SimpleRangeEvent(const boost::shared_ptr<ReferenceCalculation>& refCal,
								 const boost::shared_ptr<Range1D>& range1D,
								 const boost::shared_ptr<ReturnCalculation>& returnCalculation,
								 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), refCal_(refCal), range1D_(range1D), returnCalculation_(returnCalculation)
{
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void SimpleRangeEvent::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	refCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	returnCalculation_->initialize(timeGrid,discountCurve,pathGenFactory);
}

bool SimpleRangeEvent::pastEventOcc()
{
	return true;
}

bool SimpleRangeEvent::checkEvent(const MultiPath& path,Size endPosition)
{ 
	return false;
}

std::vector<Date> SimpleRangeEvent::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(fixingDates,this->refCal_->fixingDates());
	helper.mergeDates(fixingDates,this->returnCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> SimpleRangeEvent::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}


Real SimpleRangeEvent::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = refCal_->calculate(path,endPosition);
	Real inValue = 0.0;

	if ( range1D_->eventOcc(value) )
	{
		return returnCalculation_->calculate(path,endPosition);
	}
	else
	{
		return 0.0;
	}
}

bool SimpleRangeEvent::inRange(const std::valarray<Real>& val)
{
	Real value = refCal_->calSlice(val);

	return range1D_->eventOcc(value);
}

}

