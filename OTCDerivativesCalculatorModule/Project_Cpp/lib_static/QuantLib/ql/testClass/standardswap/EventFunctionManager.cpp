#include <ql/testClass/standardswap/eventfunctionmanager.hpp>

namespace QuantLib {

EventFunctionManager::EventFunctionManager(std::string functionSymbol,
											std::string indexSymbol,
											boost::shared_ptr<EventFunction> eventFunction)
		: functionSymbol_(functionSymbol), indexSymbol_(indexSymbol), eventFunction_(eventFunction)
{
	//QL_REQUIRE(IndexSymbolManager::hasSymbol(indexSymbol),"SymbolName : " <<indexSymbol << " must be set previous");
	indexValuePtr_ = IndexSymbolManager::instance().setSymbol(indexSymbol);
}

//불리기전에 baseIndex의 값들이 eventDate의 refDate일때로로 설정이 되어있는지 보아야함?
bool EventFunctionManager::eventOcc(){

	return eventFunction_->checkEventOcc(*indexValuePtr_);

}

}