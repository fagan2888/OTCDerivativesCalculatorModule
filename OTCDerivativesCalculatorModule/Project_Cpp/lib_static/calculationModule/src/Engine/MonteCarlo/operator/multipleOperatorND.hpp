#ifndef quantlib_MultipleOperatorND_hpp
#define quantlib_MultipleOperatorND_hpp

#include <src/Engine/MonteCarlo/operator/operatorND.hpp>

namespace QuantLib {

	class MultipleOperatorND : public OperatorND
	{
		public:

			MultipleOperatorND(const std::vector<Real>& weight);

			Real operationND(const std::vector<Real>& arr);
			Real operationND(const std::valarray<Real>& arr);

	};

}

#endif