#ifndef quantlib_MultiConditionAccrualCouponRateETI_hpp
#define quantlib_MultiConditionAccrualCouponRateETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	class MultiConditionAccrualCouponRateETI : public RateCalculation
	{
		public:
			MultiConditionAccrualCouponRateETI(const DayCounter& dayCounter,
											const std::vector<boost::shared_ptr<Range1D>>& range1DList,
											const std::vector<boost::shared_ptr<ReferenceCalculation>>& refCalcList,
											const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalcList,
											Real accrualDateNum,
											const boost::shared_ptr<DateInformation>& dateInfo, // interval 용.
											const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
											bool isExpired,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

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

			std::vector<boost::shared_ptr<Range1D>> range1DList_;
			std::vector<boost::shared_ptr<ReferenceCalculation>> refCalcList_;
			std::vector<boost::shared_ptr<ReturnCalculation>> returnCalcList_;
			
			boost::shared_ptr<DateInformation> dateInfo_; // interval 용.
			std::valarray<Size> fixingDatePosition_;
			boost::shared_ptr<FixingDateInfo> payoffDateInfo_;
			
			Real accrualDateNum_; // 이게 나누는 숫자

			bool isExpired_;
	};
}

#endif