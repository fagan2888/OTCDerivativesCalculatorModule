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

//�Ҹ������� baseIndex�� ������ eventDate�� refDate�϶��η� ������ �Ǿ��ִ��� ���ƾ���?
bool EventFunctionManager::eventOcc(){

	return eventFunction_->checkEventOcc(*indexValuePtr_);

}

}