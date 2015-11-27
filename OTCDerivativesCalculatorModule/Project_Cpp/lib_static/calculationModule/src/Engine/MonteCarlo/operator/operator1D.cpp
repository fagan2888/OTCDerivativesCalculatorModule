#include "operator1D.hpp"

namespace QuantLib {

Operator1D::Operator1D(Real constValue)
: constValue_(constValue), refFlag_(false)
{

}

Operator1D::Operator1D(const std::string& refName)
: refName_(refName), refFlag_(true)
{

}

}
