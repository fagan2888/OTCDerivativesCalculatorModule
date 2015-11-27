#include <ql/testClass/standardswap/amortizeManager.hpp>

namespace QuantLib {

AmortizeManager::AmortizeManager(std::string indexSymbol,
								 boost::shared_ptr<EventFunction> eventFunction)
		: indexSymbol_(indexSymbol), eventFunction_(eventFunction)
{
	indexValuePtr_ = IndexSymbolManager::instance().setSymbol(indexSymbol);
}

//불리기전에 baseIndex의 값들이 eventDate의 refDate일때로로 설정이 되어있는지 보아야함?
bool AmortizeManager::eventOcc(){

	return eventFunction_->checkEventOcc(*indexValuePtr_);

}

}