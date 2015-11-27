#ifndef quantlib_vanillaCallPutCouponETI_hpp
#define quantlib_vanillaCallPutCouponETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/couponCalculation.hpp>


namespace QuantLib {

	class VanillaCallPutCouponETI : public CouponCalculation
	{
		public:
			VanillaCallPutCouponETI(bool callPut,
									Real partiRate,
									Real strike,
									Real spread,
									const boost::shared_ptr<ReferenceCalculation>& refCal,
									const boost::shared_ptr<FixingDateInfo>& payoffDate,
									bool isExpired,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>());

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

			Real partiRate_;
			Real strike_;
			Real spread_;
			bool callPut_;
	};
}

#endif