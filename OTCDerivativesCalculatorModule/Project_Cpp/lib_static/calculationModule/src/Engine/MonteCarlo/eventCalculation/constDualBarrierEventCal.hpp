#ifndef quantlib_constdualbarriereventInfo_hpp
#define quantlib_constdualbarriereventInfo_hpp

#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/dateInformation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>

namespace QuantLib {

	class ConstDualBarrierETI : public EventTriggerInfo
	{
		public:
			// reference를 정의 하면 그걸로 하고
			ConstDualBarrierETI(const boost::shared_ptr<DateInformation>& barrierDateInfo,
								const boost::shared_ptr<ReferenceCalculation>& referenceCal,
								Real upperBarrier,
								Real lowerBarrier,
								Date pastEventOccDate,
								Real pastEventOccValue,
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
			Real upperBarrier_;
			Real lowerBarrier_;
			boost::shared_ptr<DateInformation> barrierDateInfo_;

			Date pastEventOccDate_;
			Real pastEventOccValue_;
	};

}

#endif