#include "MultiRangeEventCal.hpp"

namespace QuantLib {

MultiRangeEventCal::MultiRangeEventCal(const std::vector<boost::shared_ptr<Range1DJointCalculation>>& rangeJointCals,
					const std::vector<boost::shared_ptr<ReferenceCalculation>>& referenceCals,
					const boost::shared_ptr<JointSimpleCalculation>& jointRangeCal,
					const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), rangeJointCals_(rangeJointCals), referenceCals_(referenceCals),
  jointRangeCal_(jointRangeCal)
{
	this->timeFlag_ = false;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

MultiRangeEventCal::MultiRangeEventCal(const std::vector<boost::shared_ptr<Range1DJointCalculation>>& rangeJointCals,
							   const std::vector<boost::shared_ptr<ReferenceTimeCalculation>>& referenceTimeCals,
							   const boost::shared_ptr<JointSimpleCalculation>& jointRangeCal,
							   const boost::shared_ptr<DateInformation>& dateInfo,
							   const boost::shared_ptr<JointSimpleCalculation>& jointTimeCal,
							   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), rangeJointCals_(rangeJointCals), referenceTimeCals_(referenceTimeCals),
  jointRangeCal_(jointRangeCal), dateInfo_(dateInfo), jointTimeCal_(jointTimeCal)
{
	this->timeFlag_ = true;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void MultiRangeEventCal::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->fixingDatePositions_ = dateInfo_->fixingDatePositions();
	timeSize_ = this->fixingDatePositions_.size();
}

bool MultiRangeEventCal::pastEventOcc()
{
	return true;
}

bool MultiRangeEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	//Size minPosition = timeSize_;

	//if ( fixingDatePositions_[endPosition] < minPosition)
	//{
	//	minPosition = fixingDatePositions_[endPosition];
	//}

	//if ( this->timeFlag_ == true )
	//{
	//	for( Size t=0 ;t < minPosition ; ++t )
	//	{
	//		Real refVal = this->referenceCal_->calSlice(path,this->fixingDatePositions_[t]);
	//		timeJointArr_[t] = range1D_->eventOcc(refVal);
	//	}

	//	return jointSimpleCal_->jointCal(timeJointArr_);

	//}else
	//{
	//	Real refVal = this->referenceCal_->calculate(path,endPosition);
	//	return range1D_->eventOcc(refVal);
	//}

	return tf;
}

std::vector<Date> MultiRangeEventCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	//helper.mergeDates(fixingDates,this->returnCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> MultiRangeEventCal::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

bool MultiRangeEventCal::inRange(const std::valarray<Real>& val)
{
	return false;
}

}

