#include "couponCalculation.hpp"

namespace QuantLib {

CouponCalculation::CouponCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList)
{

}

}