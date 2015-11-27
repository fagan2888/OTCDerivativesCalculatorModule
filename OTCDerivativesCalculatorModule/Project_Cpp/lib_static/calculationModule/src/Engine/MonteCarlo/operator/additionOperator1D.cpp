#include "AdditionOperator1D.hpp"

namespace QuantLib {

AdditionOperator1D::AdditionOperator1D(Real constValue)
: Operator1D(constValue) 
{

}

AdditionOperator1D::AdditionOperator1D(const std::string& refName)
: Operator1D(refName)
{

}

Real AdditionOperator1D::operation1D(Real value)
{
	if ( !refFlag_ )
	{
		return value + this->constValue_;
	}
	else
	{
		return value + (*ref_);
	}

}

}
