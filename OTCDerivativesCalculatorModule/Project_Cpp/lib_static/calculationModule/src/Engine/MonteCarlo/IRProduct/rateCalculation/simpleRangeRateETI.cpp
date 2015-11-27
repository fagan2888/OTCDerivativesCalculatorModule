#include "SimpleRangeRateETI.hpp"
#include <src/util/DateHelper.hpp>
#include <iostream>

namespace QuantLib {

SimpleRangeRateETI::SimpleRangeRateETI(const DayCounter& dayCounter,
									   const Date& calculationStart,
									   const Date& calculationEnd,
									   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
									   //const boost::shared_ptr<ReferenceCalculation>& referenceCalculation,
									   const std::vector<boost::shared_ptr<SimpleRangeEvent>>& simpleRangeEventList,
									   Size denumerDateNum,
									   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter,calculationStart,calculationEnd,usingVariableInfoList),
  simpleRangeEventList_(simpleRangeEventList)
{
	this->payoffDateInfo_ = payoffDateInfo;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void SimpleRangeRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	
	for ( Size i=0 ; i < simpleRangeEventList_.size() ; i++ )
	{
		simpleRangeEventList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->rangeNum_ = simpleRangeEventList_.size();
	this->assetNum_ = pathGenFactory->numAssets();

	Date today = Settings::instance().evaluationDate();
	
	DayCounter dayCounter = Actual365Fixed();

	double calculationYearFrac = 0.0;

	if ( today < calculationEndDate_ )
	{
		calculationYearFrac = dayCounter.yearFraction( calculationStartDate_ , calculationEndDate_ );
	}

	//if ( today < calculationStart_ )
	//{
	//	calculationYearFrac = dayCounter.yearFraction( calculationStart_ , calculationEnd_ );
	//}
	//else if ( today > calculationEnd_ )
	//{
	//	calculationYearFrac = 0.0;//dayCounter.yearFraction( today , calculationEnd_ );
	//}
	//else {}

	this->yearFrac_ = calculationYearFrac;

}

bool SimpleRangeRateETI::pastEventOcc()
{
	return true;
}

bool SimpleRangeRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return false;
}

std::vector<Date> SimpleRangeRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;
	DateHelper helper = DateHelper();

	//helper.mergeDates(fixingDates,referenceCalculation_->fixingDates());

	for ( Size i = 0 ; i < simpleRangeEventList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,simpleRangeEventList_[i]->fixingDates());
	}

	return fixingDates;
}

std::vector<Date> SimpleRangeRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	payoffDates.push_back(payoffDateInfo_->fixingDate());

	return payoffDates;
}

Real SimpleRangeRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	for ( Size rng = 0 ; rng < this->rangeNum_ ; rng++ )
	{
		//std::cout << this->simpleRangeEventList_[rng]->payoff(path) << std::endl;
		value += this->simpleRangeEventList_[rng]->payoff(path,endPosition);
	}

	//return value * yearFrac_ * discount_[0];
	//return ( value * yearFrac_ ) * this->payoffDateInfo_->discount();
	return ( value * yearFrac_ ) ;

}


}

