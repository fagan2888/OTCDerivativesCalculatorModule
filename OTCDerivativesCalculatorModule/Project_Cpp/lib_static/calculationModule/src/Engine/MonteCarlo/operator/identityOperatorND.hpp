#ifndef quantlib_IdentityOperatorND_hpp
#define quantlib_IdentityOperatorND_hpp

#include <src/Engine/MonteCarlo/operator/operatorND.hpp>

namespace QuantLib {

	class IdentityOperatorND : public OperatorND
	{
		public:

			IdentityOperatorND();

			Real operationND(const std::vector<Real>& arr);
			Real operationND(const std::valarray<Real>& arr);

	};

}

#endif