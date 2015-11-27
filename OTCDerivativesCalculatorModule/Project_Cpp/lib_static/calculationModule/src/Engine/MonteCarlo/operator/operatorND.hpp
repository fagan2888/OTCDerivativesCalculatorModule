#ifndef quantlib_OperatorND_hpp
#define quantlib_OperatorND_hpp

#include <ql/types.hpp>
#include <ql/errors.hpp>
#include <string>
#include <boost/shared_ptr.hpp>
#include <vector>
#include <valarray>


namespace QuantLib {
	
	class OperatorND
	{
		public:

			virtual ~OperatorND() {}

			OperatorND(std::vector<Real> weightArr);

			virtual Real operationND(const std::vector<Real>& arr) = 0;
			virtual Real operationND(const std::valarray<Real>& arr) = 0;

		protected:
			Size arrNum_;
			std::vector<Real> weightArr_;
	};

}

#endif