#include <src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/EventFunction/functionEvents.hpp>

namespace QuantLib {

FunctionEvents::FunctionEvents(std::vector<boost::shared_ptr<EventFunctionManager>> eventFunctions,
							   const boost::shared_ptr<JointEvent>& joint)
		: indexSymbol_(indexSymbol), eventFunctionsBoostPtr_(eventFunctions)
{
	EfNum_ = eventFunctionsBoostPtr_.size();
	for(Size i=0;i<EfNum_;++i){
		eventFunctions_.push_back(eventFunctionsBoostPtr_[i].get());
	}
	joint_ = joint.get();

}

//�Ҹ������� baseIndex�� ������ eventDate�� refDate�϶��η� ������ �Ǿ��ִ��� ���ƾ���?

inline bool FunctionEvents<Joint>::eventOcc(){

	//unsigned char flag;

	std::vector<bool> tf;
	// #define DEBUG ���⿡ Ȯ�� �ڵ�? baseIndex ����

	for(Size i=0;i<EfNum_;++i){
		tf.push_back(eventFunction_[i]->eventOcc(););
	}

	return joint_->checkJoint(tf);

}

EventFunctionManager::EventFunctionManager(std::string functionSymbol,
										   std::string indexSymbol,
										   const boost::shared_ptr<EventFunction>& eventFunction)
		: functionSymbol_(functionSymbol), indexSymbol_(indexSymbol), eventFunctionsBoostPtr_(eventFunction)
{
	if(!IndexSymbolManager::instance().hasSymbol(indexSymbol))
	{
		QL_ERROR();
	}

	IndexSymbolManager::instance().setSymbol(indexSymbol);
	eventFunctions_ = eventFunctionsBoostPtr_.get();

}



}