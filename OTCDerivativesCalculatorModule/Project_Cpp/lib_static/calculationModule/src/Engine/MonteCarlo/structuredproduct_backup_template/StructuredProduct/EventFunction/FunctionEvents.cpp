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

//불리기전에 baseIndex의 값들이 eventDate의 refDate일때로로 설정이 되어있는지 보아야함?

inline bool FunctionEvents<Joint>::eventOcc(){

	//unsigned char flag;

	std::vector<bool> tf;
	// #define DEBUG 여기에 확인 코드? baseIndex 세팅

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