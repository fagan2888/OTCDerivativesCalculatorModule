#ifndef quantlib_MaximumOperator1D_hpp
#define quantlib_MaximumOperator1D_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>

namespace QuantLib {

	class MaximumOperator1D : public Operator1D
	{
		public:

			MaximumOperator1D(Real constValue);
			MaximumOperator1D(const std::string& refName);

			Real operation1D(Real value);

	};

}

#endif