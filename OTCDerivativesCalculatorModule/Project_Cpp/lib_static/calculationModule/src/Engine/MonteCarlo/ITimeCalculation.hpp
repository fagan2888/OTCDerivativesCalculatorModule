#ifndef quantlib_ITimeCalculation_hpp
#define quantlib_ITimeCalculation_hpp

#include <ql/methods/montecarlo/multipath.hpp>
#include <valarray>

namespace QuantLib {

	class ITimeCalculation
	{
		public:

			virtual ~ITimeCalculation() { }

			//virtual Real calSlice(const MultiPath& path,Size position) = 0; 
			virtual Real calSlice(const std::valarray<Real>& val) = 0; 

	};

}

#endif