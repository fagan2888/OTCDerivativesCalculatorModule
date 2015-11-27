#include "ZeroReturnCal.hpp"

namespace QuantLib {

ZeroReturnCal::ZeroReturnCal()
: ReturnCalculation(std::vector<boost::shared_ptr<VariableInfo>>())
{
}

void ZeroReturnCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
}

Real ZeroReturnCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

//Real ZeroReturnCal::calculateImplEarlyEx(const MultiPath& path,Size endPosition)
//{
//	return 0.0;
//}

Real ZeroReturnCal::calSlice(const std::valarray<Real>& val)
{
	return 0.0;
}

Real ZeroReturnCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;

}


std::vector<Date> ZeroReturnCal::fixingDates() const
{
	return this->fixingDates_;
}


}