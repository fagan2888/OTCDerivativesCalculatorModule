#include "RateCalculation.hpp"
#include <iostream>

namespace QuantLib {

RateCalculation::RateCalculation(const DayCounter& dayCounter,
								const Date& calculationStartDate,
								const Date& calculationEndDate,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), dayCounter_(dayCounter),
  calculationStartDate_(calculationStartDate), calculationEndDate_(calculationEndDate)
{

}

//Real RateCalculation::yearFracValue(Size position)
//{
//
//}


void RateCalculation::setYearFracValues(const TimeGrid& timeGrid)
{
	couponYearFraction_ = dayCounter_.yearFraction(this->calculationStartDate_,
												   this->calculationEndDate_);

	yearFracValues_ = std::valarray<Real>(timeGrid.size());

	Date today = Settings::instance().evaluationDate();
	
	Size startDatePosition = 0;

	std::cout << calculationStartDate_.serialNumber() << std::endl;
	std::cout << calculationEndDate_.serialNumber() << std::endl;

	if ( today < calculationStartDate_ )
	{
		startDatePosition = timeGrid.dateIndex(calculationStartDate_);
	}

	Size endDatePosition = timeGrid.dateIndex(calculationEndDate_);

	for ( Size i=0 ; i < timeGrid.size() ; i++)
	{
		if ( i <= startDatePosition )
		{
			yearFracValues_[i] = 0.0;

		}else if ( startDatePosition < i && i <= endDatePosition)
		{
			yearFracValues_[i] = dayCounter_.yearFraction(calculationStartDate_,timeGrid.dateAt(i));
		}else
		{
			yearFracValues_[i] = dayCounter_.yearFraction(calculationStartDate_,calculationEndDate_);
		}
	}

}

}