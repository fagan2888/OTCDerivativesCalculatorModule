#ifndef quantlib_referenceTimeCalculation_hpp
#define quantlib_referenceTimeCalculation_hpp

#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/ITimeCalculation.hpp>

namespace QuantLib {

	class ReferenceTimeCalculation : public ReferenceCalculation , public ITimeCalculation
	{
		public:
			ReferenceTimeCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);
	};

}

#endif