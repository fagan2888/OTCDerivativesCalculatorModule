#ifndef quantlib_AutoTerminationETI_hpp
#define quantlib_AutoTerminationETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>

namespace QuantLib {

	class AutoTerminationETI : public EventTriggerInfo
	{
		public:
			//AutoTerminationETI(const boost::shared_ptr<EventCalculationInfo>& eventCalInfo,
			//					const boost::shared_ptr<ReturnCalculationInfo>& returnCalInfo,
			//					const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
			//					const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>());

			AutoTerminationETI(const boost::shared_ptr<EventCalculation>& eventCal,
								const boost::shared_ptr<ReturnCalculation>& returnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>());

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);
			Date paymentDate_;

			//boost::shared_ptr<EventCalculationInfo> eventCalInfo_;
			//boost::shared_ptr<ReturnCalculationInfo> returnCalInfo_;
			boost::shared_ptr<EventCalculation> eventCal_;
			boost::shared_ptr<ReturnCalculation> returnCal_;
	};
}

#endif