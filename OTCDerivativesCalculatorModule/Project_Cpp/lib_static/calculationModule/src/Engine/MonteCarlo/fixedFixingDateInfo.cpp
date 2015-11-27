#include "fixedFixingDateInfo.hpp"

namespace QuantLib {

FixedFixingDateInfo::FixedFixingDateInfo(const Date& fixingDate,
										 bool autoCallFixing,
										 const Date& autoCallFixingDate)
:FixingDateInfo(autoCallFixing,autoCallFixingDate), fixingDate_(fixingDate)
{
	//this->fixingDatePosition_ = 0;
}

void FixedFixingDateInfo::initialize(const TimeGrid& timeGrid,
									const boost::shared_ptr<YieldTermStructure>& discountCurve,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	Date today = Settings::instance().evaluationDate();
	DayCounter dayCounter = Actual365Fixed();
	
	double fixingTime = dayCounter.yearFraction( today , fixingDate_ );

	this->fixingDatePosition_ = timeGrid.dateIndex(this->fixingDate_);
	this->fixedDiscountValue_ = 1.0;

	if ( fixingTime > 0)
	{
		fixedDiscountValue_ = discountCurve->discount(fixingTime);
	}

	double autoCallFixingTime = dayCounter.yearFraction( today , this->autoCallFixingDate_ );

	this->autoCallDatePosition_ = 9999;

	if ( autoCallFixingTime > 0 )
	{
		this->autoCallDatePosition_ = timeGrid.closestIndex(autoCallFixingTime);
	}

	discountArr_ = std::vector<Real>(timeGrid.size());

	Size startPosition = timeGrid.dateIndex(today);

	for ( Size i = startPosition ; i<timeGrid.size() ; i++)
	{
		//double t = dayCounter.yearFraction( today , timeGrid.dateAt(i) );
		double t = timeGrid[i] - timeGrid.dateTime(today);

		discountArr_[i] = discountCurve->discount(t);
	}

}

Date FixedFixingDateInfo::fixingDate()
{
	return this->fixingDate_;
}

Size FixedFixingDateInfo::fixingDatePosition()
{
	return this->fixingDatePosition_;
}

Real FixedFixingDateInfo::discount()
{
	return fixedDiscountValue_;
}

//{
//	return this->discountArr_[position];
//}
//
//Real FixedFixingDateInfo::discount()
//{
//	return fixedDiscountValue_;
//}

//Real FixedFixingDateInfo::discount()
//{
//	Real value = 0.0;
//
//	//autoCallFlag -> autoCall이 되었을때 어떻게 할건지 정해줌.
//	//false면 autoCall 상관 안하고 나중에 줌
//	//true 이고 autoCallFixingDate_가 정의되지 않으면, call발생한날,
//	//true 이고 autoCallFixingDate_가 정의되면, 정의된날 줌
//
//	//autoCall이 정의 되고 default결정일이 더 나중인경우
//	if ( autoCallFixing_ == true && position < fixingDatePosition_ )
//	{
//		if ( autoCallFixingDate_ == Date() )
//		{
//			value = this->discountArr_[position]; 
//		}else
//		{
//			value = this->discountArr_[this->autoCallDatePosition_];
//		}
//	}else
//	{
//		value = fixedDiscountValue_;
//	}
//
//	return value;
//}

}
