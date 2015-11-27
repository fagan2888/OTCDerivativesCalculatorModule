#include "variableCalculation.hpp"

namespace QuantLib {

VariableCalculation::VariableCalculation(const boost::shared_ptr<ReferenceCalculation>& referCal,
										const std::vector<boost::shared_ptr<Operator1D>>& operator1DList,
										const boost::shared_ptr<ConditionOperator>& conditionOperCal,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: IRefVariable(usingVariableInfoList), referCal_(referCal), conditionOperCal_(conditionOperCal),
  operator1DList_(operator1DList)
{

}
void VariableCalculation::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

Real VariableCalculation::calculate(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	value = this->referCal_->calculate(path,endPosition);

	for ( Size i=0 ; operator1DList_.size() ; i++)
	{
		value = this->operator1DList_[i]->operation1D(value);
	}

	value = this->conditionOperCal_->operation1D(value);

	return value;
}

}
