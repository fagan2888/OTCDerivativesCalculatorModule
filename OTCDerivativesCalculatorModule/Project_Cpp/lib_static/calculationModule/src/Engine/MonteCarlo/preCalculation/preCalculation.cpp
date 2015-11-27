#include "preCalculation.hpp"

namespace QuantLib {

PreCalculation::PreCalculation(const std::vector<boost::shared_ptr<VariableCalculation>>& variableCalList,
				const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
:IRefVariable(usingVariableInfoList), variableCalList_(variableCalList) 
{

}

void PreCalculation::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

//std::vector<Date> PreCalculation::fixingDates() const
//{
//
//}

void PreCalculation::calculate(const MultiPath& path,Size endPosition)
{
	for ( Size i=0 ; variableCalList_.size() ; i++)
	{
		this->variableCalList_[i]->calculate(path,endPosition);
	}
}

}
