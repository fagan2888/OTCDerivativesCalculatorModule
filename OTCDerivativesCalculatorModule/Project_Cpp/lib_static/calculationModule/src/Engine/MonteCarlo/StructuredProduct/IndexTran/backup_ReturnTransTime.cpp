#include "ReturnTransTime.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>

namespace QuantLib {
	
ReturnTransTime::ReturnTransTime(const boost::shared_ptr<Index>& baseIndex,
								 const std::string& symbolName,
								 const boost::shared_ptr<EventFunction>& domainSet)
: IndexTransBase(symbolName), baseIndex_(baseIndex) 
{
	//baseIndexNum_ = PathInformation::instance().getIndexPosition(baseIndex);
	symbolValuesPtr_ = IndexSymbolManager::instance().setSymbol(symbolName);
	
	timeInformationSetFlag_ = false;

	numerDateFlag_ = false;
	numerSymbolFlag_ = false;
	numerConstFlag_ = false;

	denumerDateFlag_ = false;
	denumerSymbolFlag_ = false;
	denumerConstFlag_ = false;

	numerConstValue_ = 0 ;
	denumerConstValue_ = 0 ;

	setFlag_ = false;

}

void ReturnTransTime::setNumerPtr(Integer fixingDays)
{
	numerFixingDays_ = fixingDays;
	numerDateFlag_ = true;
}

void ReturnTransTime::setNumerPtr(const std::string& numerSymbol)
{
	numerSymbol_ = numerSymbol;
	numerSymbolFlag_ = true;
}

void ReturnTransTime::setNumerPtr(Real numerValue)
{
	numerConstValue_ = numerValue;
	numerConstFlag_ = true;
}

void ReturnTransTime::setDenumerPtr(Integer fixingDays)
{
	denumerFixingDays_ = fixingDays;
	denumerDateFlag_ = true;
}

void ReturnTransTime::setDenumerPtr(const std::string& denumerSymbol)
{
	denumerSymbol_ = denumerSymbol;
	denumerSymbolFlag_ = true;
}

void ReturnTransTime::setDenumerPtr(Real denumerValue)
{
	denumerConstValue_ = denumerValue;
	denumerConstFlag_ = true;
}

void ReturnTransTime::setTimeInformation(const std::vector<Date>& eventDates)
{
	//미래일 사용 방지 코드 추가 해야함 2013-02-18

	Calendar calendar = PathInformation::instance().getCalendar();

	QL_REQUIRE(numerDateFlag_ || numerSymbolFlag_ || numerConstFlag_ , "numer information is not set");
	QL_REQUIRE(denumerDateFlag_ || denumerSymbolFlag_ || denumerConstFlag_ , "denumer information is not set");

	QL_REQUIRE((numerDateFlag_ + numerSymbolFlag_ + numerConstFlag_) < 2 , "numer information is too many set");
	QL_REQUIRE((denumerDateFlag_ + denumerSymbolFlag_ + denumerConstFlag_) < 2 , "denumer information is too many set");

	Size eventDatesSize = eventDates.size();

	numerPtr_.resize(eventDatesSize);
	denumerPtr_.resize(eventDatesSize);
	numerFixedValue_.resize(eventDatesSize);
	denumerFixedValue_.resize(eventDatesSize);

	const std::string& name = this->baseIndex_->name();
	const TimeSeries<Real>& series = IndexManager::instance().getHistory(name);
	
	const Date& today = Settings::instance().evaluationDate();

	for(Size i=0 ; i < eventDatesSize ; ++i)
	{

		//numer Setting -----------------------------------------------------------
		if(numerDateFlag_){

			const Date& numerRefFixingDate = calendar.advance(eventDates[i],numerFixingDays_,Days);

			if( numerRefFixingDate < today )
			{
				numerPtr_[i] = &numerFixedValue_[i];
				numerFixedValue_[i] = series[numerRefFixingDate];
			}else
			{
				indexFixingDates_.push_back(numerRefFixingDate);
				PathInformation::instance().addIndexFixingDate(numerRefFixingDate);
				numerPtr_[i] = PathInformation::instance().getPositionPtr(name, numerRefFixingDate ); //분자	
			}

		}

		if(numerConstFlag_)
			numerPtr_[i] = &numerConstValue_;

		if(numerSymbolFlag_)
			numerPtr_[i] = IndexSymbolManager::instance().setSymbol(numerSymbol_);

		//denumer Setting -----------------------------------------------------------
		if(denumerDateFlag_){
			
			const Date& denumerRefFixingDate = calendar.advance(eventDates[i],denumerFixingDays_,Days);

			if( denumerRefFixingDate  < today )
			{
				denumerPtr_[i] = &denumerFixedValue_[i];
				denumerFixedValue_[i] = series[denumerRefFixingDate];
			}else
			{
				indexFixingDates_.push_back(denumerRefFixingDate);
				PathInformation::instance().addIndexFixingDate(denumerRefFixingDate);
				denumerPtr_[i] = PathInformation::instance().getPositionPtr(name, denumerRefFixingDate );
			}
		}
		
		if(denumerConstFlag_)
			denumerPtr_[i] = &denumerConstValue_;

		if(denumerSymbolFlag_)
			denumerPtr_[i] = IndexSymbolManager::instance().setSymbol(denumerSymbol_);

	}

	setFlag_ = true;
}

void ReturnTransTime::initialize()
{
				
}

Size ReturnTransTime::size()
{
	return 1;
}

inline void ReturnTransTime::calValue()
{
	QL_FAIL("calValue() method called, this is timeType Class!");
	//*symbolValuesPtr_ = domainSet_->value( (*numerPtr_)/(*denumerPtr_) );
}

inline void ReturnTransTime::calValue(int refDatePosition)
{
	*symbolValuesPtr_ = *numerPtr_[refDatePosition] / *denumerPtr_[refDatePosition];
}

std::vector<Date> ReturnTransTime::indexFixingDates(const std::vector<Date>& remainEventDates)
{
	Calendar calendar = PathInformation::instance().getCalendar();
	const Date& today = Settings::instance().evaluationDate();

	for(Size i = 0 ; i < remainEventDates.size() ; ++i){

		const Date& adjuctedNumerFixingDate = calendar.advance(remainEventDates[i],numerFixingDays_,Days);
		const Date& adjuctedDenumerFixingDate = calendar.advance(remainEventDates[i],denumerFixingDays_,Days);
		
		if(today < adjuctedNumerFixingDate)
			this->indexFixingDates_.push_back(adjuctedNumerFixingDate);

		if(today < adjuctedDenumerFixingDate)
			this->indexFixingDates_.push_back(adjuctedDenumerFixingDate);

	}

	return this->indexFixingDates_;
	
}

}

