#include "NullProcessModelWrapper.hpp"
#include <iostream>
#include <ql/indexes/indexmanager.hpp>

namespace QuantLib {

NullProcessModelWrapper::NullProcessModelWrapper()
{
}

void NullProcessModelWrapper::generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{

}

void NullProcessModelWrapper::generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{

}
void NullProcessModelWrapper::generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{

}

void NullProcessModelWrapper::generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{

}

void NullProcessModelWrapper::generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{

}

void NullProcessModelWrapper::initialize(const TimeGrid& timeGrid)
{
	
}

Real NullProcessModelWrapper::indexAdjustment(Real r)
{
	return r;
}


}