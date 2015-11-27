#include "ReturnTrans.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>

namespace QuantLib {
	
ReturnTrans::ReturnTrans(const boost::shared_ptr<VariableValue>& numerVariableValue,
						 const boost::shared_ptr<VariableValue>& denumerVariableValue,
						 const std::string& symbolName) 
: IndexTransBase(symbolName),numerVariableValue_(numerVariableValue), denumerVariableValue_(denumerVariableValue)
{
	//registerWith(IndexSymbolManager::instance());
}


void ReturnTrans::initialize()
{
	//numerPosition_ = calendar.businessDaysBetween(issueDate,numerDate,true,false);
	//denumerPosition_ = calendar.businessDaysBetween(issueDate,denumerDate,true,false);
				
}

Size ReturnTrans::size()
{
	return 1;
}

//observer�� ���ߴ볪... ��.��;; �ƿĽ�... 
void ReturnTrans::variableBind()
{
	//if(!(this->variableValue_->variableBind()))
	
	this->thisVariableValue_ = IndexSymbolManager::instance().getSymbol(this->symbolName_);

	const std::string& numerString = numerVariableValue_->symbolName();
	if(numerString != "No_Symbol")
	{
		this->numerVariableValue_ = IndexSymbolManager::instance().getSymbol(numerString);
	}

	const std::string& denumerString = denumerVariableValue_->symbolName();
	if(denumerString != "No_Symbol")
	{
		this->denumerVariableValue_ = IndexSymbolManager::instance().getSymbol(denumerString);
	}	
}

//�ᱹ observer pattern���� ����� �Ͽ���...
//void ReturnTrans::update()
//{
//	const std::string& numerSymbolName = this->numerVariableValue_->symbolName();
//	const std::string& denumerSymbolName = this->denumerVariableValue_->symbolName();
//
//	this->numerVariableValue_ = IndexSymbolManager::instance().getSymbo(numerSymbolName);
//	this->denumerVariableValue_ = IndexSymbolManager::instance().getSymbo(denumerSymbolName);
//
//}

// ��� symbolptr �� set�� ������ ����Ǿ���
std::vector<Date> ReturnTrans::indexFixingDates()
{
	std::vector<Date> indexFixings;

	indexFixings = this->thisVariableValue_->indexFixingDates();

	//QL_REQUIRE( this->lastFixingDate_ <= eventDate , "lastFixingDate is later than eventDate");

	//Variable �� ptrBinding()

	return indexFixings;

}

//this class ptrBinding()
void ReturnTrans::variablePtrBind()
{
	thisPtr_ = thisVariableValue_->getPtr();

	numerPtr_ = numerVariableValue_->getPtr();
	denumerPtr_ = denumerVariableValue_->getPtr();

}

void ReturnTrans::calculate()
{
	this->calValue();
}

void ReturnTrans::calValue()
{
	*thisPtr_ = (*numerPtr_)/(*denumerPtr_);
	//*symbolValuesPtr_ = (*numerPtr_)/(*denumerPtr_);
}

}

