#include <ql/testClass/standardswapTest/eventCheckBase.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

EventCheckBase::EventCheckBase(std::string thisEventSymbolName,
				   //const std::vector<std::string,QuantLib::Index>& baseIndex,
				   const std::vector<std::string>& baseIndex,
				   bool dailyFlag,
				   std::vector<Date> eventDates, //�̺�Ʈ �˻��� , indexM_Event �� �˻��ϰԵ� ��¥��.
				   const std::vector<boost::shared_ptr<IndexTransManager>>& indexM_Event,
				   const std::vector<boost::shared_ptr<EventFunctionManager>>& eventFunctionMs,
				   //boost::shared_ptr<EventFunctionManager> amortizeM,
				   //const Date& payoffDate, //������ payoffManager���� �޾ƾ��ϴ°�?
				   //const boost::shared_ptr<IndexTransManager>& indexM_Payoff, // payoff�� ���� IndexTransform
				   const boost::shared_ptr<PayoffManager>& payoffManager, //�������� �޾ƾ� �ϴ°�?
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
	//	}//�ִ밪. //������ ���̿����� �ִ� ������ ���õǾ� ����.
	//	else{
	//		payoffDate_=Date();
	//	}
	//}//�Ѵ� ���� ��쵵 ���� ex) KI

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
		//subEventCountNum�� ����ؾ���.
	}
	
	for(Size i=0;i<indexM_Event_.size();++i){
		
		indexM_EventSymbolValue_[i] = IndexSymbolManager::instance().setSymbol(indexM_Event_[i]->getSymbol());
		thisStoredSymbolIndex_.push_back(indexM_Event_[i]->getSymbol());
		parser_.DefineVar(indexM_Event_[i]->getSymbol(),indexM_EventSymbolValue_[i]);
		payoffManager_->defineVar(indexM_Event_[i]->getSymbol());
	}
	
	for(Size i=0;i<subEventNum_;++i){
		thisStoredSymbolEvent_.push_back(subEventchecks_[i]->thisCountSymbol()); //CountSymbol �̳�?
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

	// �̰Ÿ� ���⼭ initialize�� �׸��� �ʿ�.
	funcAndSubJointEventOccFlag_.resize(timeGrid_.size());
	
	//�̰� 252�� �������� �ؾ��� ����
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
//�ϰ������� setting��
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
//�ϰ������� setting��
void EventCheckBase::defineBaseIndex(const std::string varStr){
	
	//baseIndex �ּҸ� setting
	baseIndexValue_.push_back(IndexSymbolManager::instance().setSymbol(varStr));

	for(Size i=0 ;i<indexM_Event_.size(); ++i){
		indexM_Event_[i]->defineBaseIndex(varStr);
	}
	for(Size i=0 ;i<subEventchecks_.size(); ++i){
		subEventchecks_[i]->defineBaseIndex(varStr);
	}
	payoffManager_->defineBaseIndex(varStr);

}
//�ϰ������� setting���� ���� �ƴ�.
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
				subEventchecks_[i]->subCalculate(multiPath); //���� �ʿ��ϸ� ����� ���� ��Ű��, ���߿� �ѹ��Ͼ�� �������� �ٸ��� �������� (�̰� Ŭ������ ���� �����ؾ���) �ؾ���.
				subEventOccFlags_[i] = subEventchecks_[i]->thisEventOccFlag(eventDatesPosition_[k]); // ���ΰ� ���� ������ �ִ� ��� ���ѷ��� �׽�Ʈ �ʿ�
				//subCountNum += 1; subEvent True�� ����(����� �־���ϳ�..?)
			}
			SubEventJointOccFlag_ = this->SubEventJoint_Cal();

		}

		funcAndSubJointEventOccFlag_[eventDatesPosition_[k]] = this->funcAndSubJointEvent_Cal(); //subEventFlag_�� ����Ͽ� �����.
			
		//����Ͼ�� �ٷ� �����ȯ�� ���Ѱ�. payoffManager �ȿ��� ���� �����ؾ��ҵ�.
		if(funcAndSubJointEventOccFlag_[eventDatesPosition_[k]] && autoCallableFlag_){
			//payoffIndexLocation_ = payoffManager_->payoffDatesPosition(k);
			//payoffIndexLocation_ = eventDatesPosition_[k];
			payoffAutoCallLocation_ = eventDatesPosition_[k];
			break; //�׳� ������ ��ü�� ����� �ȵ� ���¿��� isCalFlag_ �� true�� ���� �� ����. 2012-11-29
		}

		//timeEventJointOccFlag_ = this->timeEventJoint_Cal(startDatePosition_,refDatePosition);
		timeEventJointOccFlag_ = this->timeEventJoint_Cal(0,0);

		if(timeEventJointOccFlag_){
			payoffValue_=payoffManager_->value(multiPath); // �ٽ� think.
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
			//startIndex_=0; //�̰� ���� ������� 0���� ��.
} 

//�Ź� ���ŵ����͸� �̿��Ͽ� Set�ϴ� ��� �����.

}