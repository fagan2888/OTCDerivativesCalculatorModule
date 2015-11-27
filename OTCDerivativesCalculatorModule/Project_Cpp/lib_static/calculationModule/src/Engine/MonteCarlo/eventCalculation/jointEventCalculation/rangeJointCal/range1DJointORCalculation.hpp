#ifndef quantlib_Range1DJointORCalculation_hpp
#define quantlib_Range1DJointORCalculation_hpp

#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/rangeJointCal/range1DJointCalculation.hpp>

namespace QuantLib {

	// �ܼ� Range1D Set Joint ����
	class Range1DJointORCalculation : public Range1DJointCalculation
	{
		public:
			Range1DJointORCalculation(const std::vector<Range1D>& range1DList);
		
			bool jointCal(Real v);
	};
}

#endif