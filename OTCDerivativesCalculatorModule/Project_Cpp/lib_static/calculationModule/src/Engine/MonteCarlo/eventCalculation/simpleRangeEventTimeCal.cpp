#include "SimpleRangeEventTimeCal.hpp"

namespace QuantLib {

SimpleRangeEventTimeCal::SimpleRangeEventTimeCal(const boost::shared_ptr<Range1D>& range1D,
										 const boost::shared_ptr<ReferenceCalculationInfo>& referenceCalInfo,
										 const boost::shared_ptr<DateInformation>& dateInfo,
										 const boost::shared_ptr<JointSimpleCalculation>& jointSimpleCal,
										 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), range1D_(range1D), referenceCalInfo_(referenceCalInfo),
  jointSimpleCal_(jointSimpleCal), dateInfo_(dateInfo)
{
}

void SimpleRangeEventTimeCal::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	dateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	referenceCalInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->fixingDatePositions_ = dateInfo_->fixingDatePositions();
	//this->assetNum_ = pathGenFactory->pathSize();

	timeSize_ = this->fixingDatePositions_.size();
}

Real SimpleRangeEventTimeCal::accrualNum(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

bool SimpleRangeEventTimeCal::pastEventOcc()
{
	return true;
}

bool SimpleRangeEventTimeCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	//Size minPosition = timeSize_;

	//if ( fixingDatePositions_[endPosition] < minPosition)
	//{
	//	minPosition = fixingDatePositions_[endPosition];
	//}

	for( Size t=0 ;t < timeSize_ ; ++t )
	{
		Real refVal = this->referenceCalInfo_->calSlice(path,this->fixingDatePositions_[t]);
		timeJointArr_[t] = range1D_->eventOcc(refVal);
	}

	return jointSimpleCal_->jointCal(timeJointArr_);

}

std::vector<Date> SimpleRangeEventTimeCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	//helper.mergeDates(fixingDates,this->returnCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> SimpleRangeEventTimeCal::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

bool SimpleRangeEventTimeCal::inRange(const std::valarray<Real>& val)
{
	return false;
}

}

