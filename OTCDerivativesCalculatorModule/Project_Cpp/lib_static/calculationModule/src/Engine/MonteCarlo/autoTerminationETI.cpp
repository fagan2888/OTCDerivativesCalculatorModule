#include "AutoTerminationETI.hpp"

namespace QuantLib {

AutoTerminationETI::AutoTerminationETI(const boost::shared_ptr<EventCalculation>& eventCal,
								const boost::shared_ptr<ReturnCalculation>& returnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), eventCal_(eventCal), returnCal_(returnCal)
{
	this->payoffDateInfo_ = payoffDateInfo;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void AutoTerminationETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->eventCal_->initialize(timeGrid, discountCurve, pathGenFactory);
	this->returnCal_->initialize(timeGrid, discountCurve, pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid, discountCurve, pathGenFactory);
}

bool AutoTerminationETI::pastEventOcc()
{
	return true;
}

bool AutoTerminationETI::checkEvent(const MultiPath& path,Size endPosition)
{
	bool tf = this->eventCal_->checkEvent(path,endPosition);

	return tf;
}

Real AutoTerminationETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real fixed = 0.0;

	fixed = returnCal_->calculate(path,endPosition);

	//yearFraction
	return fixed * payoffDateInfo_->discount();
}

std::vector<Date> AutoTerminationETI::fixingDates() const
{
	std::vector<Date> fixingDates;
	DateHelper helper = DateHelper();
	
	helper.mergeDates(fixingDates,this->returnCal_->fixingDates());
	helper.mergeDates(fixingDates,this->eventCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> AutoTerminationETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	payoffDates.push_back(this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

