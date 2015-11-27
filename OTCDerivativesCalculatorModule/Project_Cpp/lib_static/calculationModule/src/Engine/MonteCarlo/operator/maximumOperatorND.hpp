#ifndef quantlib_MaximumOperatorND_hpp
#define quantlib_MaximumOperatorND_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/operator/operatorND.hpp>

namespace QuantLib {

	class MaximumOperatorND : public OperatorND
	{
		public:
			MaximumOperatorND(const std::vector<Real>& weight);
			
			Real operationND(const std::vector<Real>& arr);
			Real operationND(const std::valarray<Real>& arr);

	};

}

#endif