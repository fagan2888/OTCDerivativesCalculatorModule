#include "EventCheckBase.hpp"
#include <ql/settings.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathinformation.hpp>

namespace QuantLib {

EventCheckBase::EventCheckBase(const std::string& thisEventSymbolName,
				   //const std::vector<std::string>& baseIndex,
				   const boost::shared_ptr<EventIndexTransformation>& eit,
				   const boost::shared_ptr<FunctionEvents>& fe,
				   const boost::shared_ptr<PayoffBase>& pb,
				   const boost::shared_ptr<SubEvents>& subEvents,
				   const boost::shared_ptr<JointEvent>& functionAndSubEvent) //2개들어왔을때의 구분. //daily로 setting인 경우 계산 기준일자 사용함.
		: thisEventSymbolName_(thisEventSymbolName),
		  eit_(eit), fe_(fe), pb_(pb), subEvents_(subEvents), functionAndSubEvent_(functionAndSubEvent)
{
	isCalFlag_ = false;
	
	subEventNum_ = subEvents_->eventCheckNum();

	// boost_ptr into stand ptr
	eitPtr_ = eit_.get();
	fePtr_ = fe_.get();
	pbPtr_ = pb_.get();
	subEventsPtr_ = subEvents_.get();
	functionAndSubEventPtr_ = functionAndSubEvent.get();

}
bool EventCheckBase::isExpired(){
	return false;
}

void EventCheckBase::Initialize()
{
}

}