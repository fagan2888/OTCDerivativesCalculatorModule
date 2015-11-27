#include "processArrayWrapper.hpp"

namespace QuantLib 
{
ProcessArrayWrapper::ProcessArrayWrapper()
{
	this->processArrWrapper_.push_back(
		boost::shared_ptr<IProcessWrapper>(new NullProcessModelWrapper()));
}

ProcessArrayWrapper::ProcessArrayWrapper(const std::vector<boost::shared_ptr<IProcessWrapper>>& processArrWrapper,
										 const Matrix& correlation)
: processArrWrapper_(processArrWrapper), correlation_(correlation)
{

}

void ProcessArrayWrapper::generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	for ( Size i=0 ; i< processArrWrapper_.size(); i++ )
	{
		processArrWrapper_[i]->generatePath(targerPath,randomSeq,todayPosition,i);
	}
}

void ProcessArrayWrapper::generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	this->processArrWrapper_[assetPosition]->generatePath_s_up(targerPath,randomSeq,todayPosition,assetPosition);
}

void ProcessArrayWrapper::generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	this->processArrWrapper_[assetPosition]->generatePath_s_down(targerPath,randomSeq,todayPosition,assetPosition);
}

void ProcessArrayWrapper::generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	this->processArrWrapper_[assetPosition]->generatePath_sigma_up(targerPath,randomSeq,todayPosition,assetPosition);
}

void ProcessArrayWrapper::generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	this->processArrWrapper_[assetPosition]->generatePath_sigma_down(targerPath,randomSeq,todayPosition,assetPosition);
}

void ProcessArrayWrapper::initialize(const TimeGrid& timeGrid)
{

	for ( Size i=0 ; i < processArrWrapper_.size() ; i++ )
	{
		processArrWrapper_[i]->initialize(timeGrid);
	}
	
}

boost::shared_ptr<IProcessWrapper> ProcessArrayWrapper::processWrapper(Size i) const
{
	return this->processArrWrapper_[i];
}

Size ProcessArrayWrapper::size()
{
	return this->processArrWrapper_.size();
}

Matrix ProcessArrayWrapper::correlation()
{
	return this->correlation_;
}

bool ProcessArrayWrapper::isNeedSimul()
{
	bool tf = false;

	for ( Size i = 0 ; i< this->size() ; i++ )
	{
		if ( this->processArrWrapper_[i]->isNeedSimul() )
			tf = true;
	}

	return tf;
}

}
