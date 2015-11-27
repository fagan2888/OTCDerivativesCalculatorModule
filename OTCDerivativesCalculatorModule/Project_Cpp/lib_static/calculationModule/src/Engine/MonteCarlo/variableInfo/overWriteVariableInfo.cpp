#include "OverWriteVariableInfo.hpp"

namespace QuantLib {

OverWriteVariableInfo::OverWriteVariableInfo(const std::string& usingRefVarName,
									 const std::string& refInstanceName,
									 //Real initialValue,
									 bool saveFlag)
: VariableInfo(usingRefVarName,refInstanceName,0.0,saveFlag)
{

}

//void OverWriteVariableInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
//{
//	this->valueTypeRefPosition_ = pathGenFactory->registValueTypeReferenceValue(this->refInstanceName_);
//}

Real OverWriteVariableInfo::execute(Real value)
{
	this->valueTypeRefPosition_->value_ = value;

	return value;
}



}