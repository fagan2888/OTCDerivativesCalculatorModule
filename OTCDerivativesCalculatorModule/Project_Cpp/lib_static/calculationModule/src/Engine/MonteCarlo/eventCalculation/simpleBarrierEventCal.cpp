#include "simpleBarrierEventCal.hpp"

namespace QuantLib {

SimpleBarrierEventCal::SimpleBarrierEventCal(const boost::shared_ptr<EventTriggerInfo>& barrier,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), barrier_(barrier)
{
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void SimpleBarrierEventCal::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->barrier_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real SimpleBarrierEventCal::accrualNum(const MultiPath& path,Size endPosition)
{
	Real tf = this->checkEventImpl(path,endPosition);
	return tf;
}

bool SimpleBarrierEventCal::pastEventOcc()
{
	return true;
}

bool SimpleBarrierEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = barrier_->checkEvent(path,endPosition);

	#ifdef LogPrint

	std::ostringstream ss;

	ss << "SimpleBarrierEventCal TF : " << tf ;

	path.log_.push_back(ss.str());

	#endif

	return tf;
}

std::vector<Date> SimpleBarrierEventCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(fixingDates,this->barrier_->fixingDates());
	//helper.mergeDates(fixingDates,this->returnCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> SimpleBarrierEventCal::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}


Real SimpleBarrierEventCal::payoffImpl(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

bool SimpleBarrierEventCal::inRange(const std::valarray<Real>& val)
{
	return false;
}

}

