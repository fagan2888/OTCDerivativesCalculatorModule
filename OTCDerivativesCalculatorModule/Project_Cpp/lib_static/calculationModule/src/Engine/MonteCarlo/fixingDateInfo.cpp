#include "fixingDateInfo.hpp"

namespace QuantLib {

FixingDateInfo::FixingDateInfo(bool autoCallFixing,
								const Date& autoCallFixingDate)
: autoCallFixing_(autoCallFixing), autoCallFixingDate_(autoCallFixingDate)
{
		
}

}