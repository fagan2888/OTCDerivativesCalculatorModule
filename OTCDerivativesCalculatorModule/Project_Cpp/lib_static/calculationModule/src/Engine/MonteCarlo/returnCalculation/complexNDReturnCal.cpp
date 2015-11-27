#include "ComplexNDReturnCal.hpp"

namespace QuantLib {

ComplexNDReturnCal::ComplexNDReturnCal(const std::vector<boost::shared_ptr<QuantLib::VariableCalculation>>& variableCalList,
									   const boost::shared_ptr<QuantLib::OperatorND>& operatorND,
									   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReturnCalculation(usingVariableInfoList), variableCalList_(variableCalList)
{

}

void ComplexNDReturnCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	valueArr_ = std::valarray<Real>(variableCalList_.size());

	for ( Size i=0 ; i < this->variableCalList_.size() ; i++)
	{
		this->variableCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}
}

Real ComplexNDReturnCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	for ( Size i=0 ; i < this->variableCalList_.size() ; i++)
	{
		this->valueArr_[i] = this->variableCalList_[i]->calculate(path,endPosition);
	}

	return this->operatorND_->operationND(this->valueArr_);
}

Real ComplexNDReturnCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;
}

Real ComplexNDReturnCal::calSlice(const std::valarray<Real>& val)
{

	//double min = val[0];

	//for ( Size i=1 ; i < this->assetNum_ ; i++ )
	//{
	//	 if ( val[i] < min )
	//	 {
	//		 min = val[i];
	//	 }
	//}

	//return min;

	return 0.0;
}

std::vector<Date> ComplexNDReturnCal::fixingDates() const
{
	return this->fixingDates_;
}


}