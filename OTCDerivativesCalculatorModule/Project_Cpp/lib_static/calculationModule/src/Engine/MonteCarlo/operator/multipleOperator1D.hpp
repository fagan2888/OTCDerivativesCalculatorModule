#ifndef quantlib_MultipleOperator1D_hpp
#define quantlib_MultipleOperator1D_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>

namespace QuantLib {

	class MultipleOperator1D : public Operator1D
	{
		public:

			MultipleOperator1D(Real constValue);
			MultipleOperator1D(const std::string& refName);

			Real operation1D(Real value);

	};

}

#endif