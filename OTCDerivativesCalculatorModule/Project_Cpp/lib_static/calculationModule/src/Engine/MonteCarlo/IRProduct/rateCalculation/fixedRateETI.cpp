#include "FixedRateETI.hpp"
#include <iostream>

namespace QuantLib {

FixedRateETI::FixedRateETI(const DayCounter& dayCounter,
							Real fixedRate,
							const Date& calculationStartDate,
							const Date& calculationEndDate,
							const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
							bool isExpired,
							const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter,calculationStartDate,calculationEndDate,usingVariableInfoList), fixedRate_(fixedRate), 
  payoffDateInfo_(payoffDateInfo)
{
	this->isExpired_ = isExpired;
	
}

void FixedRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->RateCalculation::setYearFracValues(timeGrid);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	//this->calculationStartPosition_ = timeGrid.dateIndex(this->calculationStartDate_);

	//this->discount_[0] = 0.0;
}

bool FixedRateETI::pastEventOcc()
{
	return true;
}

bool FixedRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
}

Real FixedRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	//yearFraction
	//Real 
	//return fixedRate_ * couponYearFraction_ * payoffDateInfo_->discount();
	return fixedRate_ * couponYearFraction_ ;

}

Real FixedRateETI::autoCallPayoff(const MultiPath& path,Size position)
{
	// 수정요망 autoCallPayoffDate를 받아서 해야함
	//this->fixedRate_ * yearFracValues_[position] * payoffDateInfo_->discount();
	//Real yarFrac = path[0].timeGrid().at(position)
	Real value = 0.0;

	if ( this->calculationStartPosition_ < position )
	{
		//std::cout << yearFracValues_[position] << std::endl;
		//value = this->fixedRate_ * yearFracValues_[position] * payoffDateInfo_->discount();
		value = this->fixedRate_ * yearFracValues_[position];
	}

	return value;
}

Real FixedRateETI::accrualRate(const MultiPath& path,const Date& refDate) const
{
	//Date today = Settings::instance().evaluationDate();

	Real acc = 0.0;

	if ( this->calculationStartDate_ < refDate && refDate <= this->calculationEndDate_ )
	{
		acc = this->fixedRate_ * dayCounter_.yearFraction(this->calculationStartDate_,refDate);
	}

	return acc; 
}

std::vector<Date> FixedRateETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	return fixingDates;
}

std::vector<Date> FixedRateETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(payoffDates,this->payoffDateInfo_->fixingDate());

	return payoffDates;

}

}

