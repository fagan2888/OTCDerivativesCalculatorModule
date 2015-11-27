#ifndef quantlib_SimpleRangeAccrualRateETI_hpp
#define quantlib_SimpleRangeAccrualRateETI_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/simpleRangeEvent.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	class SimpleRangeAccrualRateETI : public RateCalculation
	{
		public:
			SimpleRangeAccrualRateETI(const DayCounter& dayCounter,
									const Date& calculationStart,
									const Date& calculationEnd,
									const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
									const boost::shared_ptr<ReferenceCalculation>& referenceCalculation,
									const std::vector<boost::shared_ptr<SimpleRangeEvent>>& simpleRangeRateList,
									Size denumerDateNum,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);;

		protected:
			boost::shared_ptr<ReferenceCalculation> referenceCalculation_;
			std::vector<boost::shared_ptr<SimpleRangeEvent>> simpleRangeRateList_;
			
			Size denumerDateNum_;
			Size rangeNum_;

	};
}

#endif