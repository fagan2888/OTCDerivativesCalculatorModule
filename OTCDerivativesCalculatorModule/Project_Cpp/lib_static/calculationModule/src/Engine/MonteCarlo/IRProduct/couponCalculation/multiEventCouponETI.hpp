#ifndef quantlib_MultiEventCouponETI_hpp
#define quantlib_MultiEventCouponETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/couponCalculation.hpp>

namespace QuantLib {

	class MultiEventCouponETI : public CouponCalculation
	{
		public:
			MultiEventCouponETI(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
								const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalList,
								const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								bool isExpired,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();
			bool checkEvent(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

		private:
			Size multiEventSize_;
			std::vector<boost::shared_ptr<EventCalculation>> eventCalList_;
			std::vector<boost::shared_ptr<ReturnCalculation>> returnCalList_;

			boost::shared_ptr<ReturnCalculation> complementReturnCal_;
	};
}

#endif