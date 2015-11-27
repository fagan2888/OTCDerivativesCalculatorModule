#include "OverWriteVariableEventInfo.hpp"

namespace QuantLib {

OverWriteVariableEventInfo::OverWriteVariableEventInfo(const std::string& usingRefVarName,
									 const std::string& refInstanceName,
									 bool initialTF)
: VariableEventInfo(usingRefVarName,refInstanceName,initialTF)
{

}

//void OverWriteVariableEventInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
//{
//	
//}

bool OverWriteVariableEventInfo::execute(bool tf)
{
	this->valueTypeRefPosition_->value_ = tf;

	return tf;
}



}