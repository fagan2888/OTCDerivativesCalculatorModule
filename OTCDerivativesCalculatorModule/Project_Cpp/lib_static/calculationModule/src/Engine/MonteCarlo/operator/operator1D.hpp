#ifndef quantlib_Operator1D_hpp
#define quantlib_Operator1D_hpp

#include <ql/types.hpp>
#include <string>
#include <boost/shared_ptr.hpp>

namespace QuantLib {

	class Operator1D
	{
		public:

			virtual ~Operator1D() {}

			Operator1D(Real constValue);
			Operator1D(const std::string& refName);

			virtual Real operation1D(Real v) = 0;

		protected:

			Real constValue_;
			std::string refName_;
			bool refFlag_;
			boost::shared_ptr<Real> ref_;
	};

}

#endif