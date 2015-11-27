#ifndef quantlib_simplerangeconstreturntriggerinfo_hpp
#define quantlib_simplerangeconstreturntriggerinfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/time/date.hpp>

namespace QuantLib {

	class SimpleRangeConstReturnETI : public EventTriggerInfo
	{
		public:
			SimpleRangeConstReturnETI(const boost::shared_ptr<EventTriggerInfo>& rangeEvent,
										const Date& payoffDate,
										Real constReturn,
										bool isExpired);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			bool pastEventOcc();
			bool autoCallEvent(const MultiPath& path);
			bool checkEvent(const MultiPath& path);
			Real payoff(const MultiPath& path);

		private:
			boost::shared_ptr<EventTriggerInfo> rangeEvent_;
			Real constReturn_;

			//std::vector<Real> basePrice_;
	};

}

#endif