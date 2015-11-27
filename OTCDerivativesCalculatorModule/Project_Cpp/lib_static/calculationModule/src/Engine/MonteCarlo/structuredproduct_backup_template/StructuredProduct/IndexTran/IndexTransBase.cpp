#include <src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>

namespace QuantLib {

IndexTransBase::IndexTransBase()
				: symbolName_("defualtSymbolName"), eqExpression_("defaultEqExpression") {}

IndexTransBase::IndexTransBase(const std::string& symbolName,
											 const std::string& eqExpression)
				: symbolName_(symbolName), symbolValuesPtr_(IndexSymbolManager::instance().setSymbol(symbolName))
{

}

void IndexTransBase::initialize(const TimeGrid& timeGrid, const Calendar& calendar){
	Date today = Settings::instance().evaluationDate();
}

void IndexTransBase::defineVar(const std::string varStr){}
void IndexTransBase::defineConst(const std::string varStr,Real constValue){}
void IndexTransBase::defineBaseIndex(const std::string varStr){}

void IndexTransBase::calValue(){}
void IndexTransBase::calValue(int refDatePosition){}

}