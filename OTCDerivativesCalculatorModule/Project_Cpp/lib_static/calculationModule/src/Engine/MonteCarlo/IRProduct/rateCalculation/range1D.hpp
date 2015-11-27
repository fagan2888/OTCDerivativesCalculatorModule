#ifndef quantlib_range1D_hpp
#define quantlib_range1D_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
//#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	class Range1D
	{
		public:
			Range1D(Real upperBound,
					bool upperBoundEqulity,
			   		Real lowerBound,
					bool lowerBoundEqulity);
						  
			bool eventOcc(Real value) const;

			Real upperBound() { return this->upperBound_;}
			Real lowerBound() { return this->lowerBound_;}

		protected:
			Real upperBound_;
			bool upperBoundEqulity_;
			Real lowerBound_;
			bool lowerBoundEqulity_;
	};
}

#endif