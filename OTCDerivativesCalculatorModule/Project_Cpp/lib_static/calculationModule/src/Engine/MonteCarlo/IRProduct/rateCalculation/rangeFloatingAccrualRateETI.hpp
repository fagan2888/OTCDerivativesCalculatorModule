#ifndef quantlib_RangeFloatingAccrualRateETI_hpp
#define quantlib_RangeFloatingAccrualRateETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/couponCalculation.hpp>

namespace QuantLib {

	class RangeFloatingAccrualRateETI : public CouponCalculation
	{
		public:
			RangeFloatingAccrualRateETI(const boost::shared_ptr<EventCalculation>& eventCal,
								const boost::shared_ptr<ReturnCalculation>& returnCal,
								const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								bool isExpired,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real payoffImpl(const MultiPath& path,Size endPosition);
			//Real payoffImplEarlyEx(const MultiPath& path,Size endPosition);

			bool pastEventOcc();
			bool checkEvent(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

		private:
			bool eventOcc_;
			boost::shared_ptr<EventCalculation> eventCal_;
			boost::shared_ptr<ReturnCalculation> complementReturnCal_;
	};
}

#endif