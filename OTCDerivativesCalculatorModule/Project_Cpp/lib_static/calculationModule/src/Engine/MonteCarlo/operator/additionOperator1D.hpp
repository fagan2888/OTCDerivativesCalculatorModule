#ifndef quantlib_AdditionOperator1D_hpp
#define quantlib_AdditionOperator1D_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>

namespace QuantLib {

	class AdditionOperator1D : public Operator1D
	{
		public:

			AdditionOperator1D(Real constValue);
			AdditionOperator1D(const std::string& refName);

			Real operation1D(Real value);

	};

}

#endif