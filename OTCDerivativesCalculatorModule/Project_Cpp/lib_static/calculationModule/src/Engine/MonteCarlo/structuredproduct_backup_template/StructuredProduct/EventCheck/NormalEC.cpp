#include <src/Engine/MonteCarlo/StructuredProduct/EventCheck/normalEC.hpp>

namespace QuantLib {

EV_TEMPLATE
NormalEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::NormalEC(std::string thisEventSymbolName,
												const ITM& itm,
												const FEM& fem,
												const PM& pm,
												const SubEvent& subJointEvent,
												const FSEvent& functionAndSubEvent,
												Date eventDates,
												boost::shared_ptr<IEventCheck>& subEventchecks = boost::shared_ptr<IEventCheck>())
: thisEventSymbolName_(thisEventSymbolName), itm_(itm), fem_(fem), pm_(pm), 
	subJointEvent_(subJointEvent), functionAndSubEvent_(functionAndSubEvent),
	eventDates_.push_back(eventDates), subEventchecks_(subEventchecks)
{
	
}

EV_TEMPLATE
void NormalEC<ITM,PM,FEM,SubEvent,FSEvent,TEvent>::calculate(){
				
	if(!isCalFlag_){
				
		itm_.calValue();

		eventFunctionOccFlags_[0] = fem_.evetOccc();

		if(functionEventJointOccFlag_){
			for(Size i=0;i<subEventNum_;++i){
				subEventchecks_[i]->subCalculate(multiPath);
				subEventOccFlags_[i] = subEventchecks_[i]->thisEventOccFlag(eventDatesPosition_[0]); // ���ΰ� ���� ������ �ִ� ��� ���ѷ��� �׽�Ʈ �ʿ�
			}
			SubEventJointOccFlag_ = this->SubEventJoint_Cal();
					
			if(functionEventJointOccFlag_ && SubEventJointOccFlag_){
				payoffValue_ = pm_.value();
			}
		}
	}
}

}


