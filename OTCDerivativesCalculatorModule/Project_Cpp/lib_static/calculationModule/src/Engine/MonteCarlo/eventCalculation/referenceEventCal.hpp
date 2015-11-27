#ifndef quantlib_ReferenceEventCal_hpp
#define quantlib_ReferenceEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>

namespace QuantLib {

	class ReferenceEventCal : public EventCalculation
	{
		public:
			ReferenceEventCal(const std::string& refEventName,
							  const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real accrualNum(const MultiPath& path,Size endPosition) ;

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			Real payoff(const MultiPath& path);
			bool pastEventOcc();;
			bool checkEventImpl(const MultiPath& path,Size endPosition);
			bool inRange(const std::valarray<Real>& val);

		protected:

			std::string refEventName_;
			boost::shared_ptr<variableStore> refEventOccPtr_;

	};
}

#endif