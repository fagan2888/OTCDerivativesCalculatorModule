#include "dateList.hpp"

namespace QuantLib {

DateList::DateList(const std::vector<Date>& dateList)
:dateList_(dateList)
{

}

void DateList::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

	Date today = Settings::instance().evaluationDate();
	
	DayCounter dayCounter = Actual365Fixed();

	Size dateNum_ = this->dateList_.size();

	// fixingDates
	this->fixingDatePositions_ = std::valarray<Size>(dateNum_);

	for ( Size i=0 ; i<dateNum_ ; i++ )
	{
		Real fixingTime = dayCounter.yearFraction( today , this->dateList_[i] );
		Size datePosition = timeGrid.closestIndex( fixingTime );

		this->fixingDatePositions_[i] = datePosition;
	}

	// pastFixingDates // 그냥 전체로 함.
}

std::valarray<Size> DateList::fixingDatePositions()
{
	return this->fixingDatePositions_;
}

std::valarray<Size> DateList::pastFixingDatePositions()
{
	return this->pastFixingDatePositions_;
}

std::vector<Date> DateList::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i=0 ; i<dateList_.size() ; i++)
	{
		fixingDates.push_back(dateList_[i]);
	}

	return fixingDates;
}


}

