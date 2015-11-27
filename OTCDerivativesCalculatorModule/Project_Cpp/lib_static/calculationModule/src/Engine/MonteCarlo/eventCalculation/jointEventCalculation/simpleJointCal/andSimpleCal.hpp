#ifndef quantlib_AndEventCal_hpp
#define quantlib_AndEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/simpleJointCal/jointSimpleCalculation.hpp>

namespace QuantLib {

class AndSimpleCal : public JointSimpleCalculation
{
	
	public:
		AndSimpleCal(bool pastOcc = false);

		bool jointCal(const std::valarray<bool>& tfs);

		// Accrual Â÷ÀÌ ?
		bool jointCal(const std::valarray<Real>& tfs);

	private:
		bool pastOcc_;

};

}
#endif