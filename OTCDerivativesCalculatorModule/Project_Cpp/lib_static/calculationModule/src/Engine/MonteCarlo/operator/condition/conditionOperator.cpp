#include "ConditionOperator.hpp"

namespace QuantLib {

ConditionOperator::ConditionOperator(const std::vector<boost::shared_ptr<RangeConditionOperator1D>>& rangeConditionOper1DList)
: rangeConditionOper1DList_(rangeConditionOper1DList)
{

}

Real ConditionOperator::operation1D(Real v)
{
	Real value = v;

	for ( Size i=0 ; rangeConditionOper1DList_.size() ; i++)
	{
		value = rangeConditionOper1DList_[i]->operation1D(value);
	}

	return value;
}

}
