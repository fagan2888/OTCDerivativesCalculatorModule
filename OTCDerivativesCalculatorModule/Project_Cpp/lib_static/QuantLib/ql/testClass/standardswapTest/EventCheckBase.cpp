#include <ql/testClass/standardswapTest/eventCheckBase.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

EventCheckBase::EventCheckBase(std::string thisEventSymbolName,
				   //const std::vector<std::string,QuantLib::Index>& baseIndex,
				   const std::vector<std::string>& baseIndex,
				   bool dailyFlag,
				   std::vector<Date> eventDates, //이벤트 검사일 , indexM_Event 이 검사하게될 날짜들.
				   const std::vector<boost::shared_ptr<IndexTransManager>>& indexM_Event,
				   const std::vector<boost::shared_ptr<EventFunctionManager>>& eventFunctionMs,
				   //boost::shared_ptr<EventFunctionManager> amortizeM,
				   //const Date& payoffDate, //각각의 payoffManager에서 받아야하는가?
				   //const boost::shared_ptr<IndexTransManager>& indexM_Payoff, // payoff를 위한 IndexTransform
				   const boost::shared_ptr<PayoffManager>& payoffManager, //여러개를 받아야 하는가?
				   const boost::shared_ptr<JointEvent>& functionJointEvent,
				   const boost::shared_ptr<JointEvent>& subJointEvent,
				   const boost::shared_ptr<JointEvent>& functionAndSubEvent,
				   const boost::shared_ptr<JointEvent>& timeJointEvent,
				   bool autoCallableFlag ,
				   const std::vector<boost::shared_ptr<EventCheckBase>>& subEventchecks )
		: thisEventSymbolName_(thisEventSymbolName), baseIndex_(baseIndex), dailyFlag_(dailyFlag) ,eventDates_(eventDates),
		  indexM_Event_(indexM_Event), eventFunctionMs_(eventFunctionMs),// amortizeM_(amortizeM),
		  payoffManager_(payoffManager), 
		  functionJointEvent_(functionJointEvent),subJointEvent_(subJointEvent),
		  functionAndSubEvent_(functionAndSubEvent),timeJointEvent_(timeJointEvent),
		  autoCallableFlag_(autoCallableFlag) ,subEventchecks_(subEventchecks)
{
	isCalFlag_ = false;

	//if(payoffManager){
	//	payoffDate_ = payoffManager->payoffDate();
	//}else{
	//	if(eventDates.size() > 1){
	//		payoffDate_ = eventDates.back();
	//	}//최대값. //어차피 페이오프가 있는 곳에서 세팅되어 사용됨.
	//	else{
	//		payoffDate_=Date();
	//	}
	//}//둘다 없는 경우도 있음 ex) KI

	eventDatesPositionNum_ = eventDates.size();

	eventDatesPosition_.resize(eventDatesPositionNum_);

	eventFunctionMNums_ = eventFunctionMs_.size();
	eventFunctionOccFlags_.resize(eventFunctionMNums_);
	
	subEventNum_ = subEventchecks_.size();
	subEventOccFlags_.resize(subEventNum_);

	//baseIndexValue_.resize(baseIndex_.size());
	indexM_EventSymbolValue_.resize(indexM_Event_.size());

	for(Size i=0;i<eventFunctionSymbols_.size();++i){
		eventFunctionSymbols_.push_back(eventFunctionMs_[i]->functionSymbol());
	}

	for(Size i=0;i<baseIndex_.size();++i){

		this->defineBaseIndex(baseIndex_[i]);
		//subEventCountNum도 등록해야함.
	}
	
	for(Size i=0;i<indexM_Event_.size();++i){
		
		indexM_EventSymbolValue_[i] = IndexSymbolManager::instance().setSymbol(indexM_Event_[i]->getSymbol());
		thisStoredSymbolIndex_.push_back(indexM_Event_[i]->getSymbol());
		parser_.DefineVar(indexM_Event_[i]->getSymbol(),indexM_EventSymbolValue_[i]);
		payoffManager_->defineVar(indexM_Event_[i]->getSymbol());
	}
	
	for(Size i=0;i<subEventNum_;++i){
		thisStoredSymbolEvent_.push_back(subEventchecks_[i]->thisCountSymbol()); //CountSymbol 이네?
	}
}

bool isExpired(){
	return false;
}

void EventCheckBase::gridInitialize(const TimeGrid& timeGrid , 
								const Calendar& calendar){
	
	TimeGrid timeGrid_ = timeGrid;
	Calendar calendar_ = calendar;
	
	Date today = Settings::instance().evaluationDate();
	Date issueDate = Date(27,Sep,2012);

	// 이거만 여기서 initialize함 그리드 필요.
	funcAndSubJointEventOccFlag_.resize(timeGrid_.size());
	
	//이건 252일 기준으로 해야함 프허
	if(dailyFlag_){
		QL_REQUIRE(eventDates_.size() == 2 , "size of eventDates must be 2 in daily case ");
		
		//Size initialNum = calendar.businessDaysBetween(issueDate,eventDates_[0],true,false);
		Size initialNum = 0;
		startDatePosition_ = initialNum;
		Size lastNum = calendar.businessDaysBetween(issueDate,eventDates_[1],true,false);
		eventDatesPosition_.resize(lastNum);
		eventDatesPositionNum_ = lastNum;
		for(Size i=0;i<lastNum;++i){
			eventDatesPosition_[i] = i;
		}
	}else{
		for(Size i=0;i<eventDates_.size();++i){
			eventDatesPosition_[i] = calendar.businessDaysBetween(issueDate,eventDates_[i],true,false);
			//timeGrid.index(dayCounter.yearFraction(today,eventDates_[i])); 
		}
	}
	
	payoffDatesPosition_ = payoffManager_->payoffDatesPosition();
	payoffManager_->initialize(timeGrid , calendar);

}
void EventCheckBase::addSymbolEvent(const std::string& symbolName){
	thisStoredSymbolEvent_.push_back(symbolName);
}
//일괄적으로 setting함
void EventCheckBase::defineConst(const std::string varStr,Real constValue){
	parser_.DefineConst(varStr,constValue);

	for(Size i=0 ;i<indexM_Event_.size(); ++i){
		indexM_Event_[i]->defineConst(varStr,constValue);
	}
	for(Size i=0 ;i<subEventchecks_.size(); ++i){
		subEventchecks_[i]->defineConst(varStr,constValue);
	}
	
	payoffManager_->defineConst(varStr,constValue);
}
//일괄적으로 setting함
void EventCheckBase::defineBaseIndex(const std::string varStr){
	
	//baseIndex 주소를 setting
	baseIndexValue_.push_back(IndexSymbolManager::instance().setSymbol(varStr));

	for(Size i=0 ;i<indexM_Event_.size(); ++i){
		indexM_Event_[i]->defineBaseIndex(varStr);
	}
	for(Size i=0 ;i<subEventchecks_.size(); ++i){
		subEventchecks_[i]->defineBaseIndex(varStr);
	}
	payoffManager_->defineBaseIndex(varStr);

}
//일괄적으로 settingㅏ는 것이 아님.
//void EventCheckBase::defineVar(const std::string varStr){
//}


void EventCheckBase::calculate(const MultiPath& multiPath){

	if(!isCalFlag_){
		this->setBaseIndexValue(multiPath,eventDatesPosition_[k]);
			
		for(Size i=0;i<thisStoredSymbolIndex_.size() ;++i){
			indexM_Event_[i]->calValue(multiPath,eventDatesPosition_[k]);
		}

		for(Size z=0;z<eventFunctionMNums_;z++){
			eventFunctionOccFlags_[z] = eventFunctionMs_[z]->eventOcc();
		}

		functionEventJointOccFlag_ = this->functionEventsJoint_Cal();

		if(functionEventJointOccFlag_){
			for(Size i=0;i<subEventNum_;++i){
				subEventchecks_[i]->subCalculate(multiPath); //뭐든 필요하면 계산은 먼저 시키고, 나중에 한번일어난걸 가져오던 다른걸 가져오던 (이건 클래스로 갈지 생각해야함) 해야함.
				subEventOccFlags_[i] = subEventchecks_[i]->thisEventOccFlag(eventDatesPosition_[k]); // 서로가 서로 가지고 있는 경우 무한루프 테스트 필요
				//subCountNum += 1; subEvent True인 개수(여기다 넣어야하나..?)
			}
			SubEventJointOccFlag_ = this->SubEventJoint_Cal();

		}

		funcAndSubJointEventOccFlag_[eventDatesPosition_[k]] = this->funcAndSubJointEvent_Cal(); //subEventFlag_를 사용하여 계산함.
			
		//사건일어난날 바로 조기상환을 위한것. payoffManager 안에서 최종 결정해야할듯.
		if(funcAndSubJointEventOccFlag_[eventDatesPosition_[k]] && autoCallableFlag_){
			//payoffIndexLocation_ = payoffManager_->payoffDatesPosition(k);
			//payoffIndexLocation_ = eventDatesPosition_[k];
			payoffAutoCallLocation_ = eventDatesPosition_[k];
			break; //그냥 빠지면 전체가 계산이 안된 상태에서 isCalFlag_ 에 true가 박힐 수 있음. 2012-11-29
		}

		//timeEventJointOccFlag_ = this->timeEventJoint_Cal(startDatePosition_,refDatePosition);
		timeEventJointOccFlag_ = this->timeEventJoint_Cal(0,0);

		if(timeEventJointOccFlag_){
			payoffValue_=payoffManager_->value(multiPath); // 다시 think.
		}
	}



	isCalFlag_=true;

}

Real EventCheckBase::payoff(const MultiPath& multiPath){
	
	calculate(multiPath);

	return payoffValue_;
}

//eventCalFunction
inline bool EventCheckBase::functionEventsJoint_Cal(){
	bool tf;
	
	tf = functionJointEvent_.checkJoint(eventFunctionOccFlags_);
	functionEventOccCount_ = functionJointEvent_.getCount();

	return tf;
}

inline bool EventCheckBase::SubEventJoint_Cal(){
	bool tf;
	
	tf = subJointEvent_.checkJoint(subEventOccFlags_);
	subEventJointOccCount_ = subJointEvent_.getCount();

	return tf;
}

inline bool EventCheckBase::funcAndSubJointEvent_Cal(){
	bool tf;
	std::vector<bool> functionAndsubFlag;
	functionAndsubFlag.push_back(functionEventJointOccFlag_);
	functionAndsubFlag.push_back(SubEventJointOccFlag_);
	
	tf = functionAndSubEvent_.checkJoint(functionAndsubFlag);
	//functionAndSubEventOccCount_ = functionAndSubEvent_->getCount();

	return tf;
}


inline bool EventCheckBase::timeEventJoint_Cal(Size startDatePosition,Size refDatePosition){
	bool tf;
	
	tf = timeJointEvent_->checkJoint(funcAndSubJointEventOccFlag_,startDatePosition,refDatePosition);
	timeEventJointOccCount_ = timeJointEvent_->getCount();

	return tf;
}

//others

Size EventCheckBase::payoffIndexLocation() const{return payoffManager_->payoffDatesPosition();}

void EventCheckBase::setBaseIndexValue(const MultiPath& multiPath,int datesPosition){
	for(Size i=0;i<baseIndex_.size();++i){
		*baseIndexValue_[i]=multiPath[i][datesPosition];
	}
}

void EventCheckBase::reset(){
	bool tf = false;
		this->isCalFlag_=tf;
		this->payoffValue_ = 0.0;

			//eventOcc_=past;
			//startIndex_=0; //이건 과거 상관없이 0으로 들어감.
} 

//매번 과거데이터를 이용하여 Set하는 경우 사용함.

}