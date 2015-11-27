#ifndef quantlib_monte_coupon_hpp
#define quantlib_monte_coupon_hpp

#include <ql/cashflows/coupon.hpp>
#include <ql/patterns/observable.hpp>
#include <ql/index.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/math/array.hpp>

namespace QuantLib {

	class MonteCoupon : public Coupon ,
						public Observer {
	public:

		MonteCoupon(const Date& paymentDate,
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
					const Date& refPeriodStart = Date() ,
					const Date& refPeriodEnd = Date(),
					bool accrual= false);
		// Coupon interface
		Real amount() const { return rate() * accrualPeriod() * nominal(); }
		Real expectedAmount(const Array& preRate,const Array& refRate) const { return expectedRate(preRate,refRate) * accrualPeriod() * nominal(); }
		void update() { notifyObservers(); }
		DayCounter dayCounter() const{return dayCounter_;};
		
		//inspector
		virtual Rate expectedRate(const Array& preRate,const Array& refRate) const = 0;

		const std::vector<boost::shared_ptr<Index> >& index() const;
		
		Real accruedAmount(const Date&) const;

	protected:
		Size NumOfIndex_;
		Size fixingDays_;

		DayCounter dayCounter_;
		std::vector<boost::shared_ptr<Index> > index_;
		Real capRate_;
		Real floorRate_;
		Real gearing_;
		Spread spread_;
		bool accrual_;
		std::vector<Date> accrualObservationDates_;
		Real totalObservations_;
		Size observationDays_;
	};

}


#endif
