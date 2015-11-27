#ifndef quantlib_OptionPayoffFunction_hpp
#define quantlib_OptionPayoffFunction_hpp

#include <ql/types.hpp>

namespace QuantLib {

class OptionPayoffFunction {
	public:
		virtual Real calculate(Real v) = 0;
	
};

}

#endif