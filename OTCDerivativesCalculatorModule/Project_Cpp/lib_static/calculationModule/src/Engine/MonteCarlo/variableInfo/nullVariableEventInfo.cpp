#include "NullVariableEventInfo.hpp"

namespace QuantLib {

NullVariableEventInfo::NullVariableEventInfo()
:VariableEventInfo("","",false)
{

}

void NullVariableEventInfo::initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

}

bool NullVariableEventInfo::execute(bool tf)
{
	return tf;
}

}