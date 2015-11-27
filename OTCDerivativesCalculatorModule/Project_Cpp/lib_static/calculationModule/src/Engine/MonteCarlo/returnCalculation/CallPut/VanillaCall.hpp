#ifndef quantlib_VanillaCall_hpp
#define quantlib_VanillaCall_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/returnCalculation/CallPut/OptionPayoffFunction.hpp>

namespace QuantLib {

	class VanillaCall : public OptionPayoffFunction {
		
		public:
			VanillaCall(Real partiRate,
						Real strike,
						Real spread);
			Real calculate(Real v);
	
		private:
			Real partiRate_;
			Real strike_;
			Real spread_;
	};
}

#endif