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
										const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										Real constReturn,
										bool isExpired,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();
			bool autoCallEvent(const MultiPath& path);
			bool checkEvent(const MultiPath& path,Size endPosition);

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);

		private:
			boost::shared_ptr<EventTriggerInfo> rangeEvent_;
			Real constReturn_;

			//std::vector<Real> basePrice_;
	};

}

#endif