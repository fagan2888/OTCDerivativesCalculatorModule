#include "OperatorND.hpp"

namespace QuantLib {

OperatorND::OperatorND(std::vector<Real> weightArr)
: weightArr_(weightArr)
{
	arrNum_ = weightArr_.size();
}

}
