#include "Range1DJointAndCalculation.hpp"

namespace QuantLib {

Range1DJointAndCalculation::Range1DJointAndCalculation(const std::vector<Range1D>& range1DList)
: Range1DJointCalculation(range1DList)
{
	
}

bool Range1DJointAndCalculation::jointCal(Real v)
{
	for(Size i=0 ; i < this->jointEventSize_; i++)
	{
		bool tf = this->range1DList_[i].eventOcc(v);
		
		if ( tf != false )
			return false;
			
	}

	return true;
}

}