#include "Range1DJointORCalculation.hpp"

namespace QuantLib {

Range1DJointORCalculation::Range1DJointORCalculation(const std::vector<Range1D>& range1DList)
: Range1DJointCalculation(range1DList)
{
	
}

bool Range1DJointORCalculation::jointCal(Real v)
{
	for(Size i=0 ; i < this->jointEventSize_; i++)
	{
		bool tf = this->range1DList_[i].eventOcc(v);
		
		if ( tf != true )
			return true;
			
	}

	return false;
}

}