#include "ConstVariableValue.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/indexsymbolmanager.hpp>

namespace QuantLib {

// 보통 issueDate에 fix함, 그렇지 않은경우 0 넣어서 함(그냥 const니까..) , 근데 둘 차이가 뭐냐...ㅡ.ㅡ;
ConstVariableValue::ConstVariableValue(Real constValue,
					const std::string& symbolName,
					const Date& date)
: VariableValue()
{
	this->value_ = constValue;
	this->symbolName_ = symbolName;
	this->setSymbolManagerFlag_ = true;
	this->lastFixingDate_ = date;
	this->variableBindingFlag_ = true;
}

ConstVariableValue::ConstVariableValue(Real constValue)
: VariableValue() 
{
	this->lastFixingDate_ = Date();
	this->value_ = constValue;
	this->variableBindingFlag_ = true;
}

ConstVariableValue::ConstVariableValue(Real constValue,const Date& fixingDate)
: VariableValue()
{
	this->lastFixingDate_ = Date();
	this->value_ = constValue;
}

void ConstVariableValue::registManager()
{
	if(this->setSymbolManagerFlag_)
		IndexSymbolManager::instance().setSymbol(symbolName_,shared_from_this());
}

void ConstVariableValue::variablePtrBind()
{
	if(!this->ptrBindingFlag_){
		this->valuePtr_ = &(this->value_);
	}

	this->ptrBindingFlag_ = true;
}

void ConstVariableValue::variableBind(const std::vector<std::string>& circulationCheckString)
{

}

void ConstVariableValue::validFixingDates(const std::vector<Date>& eventDates)
{
	QL_REQUIRE(eventDates.size() < 2 , "too many eventDates");

	const Date& eventDate = eventDates.back();
	const Date& lastDate = this->calculateLastIndexFixing();

	QL_REQUIRE(eventDate >= lastDate , "fixingDate is earlier than eventDate." << " lastFixingDate : " << lastDate << ", eventDate : " << eventDate);
}

Date ConstVariableValue::calculateLastIndexFixing()
{
	return this->lastFixingDate_;
}

std::vector<Date> ConstVariableValue::indexFixingDates()
{
	std::vector<Date> dates;

	dates.push_back(this->lastFixingDate_);

	return dates;
}



}