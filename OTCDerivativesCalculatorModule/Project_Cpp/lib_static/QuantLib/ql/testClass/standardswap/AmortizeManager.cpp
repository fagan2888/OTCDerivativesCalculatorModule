#include <ql/testClass/standardswap/amortizeManager.hpp>

namespace QuantLib {

AmortizeManager::AmortizeManager(std::string indexSymbol,
								 boost::shared_ptr<EventFunction> eventFunction)
		: indexSymbol_(indexSymbol), eventFunction_(eventFunction)
{
	indexValuePtr_ = IndexSymbolManager::instance().setSymbol(indexSymbol);
}

//�Ҹ������� baseIndex�� ������ eventDate�� refDate�϶��η� ������ �Ǿ��ִ��� ���ƾ���?
bool AmortizeManager::eventOcc(){

	return eventFunction_->checkEventOcc(*indexValuePtr_);

}

}