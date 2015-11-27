/*! \file RangeCoupon.hpp
    \brief Coupon paying a variable index-based rate
*/

#ifndef quantlib_fixed_mc_coupon_hpp
#define quantlib_fixed_mc_coupon_hpp

#include <ql/testclass/montecoupon.hpp>
#include <ql/interestrate.hpp>

namespace QuantLib {

    class InterestRateIndex;

    //! base floating-rate coupon class
    class FixedCoupon : public MonteCoupon {
      public:
        FixedCoupon(Real nominal,
                   const Date& startDate,
                   const Date& endDate,
                   Natural fixingDays,
                   Real fixedRate,
				   const DayCounter& dayCounter);

        //! \name Coupon interface
        //@{
		Rate rate() const { return rate_; }
		//! \name MonteCoupon interface
		Rate expectedRate(const Array& preRate,const Array& refRate) const;
		Rate InRangeTime(Real preRate,Real refRate,Real up,Real down) const;
		Real accruedAmount(const Date&) const;

      protected:
        //! convexity adjustment for the given index fixing
       InterestRate rate_;		
    };


}

#endif
