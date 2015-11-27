#include "MaximumOperator1D.hpp"

namespace QuantLib {

MaximumOperator1D::MaximumOperator1D(Real constValue)
: Operator1D(constValue) 
{
	
}

MaximumOperator1D::MaximumOperator1D(const std::string& refName)
: Operator1D(refName)
{
	
}

Real MaximumOperator1D::operation1D(Real value)
{
	if ( refFlag_ )
	{
		return std::max( value , (*ref_) );
	}
	else
	{
		return std::max( value , this->constValue_ );
	}

}

}
