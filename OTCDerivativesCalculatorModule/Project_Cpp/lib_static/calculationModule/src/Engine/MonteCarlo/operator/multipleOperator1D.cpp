#include "MultipleOperator1D.hpp"

namespace QuantLib {

MultipleOperator1D::MultipleOperator1D(Real constValue)
: Operator1D(constValue) 
{

}

MultipleOperator1D::MultipleOperator1D(const std::string& refName)
: Operator1D(refName)
{

}

Real MultipleOperator1D::operation1D(Real value)
{
	if ( !refFlag_ )
	{
		return value * this->constValue_;
	}
	else
	{
		return value * (*ref_);
	}

}

}
