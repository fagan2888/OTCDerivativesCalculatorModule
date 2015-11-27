#include "range1D.hpp"

namespace QuantLib {

Range1D::Range1D(Real upperBound,
				  bool upperBoundEqulity,
			   	  Real lowerBound,
				  bool lowerBoundEqulity)
: upperBound_(upperBound), upperBoundEqulity_(upperBoundEqulity),
  lowerBound_(lowerBound), lowerBoundEqulity_(lowerBoundEqulity)
{
}
						  
bool Range1D::eventOcc(Real value) const
{
	if( lowerBound_ < value && upperBound_ > value )
	{
		return true;
	}else
	{
		return false;
	}

}

}

