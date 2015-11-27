#ifndef quantlib_mc_ireturncalculation_hpp
#define quantlib_mc_ireturncalculation_hpp

namespace QuantLib {
	class IReturnCalculation {
		public:
			virtual void initialize(const TimeGrid& timeGrid) = 0; 
			virtual void returnCalculate(const MultiPath& multiPath) = 0;
	};

}

#endif