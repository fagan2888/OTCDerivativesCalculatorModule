#include "MaximumOperatorND.hpp"

namespace QuantLib {

MaximumOperatorND::MaximumOperatorND(const std::vector<Real>& weight)
: OperatorND(weight)
{
	
}

Real MaximumOperatorND::operationND(const std::valarray<Real>& arr)
{
	Real v = arr[0];

	for ( Size i=1 ; i<this->arrNum_; i++ )
	{
		if ( v < arr[1] )
			v = arr[1];
	}
	
	return v;
}

Real MaximumOperatorND::operationND(const std::vector<Real>& arr)
{
	Real v = arr[0];

	for ( Size i=1 ; i<this->arrNum_; i++ )
	{
		if ( v < arr[1] )
			v = arr[1];
	}
	
	return v;
}


}
