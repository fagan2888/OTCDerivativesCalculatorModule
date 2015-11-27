#include "NullVariableInfo.hpp"

namespace QuantLib {

NullVariableInfo::NullVariableInfo()
:VariableInfo("","",0.0,false)
{

}

void NullVariableInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

Real NullVariableInfo::execute(Real value)
{
	return value;
}

}