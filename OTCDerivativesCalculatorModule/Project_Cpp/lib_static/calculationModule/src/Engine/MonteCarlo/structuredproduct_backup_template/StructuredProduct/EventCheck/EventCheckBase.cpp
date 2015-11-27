#include <src/Engine/MonteCarlo/StructuredProduct/EventCheck/EventCheckBase.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

EV_TEMPLATE
EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::EventCheckBase(std::string thisEventSymbolName,
				   const std::vector<std::string>& baseIndex,
				   const ITM& itM,
				   const FEM& feM,
				   const PM& pm,
				   const SubEvent& subJointEvent,
				   const FSEvent& functionAndSubEvent,
				   std::vector<Date> eventDates, //2개들어왔을때의 구분. //daily로 setting인 경우 계산 기준일자 사용함.
				   boost::shared_ptr<IEventCheck>& subEventchecks = boost::shared_ptr<IEventCheck>())
		: thisEventSymbolName_(thisEventSymbolName), baseIndex_(baseIndex), eventDates_(eventDates),
		  itM_(itM), feM_(feMs), pm_(pm), subJointEvent_(subJointEvent), 
		  functionAndSubEvent_(functionAndSubEvent), subEventchecks_(subEventchecks)
{
	isCalFlag_ = false;

	eventDatesPositionNum_ = eventDates.size();
	eventDatesPosition_.resize(eventDatesPositionNum_);

	eventFunctionMNums_ = eventFunctionMs_.size();
	eventFunctionOccFlags_.resize(eventFunctionMNums_);
	
	subEventNum_ = subEventchecks_.size();
	subEventOccFlags_.resize(subEventNum_);

}
EV_TEMPLATE
bool EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::isExpired(){
	return false;
}

EV_TEMPLATE
void EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::gridInitialize(const TimeGrid& timeGrid , 
								const Calendar& calendar){
	
	TimeGrid timeGrid_ = timeGrid;
	Calendar calendar_ = calendar;
	
	Date today = Settings::instance().evaluationDate();
	Date issueDate = Date(27,Sep,2012);

	funcAndSubJointEventOccFlag_.resize(timeGrid_.size());
	
	//이건 252일 기준으로 해야함 프허
		for(Size i=0;i<eventDates_.size();++i){
			eventDatesPosition_[i] = calendar.businessDaysBetween(issueDate,eventDates_[i],true,false);
			//timeGrid.index(dayCounter.yearFraction(today,eventDates_[i])); 
		}
	
	payoffDatesPosition_ = pm_.payoffDatesPosition();
	pm_.initialize(timeGrid , calendar);

}

EV_TEMPLATE
void EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::addSymbolEvent(const std::string& symbolName){
	thisStoredSymbolEvent_.push_back(symbolName);
}

//일괄적으로 setting함
EV_TEMPLATE
void EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::defineConst(const std::string varStr,Real constValue){
	
	//parser_.DefineConst(varStr,constValue);
	
	itm_.defineConst(varStr,constValue);

	for(Size i=0 ;i<subEventchecks_.size(); ++i){
		subEventchecks_[i]->defineConst(varStr,constValue);
	}
	
	pm_.defineConst(varStr,constValue);
}

//일괄적으로 setting함
EV_TEMPLATE
void EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::defineBaseIndex(const std::string varStr){
	
	//baseIndex 주소를 setting
	baseIndexValue_.push_back(IndexSymbolManager::instance().setSymbol(varStr));

	
		itm_[i]->defineBaseIndex(varStr);
	
	for(Size i=0 ;i<subEventchecks_.size(); ++i){
		subEventchecks_[i]->defineBaseIndex(varStr);
	}
	pm_.defineBaseIndex(varStr);

}

EV_TEMPLATE
void EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::eventRefSymSet()
{

}

EV_TEMPLATE
Real EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::payoff(){
	calculate();
	return payoffValue_;
}

//eventCalFunction
EV_TEMPLATE
inline bool EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::functionEventsJoint_Cal(){
	bool tf;
	
	tf = functionJointEvent_.checkJoint(eventFunctionOccFlags_);
	functionEventOccCount_ = functionJointEvent_.getCount();

	return tf;
}

EV_TEMPLATE
inline bool EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::SubEventJoint_Cal(){
	bool tf;
	
	tf = subJointEvent_.checkJoint(subEventOccFlags_);
	subEventJointOccCount_ = subJointEvent_.getCount();

	return tf;
}

EV_TEMPLATE
inline bool EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::funcAndSubJointEvent_Cal(){
	bool tf;
	std::vector<bool> functionAndsubFlag;
	functionAndsubFlag.push_back(functionEventJointOccFlag_);
	functionAndsubFlag.push_back(SubEventJointOccFlag_);
	
	tf = functionAndSubEvent_.checkJoint(functionAndsubFlag);
	//functionAndSubEventOccCount_ = functionAndSubEvent_->getCount();

	return tf;
}

EV_TEMPLATE
inline bool EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::timeEventJoint_Cal(Size startDatePosition,Size refDatePosition){
	bool tf;
	
	tf = timeJointEvent_->checkJoint(funcAndSubJointEventOccFlag_,startDatePosition,refDatePosition);
	timeEventJointOccCount_ = timeJointEvent_->getCount();

	return tf;
}

//others
EV_TEMPLATE
Size EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::payoffIndexLocation() const{return pm_->payoffDatesPosition();}


//void EventCheckBase::setBaseIndexValue(const MultiPath& multiPath,int datesPosition){
//	for(Size i=0;i<baseIndex_.size();++i){
//		*baseIndexValue_[i]=multiPath[i][datesPosition];
//	}
//}
EV_TEMPLATE
void EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::reset(){
	bool tf = false;
	this->isCalFlag_=tf;
	this->payoffValue_ = 0.0;

			//eventOcc_=past;
			//startIndex_=0; //이건 과거 상관없이 0으로 들어감.
} 

//매번 과거데이터를 이용하여 Set하는 경우 사용함.

}