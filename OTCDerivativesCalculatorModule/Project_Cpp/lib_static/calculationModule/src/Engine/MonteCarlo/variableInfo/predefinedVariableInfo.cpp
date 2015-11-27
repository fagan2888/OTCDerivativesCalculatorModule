#include "PreDefinedVariableInfo.hpp"

namespace QuantLib {

PreDefinedVariableInfo::PreDefinedVariableInfo(const std::string& refInstanceName,
											   const boost::shared_ptr<FixingInformation>& fixingInfo)
: VariableInfo("",refInstanceName,0.0,false)
{
	Date today = Settings::instance().evaluationDate();
	this->initialValue_ = fixingInfo->fixingValue(today);
}

//PreDefinedVariableInfo::PreDefinedVariableInfo(const std::string& usingRefVarName,
//										 const std::string& refInstanceName,
//										 const boost::shared_ptr<FixingInformation>& fixingInfo,
//										 bool saveFlag)
//: VariableInfo(usingRefVarName,refInstanceName,0.0,saveFlag) 
//{
//	Date today = Settings::instance().evaluationDate();
//	this->initialValue_ = this->fixingInfo_->fixingValue(today);
//}

//void PreDefinedVariableInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
//{
//	this->valueTypeRefPosition_ = pathGenFactory->registValueTypeReferenceValue(this->refInstanceName_);
//}

Real PreDefinedVariableInfo::execute(Real value)
{
	//this->valueTypeRefPosition_->value_ = value;

	return value;
}



}