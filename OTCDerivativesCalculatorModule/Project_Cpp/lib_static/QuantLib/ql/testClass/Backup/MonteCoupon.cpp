//#include <ql/time/daycounter.hpp>
#include <ql/testClass/MonteCoupon.hpp>

namespace QuantLib {
	
	MonteCoupon::MonteCoupon(const Date& paymentDate,
					Real nominal,			
					const Date& startDate,
                    const Date& endDate,
					Natural fixingDays,
					std::vector<boost::shared_ptr<Index>>& index,
					const DayCounter& dayCounter,
					Real gearing,
                    Spread spread,
					Real capRate,
					Real floorRate,
					const Date& refPeriodStart,
					const Date& refPeriodEnd,
					bool accrual)
				: Coupon(paymentDate, nominal,startDate, endDate,refPeriodStart,refPeriodEnd) ,
			index_(index),dayCounter_(dayCounter),gearing_(gearing), spread_(spread),
			capRate_(capRate),floorRate_(floorRate),accrual_(accrual) {
	
		/*registerWith(index_);
        registerWith(Settings::instance().evaluationDate());*/
		
		QL_REQUIRE(gearing_!=0, "Null gearing not allowed");
		QL_REQUIRE(capRate>floorRate, "capRate must be larger than floorRate");
		QL_REQUIRE(index[0], "Index must be given");

		totalObservations_=1.0;
		observationDays_=accrualEndDate_.serialNumber() - accrualStartDate_.serialNumber();
		//QL_REQUIRE(!dayCounter_==Null(), "Coupon must have a dayCounter");

		if(accrual)	{
			totalObservations_=365.0;
			Calendar calendar=index[0]->fixingCalendar();
			//BigInteger observationDays_=dayCounter.dayCount(startDate,endDate);
			Size observationDays_=accrualDays();
			for(Size i=0;i<observationDays_;++i){
					//endOfMonth 가 모지...
					Date nextDate = calendar.advance(startDate,i,Days);
					accrualObservationDates_.push_back(nextDate);
			}
		}
	}

    Real MonteCoupon::accruedAmount(const Date& d) const {
        if (d <= accrualStartDate_ || d > paymentDate_ ) {
            return 0.0;
        } else {
            return nominal() * rate();
			
            /* rate()에서 Accrual 알아서 되서 나옴     *dayCounter().yearFraction(accrualStartDate_,
                                          std::min(d, accrualEndDate_),
                                          refPeriodStart_,
                                          refPeriodEnd_);//이부분 어떻게 처리?*/
        }
    }
	 const std::vector<boost::shared_ptr<Index> >& MonteCoupon::index() const{
		return index_;
	 }
}

