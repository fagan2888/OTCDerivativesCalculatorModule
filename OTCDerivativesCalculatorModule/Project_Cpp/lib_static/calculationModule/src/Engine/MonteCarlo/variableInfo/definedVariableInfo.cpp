#include "DefinedVariableInfo.hpp"

namespace QuantLib {

DefinedVariableInfo::DefinedVariableInfo(const std::string& refInstanceName)
: VariableInfo("",refInstanceName,0.0,false)
{

}

Real DefinedVariableInfo::execute(Real value)
{
	return value;
}



}