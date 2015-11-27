#ifndef quantlib_DivisionOperatorND_hpp
#define quantlib_DivisionOperatorND_hpp

#include <src/Engine/MonteCarlo/operator/operatorND.hpp>

namespace QuantLib {

	class DivisionOperatorND : public OperatorND
	{
		public:

			DivisionOperatorND(const std::vector<Real>& weight);

			Real operationND(const std::vector<Real>& arr);
			Real operationND(const std::valarray<Real>& arr);

	};

}

#endif