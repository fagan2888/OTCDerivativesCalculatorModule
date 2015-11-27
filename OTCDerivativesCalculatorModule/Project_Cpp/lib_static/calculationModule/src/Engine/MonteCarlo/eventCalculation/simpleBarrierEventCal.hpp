#ifndef quantlib_SimpleBarrierEventCal_hpp
#define quantlib_SimpleBarrierEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>

namespace QuantLib {

	class SimpleBarrierEventCal : public EventCalculation
	{
		public:
			SimpleBarrierEventCal(const boost::shared_ptr<EventTriggerInfo>& barrier,
								  const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList );

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real accrualNum(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();;
			bool checkEventImpl(const MultiPath& path,Size endPosition);
			bool inRange(const std::valarray<Real>& val);

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);
			boost::shared_ptr<EventTriggerInfo> barrier_;
			Size fixingAccrualNum_;

	};
}

#endif