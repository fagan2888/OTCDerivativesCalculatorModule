#ifndef quantlib_constBarrierEventInfo_hpp
#define quantlib_constBarrierEventInfo_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>

namespace QuantLib {

	// 이건 전체 Barrier임 부분 배리어는 따로 만듬
	class CompositeSumOptionETI : public EventTriggerInfo
	{
		public:
			//CompositeSumOptionETI(const Date& fixingDate,
			//					  const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
			//					  const boost::shared_ptr<ReferenceCalculation> referenceCal,
			//					  const std::vector<boost::shared_ptr<EventTriggerInfo>>& optionList,
			//					  const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);
			
			CompositeSumOptionETI(const boost::shared_ptr<ReferenceCalculation> referenceCal,
								  const std::vector<boost::shared_ptr<EventTriggerInfo>>& optionList,
								  const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			CompositeSumOptionETI(const boost::shared_ptr<ReferenceCalculation> referenceCal,
								  const std::vector<boost::shared_ptr<EventTriggerInfo>>& optionList);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;


			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			bool pastEventOcc();

			bool checkEvent(const MultiPath& path,Size endPosition);

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);


		private:
			Size optionListNum_;
			
			std::vector<boost::shared_ptr<EventTriggerInfo>> optionList_;
			

	};

}

#endif