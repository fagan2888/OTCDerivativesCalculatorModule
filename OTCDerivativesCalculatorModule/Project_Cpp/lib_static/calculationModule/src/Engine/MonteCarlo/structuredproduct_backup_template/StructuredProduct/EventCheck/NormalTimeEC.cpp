#include <src/Engine/MonteCarlo/StructuredProduct/EventCheck/NormalTimeEC.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

EV_TEMPLATE
NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::NormalTimeEC(
				   std::string thisEventSymbolName,
				   const std::vector<std::string>& baseIndex,
				   const ITM& itM,
				   const FEM& feM,
				   const PM& pm,
				   const FSEvent& functionAndSubEvent,
				   const TEvent& timeEvent,
				   std::vector<Date> eventDates) //2개들어왔을때의 구분. //daily로 setting인 경우 계산 기준일자 사용함.
				   //boost::shared_ptr<EventCheckBase>& subEventchecks = boost::shared_ptr<EventCheckBase>())
		: thisEventSymbolName_(thisEventSymbolName), baseIndex_(baseIndex), eventDates_(eventDates),
		  itM_(itM), feM_(feMs), pm_(pm), 
		  //subJointEvent_(subJointEvent), 
		  functionAndSubEvent_(functionAndSubEvent),timeEvent_(timeEvent_), subEventchecks_(subEventchecks)
{
	isCalFlag_ = false;

	eventDatesPositionNum_ = eventDates.size();
	eventDatesPosition_.resize(eventDatesPositionNum_);

	eventFunctionMNums_ = eventFunctionMs_.size();
	eventFunctionOccFlags_.resize(eventFunctionMNums_);
	
	subEventNum_ = subEventchecks_.size();
	subEventOccFlags_.resize(subEventNum_);

	//baseIndexValue_.resize(baseIndex_.size());
	indexM_EventSymbolValue_.resize(itM_.size());

	for(Size i=0;i<eventFunctionSymbols_.size();++i){
		eventFunctionSymbols_.push_back(eventFunctionMs_[i]->functionSymbol());
	}

	for(Size i=0;i<itM_.size();++i){
		
		indexM_EventSymbolValue_[i] = IndexSymbolManager::instance().setSymbol(itM_[i]->getSymbol());
		thisStoredSymbolIndex_.push_back(itM_[i]->getSymbol());
		parser_.DefineVar(itM_[i]->getSymbol(),indexM_EventSymbolValue_[i]);
		payoffManager_->defineVar(itM_[i]->getSymbol());
	}
	
	for(Size i=0;i<subEventNum_;++i){
		thisStoredSymbolEvent_.push_back(subEventchecks_[i]->thisCountSymbol()); //CountSymbol 이네?
	}
}

EV_TEMPLATE
void NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::calculate(){
		
	if(!isCalFlag_){
		for(Size k=0;k<eventDatesPositionNum_;k++){
			this->setBaseIndexValue(multiPath,eventDatesPosition_[k]);
				
			itm_.calValue(multiPath,eventDatesPosition_[k]);
				
			eventFunctionOccFlags_[z] = functionEventM_.eventOcc();
			functionEventJointOccFlag_ = this->functionEventsJoint_Cal();

			funcAndSubJointEventOccFlag_[eventDatesPosition_[k]] = this->funcAndSubJointEvent_Cal(); //subEventFlag_를 사용하여 계산함.
			
			if(funcAndSubJointEventOccFlag_[eventDatesPosition_[k]] ){
				//payoffIndexLocation_ = payoffManager_->payoffDatesPosition(k);
				//payoffIndexLocation_ = eventDatesPosition_[k];
				payoffAutoCallLocation_ = eventDatesPosition_[k];
				break; //그냥 빠지면 전체가 계산이 안된 상태에서 isCalFlag_ 에 true가 박힐 수 있음. 2012-11-29
			}

			//timeEventJointOccFlag_ = this->timeEventJoint_Cal(startDatePosition_,refDatePosition);
			timeEventJointOccFlag_ = this->timeEventJoint_Cal(0,0);

			if(timeEventJointOccFlag_){

			}
		}
	}


	isCalFlag_=true;
			
}


EV_TEMPLATE void NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::
	gridInitialize(const TimeGrid& timeGrid ,const Calendar& calendar)
	{
	
		TimeGrid timeGrid_ = timeGrid;
		Calendar calendar_ = calendar;
	
		Date today = Settings::instance().evaluationDate();
		Date issueDate = Date(27,Sep,2012);

		// 이거만 여기서 initialize함 그리드 필요.
		funcAndSubJointEventOccFlag_.resize(timeGrid_.size());
	
		//이건 252일 기준으로 해야함 프허
			for(Size i=0;i<eventDates_.size();++i){
				eventDatesPosition_[i] = calendar.businessDaysBetween(issueDate,eventDates_[i],true,false);
				//timeGrid.index(dayCounter.yearFraction(today,eventDates_[i])); 
			}
	
		payoffDatesPosition_ = pm_.payoffDatesPosition();
		pm_.initialize(timeGrid , calendar);

	}

EV_TEMPLATE void NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::
	addSymbolEvent(const std::string& symbolName)
	{
		thisStoredSymbolEvent_.push_back(symbolName);
	}

//일괄적으로 setting함
EV_TEMPLATE void NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::
	defineConst(const std::string varStr,Real constValue){
	
	//parser_.DefineConst(varStr,constValue);
	
	itm_.defineConst(varStr,constValue);

	for(Size i=0 ;i<subEventchecks_.size(); ++i){
		subEventchecks_[i]->defineConst(varStr,constValue);
	}
	
	pm_.defineConst(varStr,constValue);
}
//일괄적으로 setting함
EV_TEMPLATE void NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::
	defineBaseIndex(const std::string varStr){
	
	//baseIndex 주소를 setting
	baseIndexValue_.push_back(IndexSymbolManager::instance().setSymbol(varStr));

	
		itm_[i]->defineBaseIndex(varStr);
	
	for(Size i=0 ;i<subEventchecks_.size(); ++i){
		subEventchecks_[i]->defineBaseIndex(varStr);
	}
	pm_.defineBaseIndex(varStr);

}


EV_TEMPLATE inline bool NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::
	timeEventJoint_Cal(Size startDatePosition,Size refDatePosition){
	bool tf;
	
	tf = timeJointEvent_->checkJoint(funcAndSubJointEventOccFlag_,startDatePosition,refDatePosition);
	timeEventJointOccCount_ = timeJointEvent_->getCount();

	return tf;
}

EV_TEMPLATE void NormalTimeEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::
	reset(){
	bool tf = false;
		this->isCalFlag_=tf;
		this->payoffValue_ = 0.0;

			//eventOcc_=past;
			//startIndex_=0; //이건 과거 상관없이 0으로 들어감.
} 

//매번 과거데이터를 이용하여 Set하는 경우 사용함.

}



//
//
//
////이건 252일 기준으로 해야함 프허
//QL_REQUIRE(eventDates_.size() == 2 , "size of eventDates must be 2 in daily case ");
//		
//		//Size initialNum = calendar.businessDaysBetween(issueDate,eventDates_[0],true,false);
//		Size initialNum = 0;
//		startDatePosition_ = initialNum;
//		Size lastNum = calendar.businessDaysBetween(issueDate,eventDates_[1],true,false);
//		eventDatesPosition_.resize(lastNum);
//		eventDatesPositionNum_ = lastNum;
//		for(Size i=0;i<lastNum;++i){
//			eventDatesPosition_[i] = i;
//		}
//
//
//