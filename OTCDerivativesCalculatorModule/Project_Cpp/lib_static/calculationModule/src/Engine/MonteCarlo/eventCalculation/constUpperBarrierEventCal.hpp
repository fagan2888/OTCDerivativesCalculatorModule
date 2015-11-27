#ifndef quantlib_constupperbarriereventInfo_hpp
#define quantlib_constupperbarriereventInfo_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/dateInformation.hpp>

namespace QuantLib {

	// 이건 전체 Barrier임 부분 배리어는 따로 만듬
	class ConstUpperBarrierETI : public EventTriggerInfo
	{
		public:
			ConstUpperBarrierETI(const boost::shared_ptr<DateInformation>& barrierDateInfo,
								const boost::shared_ptr<ReferenceCalculation>& referenceCal,
								Real barrier,
								Date pastEventOccDate,
								Real pastEventOccValue,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();

			//bool autoCallEvent(const MultiPath& path);
			bool checkEvent(const MultiPath& path,Size endPosition);

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);

		private:
			Real barrier_;
			boost::shared_ptr<DateInformation> barrierDateInfo_;

			Date pastEventOccDate_;
			Real pastEventOccValue_;
	};

}

#endif