#ifndef quantlib_eventTriggerInfo_hpp
#define quantlib_eventTriggerInfo_hpp

#include <ql/timegrid.hpp>
#include <src/util/ConvertFunction.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculationInfo.hpp>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/dateInformation.hpp>
#include <src/Engine/MonteCarlo/fixingDateInfo.hpp>
#include <src/Engine/MonteCarlo/IRefVariable.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/returnCalculationInfo.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/eventCalculationInfo.hpp>
#include <src/Engine/MonteCarlo/preEventCalculation/preEventCalculation.hpp>
#include <src/Engine/MonteCarlo/preEventCalculation/preConditionEvent.hpp>
#include <src/Engine/MonteCarlo/pricer/additionalOption/additionalOption.hpp>

namespace QuantLib {

	class EventTriggerInfo : public IRefVariable
	{
		public:
			
			virtual ~EventTriggerInfo(){}

			EventTriggerInfo(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			// payoff 
			Real payoff(const MultiPath& path,Size endPosition);
			Real payoffEarlyEx(const MultiPath& path,Size endPosition);
			//Real payoffEarlyEx(const MultiPath& path,Size endPosition);

			virtual Real discount() { return this->payoffDateInfo_->discount();}
			
			// discount 랑 곱해서 같이 떨궈져 나옴. // payoff발생이 unpredictable인경우 새로 구현함
			virtual Real NPV(const MultiPath& path,Size endPosition) 
				{ return this->payoff(path,endPosition) * this->discount(); }

			virtual Real accrualRate(const MultiPath& path,const Date& refDate) const { return 0.0; }
			virtual Real accrualAmount() const { return 0.0; }

			//pure virtual
			virtual bool pastEventOcc() = 0;
			virtual bool checkEvent(const MultiPath& path,Size endPosition = 0) = 0;
			//virtual bool checkEventEarlyEx(const MultiPath& path,Size endPosition) = 0;
			
			//virtual bool autoCallEvent(const MultiPath& path) { return false;}
			virtual bool autoCallEvent();
			virtual Size autoCallEventPosition();

			virtual Real autoCallPayoff(const MultiPath& path,Size position) { return this->payoff(path,position); }

			//여기서 refVariable regist을 하고
			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			//virtual
			//virtual void setReferenceCal(const boost::shared_ptr<ReferenceCalculation> referenceCal) { }

			virtual std::vector<Date> fixingDates() const = 0;
			virtual std::vector<Date> payoffDates() const = 0;

			virtual bool isExpired() ;

			virtual void reset() ;

			bool preCondiEvent();
			

			// --------------------------- set base function ---------------------------------------------------

			// setEventDate 
			void setEventDate(const Date& eventDate);
			Date getEventDate();
			Size getEventDatePosition();

			void setAdditionalOption(const boost::shared_ptr<AdditionalOption>& option);
			//boost::shared_ptr<AdditionalOption> getAdditionalOption();
			Size getAdditionalOption(); // 0 : none , 1 : callable , 2 : puttable

			Date getPayoffDate();
			// preEventCalculation
			void setPreEventCalcaultion(const boost::shared_ptr<PreEventCalculation>& preEventCal);
			// preConditionEvent : 이 eventTrigger의 payoff를 계산 할지 말지를 결정함
			void setPreConditionEvent(const boost::shared_ptr<PreConditionEvent>& preCondEvent);
			// autoTermination
			void setAutoTerminationETI(const boost::shared_ptr<EventTriggerInfo>& autoTerminationETI);

			//여기도 postCalculation이 있어야 하지 않나...?

			Real autoTermination(const MultiPath& path,Size endPosition = 0);
			//Real autoTerminationEarlyEx(const MultiPath& path,Size endPosition);

		protected:
			virtual Real payoffImpl(const MultiPath& path,Size endPosition) = 0;

			// accrual이라던지 새롭게 정의 하던지 그건 여기서 하고,
			// 간단한 rate accrual은 rateType 내에 accrual함수를 박아서 해결
			// 그외 모든걸 earlyEx로 내려 가면서 하는건 예측하지 않은 pricing이 나올거 같아
			// 부담이 좀 됨( 너무 깊게 내려가지 말자 )
			virtual Real payoffImplEarlyEx(const MultiPath& path,Size endPosition);

			virtual void initializeImpl(const TimeGrid& timeGrid,
									const boost::shared_ptr<YieldTermStructure>& discountCurve,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;

		protected:
			bool isExpired_;
			//bool autoCallFlag_;
			bool autoCallOccFlag_;
			bool pastEventOcc_;
			
			TimeGrid timeGrid_;
			Size assetNum_;
			Size fixingDatePositionsNum_;

			//autoCallDate 와 eventDate는 같음
			Size eventDatePosition_;

			boost::shared_ptr<ReferenceCalculation> referenceCal_;
			boost::shared_ptr<ReturnCalculation> returnCal_;

			//boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
			boost::shared_ptr<FixingDateInfo> payoffDateInfo_;

			//set from setter
			Date eventDate_;
			boost::shared_ptr<PreEventCalculation> preEventCal_;
			boost::shared_ptr<PreConditionEvent> preCondiEvent_;
			boost::shared_ptr<EventTriggerInfo> autoTerminationETI_;
			
			boost::shared_ptr<AdditionalOption> additionalOption_;
			Size optionType_;
			//std::valarray<Size> fixingDatePositions_;
			//std::valarray<Size> payoffDatePositions_;

			//Array discount_;

	};

}

#endif