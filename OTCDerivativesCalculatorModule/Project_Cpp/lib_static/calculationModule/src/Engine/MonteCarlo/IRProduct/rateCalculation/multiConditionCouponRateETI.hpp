#ifndef quantlib_MultiConditionCouponRateETI_hpp
#define quantlib_MultiConditionCouponRateETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	class MultiConditionCouponRateETI : public RateCalculation
	{
		public:
			MultiConditionCouponRateETI(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalcList,
										const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalcList,
										QuantLib::DayCounter dayCounter,
										const Date& calculationStartDate,
										const Date& calculationEndDate,
										//const boost::shared_ptr<FixingDateInfo>& calculationStartDateInfo,
										//const boost::shared_ptr<FixingDateInfo>& calculationEndDateInfo,
										//const boost::shared_ptr<FixingDateInfo>& fixingDateInfo,

										// autoCall을 해야대나
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
			std::vector<boost::shared_ptr<EventCalculation>> eventCalcList_;
			std::vector<boost::shared_ptr<ReturnCalculation>> returnCalcList_;
			//boost::shared_ptr<FixingDateInfo> calculationStartDateInfo_;
			//boost::shared_ptr<FixingDateInfo> calculationEndDateInfo_;
			boost::shared_ptr<FixingDateInfo> payoffDateInfo_;

			bool isExpired_;
	};
}

#endif