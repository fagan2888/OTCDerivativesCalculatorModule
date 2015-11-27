#include "SimpleVariableValue.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathInformation.hpp>

namespace QuantLib {

SimpleVariableValue::SimpleVariableValue(const boost::shared_ptr<Index>& baseIndex,
										 const Date& date,
										 const std::string& symbolName )
: VariableValue(), baseIndex_(baseIndex)
{
	lastFixingDate_ = date;
	this->variableBindingFlag_ = true;
}

SimpleVariableValue::SimpleVariableValue(const boost::shared_ptr<Index>& baseIndex,
						 	 Integer fixingDays,
							 const std::string& symbolName )
: VariableValue()
{
	QL_FAIL("not implemented");
}

void SimpleVariableValue::variablePtrBind()
{
	if(!this->ptrBindingFlag_){

		const Date& today = Settings::instance().evaluationDate();

		const std::string& name = this->baseIndex_->name();

		const TimeSeries<Real>& series = IndexManager::instance().getHistory(name);

		if( lastFixingDate_ < today )
		{
			value_ = series[lastFixingDate_]; 
			this->valuePtr_ = &(this->value_);
		}
		else
		{
			this->valuePtr_ = PathInformation::instance().getPositionPtr(name,this->lastFixingDate_); //분자	
		}
	}
	
	this->ptrBindingFlag_ = true;

}

void SimpleVariableValue::variableBind(const std::vector<std::string>& circulationCheckString)
{
	//할일 없음
}

Date SimpleVariableValue::calculateLastIndexFixing()
{
	return this->lastFixingDate_;
}

std::vector<Date> SimpleVariableValue::indexFixingDates()
{
	std::vector<Date> dates;

	dates.push_back(this->lastFixingDate_);

	return dates;
}

void SimpleVariableValue::validFixingDates(const std::vector<Date>& eventDates)
{
	QL_REQUIRE(eventDates.size() == 1 , "too many eventDates or no date");

	const Date& eventDate = eventDates.back();
	const Date& lastDate = this->calculateLastIndexFixing();

	QL_REQUIRE(eventDate >= lastDate , "fixingDate is earlier than eventDate." << " lastFixingDate : " << lastDate << ", eventDate : " << eventDate);
}

}