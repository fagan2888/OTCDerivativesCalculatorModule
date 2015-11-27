#include "referenceCalculation.hpp"

namespace QuantLib {

ReferenceCalculation::ReferenceCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: IRefVariable(usingVariableInfoList) 
{
	this->preFixedFlag_ = false;
	this->preFixingValue_ = 0.0;
	this->postCalFlag_ = false;
	this->referenceRefFlag_ = false;
	
}

void ReferenceCalculation::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	IRefVariable::setRefVariable(pathGenFactory);

	Date today = Settings::instance().evaluationDate();

	//if ( this->fixingDateInfo_ != 0)
	//{
	//	Date fixingDate = this->fixingDateInfo_->fixingDate();

	//	if ( fixingDate < today )
	//	{
	//		this->preFixedFlag_ = true;	

	//		if ( this->fixingInfo_ != 0 )
	//		{
	//			this->preFixingValue_ = this->fixingInfo_->fixingValue(today);
	//		}
	//		else
	//		{
	//			this->preFixingValue_ = 0.0;
	//			QL_FAIL("fixingInfo is empty");
	//		}
	//	}
	//}

	if( this->postCalFlag_ )
	{
		this->postCalculation_->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	if ( this->referenceRefFlag_ )
	{
		this->referenceRefVariable_->initialize(pathGenFactory);
	}

	this->initializeImpl(timeGrid,discountCurve,pathGenFactory);
	this->pastFixingInitialize(pathGenFactory);
}				


void ReferenceCalculation::setFixingInformation(const boost::shared_ptr<FixingInformation>& fixingInfo)
{
	this->preFixedFlag_ = true;
	this->fixingInfo_ = fixingInfo;
}


void ReferenceCalculation::setPostCalculation(const boost::shared_ptr<PostCalculation>& postCal)
{
	this->postCalFlag_ = true;
	this->postCalculation_ = postCal;
}

void ReferenceCalculation::setReferenceRefVariable(const boost::shared_ptr<VariableInfo>& referenceRefVariable )
{
	this->referenceRefFlag_ = true;
	this->referenceRefVariable_ = referenceRefVariable;	
}

Real ReferenceCalculation::calculate(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	if ( this->preFixedFlag_ )
	{
		value = this->preFixingValue_;
	}else
	{
		value = this->calculateImpl(path,endPosition);
	}

	if( this->postCalFlag_ )
	{
		value = this->postCalculation_->calculate(value);
	}

	if ( this->referenceRefFlag_ )
	{
		value = this->referenceRefVariable_->execute(value);
	}

	return value;
}

}

