#ifndef quantlib_vanillaPutEventInfo_hpp
#define quantlib_vanillaPutEventInfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>

namespace QuantLib {

	// 이건 전체 Barrier임 부분 배리어는 따로 만듬
	// 
	class VanillaPutETI : public EventTriggerInfo
	{
		public:
			VanillaPutETI(double partiRate,
						const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
						const boost::shared_ptr<ReferenceCalculation>& referenceCal,
						double strike,
						double lowerBound,
						const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			//VanillaPutETI(double unit,
			//			const Date& fixingDate,
			//			const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
			//			double strike);

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
			boost::shared_ptr<ReferenceCalculation> referenceCal_;

	};

}

#endif