#ifndef quantlib_VanillaPut_hpp
#define quantlib_VanillaPut_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/returnCalculation/CallPut/OptionPayoffFunction.hpp>

namespace QuantLib {

	class VanillaPut : public OptionPayoffFunction {
		
		public:
			VanillaPut(Real partiRate,
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