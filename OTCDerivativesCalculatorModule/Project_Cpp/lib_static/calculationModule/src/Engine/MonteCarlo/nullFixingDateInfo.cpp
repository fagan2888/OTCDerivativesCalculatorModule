#include "nullFixingDateInfo.hpp"

namespace QuantLib {

NullFixingDateInfo::NullFixingDateInfo()
: FixingDateInfo(false,Date())
{

}

void NullFixingDateInfo::initialize(const TimeGrid& timeGrid,
									const boost::shared_ptr<YieldTermStructure>& discountCurve,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

Date NullFixingDateInfo::fixingDate()
{
	return Date();
}

Size NullFixingDateInfo::fixingDatePosition()
{
	return 0;
}

Real NullFixingDateInfo::discount()
{
	return 0.0;
}


}
