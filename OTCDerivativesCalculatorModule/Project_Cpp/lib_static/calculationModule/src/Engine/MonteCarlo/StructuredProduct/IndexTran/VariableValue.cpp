#include "VariableValue.hpp"

namespace QuantLib {

VariableValue::VariableValue()
{
	this->ptrBindingFlag_ = false;
}

void VariableValue::itbBindingFlag()
{
	return itbBindingFlag_;
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