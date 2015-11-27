#include "DivisionOperatorND.hpp"

namespace QuantLib {

DivisionOperatorND::DivisionOperatorND(const std::vector<Real>& weight)
: OperatorND(weight) 
{

}

Real DivisionOperatorND::operationND(const std::vector<Real>& arr)
{
	return (this->weightArr_[1]*arr[1])/(this->weightArr_[0]*arr[0]);
}

Real DivisionOperatorND::operationND(const std::valarray<Real>& arr)
{
	return (this->weightArr_[1]*arr[1])/(this->weightArr_[0]*arr[0]);
}

}
