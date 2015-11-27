#include "ResetVariableInfo.hpp"

namespace QuantLib {

ResetVariableInfo::ResetVariableInfo(const std::string& refInstanceName,
									 Real resetValue)
: VariableInfo("",refInstanceName,0.0,false), resetValue_(resetValue)
{

}

//void ResetVariableInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
//{
//	this->valueTypeRefPosition_ = pathGenFactory->registValueTypeReferenceValue(this->refInstanceName_);
//}

Real ResetVariableInfo::execute(Real value)
{
	this->valueTypeRefPosition_->value_ = resetValue_;

	return value;
}

}