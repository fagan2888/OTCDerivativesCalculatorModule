#ifndef quantlib_Range1DJointAndCalculation_hpp
#define quantlib_Range1DJointAndCalculation_hpp

#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/rangeJointCal/range1DJointCalculation.hpp>

namespace QuantLib {

	// �ܼ� Range1D Set Joint ����
	class Range1DJointAndCalculation : public Range1DJointCalculation
	{
		public:
			Range1DJointAndCalculation(const std::vector<Range1D>& range1DList);

			bool jointCal(Real v);
	};
}

#endif