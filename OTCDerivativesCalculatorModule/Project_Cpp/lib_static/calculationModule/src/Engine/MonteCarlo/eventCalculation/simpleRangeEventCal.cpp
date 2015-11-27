#include "SimpleRangeEventCal.hpp"

namespace QuantLib {

SimpleRangeEventCal::SimpleRangeEventCal(const boost::shared_ptr<Range1D>& range1D,
										 //const boost::shared_ptr<ReferenceCalculationInfo>& referenceCalInfo,
										 const boost::shared_ptr<ReferenceCalculation>& referenceCal,
										 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), range1D_(range1D), referenceCal_(referenceCal)
{
}

void SimpleRangeEventCal::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	referenceCal_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real SimpleRangeEventCal::accrualNum(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

bool SimpleRangeEventCal::pastEventOcc()
{
	return true;
}

bool SimpleRangeEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	Real refVal = this->referenceCal_->calculate(path,endPosition);

	tf = range1D_->eventOcc(refVal);
	
	#ifdef LogPrint

	std::ostringstream ss;

	ss << "SimpleRangeEventCal TF : " << tf << " , " ;
	ss << " Range ( " << this->range1D_->lowerBound() << " < " << refVal << " < " << this->range1D_->upperBound() << " )";

	path.log_.push_back(ss.str());

	#endif

	return tf;
}

std::vector<Date> SimpleRangeEventCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	return fixingDates;
}

std::vector<Date> SimpleRangeEventCal::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

bool SimpleRangeEventCal::inRange(const std::valarray<Real>& val)
{
	return false;
}

}

