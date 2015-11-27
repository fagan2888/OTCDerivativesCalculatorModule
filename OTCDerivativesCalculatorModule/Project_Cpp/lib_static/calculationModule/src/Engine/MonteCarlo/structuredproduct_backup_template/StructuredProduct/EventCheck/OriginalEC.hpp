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