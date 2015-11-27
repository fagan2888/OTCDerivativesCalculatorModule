#include "PayoffComplexVariableValue.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathInformation.hpp>

namespace QuantLib {

PayoffComplexVariableValue::PayoffComplexVariableValue(const std::string& symbolName)
: VariableValue()
{
	this->symbolName_ = symbolName;
	//IndexSymbolManager::instance().setVariableValue(symbolName,this);
	this->variableBindingFlag_ = false;
}

PayoffComplexVariableValue::PayoffComplexVariableValue(const boost::shared_ptr<PayoffBase>& pb,
	  									 const std::string& symbolName,
										 const std::vector<boost::shared_ptr<VariableValue>>& addedVariableValues)
: VariableValue(), pb_(pb), addedVariableValues_(addedVariableValues)
{
	this->symbolName_ = symbolName;

	this->setSymbolManagerFlag_ = true;

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

void PayoffComplexVariableValue::registManager()
{
	if(this->setSymbolManagerFlag_)
		IndexSymbolManager::instance().setSymbol(symbolName_,shared_from_this());
}

//void PayoffComplexVariableValue::addVariableValue(const boost::shared_ptr<VariableValue>& variableValue)
//{
//	this->addedVariableValues_.push_back(variableValue);
//}

void PayoffComplexVariableValue::variableBind(const std::vector<std::string>& circulationCheckString)
{
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

	this->pb_->variableBind();
}

void PayoffComplexVariableValue::variablePtrBind()
{
	if(!this->ptrBindingFlag_){
		value_ = 0.0;
		this->valuePtr_ = &(this->value_);
	}

	this->ptrBindingFlag_ = true;

}

void PayoffComplexVariableValue::calculate()
{
	// 여기에 쓰이는 것은 
	for(Size i=0 ; i<addedVariableValues_.size() ; ++i)
	{
		addedVariableValues_[i]->calculate();
	}

	this->pb_->calculate();
	
	//여기 드가나..? 원래 eventcheck에 넣으려고 했음(event가 일어났을때만 할라고)
	this->addSample();
}

void PayoffComplexVariableValue::addSample()
{
	this->sampleAccumulator_.add(value_,1.0);
}

//time으로 들어왔을때를 대비 하여 eventdates Maximum 값으로 가야대나..? 2013-02-25
void PayoffComplexVariableValue::validFixingDates(const std::vector<Date>& eventDates)
{
	QL_REQUIRE(eventDates.size() == 1 , "too many eventDates no date");

	const Date& eventDate = eventDates.back();
	const Date& lastDate = this->calculateLastIndexFixing();

	QL_REQUIRE(eventDate >= lastDate , "fixingDate is earlier than eventDate." << " lastFixingDate : " << lastDate << ", eventDate : " << eventDate);
}

Date PayoffComplexVariableValue::calculateLastIndexFixing()
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

std::vector<Date> PayoffComplexVariableValue::indexFixingDates()
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