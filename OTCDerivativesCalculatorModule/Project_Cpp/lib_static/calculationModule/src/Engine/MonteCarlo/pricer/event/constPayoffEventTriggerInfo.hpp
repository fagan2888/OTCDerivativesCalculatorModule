#ifndef quantlib_constPayoffEventTriggerInfo_hpp
#define quantlib_constPayoffEventTriggerInfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>
#include <ql/time/date.hpp>

namespace QuantLib {

	class ConstPayoffEventTriggerInfo : public EventTriggerInfo
	{
		public:
			//ConstPayoffEventTriggerInfo(const Date& fixingDate,
			//							const Date& payoffDate,
			//							Real constReturn);

			ConstPayoffEventTriggerInfo(const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo,
										Real constReturn,
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
			Real constReturn_;
	};

}

#endif