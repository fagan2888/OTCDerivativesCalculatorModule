#include "VariableEventInfo.hpp"

namespace QuantLib {

VariableEventInfo::VariableEventInfo(const std::string& usingRefVarName,
									 const std::string& refInstanceName,
									 bool initialTF)
: usingRefVarName_(usingRefVarName), refInstanceName_(refInstanceName), initialTF_(initialTF)
{

}

void VariableEventInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->valueTypeRefPosition_ = pathGenFactory->registValueTypeReferenceValue(this->refInstanceName_);
}

void VariableEventInfo::reset()
{
	this->valueTypeRefPosition_->value_ = this->initialTF_;
}

}