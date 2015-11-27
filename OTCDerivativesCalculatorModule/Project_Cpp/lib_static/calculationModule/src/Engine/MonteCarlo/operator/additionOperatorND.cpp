#include "AdditionOperatorND.hpp"

namespace QuantLib {

AdditionOperatorND::AdditionOperatorND(const std::vector<Real>& weight)
: OperatorND(weight)
{

}

Real AdditionOperatorND::operationND(const std::vector<Real>& arr)
{
	QL_FAIL("not implemented");
	return 0.0;
}

Real AdditionOperatorND::operationND(const std::valarray<Real>& arr)
{
	QL_FAIL("not implemented");
	return 0.0;
}

}
