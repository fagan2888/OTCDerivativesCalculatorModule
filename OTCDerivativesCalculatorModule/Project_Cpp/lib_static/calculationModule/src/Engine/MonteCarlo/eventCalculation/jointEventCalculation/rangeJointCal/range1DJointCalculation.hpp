#ifndef quantlib_RangeJointCalculation_hpp
#define quantlib_RangeJointCalculation_hpp

#include <ql/types.hpp>
#include <vector>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>

namespace QuantLib {

	// �ܼ� Range1D Set Joint ����
	class Range1DJointCalculation
	{
		public:
			Range1DJointCalculation(const std::vector<Range1D>& range1DList);

			virtual bool jointCal(Real v) = 0;

		protected:
			Size jointEventSize_;
			std::vector<Range1D> range1DList_;

	};
}

#endif