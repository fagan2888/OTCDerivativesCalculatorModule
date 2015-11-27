#include "referenceCalculationInfo.hpp"

namespace QuantLib {

ReferenceCalculationInfo::ReferenceCalculationInfo(const std::vector<boost::shared_ptr<QuantLib::ReferenceCalculation>>& referenceCalList,
													const boost::shared_ptr<QuantLib::OperatorND>& operatorND,
													const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReferenceCalculation(usingVariableInfoList), referenceCalList_(referenceCalList), operatorND_(operatorND)
{
	//this->fixingDateInfo_ = boost::shared_ptr<FixingDateInfo>(
}

void ReferenceCalculationInfo::initializeImpl(const TimeGrid& timeGrid,
											const boost::shared_ptr<YieldTermStructure>& discountCurve,
											const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->refCalNum_ = this->referenceCalList_.size();

	this->arr_ = std::valarray<Real>(this->refCalNum_);
	
	for ( Size i=0 ;i<this->refCalNum_; i++ )
	{
		this->referenceCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

}

Real ReferenceCalculationInfo::calSlice(const MultiPath& path,Size position)
{
	for ( Size i=0 ;i<this->refCalNum_; i++ )
	{
		this->arr_[i] = this->referenceCalList_[i]->calSlice(path,position);
	}

	return this->operatorND_->operationND(this->arr_);
}

Real ReferenceCalculationInfo::calSlice(const std::valarray<Real>& val)
{
	QL_FAIL("not implemented");

	return 0.0;
}

Real ReferenceCalculationInfo::calculateImpl(const MultiPath& path,Size endPosition)
{
	for ( Size i=0 ;i<this->refCalNum_; i++ )
	{
		this->arr_[i] = this->referenceCalList_[i]->calculate(path,endPosition);
	}

	return this->operatorND_->operationND(this->arr_);
}

std::vector<Date> ReferenceCalculationInfo::fixingDates() const
{
	return std::vector<Date>();
}

}