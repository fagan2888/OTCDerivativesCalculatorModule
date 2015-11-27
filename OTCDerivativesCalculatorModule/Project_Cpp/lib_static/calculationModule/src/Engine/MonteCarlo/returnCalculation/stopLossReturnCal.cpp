#include "StopLossReturnCal.hpp"

namespace QuantLib {

StopLossReturnCal::StopLossReturnCal(const boost::shared_ptr<QuantLib::ReferenceCalculation>& refCal,
									 Real power,
									 Real lossTrigger,
									 Real maximumLoss,
									 //Real withNotional,
									 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReturnCalculation(usingVariableInfoList), refCal_(refCal), power_(power), lossTrigger_(lossTrigger),
  maximumLoss_(maximumLoss)//, withNotional_(withNotional)
{

}

void StopLossReturnCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->refCal_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real StopLossReturnCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	Real refValue = this->refCal_->calculate(path,endPosition);

	//return withNotional_ - (1.0 * power_ * std::min(this->maximumLoss_ , 
	//												std::max(0.0 , this->lossTrigger_ - refValue)));

	return - (1.0 * power_ * std::min(this->maximumLoss_ , 
									std::max(0.0 , this->lossTrigger_ - refValue)));

}

Real StopLossReturnCal::calSlice(const std::valarray<Real>& val)
{
	return 0.0;
}

Real StopLossReturnCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;

}

std::vector<Date> StopLossReturnCal::fixingDates() const
{
	return refCal_->fixingDates();
}


}