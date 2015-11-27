#ifndef quantlib_SimpleEventCouponETI_hpp
#define quantlib_SimpleEventCouponETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/couponCalculation.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/eventCalculationInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/returnCalculationInfo.hpp>

namespace QuantLib {

	class SimpleEventCouponETI : public CouponCalculation
	{
		public:
			//SimpleEventCouponETI(const boost::shared_ptr<EventCalculationInfo>& eventCalInfo,
			//					const boost::shared_ptr<ReturnCalculationInfo>& returnCalInfo,
			//					const boost::shared_ptr<ReturnCalculationInfo>& complementReturnCalInfo,
			//					const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
			//					bool isExpired,
			//					const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>());

			SimpleEventCouponETI(const boost::shared_ptr<EventCalculation>& eventCal,
								const boost::shared_ptr<ReturnCalculation>& returnCal,
								const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								bool isExpired,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>());

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
			//boost::shared_ptr<EventCalculationInfo> eventCalInfo_;
			//boost::shared_ptr<ReturnCalculationInfo> returnCalInfo_;
			//boost::shared_ptr<ReturnCalculationInfo> complementReturnCalInfo_;

			boost::shared_ptr<EventCalculation> eventCal_;
			boost::shared_ptr<ReturnCalculation> returnCal_;
			boost::shared_ptr<ReturnCalculation> complementReturnCal_;
	};
}

#endif