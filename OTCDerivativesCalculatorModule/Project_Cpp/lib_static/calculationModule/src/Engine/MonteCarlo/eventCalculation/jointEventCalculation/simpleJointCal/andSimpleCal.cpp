#include "andSimpleCal.hpp"

namespace QuantLib {

AndSimpleCal::AndSimpleCal(bool pastOcc)
: pastOcc_(pastOcc)
{
}

bool AndSimpleCal::jointCal(const std::valarray<bool>& tfs)
{
	if ( pastOcc_ == false )
	{
		for ( Size i=0 ; i < this->jointEventSize_ ; i++)
		{
			if ( tfs[i] == false )
			{
				return false;
			}
		}

		return true;
	}
	else
	{
		return true;
	}
}


bool AndSimpleCal::jointCal(const std::valarray<Real>& tfs)
{
	if ( pastOcc_ == false )
	{
		for ( Size i=0 ; i < this->jointEventSize_ ; i++)
		{
			if ( tfs[i] == 0 )
			{
				return false;
			}
		}

		return true;
	}
	else
	{
		return true;
	}
}

}