#include "MultipleOperatorND.hpp"

namespace QuantLib {

MultipleOperatorND::MultipleOperatorND(const std::vector<Real>& weight)
: OperatorND(weight) 
{

}

Real MultipleOperatorND::operationND(const std::vector<Real>& arr)
{
	QL_FAIL("not implemented");
	return 0.0;

}

Real MultipleOperatorND::operationND(const std::valarray<Real>& arr)
{
	QL_FAIL("not implemented");
	return 0.0;


}
}
