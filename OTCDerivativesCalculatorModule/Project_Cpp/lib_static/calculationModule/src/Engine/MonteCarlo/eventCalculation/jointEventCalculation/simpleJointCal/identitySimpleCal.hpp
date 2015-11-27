#ifndef quantlib_IdentityEventCal_hpp
#define quantlib_IdentityEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/simpleJointCal/jointSimpleCalculation.hpp>

namespace QuantLib {

class IdentitySimpleCal : public JointSimpleCalculation
{
	
	public:
		IdentitySimpleCal(bool pastOcc = false);

		bool jointCal(const std::valarray<bool>& tfs);

		// Accrual Â÷ÀÌ ?
		bool jointCal(const std::valarray<Real>& tfs);

	private:
		bool pastOcc_;

};

}
#endif