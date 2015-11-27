#include "ReturnCalculationInfo.hpp"

namespace QuantLib {

ReturnCalculationInfo::	ReturnCalculationInfo(const std::vector<boost::shared_ptr<QuantLib::ReturnCalculation>>& returnCalList,
											const boost::shared_ptr<QuantLib::OperatorND>& operatorND,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList )
: ReturnCalculation(usingVariableInfoList), operatorND_(operatorND), returnCalList_(returnCalList)
{

}

void ReturnCalculationInfo::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	valueArr_ = std::valarray<Real>(returnCalList_.size());

	for ( Size i=0 ; i < this->returnCalList_.size() ; i++)
	{
		this->returnCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}
}

Real ReturnCalculationInfo::calculateImpl(const MultiPath& path,Size endPosition)
{
	for ( Size i=0 ; i < this->returnCalList_.size() ; i++)
	{
		this->valueArr_[i] = this->returnCalList_[i]->calculate(path,endPosition);
	}

	return this->operatorND_->operationND(this->valueArr_);
}

Real ReturnCalculationInfo::calSlice(const MultiPath& path,Size position)
{
	return 0.0;
}


Real ReturnCalculationInfo::calSlice(const std::valarray<Real>& val)
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

std::vector<Date> ReturnCalculationInfo::fixingDates() const
{
	return this->fixingDates_;
}


}