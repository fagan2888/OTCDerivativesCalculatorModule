#ifndef quantlib_eventCalculation_hpp
#define quantlib_eventCalculation_hpp

#include <src/Engine/MonteCarlo/IRefVariable.hpp>
#include <src/Engine/MonteCarlo/preEventCalculation/preConditionEvent.hpp>
#include <src/Engine/MonteCarlo/variableInfo/all.hpp>

namespace QuantLib {

	class EventCalculation : public IRefVariable
	{
		public:
			EventCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			bool checkEvent(const MultiPath& path,Size endPosition = 0);
			bool checkEventEarlyEx(const MultiPath& path,Size endPosition = 0);

			bool preCondiEvent();
			bool eventOccVariableEvent(bool eventOcc);

			virtual Real accrualNum(const MultiPath& path,Size endPosition) = 0;

			//이거 우선 남겨만 놓자...
			virtual bool pastEventOcc() { return false; };
			virtual std::vector<Date> fixingDates() const { return std::vector<Date>(); };

			//regist EventReferenceName
			//나머지 eventocc 개수 라던지 이건 밑으로 내리고
			//이건 공통의 eventOccRef임
			//void setEventRefOcc(const std::string& refName);
			void setPastEventOcc(bool pastEventOcc);

			void setPreConditionEvent(const boost::shared_ptr<PreConditionEvent>& preCondiEvent);
			void setRefVariableEventOcc(const boost::shared_ptr<VariableEventInfo>& eventOccVariableEventInfo);

		protected:
			virtual bool checkEventImpl(const MultiPath& path,Size endPosition) = 0;
			//virtual bool checkEventImplEarlyEx(const MultiPath& path,Size endPosition) = 0;
			virtual bool checkEventEarlyExImpl(const MultiPath& path,Size endPosition = 0);

			virtual void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;

			Size todayPosition_;

		private:
			bool pastEventOcc_;
			Real preAccrualNum_;
			Real AccrualNum_;

			//bool eventRefOccFlag_;
			std::string eventRefName_;
			//boost::shared_ptr<variableStore> eventRefOccPtr_;
			boost::shared_ptr<PreConditionEvent> preCondiEvent_;

			boost::shared_ptr<VariableEventInfo> eventOccVariableEventInfo_;



	};
}

#endif