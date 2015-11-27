#include "ComplexTimeFunctionVariableValue.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathInformation.hpp>

namespace QuantLib {

ComplexTimeFunctionVariableValue::ComplexTimeFunctionVariableValue(const std::string& symbolName)
: VariableValue()
{
	this->symbolName_ = symbolName;
	//IndexSymbolManager::instance().setVariableValue(symbolName,this);
	this->variableBindingFlag_ = false;
}

ComplexTimeFunctionVariableValue::ComplexTimeFunctionVariableValue(const boost::shared_ptr<IndexTransBase>& itb,
																	 const std::vector<Date>& calDates,
	  																 const std::string& symbolName,
																	 const std::vector<boost::shared_ptr<VariableValue>>& addedVariableValues)
: VariableValue(), itb_(itb), calDates_(calDates), addedVariableValues_(addedVariableValues)
{
	this->symbolName_ = symbolName;
	this->setSymbolManagerFlag_ = true;
	this->variableBindingFlag_ = true;
	this->timePositionNum_ = calDates_.size();

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

void ComplexTimeFunctionVariableValue::registManager()
{
	if(this->setSymbolManagerFlag_)
		IndexSymbolManager::instance().setSymbol(symbolName_,shared_from_this());
}

//void ComplexTimeFunctionVariableValue::addVariableValue(const boost::shared_ptr<VariableValue>& variableValue)
//{
//	this->addedVariableValues_.push_back(variableValue);
//}

//계산에 사용할 놈을 eventDate 로 받아서 헷갈리는듯. 얘는 timestyle이 아니면 사용하지 않음.
void ComplexTimeFunctionVariableValue::initialize(const std::vector<Date>& eventDates)
{
	//QL_REQUIRE(this->initializeFlag_ == false,"twice initialized"); 몇번 불리나 count 함 해봐야겠음.

	eventDates_ = eventDates;

	for(Size i = 0 ; i < addedVariableValues_.size() ; ++i)
	{
		// 얘가 가지고 있는 놈들은 calDates_ 로 initialize 함.
		addedVariableValues_[i]->initialize(calDates_);
	}	

	initializeFlag_ = true;
}

void ComplexTimeFunctionVariableValue::variableBind(const std::vector<std::string>& circulationCheckString)
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

	this->itb_->variableBind();
}

void ComplexTimeFunctionVariableValue::variablePtrBind()
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

void ComplexTimeFunctionVariableValue::calculate()
{
	//history 처리 여부
	for(Size time = 0 ; time < this->timePositionNum_ ; ++time)
	{
		for(Size i=0 ; i<addedVariableValues_.size() ; ++i)
		{
			addedVariableValues_[i]->calculate(time);
		}

		this->itb_->calculate();
	}
}

//time으로 들어왔을때를 대비 하여 eventdates Maximum 값으로 가야대나..? 2013-02-25
//time인경우 맨앞에꺼를 검사하고 simple인경우 마지막꺼를 검사함.
void ComplexTimeFunctionVariableValue::validFixingDates(const std::vector<Date>& eventDates)
{
	const Date& eventDateFront = eventDates.front();

	bool eventDateCheckFlag = false;
	bool eventDateFrontCheckFlag = false;

	//eventDate 가 같은지 검사.
	for(Size i=0;i<addedVariableValues_.size();++i)
	{
		const std::vector<Date>& dates = addedVariableValues_[i]->eventDates();
		const Date& roopDate = addedVariableValues_[i]->calculateLastIndexFixing();

		if(eventDates.size() == dates.size() 
			&& eventDates.front() == dates.front() 
				&& eventDates.back() == dates.back() 
					&& eventDates.size() > 1)
		{
			eventDateCheckFlag = true;
		}
		
		if(  roopDate < eventDateFront )
		{
			eventDateFrontCheckFlag = true;
		}
	}
	//if()
	QL_REQUIRE(eventDateCheckFlag == true || eventDateFrontCheckFlag == true, "validFixingDates error");

}

Date ComplexTimeFunctionVariableValue::calculateLastIndexFixing()
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

std::vector<Date> ComplexTimeFunctionVariableValue::indexFixingDates()
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