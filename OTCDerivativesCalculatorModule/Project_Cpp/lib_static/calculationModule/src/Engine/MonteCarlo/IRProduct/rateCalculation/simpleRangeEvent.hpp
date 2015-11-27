#ifndef quantlib_simpleRangeEvent_hpp
#define quantlib_simpleRangeEvent_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>

namespace QuantLib {

	class SimpleRangeEvent : public EventTriggerInfo
	{
		public:
			SimpleRangeEvent(const boost::shared_ptr<ReferenceCalculation>& refCal,
							const boost::shared_ptr<Range1D>& range1D,
							const boost::shared_ptr<ReturnCalculation>& returnCalculation,
							const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							    const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);
			bool inRange(const std::valarray<Real>& val);

		protected:

			Real payoffImpl(const MultiPath& path,Size endPosition);

			boost::shared_ptr<ReferenceCalculation> refCal_;
			boost::shared_ptr<Range1D> range1D_;
			boost::shared_ptr<ReturnCalculation> returnCalculation_;
			Size fixingAccrualNum_;


	};
}

#endif