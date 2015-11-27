#include "referenceTimeCalculation.hpp"

namespace QuantLib {

ReferenceTimeCalculation::ReferenceTimeCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReferenceCalculation(usingVariableInfoList) 
{
}


}
