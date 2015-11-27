#include "VariableValue.hpp"

namespace QuantLib {

VariableValue::VariableValue()
{
	this->variableBindingFlag_ = false;
	this->setSymbolManagerFlag_ = false;
	this->ptrBindingFlag_ = false;
	this->symbolName_ = "No_Symbol";
}

bool VariableValue::variableBindingFlag()
{
	return variableBindingFlag_;
}
std::string VariableValue::symbolName()
{
	return this->symbolName_;
}
Real* VariableValue::getPtr()
{
	if(this->ptrBindingFlag_)
	{
		return this->valuePtr_;
	}
	else
	{
		QL_FAIL("ptr was not binding");
	}
}

}