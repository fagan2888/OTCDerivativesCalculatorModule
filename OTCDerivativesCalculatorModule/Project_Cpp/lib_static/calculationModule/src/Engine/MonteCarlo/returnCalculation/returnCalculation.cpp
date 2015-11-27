#include "returnCalculation.hpp"

namespace QuantLib {

ReturnCalculation::ReturnCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: IRefVariable(usingVariableInfoList)
{
	this->preCalFlag_ = false;
	this->postCalFlag_ = false;
	this->returnRefFlag_ = false;
	this->resetVarFlag_ = false;
}


void ReturnCalculation::initialize(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

	if ( this->preCalFlag_ )
		this->preCalculation_->initialize(timeGrid,discountCurve,pathGenFactory);

	if ( this->postCalFlag_ )
		this->postCalculation_->initialize(timeGrid,discountCurve,pathGenFactory);

	if ( this->returnRefFlag_ )
		this->returnRefVariable_->initialize(pathGenFactory);

	if ( this->resetVarFlag_ )
		this->resetVariableInfo_->initialize(pathGenFactory);

	this->initializeImpl(timeGrid,discountCurve,pathGenFactory);

}

void ReturnCalculation::setPreCalculation(const boost::shared_ptr<PreCalculation>& preCal)
{
	this->preCalFlag_ = true;;
	this->preCalculation_ =  preCal;
}

void ReturnCalculation::setPostCalculation(const boost::shared_ptr<PostCalculation>& postCal)
{
	this->postCalFlag_ = true;
	this->postCalculation_ = postCal;
}

void ReturnCalculation::setReturnRefVariable(const boost::shared_ptr<VariableInfo>& returnRefVariable )
{
	this->returnRefFlag_ = true;
	this->returnRefVariable_ = returnRefVariable;	
}

void ReturnCalculation::setResetRefVariable(const boost::shared_ptr<VariableInfo>& resetVariableInfo)
{
	this->resetVarFlag_ = true;
	this->resetVariableInfo_ = resetVariableInfo;
}

Real ReturnCalculation::calculate(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	if( this->preCalFlag_ )
	{
		this->preCalculation_->calculate(path,endPosition);
	}

	value = this->calculateImpl(path,endPosition);

	if( this->postCalFlag_ )
	{
		value = this->postCalculation_->calculate(value);
	}

	if ( this->returnRefFlag_ )
	{
		value = this->returnRefVariable_->execute(value);
	}

	if ( this->resetVarFlag_ )
	{
		this->resetVariableInfo_->execute(0.0);
	}

	return value;
}
//
//Real ReturnCalculation::calculateImplEarlyEx(const MultiPath& path,Size endPosition)
//{
//	Real value = 0.0;
//
//	if( this->preCalFlag_ )
//	{
//		this->preCalculation_->calculateEarlyEx(path,endPosition);
//	}
//
//	value = this->calculateImplEarlyEx(path,endPosition);
//
//	if( this->postCalFlag_ )
//	{
//		value = this->postCalculation_->calculate(value);
//	}
//
//	resetVariableInfo_->execute();
//
//	return value;
//}


}

