#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>
#include "functionEvents.hpp"
#include <ql/errors.hpp>
#include <valarray>

namespace QuantLib {

FunctionEvents::FunctionEvents(std::valarray<boost::shared_ptr<EventFunctionManager>> eventFunctions,
							   const boost::shared_ptr<JointEvent>& joint)
		: eventFunctionsMBoostPtr_(eventFunctions), joint_(joint)
{
 	
	EfNum_ = eventFunctionsMBoostPtr_.size();
	eventFunctions_.resize(EfNum_);

	for(Size i=0;i<EfNum_;++i){
		eventFunctionsMBoostPtr_[i] = eventFunctions[i];
		eventFunctions_[i] = eventFunctions[i].get();
	}

	jointPtr_ = joint_.get();

}

//불리기전에 baseIndex의 값들이 eventDate의 refDate일때로로 설정이 되어있는지 보아야함?

bool FunctionEvents::eventOcc()
{
	//unsigned char flag;

	std::valarray<bool> tf(EfNum_);
	// #define DEBUG 여기에 확인 코드? baseIndex 세팅

	for(Size i=0;i<EfNum_;++i)
	{
		tf[i] = eventFunctions_[i]->eventOcc();
	}

	return jointPtr_->checkJoint(tf);
}

Size FunctionEvents::eventNum()
{
	return EfNum_;
}

void FunctionEvents::variableBind()
{
	for(Size i=0;i<EfNum_;++i)
	{
		eventFunctionsMBoostPtr_[i]->variableBind();
	}
}

void FunctionEvents::variablePtrBind()
{
	for(Size i=0;i<EfNum_;++i)
	{
		eventFunctionsMBoostPtr_[i]->variablePtrBind();
	}
}


void FunctionEvents::validFixingDates(const std::vector<Date>& eventDates)
{
	for(Size i=0;i<EfNum_;++i)
	{
		eventFunctionsMBoostPtr_[i]->validFixingDates(eventDates);
	}

}

// EventFunctionManager cpp

EventFunctionManager::EventFunctionManager(const std::string& functionSymbol,
										   const std::string& indexSymbol,
										   const boost::shared_ptr<EventFunction>& eventFunction)
		: functionSymbol_(functionSymbol), indexSymbol_(indexSymbol), eventFunctionsBoostPtr_(eventFunction)
{
	eventFunctions_ = eventFunctionsBoostPtr_.get();
}

void EventFunctionManager::variableBind()
{

	if(!IndexSymbolManager::instance().hasSymbol(indexSymbol_))
	{
		QL_FAIL("IndexSymbolManager doesn't have " + indexSymbol_ + "fail in EventFunctionManager Constructor ");
	}

	thisVariableValue_ = IndexSymbolManager::instance().getSymbol(this->indexSymbol_);

}

void EventFunctionManager::variablePtrBind()
{
	indexValuePtr_ = thisVariableValue_->getPtr();
}

void EventFunctionManager::validFixingDates(const std::vector<Date>& eventDates)
{
	this->thisVariableValue_->validFixingDates(eventDates);
}


}