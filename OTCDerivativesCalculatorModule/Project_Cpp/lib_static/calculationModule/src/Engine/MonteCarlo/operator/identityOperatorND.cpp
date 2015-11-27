#include "IdentityOperatorND.hpp"

namespace QuantLib {

IdentityOperatorND::IdentityOperatorND()
: OperatorND(std::vector<Real>()) 
{

}

Real IdentityOperatorND::operationND(const std::vector<Real>& arr)
{
	return arr[0];
}

Real IdentityOperatorND::operationND(const std::valarray<Real>& arr)
{
	return arr[0];
}

}
