#include "MCPricer.hpp"

namespace QuantLib {

void MCPricer::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	
	for ( Size i=0 ;i<this->variableInfoList_.size() ; i++)
	{
		pathGenFactory->registValueTypeReferenceValue(
			this->variableInfoList_[i]->refInstanceName());

		this->variableInfoList_[i]->initialize(pathGenFactory);
	}

	this->initializeImpl(timeGrid,discountCurve,pathGenFactory);
}

void MCPricer::reset() const
{
	for ( Size i=0 ;i<this->variableInfoList_.size() ; i++)
	{
		this->variableInfoList_[i]->reset();
	}

	this->resetImpl();
}

void MCPricer::registVariableInfo(const std::vector<boost::shared_ptr<VariableInfo>>& variableInfoList)
{
	this->variableInfoList_ = variableInfoList;

}



}
