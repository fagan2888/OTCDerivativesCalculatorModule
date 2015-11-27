#include "postCalculation.hpp"

namespace QuantLib {

PostCalculation::PostCalculation(const std::vector<boost::shared_ptr<Operator1D>>& operator1DList,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: IRefVariable(usingVariableInfoList), operator1DList_(operator1DList)
{
	this->oper1DNum_ = operator1DList.size();
}

void PostCalculation::initialize(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

Real PostCalculation::calculate(Real v)
{
	Real value = v;

	for ( Size i=0 ; i < this->oper1DNum_ ; i++)
	{
		value = this->operator1DList_[i]->operation1D(value);
	}

	return value;
}


}

