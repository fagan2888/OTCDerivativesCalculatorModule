#ifndef quantlib_AdditionOperatorND_hpp
#define quantlib_AdditionOperatorND_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/operator/operatorND.hpp>

namespace QuantLib {

	class AdditionOperatorND : public OperatorND
	{
		public:
			AdditionOperatorND(const std::vector<Real>& weight);

			Real operationND(const std::vector<Real>& arr);
			Real operationND(const std::valarray<Real>& arr);

	};

}

#endif