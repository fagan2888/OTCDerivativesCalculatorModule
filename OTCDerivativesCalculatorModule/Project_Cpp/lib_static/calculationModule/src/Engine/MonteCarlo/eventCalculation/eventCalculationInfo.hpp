#ifndef quantlib_EventCalculationInfo_hpp
#define quantlib_EventCalculationInfo_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/simpleJointCal/all.hpp>

namespace QuantLib {

	class EventCalculationInfo : public EventCalculation
	{
		public:
			//ReferenceCalculation에서 refRefCal이 오던가 날짜가 fix되는경우
			EventCalculationInfo(const std::vector<boost::shared_ptr<EventCalculation>>& eventList,
								 const boost::shared_ptr<JointSimpleCalculation>& jointSimpleCal,
								 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real accrualNum(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();;
			
		protected:
			//Real payoffImpl(const MultiPath& path,Size endPosition);
			bool checkEventImpl(const MultiPath& path,Size endPosition);

			std::valarray<Real> calValArr_;
			Size eventNum_;

			std::vector<boost::shared_ptr<EventCalculation>> eventList_;
			boost::shared_ptr<JointSimpleCalculation> jointSimpleCal_;

	};
}

#endif