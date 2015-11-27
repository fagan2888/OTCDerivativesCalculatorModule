#include "ReturnTransTime.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>

namespace QuantLib {
	
ReturnTransTime::ReturnTransTime(const boost::shared_ptr<VariableValue>& numerVariableValue,
						 const boost::shared_ptr<VariableValue>& denumerVariableValue,
						 const std::string& symbolName) 
: IndexTransBase(symbolName),numerVariableValue_(numerVariableValue), denumerVariableValue_(denumerVariableValue)
{
	registerWith(IndexSymbolManager::instance());
}

Size ReturnTransTime::size()
{
	return 1;
}

//observer�� ���ߴ볪... ��.��;; �ƿĽ�... 
void ReturnTransTime::variableBind()
{
	if(!(this->variableValue_->variableBind()))
		this->variableValue_ = IndexSymbolManager::instance().getSymbol(this->variableValue_->symbol());
	
	this->thisVariableValue_->valuePtrBinding();

}


// ��� symbolptr �� set�� ������ ����Ǿ���
std::vector<Date> ReturnTransTime::indexFixingDates()
{
	std::vector<Date> indexFixings;

	indexFixings = this->thisVariableValue_->indexFixingDates();

	//QL_REQUIRE( this->lastFixingDate_ <= eventDate , "lastFixingDate is later than eventDate");

	//Variable �� ptrBinding()

	return indexFixings;

}

//this class ptrBinding()
void ReturnTransTime::valuePtrBinding()
{
	thisPtr_ = variableValue_->getPtr();

	numerPtr_ = numerVariableValue_->getPtr();
	denumerPtr_ = denumerVariableValue_->getPtr();

}

void ReturnTransTime::calculate()
{
	this->calValue();
}

void ReturnTransTime::calValue()
{
	*symbolValuesPtr_ = (*numerPtr_)/(*denumerPtr_);
}

}

