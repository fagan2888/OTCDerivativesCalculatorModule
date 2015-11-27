#ifndef quantlib_vanillaCouponETI_hpp
#define quantlib_vanillaCouponETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/couponCalculation.hpp>


namespace QuantLib {

	class VanillaCouponETI : public CouponCalculation
	{
		public:
			VanillaCouponETI(Real gearing,
							Real spread,
							const boost::shared_ptr<ReturnCalculation>& returnCal,
							const boost::shared_ptr<FixingDateInfo>& payoffDate,
							bool isExpired,
							const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

		protected:
			boost::shared_ptr<EventTriggerInfo> couponCalculation_;
			Real gearing_;
			Real spread_;
	};
}

#endif