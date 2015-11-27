#include "normalEC.hpp"

namespace QuantLib {

NormalEC::NormalEC(const std::string& thisEventSymbolName,
				const boost::shared_ptr<EventIndexTransformation>& eit,
				const boost::shared_ptr<FunctionEvents>& fe,
				const boost::shared_ptr<PayoffBase>& pb,
				const boost::shared_ptr<SubEvents>& subEvents,
				const boost::shared_ptr<JointEvent>& functionAndSubEvent,
				const Date& eventDate)
: EventCheckBase(thisEventSymbolName, eit, fe, pb, subEvents, functionAndSubEvent ) , eventDate_(eventDate)
{
	bindingFlag_= false;
	isHistoryCalFlag_ = false;
	eventOccHistoryFlag_ = false;

	const Date& today = Settings::instance().evaluationDate();

	// expired 되면 isCalFlag 를 true로 fix함.
	isExpired_ = false;

	if(eventDate_ < today)
		isExpired_ = true;

}

void NormalEC::historyCalculate()
{
	if(isExpired_)
	{
		this->calculate();
		eventOccHistoryFlag_ = eventOccFlag_;
		isHistoryCalFlag_ = true;
	}

	isHistoryCalFlag_ = true;
}

void NormalEC::variableBind()
{
	eitPtr_->variableBind();
	fePtr_->variableBind();
	//pbPtr_->variableBind();
	
	//이거 생각해봐야함, baseClass로 올릴지 말지. 2013-02-25
	this->thisPayoffVariableValue_ = IndexSymbolManager::instance().getSymbol(pbPtr_->symbolName());

}

void NormalEC::variablePtrBind()
{
	eitPtr_->variablePtrBind();
	fePtr_->variablePtrBind();
	pbPtr_->variablePtrBind();
}

void NormalEC::validFixingDates()
{
	std::vector<Date> eventDates; //time style때문에 이렇게 감.

	eventDates.push_back(this->eventDate_);

	//const Date& today = Settings::instance().evaluationDate();

	eitPtr_->validFixingDates(eventDates);
	fePtr_->validFixingDates(eventDates);

	this->thisPayoffVariableValue_->validFixingDates(eventDates);
	
	//QL_REQUIRE( this->lastFixingDate_ <= eventDate , "lastFixingDate is later than eventDate");

	this->bindingFlag_ = true;
}

bool NormalEC::bindingFlag()
{
	return this->bindingFlag_;
}

void NormalEC::calculate(){
				
	if(!isCalFlag_){
		//test time
		eitPtr_->calculate();

		//eventFunctionOccFlags_[0] = fePtr_->eventOcc();
		functionEventJointOccFlag_ = fePtr_->eventOcc();

		if(functionEventJointOccFlag_){
			
			subEventJointOccFlag_ = subEventsPtr_->eventOcc();

			if(functionAndSubEventPtr_->checkJoint(functionEventJointOccFlag_,subEventJointOccFlag_)){
				eventOccFlag_ = true;
				pbPtr_->calculate();
			}
		}
	}
	
	isCalFlag_ = true;
}

bool NormalEC::eventOcc()
{
	if(!isCalFlag_)
	{
		this->calculate();
	}

	return eventOccFlag_;
}

bool NormalEC::eventHistoryOcc()
{
	return eventOccHistoryFlag_;
}

void NormalEC::reset()
{
	//history는 죄다 계산 됬다고 가정함.
	QL_REQUIRE(isHistoryCalFlag_ , "need history calculation prior");

	if(!isExpired_){
		this->isCalFlag_ = false;
		this->payoffValue_ = 0.0;
		eventOccFlag_ = eventOccHistoryFlag_;
	}

} 

std::vector<Date> NormalEC::indexFixingDates()
{
	return this->eitPtr_->indexFixingDates();
}

std::vector<Date> NormalEC::payoffDates()
{
	return this->pbPtr_->payoffDates();
}

Real NormalEC::payoff()
{
	return *payoffValuePtr_;
}

}


