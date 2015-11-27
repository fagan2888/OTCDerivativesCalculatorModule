#ifndef quantlib_rangeRateCalculation_hpp
#define quantlib_rangeRateCalculation_hpp

#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	class RangeRateCalulation : public RateCalculation
	{
		public:
			RangeRateCalulation(const DayCounter& dayCounter,
								const Date& calculationStartDate,
								const Date& calculationEndDate,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								const std::vector<boost::shared_ptr<EventTriggerInfo>>& rangeEventInfoList,
								bool isExpired,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList );

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;	

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();
			bool checkEvent(const MultiPath& path,Size endPosition);

		protected:
			Size rangeNum_;
			Date paymentDate_;
			std::vector<boost::shared_ptr<EventTriggerInfo>> rangeEventInfoList_;
			

	};
}

#endif