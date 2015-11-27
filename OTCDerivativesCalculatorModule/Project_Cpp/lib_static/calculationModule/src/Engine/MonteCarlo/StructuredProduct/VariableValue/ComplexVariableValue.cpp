#include "ComplexVariableValue.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathInformation.hpp>

namespace QuantLib {

ComplexVariableValue::ComplexVariableValue(const std::string& symbolName)
: VariableValue()
{
	QL_REQUIRE(symbolName != "" , "compelx symbolName can't be null");
	this->symbolName_ = symbolName;
	//IndexSymbolManager::instance().setVariableValue(symbolName,this);
	this->variableBindingFlag_ = false;
}

ComplexVariableValue::ComplexVariableValue(boost::shared_ptr<IndexTransBase> itb,
	  									 const std::string& symbolName,
										 const std::vector<boost::shared_ptr<VariableValue>>& addedVariableValues)
: VariableValue(), itb_(itb), addedVariableValues_(addedVariableValues)
{
	
	QL_REQUIRE(symbolName != "" , "compelx symbolName can't be null");
	this->setSymbolManagerFlag_ = true;

	this->symbolName_ = symbolName;

	this->variableBindingFlag_ = true;

	for(Size i = 0 ; i < addedVariableValues_.size() ; ++i)
	{
		bool tf = addedVariableValues_[i]->variableBindingFlag();
		if(!tf)
		{
			this->variableBindingFlag_ = false;
			break;
		}
	}
}

void ComplexVariableValue::registManager()
{
	if(this->setSymbolManagerFlag_)
		IndexSymbolManager::instance().setSymbol(symbolName_,shared_from_this());
}

//void ComplexVariableValue::addVariableValue(const boost::shared_ptr<VariableValue>& variableValue)
//{
//	this->addedVariableValues_.push_back(variableValue);
//}
void ComplexVariableValue::initialize(const std::vector<Date>& eventDates)
{

	eventDates_ = eventDates;

	for(Size i = 0 ; i < addedVariableValues_.size() ; ++i)
	{
		addedVariableValues_[i]->initialize(eventDates);
	}	
}
//여기서 timeStyle 이 중복되는 가도 검사함.
void ComplexVariableValue::variableBind(const std::vector<std::string>& circulationCheckString)
{
	//QL_REQUIRE(timeTypeStr == this->timeTypeCheckStr_ , "time style event must be same. this Variable time type in : " << this->timeTypeCheckStr_ << " but used Variable event time type : "<< timeTypeStr );

	std::vector<std::string> newCirculationCheckString = circulationCheckString;

	for(Size i = 0 ; i < circulationCheckString.size() ; ++i)
	{
		if(circulationCheckString[i] == this->symbolName_)
			QL_FAIL("circulation Symbol dectected. circulated symbolName : " << this->symbolName_ );
	}

	newCirculationCheckString.push_back(this->symbolName_);

	if(!(this->variableBindingFlag_))
	{
		for(Size i = 0 ; i < addedVariableValues_.size() ; ++i)
		{
			const std::string& symbolName = addedVariableValues_[i]->symbolName();
			if(symbolName != "No_Symbol"){
				addedVariableValues_[i] = IndexSymbolManager::instance().getSymbol(symbolName,newCirculationCheckString);
			}
		}	
	}

	this->variableBindingFlag_ = true;

	this->itb_->variableBind();
	
}

void ComplexVariableValue::variablePtrBind()
{
	if(!this->ptrBindingFlag_){
		value_ = 0.0;
		this->valuePtr_ = &(this->value_);

		for(Size i = 0 ; i < addedVariableValues_.size() ; ++i)
		{
			addedVariableValues_[i]->variablePtrBind();
		}

		this->ptrBindingFlag_ = true;
	}

	itb_->variablePtrBind();
}


void ComplexVariableValue::calculate(Size timePosition)
{

	for(Size i=0 ; i<addedVariableValues_.size() ; ++i)
	{
		addedVariableValues_[i]->calculate(timePosition);
	}

	this->itb_->calculate();
}


void ComplexVariableValue::calculate()
{

	for(Size i=0 ; i<addedVariableValues_.size() ; ++i)
	{
		addedVariableValues_[i]->calculate();
	}

	this->itb_->calculate();
}

//time으로 들어왔을때를 대비 하여 eventdates Maximum 값으로 가야대나..? 2013-02-25
//time인경우 맨앞에꺼를 검사하고 simple인경우 마지막꺼를 검사함?
void ComplexVariableValue::validFixingDates(const std::vector<Date>& eventDates)
{
	//QL_REQUIRE(eventDates.size() == 1 , "too many eventDates no date");

	const Date& eventDate = eventDates.front();
	const Date& lastDate = this->calculateLastIndexFixing();

	QL_REQUIRE(eventDate >= lastDate , "fixingDate is earlier than eventDate." << " lastFixingDate : " << lastDate << ", eventDate : " << eventDate);
}

Date ComplexVariableValue::calculateLastIndexFixing()
{
	if(!(this->variableBindingFlag_))
		QL_FAIL("variable is not bind");
		
	for(Size i=0;i<addedVariableValues_.size();++i)
	{
		const Date& roopDate = addedVariableValues_[i]->calculateLastIndexFixing();

		if( lastFixingDate_ < roopDate )
		{
			lastFixingDate_ = roopDate;
		}
	}

	return lastFixingDate_;
	
}

std::vector<Date> ComplexVariableValue::indexFixingDates()
{
	if(!variableBindingFlag_)
		QL_FAIL("variable is not binding");

	std::vector<Date> dates;

	for(Size i = 0 ; i < this->addedVariableValues_.size() ; ++i)
	{
		const std::vector<Date>& fixings = this->addedVariableValues_[i]->indexFixingDates();
		dates.insert( dates.begin() , fixings.begin(),fixings.end() );
	}

	return dates;
}


}