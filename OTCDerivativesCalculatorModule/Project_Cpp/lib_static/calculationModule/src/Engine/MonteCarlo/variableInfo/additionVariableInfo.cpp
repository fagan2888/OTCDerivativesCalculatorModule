#include "AdditionVariableInfo.hpp"

namespace QuantLib {

AdditionVariableInfo::AdditionVariableInfo(const std::string& usingRefVarName,
											const std::string& refInstanceName,
											//Real initialValue,
											bool saveFlag)
: VariableInfo(usingRefVarName,refInstanceName,0.0,saveFlag)
{

}




Real AdditionVariableInfo::execute(Real v)
{
	Real addedValue = valueTypeRefPosition_->value_ + v;

	valueTypeRefPosition_->value_ = addedValue ;

	if ( this->saveFlag_ == true )
	{
		return 0.0;
	}else
	{
		return v;
	}
}

}