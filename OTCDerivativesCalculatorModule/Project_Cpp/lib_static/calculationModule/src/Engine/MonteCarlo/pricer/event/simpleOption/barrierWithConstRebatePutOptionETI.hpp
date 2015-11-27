#ifndef quantlib_BarrierWithConstRebatePutOptionETI_hpp
#define quantlib_BarrierWithConstRebatePutOptionETI_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>

namespace QuantLib {

	// 이건 전체 Barrier임 부분 배리어는 따로 만듬
	class BarrierWithConstRebatePutOptionETI : public EventTriggerInfo
	{
		public:
			BarrierWithConstRebatePutOptionETI(double partiRate,
						   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
						   const boost::shared_ptr<ReferenceCalculation>& referenceCal,
						   const boost::shared_ptr<EventTriggerInfo>& barrierInfo,
						   double strike,
						   double lowerBound,
						   double rebateRate,
						   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);
			
			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;			

			bool pastEventOcc();

			bool checkEvent(const MultiPath& path,Size endPosition);

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);

		private:
			double partiRate_;
			double strike_;
			double lowerBound_;
			double rebateRate_;

			boost::shared_ptr<ReferenceCalculation> referenceCal_;
			boost::shared_ptr<EventTriggerInfo> barrierInfo_;
	};

}

#endif