#include "Complex1DReturnCal.hpp"

namespace QuantLib {

Complex1DReturnCal::Complex1DReturnCal(const boost::shared_ptr<QuantLib::VariableCalculation>& variableCal,
									   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReturnCalculation(usingVariableInfoList), variableCal_(variableCal)
{

}

void Complex1DReturnCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->variableCal_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real Complex1DReturnCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	return variableCal_->calculate(path,endPosition);
}

Real Complex1DReturnCal::calSlice(const std::valarray<Real>& val)
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

Real Complex1DReturnCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;
}

std::vector<Date> Complex1DReturnCal::fixingDates() const
{
	return this->fixingDates_;
}


}