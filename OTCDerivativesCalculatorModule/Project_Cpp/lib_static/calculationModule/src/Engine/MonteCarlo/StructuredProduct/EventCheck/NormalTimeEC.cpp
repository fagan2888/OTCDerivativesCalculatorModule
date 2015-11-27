#include "NormalTimeEC.hpp"
#include <ql/settings.hpp>

namespace QuantLib {

NormalTimeEC::NormalTimeEC(const std::string& thisEventSymbolName,
						   const boost::shared_ptr<EventIndexTransformation>& eit,
						   const boost::shared_ptr<FunctionEvents>& fe,
						   const boost::shared_ptr<PayoffBase>& pb,
						   const boost::shared_ptr<JointEvent>& functionAndSubEvent,
						   const boost::shared_ptr<JointTimeEvent>& timeEvent,
						   DateIntervalMaker eventDates)
: EventCheckBase(thisEventSymbolName, eit, fe, pb, boost::shared_ptr<SubEvents>(new SubEvents()), functionAndSubEvent) , eventDates_(eventDates)
{
	this->ishistoryCalFlag_ = false;
	this->bindingFlag_ = false;
	this->eventOccHistoryFlag_ = false;
	this->isExpired_ = false;

	const std::vector<Date>& skippedDates = this->eventDates_.skippedDates();

	const std::vector<Date>& historyDates = this->eventDates_.historyDates();

	QL_REQUIRE(skippedDates.size() > 1,"eventDates must larger than 2" << skippedDates.size() );

	//indexFixingDate_.push_back(eitPtr_->indexFixingDates());
	
	this->timeEventPtr_ = timeEvent.get();

	this->skippedEventDatesNum_ = skippedDates.size();

	this->historyNum_ = historyDates.size();
	
	const Date& today = Settings::instance().evaluationDate();
	const Date& lastEventDate = skippedDates.back();

	if(lastEventDate < today)
		isExpired_ = true;


}
void NormalTimeEC::variableBind()
{

	eitPtr_->variableBind();

	const std::vector<Date>& skippedDates = this->eventDates_.skippedDates();
	eitPtr_->initialize(skippedDates);

	//이거 생각해봐야함, 공통으로 뺄지 말지. 2013-02-25
	//timeStyle에서는 페이오프 빼자. 2013-03-04
	//this->thisPayoffVariableValue_ = IndexSymbolManager::instance().getSymbol(pbPtr_->symbolName());

	fePtr_->variableBind();
	//pbPtr_->variableBind();

}

void NormalTimeEC::variablePtrBind()
{
	eitPtr_->variablePtrBind();
	fePtr_->variablePtrBind();
	pbPtr_->variablePtrBind();
}

void NormalTimeEC::validFixingDates()
{
	const std::vector<Date>& skippedDates = this->eventDates_.skippedDates();

	eitPtr_->validFixingDates(skippedDates);

	this->bindingFlag_ = true;
}

void NormalTimeEC::historyCalculate()
{
	for(Size k = 0 ; k < this->historyNum_ ; ++k)
	{
		this->eitPtr_->calculate(k);

		if(fePtr_->eventOcc())
			this->timeEventPtr_->addTF();

		if(timeEventPtr_->eventOcc())
			this->eventOccHistoryFlag_ = true;
	}

	this->timeEventPtr_->reset();

	this->ishistoryCalFlag_ = true;

	//history 계산이 끝나면
	// timeStyle Variable을 다른데서 참조 할 수 없도록 해야함. //  
	// 이 논리는 그냥 c#에서 symbol을 사용할수 없도록함.
}

void NormalTimeEC::calculate()
{
	if(!isCalFlag_)
	{
		for(Size k = historyNum_ ; k < skippedEventDatesNum_ ; k++)
		{
			eitPtr_->calculate(k);

			if(fePtr_->eventOcc())
				timeEventPtr_->addTF();

			if(timeEventPtr_->eventOcc())
				eventOccFlag_ = true;
		}
	}

	isCalFlag_=true;

}

void NormalTimeEC::reset()
{
	timeEventPtr_->reset();
	isCalFlag_ = false;
	eventOccFlag_ = eventOccHistoryFlag_;
} 


bool NormalTimeEC::eventOcc()
{
	return eventOccFlag_;
}

bool NormalTimeEC::eventHistoryOcc()
{
	return this->eventOccHistoryFlag_;
}


//이 함수는 indexFixingDates 가 최종 확정된 후에 불려서 나머지 history랑 pathposition을 확정함.
Real NormalTimeEC::payoff()
{
	return *payoffValuePtr_;
}


bool NormalTimeEC::bindingFlag()
{
	return bindingFlag_;
}


std::vector<Date> NormalTimeEC::indexFixingDates()
{
	const std::vector<Date>& skippedRemainDates = eventDates_.skippedRemainDates();

	return this->eitPtr_->indexFixingDates();
}

std::vector<Date> NormalTimeEC::payoffDates()
{
	return this->pbPtr_->payoffDates();
}


}

