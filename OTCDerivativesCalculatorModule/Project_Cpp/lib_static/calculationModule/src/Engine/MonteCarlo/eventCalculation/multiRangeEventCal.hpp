#ifndef quantlib_MultiRangeEventCal_hpp
#define quantlib_MultiRangeEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceTimeCalculation.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/simpleJointCal/jointSimpleCalculation.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/rangeJointCal/range1DJointCalculation.hpp>

namespace QuantLib {

	class MultiRangeEventCal : public EventCalculation
	{
		public:
			//ReferenceCalculation에서 refRefCal이 오던가 날짜가 fix되는경우
			MultiRangeEventCal(const std::vector<boost::shared_ptr<Range1DJointCalculation>>& rangeJointCals,
							   const std::vector<boost::shared_ptr<ReferenceCalculation>>& referenceCals,
							   const boost::shared_ptr<JointSimpleCalculation>& jointRangeCal,
							   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			//ReferenceCalculation에서 날짜가 fix되지 않는 경우, fix되었다고 해도 여기서 세팅된 날짜로 계산됨
			//과거 사건에 대한 정보는 JointSimpleCalculation에 저장됨
			
			// 간단한 range 사건의 경우 여기서 처리함
			MultiRangeEventCal(const std::vector<boost::shared_ptr<Range1DJointCalculation>>& rangeJointCals,
							   const std::vector<boost::shared_ptr<ReferenceTimeCalculation>>& referenceTimeCals,
							   const boost::shared_ptr<JointSimpleCalculation>& jointRangeCal,
							   const boost::shared_ptr<DateInformation>& dateInfo,
							   const boost::shared_ptr<JointSimpleCalculation>& jointTimeCal,
							   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();;
			
			bool inRange(const std::valarray<Real>& val);

		protected:
			//Real payoffImpl(const MultiPath& path,Size endPosition);
			bool checkEventImpl(const MultiPath& path,Size endPosition);

			Size fixingAccrualNum_;
			std::valarray<Real> refValArr_;

			bool timeFlag_;
			Size timeSize_;
			std::valarray<bool> timeJointArr_;

			std::vector<boost::shared_ptr<Range1DJointCalculation>> rangeJointCals_;
			std::vector<boost::shared_ptr<ReferenceCalculation>> referenceCals_;
			std::vector<boost::shared_ptr<ReferenceTimeCalculation>> referenceTimeCals_;
			boost::shared_ptr<JointSimpleCalculation> jointRangeCal_;
			boost::shared_ptr<DateInformation> dateInfo_;
			boost::shared_ptr<JointSimpleCalculation> jointTimeCal_;

	};
}

#endif