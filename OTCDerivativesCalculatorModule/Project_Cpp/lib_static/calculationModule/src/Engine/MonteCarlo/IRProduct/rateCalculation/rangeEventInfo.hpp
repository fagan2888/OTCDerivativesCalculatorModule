#ifndef quantlib_rangeEventInfo_hpp
#define quantlib_rangeEventInfo_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>

namespace QuantLib {

	class RangeEventInfo : public EventTriggerInfo
	{
		public:
			RangeEventInfo(const boost::shared_ptr<EventTriggerInfo>& rangeEvent,
							const boost::shared_ptr<EventTriggerInfo>& couponCalculation,
							const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			//virtual ~RateCalculation(){}

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);;

		protected:
			boost::shared_ptr<EventTriggerInfo> rangeEvent_;
			boost::shared_ptr<EventTriggerInfo> couponCalculation_;
			

	};
}

#endif