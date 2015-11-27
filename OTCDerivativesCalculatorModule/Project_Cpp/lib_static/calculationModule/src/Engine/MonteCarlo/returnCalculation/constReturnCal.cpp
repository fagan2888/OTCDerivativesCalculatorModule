#include "constReturnCal.hpp"

namespace QuantLib {

ConstReturnCal::ConstReturnCal(Real constValue,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList )
: ReturnCalculation(usingVariableInfoList), constValue_(constValue)
{
}

void ConstReturnCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
}

Real ConstReturnCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	return this->constValue_;
}

Real ConstReturnCal::calSlice(const std::valarray<Real>& val)
{
	return this->constValue_;
}

Real ConstReturnCal::calSlice(const MultiPath& path,Size position)
{
	return this->constValue_;
}

std::vector<Date> ConstReturnCal::fixingDates() const
{
	return this->fixingDates_;
}


}