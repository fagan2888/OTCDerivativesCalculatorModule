#include "SimpleTimeVariableValue.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathInformation.hpp>

namespace QuantLib {

SimpleTimeVariableValue::SimpleTimeVariableValue(const boost::shared_ptr<Index>& baseIndex,
											 	 Integer fixingDays,
												 const std::string& symbolName )
: VariableValue(), baseIndex_(baseIndex), fixingDays_(fixingDays)
{
	this->variableBindingFlag_ = true;
	this->eventDatesInitializeFlag_ = false;
}
void SimpleTimeVariableValue::initialize(const std::vector<Date>& eventDates)
{
	//QL_REQUIRE(this->initializeFlag_ == false,"twice initialized");

	timePositionNum_ = eventDates.size();
	this->eventDates_ = eventDates;
	this->eventDatesInitializeFlag_ = true;
	
	lastFixingDate_ = eventDates.back();

	timePtr_ = std::valarray<double*>(timePositionNum_);
	timeValue_ = std::valarray<double>(timePositionNum_);

	this->initializeFlag_ = true;

}

void SimpleTimeVariableValue::variableBind(const std::vector<std::string>& circulationCheckString)
{

}

void SimpleTimeVariableValue::variablePtrBind()
{
	if(!this->ptrBindingFlag_)
	{
		QL_REQUIRE(eventDatesInitializeFlag_,"eventDatesInitializeFlag must be set prior");

		const Date& today = Settings::instance().evaluationDate();

		const std::string& name = this->baseIndex_->name();

		const TimeSeries<Real>& series = IndexManager::instance().getHistory(name);
		// 이거 나중에 해야함. QL_REQUIRE(series.size() > 0,"history is empty. name : " << name);
	
		Calendar calendar = PathInformation::instance().getCalendar();

		for(Size i = 0 ; i < timePositionNum_ ; ++i){
			if( eventDates_[i] < today )
			{
				const Date& fixing = calendar.advance(eventDates_[i],fixingDays_,Days);
				timeValue_[i] = series[fixing]; 
				this->timePtr_[i] = &(this->timeValue_[i]);
			}
			else
			{
				//timeValue_[i] = 0.0; 
				this->timePtr_[i] = PathInformation::instance().getPositionPtr(name,eventDates_[i]); //분자	
			}
		}
	
		value_ = 0.0;
		this->valuePtr_ = &(this->value_);

		this->ptrBindingFlag_ = true;
	}
}

void SimpleTimeVariableValue::calculate()
{
	 QL_FAIL("do not this for not time stype eventCheck");
}

void SimpleTimeVariableValue::calculate(Size timePosition)
{
	 value_ = *(timePtr_[timePosition]);
}


Date SimpleTimeVariableValue::calculateLastIndexFixing()
{
	return this->lastFixingDate_;
}

std::vector<Date> SimpleTimeVariableValue::indexFixingDates()
{
	std::vector<Date> dates;
	
	Calendar calendar = PathInformation::instance().getCalendar();

	for(Size i = 0 ; i < timePositionNum_ ; ++i)
	{
		const Date& fixing = calendar.advance(eventDates_[i],fixingDays_,Days);
		dates.push_back(fixing);
	}

	return dates;
}

void SimpleTimeVariableValue::validFixingDates(const std::vector<Date>& eventDates)
{
	const Date& eventDate = eventDates.front();
	const Date& lastDate = this->calculateLastIndexFixing();

	QL_REQUIRE(eventDate >= lastDate , "fixingDate is earlier than eventDate." << " lastFixingDate : " << lastDate << ", eventDate : " << eventDate);
}

}