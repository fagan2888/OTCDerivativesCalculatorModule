#ifndef quantlib_autocallconstreturneventtriggerinfo_hpp
#define quantlib_autocallconstreturneventtriggerinfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/time/date.hpp>

namespace QuantLib {

	class AutoCallConstReturnEventTriggerInfo : public EventTriggerInfo
	{
		public:
			AutoCallConstReturnEventTriggerInfo(const boost::shared_ptr<FixingDateInfo>& fixingDateInfo,
												const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
												Real constReturn,
												//std::vector<Real> basePrice,
												Real trigger,
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
			void reset();

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);

		private:
			Real constReturn_;
			Real trigger_;
			Size pathSize_;
			bool isFixed_;
			bool autoCallEventFlag_;
			//std::vector<Real> basePrice_;
	};

}

#endif