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