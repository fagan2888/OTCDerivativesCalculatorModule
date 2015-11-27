#include "dailyInterval.hpp"



namespace QuantLib {

DailyInterval::DailyInterval(const Date& observationStartDate,
							const Date& observationEndDate)
:observationStartDate_(observationStartDate), observationEndDate_(observationEndDate)
{

}

void DailyInterval::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

	Date today = Settings::instance().evaluationDate();
	
	DayCounter dayCounter = Actual365Fixed();
	
	//Real obserbationStartTime = 0.0;
	//Real t = dayCounter.yearFraction( today , this->observationStartDate_ );

	//if ( t > 0.0 )
	//{
	//	obserbationStartTime = dayCounter.yearFraction( today , this->observationStartDate_ );
	//}

	//Real obserbationEndTime   = dayCounter.yearFraction( today , this->observationEndDate_ );

	//Size obserbationStartPosition = timeGrid.closestIndex( obserbationStartTime );
	//Size obserbationEndPosition = timeGrid.closestIndex( obserbationEndTime );
	//Size todayPosition = timeGrid.dateIndex(today);

	Size obserbationStartPosition = timeGrid.dateIndex( this->observationStartDate_);
	Size obserbationEndPosition = timeGrid.dateIndex( this->observationEndDate_ );

	Size intervalNum = obserbationEndPosition - obserbationStartPosition;

	// fixingDates // 그냥 전체를 떠 // 느리면 나중에 remainFixing을 구현함.
	this->fixingDatePositions_ = std::valarray<Size>(intervalNum);
	
	for ( Size i=0 ; i<intervalNum; i++ )
	{
		//this->fixingDatePositions_[i] = obserbationStartPosition + i;
		this->fixingDatePositions_[i] = obserbationStartPosition + i;
	}

	//Size pastIntervalNum_ = obserbationStartPosition - todayPosition;

	// pastFixingDates

	//this->pastFixingDatePositions_ = std::valarray<Size>(this->pastIntervalNum_);

	//for ( Size i=0 ; i<this->pastIntervalNum_ ; i++ )
	//{
	//	//this->fixingDatePositions_[i] = obserbationStartPosition + i;
	//	//this->fixingDatePositions_[i] = todayPosition + i;
	//	this->pastFixingDatePositions_[i] = i;
	//}

	//Size startIndex = 0;
	//Size endIndex = 0;

	//if ( this->observationEndDate_ < today )
	//{
	//	if ( today < this->observationStartDate_ )
	//	{
	//		startIndex = timeGrid.dateIndex(this->observationStartDate_);
	//	}

	//	endIndex = timeGrid.dateIndex(this->observationEndDate_);
	//}

}

std::valarray<Size> DailyInterval::fixingDatePositions()
{
	return this->fixingDatePositions_;
}

std::valarray<Size> DailyInterval::pastFixingDatePositions()
{
	return this->pastFixingDatePositions_;
}

std::vector<Date> DailyInterval::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	//Calendar calendar = NullCalendar();
	Calendar calendar = SouthKorea();
	Period oneDay = Period(1,Days);

	Date roopDate = observationStartDate_;

	while ( roopDate <= observationEndDate_ )
	{
		fixingDates.push_back(roopDate);
		roopDate = calendar.advance(roopDate,oneDay);
	}

	return fixingDates;
}

}

