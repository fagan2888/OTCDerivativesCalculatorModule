#include "variableInfo.hpp"

namespace QuantLib {

//VariableInfo::VariableInfo(const std::string& usingRefVarName,
//						 const std::string& refInstanceName,
//						 //Real initialValue,
//						 const boost::shared_ptr<FixingInformation>& fixingInfo,
//						 bool saveFlag)
//: usingRefVarName_(usingRefVarName), refInstanceName_(refInstanceName), 
//  fixingInfo_(fixingInfo), saveFlag_(saveFlag)
//{
//	Date today = Settings::instance().evaluationDate();
//	
//	this->initialValue_ = this->fixingInfo_->fixingValue(today);
//}

VariableInfo::VariableInfo(const std::string& usingRefVarName,
						 const std::string& refInstanceName,
						 Real initialValue,
						 bool saveFlag)
: usingRefVarName_(usingRefVarName), refInstanceName_(refInstanceName), 
  saveFlag_(saveFlag)
{
	Date today = Settings::instance().evaluationDate();
	
	this->initialValue_ = initialValue;
}


void VariableInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->valueTypeRefPosition_ = pathGenFactory->getValueTypeReference(this->refInstanceName_);

	this->valueTypeRefPosition_->value_ = this->initialValue_;

}

std::string VariableInfo::refInstanceName()
{
	return this->refInstanceName_;
}

void VariableInfo::reset()
{
	this->valueTypeRefPosition_->value_ = this->initialValue_;
}

}