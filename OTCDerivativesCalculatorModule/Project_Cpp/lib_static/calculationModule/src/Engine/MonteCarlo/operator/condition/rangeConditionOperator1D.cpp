#include "RangeConditionOperator1D.hpp"

namespace QuantLib {

RangeConditionOperator1D::RangeConditionOperator1D(const boost::shared_ptr<Range1D>& range1D,
													Real constValue)
: Operator1D(constValue) , range1D_(range1D)
{

}

RangeConditionOperator1D::RangeConditionOperator1D(const boost::shared_ptr<Range1D>& range1D,
													const std::string& refName)
: Operator1D(refName) , range1D_(range1D)
{

}

Real RangeConditionOperator1D::operation1D(Real v)
{
	Real value = 0.0;

	bool tf = this->range1D_->eventOcc(v);

	if ( tf )
	{
		if ( this->refFlag_ )
		{
			value = 0.0;

		}else
		{
			value = this->constValue_;
		}
	
	}

	return value;

}

}
