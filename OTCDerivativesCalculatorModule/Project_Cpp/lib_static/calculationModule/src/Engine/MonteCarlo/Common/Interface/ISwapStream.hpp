#ifndef quantlib_mc_iswapstream_hpp
#define quantlib_mc_iswapstream_hpp

namespace QuantLib {
	class ISwapStream {
		public:
			virtual void initialize(const TimeGrid& timeGrid) = 0; 
			virtual bool accrualFlag() = 0;
			virtual Real accrualCoupon(Size k) = 0;

	};

}

#endif