/*! \file PowerSpreadCoupon.hpp
    \brief Coupon paying a variable index-based rate
*/

#ifndef quantlib_power_spread_coupon_hpp
#define quantlib_power_spread_coupon_hpp

#include <ql/testclass/montecoupon.hpp>

namespace QuantLib {

    class InterestRateIndex;

    //! base floating-rate coupon class
    class PowerSpreadCoupon : public MonteCoupon {
      public:
        PowerSpreadCoupon(const Date& paymentDate,
                           Real nominal,
                           const Date& startDate,
                           const Date& endDate,
                           Natural fixingDays,
						   std::vector<boost::shared_ptr<Index>>& index,
						   const DayCounter& dayCounter,
						   Real gearing = 1.0,
                           Spread spread = 0.0,
						   Real capRate = 1.0,
						   Real floorRate = 0.0,
						   const Date& refPeriodStart = Date(),
                           const Date& refPeriodEnd = Date(),
						   bool accrual = false,
                           bool isInArrears = false);

        //! \name Coupon interface
        //@{
        Rate rate() const;
		
		//const std::vector<boost::shared_ptr<InterestRateIndex> >& index() const;

		//! \name MonteCoupon interface
		Rate expectedRate(const Array& preRate,const Array& refRate) const;
	
      protected:
        //! convexity adjustment for the given index fixing
		//std::vector<boost::shared_ptr<InterestRateIndex> >& index_;

		bool isInArrears_;
		
    };

    // inline definitions

	

	/*inline const std::vector<Rate>& RangeAccrualCoupon::convexityAdjustment() const {
	
		return convexityAdjustmentImpl(indexFixing());
    }*/

    //inline boost::shared_ptr<RangeAccrualCouponPricer>
    //RangeAccrualCoupon::pricer() const {
    //    return pricer_;
    //}

    //inline Rate
    //RangeAccrualCoupon::convexityAdjustmentImpl(Rate fixing) const {
    //    return (gearing() == 0.0 ? 0.0 : adjustedFixing()-fixing);
    //}


}

#endif
