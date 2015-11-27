#include "simpleRangeAccrualRateETI.hpp"

namespace QuantLib {

SimpleRangeAccrualRateETI::SimpleRangeAccrualRateETI(const DayCounter& dayCounter,
									const Date& calculationStart,
									const Date& calculationEnd,
									const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
									const boost::shared_ptr<ReferenceCalculation>& referenceCalculation,
									const std::vector<boost::shared_ptr<SimpleRangeEvent>>& simpleRangeRateList,
									Size denumerDateNum,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter,calculationStart,calculationEnd,usingVariableInfoList), referenceCalculation_(referenceCalculation), 
  simpleRangeRateList_(simpleRangeRateList), denumerDateNum_(denumerDateNum)
{
	this->payoffDateInfo_ = payoffDateInfo;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void SimpleRangeAccrualRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	referenceCalculation_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->rangeNum_ = simpleRangeRateList_.size();
	this->assetNum_ = pathGenFactory->numAssets();
	
	Date today = Settings::instance().evaluationDate();
	
	DayCounter dayCounter = Actual365Fixed();

	double fixingStartTime = dayCounter.yearFraction( today , calculationStartDate_ );
	Size fixingStartPosition = timeGrid.closestIndex(fixingStartTime);

	double fixingEndTime = dayCounter.yearFraction( today , calculationEndDate_ );
	Size fixingEndPosition = timeGrid.closestIndex(fixingEndTime);

	Size fixingSize = fixingEndPosition - fixingStartPosition;
	
	this->fixingDatePositions_ = std::valarray<Size>(fixingSize);

	for ( Size position = 0 ; fixingSize ; position++ )
	{
		fixingDatePositions_[position] = fixingStartPosition + position;
	}

	for ( Size rng = 0 ; this->rangeNum_ ; rng++ )
	{
		simpleRangeRateList_[rng]->initialize(timeGrid,discountCurve,pathGenFactory);
	}
	
}

bool SimpleRangeAccrualRateETI::pastEventOcc()
{
	return true;
}

bool SimpleRangeAccrualRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return false;
}

Real SimpleRangeAccrualRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	std::valarray<Size> accrualCountList(this->rangeNum_,0);
	std::valarray<Real> accrualPath(this->assetNum_);

	for ( Size position = 0 ; this->fixingDatePositionsNum_ ; position++ )
	{
		for ( Size asset = 0 ; this->assetNum_ ; asset++ )
		{
			accrualPath[asset] = path[asset][fixingDatePositions_[position]];
		}

		for ( Size rng = 0 ; this->rangeNum_ ; rng++ )
		{
			accrualCountList[rng] = this->simpleRangeRateList_[rng]->inRange(accrualPath);
		}
	}

	for ( Size rng = 0 ; this->rangeNum_ ; rng++ )
	{
		 value += accrualCountList[rng] * this->simpleRangeRateList_[rng]->payoff(path,endPosition);
	}

	return value;
}

std::vector<Date> SimpleRangeAccrualRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < simpleRangeRateList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,simpleRangeRateList_[i]->fixingDates());
	}

	helper.mergeDates(fixingDates,this->referenceCalculation_->fixingDates());

	return fixingDates;
}

std::vector<Date> SimpleRangeAccrualRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < simpleRangeRateList_.size() ; i++ )
	{
		helper.mergeDates(payoffDates,simpleRangeRateList_[i]->payoffDates());
	}

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

