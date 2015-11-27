/*! \file RangeCoupon.hpp
    \brief Coupon paying a variable index-based rate
*/

#ifndef quantlib_range_accrual_coupon_hpp
#define quantlib_range_accrual_coupon_hpp

#include <ql/testclass/montecoupon.hpp>


namespace QuantLib {

    class InterestRateIndex;

    //! base floating-rate coupon class
    class RangeCoupon : public MonteCoupon {
      public:
        RangeCoupon(Real nominal,
                   const Date& startDate,
                   const Date& endDate,
                   Natural fixingDays,
                   Real couponRate,
				   const std::vector<Real>& upperTrigger,
				   const std::vector<Real>& lowerTrigger,
				   const DayCounter& dayCounter,
				   std::vector<boost::shared_ptr<Index>>& index,
				   Real gearing = 1.0,
                   Spread spread = 0.0,
				   Real capRate = 1.0,
				   Real floorRate = -1.0,
				   bool accrual = false);

        //! \name Coupon interface
        //@{
        Rate rate() const;
		
		//const std::vector<boost::shared_ptr<InterestRateIndex> >& index() const;

		//! \name MonteCoupon interface
		//Rate expectedRate(const Array& preRate,const Array& nextRate) const;
		Rate expectedRate(const Array& preRate,const Array& refRate) const;
		Rate expectedArrRate(const Array& preRate,const Array& refRate) const;
		Rate InRangeTime(Real preRate,Real refRate,Real up,Real down) const;
	
      protected:
        //! convexity adjustment for the given index fixing
		//std::vector<boost::shared_ptr<InterestRateIndex> >& index_;

		std::vector<Real> upperTrigger_;
		std::vector<Real> lowerTrigger_;
		Real accrualRate_;
		bool isInArrears_;
		
    };

    // inline definitions

	

	/*inline const std::vector<Rate>& RangeCoupon::convexityAdjustment() const {
	
		return convexityAdjustmentImpl(indexFixing());
    }*/

    //inline boost::shared_ptr<RangeCouponPricer>
    //RangeCoupon::pricer() const {
    //    return pricer_;
    //}

    //inline Rate
    //RangeCoupon::convexityAdjustmentImpl(Rate fixing) const {
    //    return (gearing() == 0.0 ? 0.0 : adjustedFixing()-fixing);
    //}


}

#endif
