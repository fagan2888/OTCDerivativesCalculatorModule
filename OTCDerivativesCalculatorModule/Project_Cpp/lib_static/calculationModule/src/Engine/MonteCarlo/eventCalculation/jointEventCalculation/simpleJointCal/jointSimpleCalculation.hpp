#ifndef quantlib_JointSimpleCalculation_hpp
#define quantlib_JointSimpleCalculation_hpp

#include <ql/types.hpp>
#include <valarray>

namespace QuantLib {

	class JointSimpleCalculation
	{
		public:
			virtual bool jointCal(const std::valarray<bool>& tfs) = 0;
			virtual bool jointCal(const std::valarray<Real>& tfs) = 0;

		protected:
			Size jointEventSize_;

	};
}

#endif