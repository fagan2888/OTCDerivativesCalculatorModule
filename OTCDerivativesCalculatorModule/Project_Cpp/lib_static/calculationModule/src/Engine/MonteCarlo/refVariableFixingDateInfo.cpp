#include "refVariableFixingDateInfo.hpp"

namespace QuantLib {

RefVariableFixingDateInfo::RefVariableFixingDateInfo(const std::string& refVarName)
:FixingDateInfo(false,Date()),refVarName_(refVarName)
{

}

void RefVariableFixingDateInfo::initialize(const TimeGrid& timeGrid,
										   const boost::shared_ptr<YieldTermStructure>& discountCurve,
										   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	datePositionPtr_ = pathGenFactory->registDateTypeReferenceValue(this->refVarName_);
}

Date RefVariableFixingDateInfo::fixingDate()
{
	return Date();
}

Size RefVariableFixingDateInfo::fixingDatePosition()
{
	return static_cast<Size>(datePositionPtr_->value_);
}

Real RefVariableFixingDateInfo::discount()
{
	return 0.0;
}

}
