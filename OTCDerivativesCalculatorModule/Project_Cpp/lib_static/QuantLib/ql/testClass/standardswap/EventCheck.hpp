#ifndef quantlib_eventcheck_hpp
#define quantlib_eventcheck_hpp

#include <ql/math/array.hpp>
#include <ql/time/date.hpp>
#include <ql/testClass/standardswap/indextransmanager.hpp>
#include <ql/testClass/standardswap/payoffmanager.hpp>
#include <ql/testClass/standardswap/eventfunction.hpp>
#include <ql/testClass/standardswap/eventFunctionManager.hpp>
#include <ql/testClass/standardswap/jointEvent.hpp>

#include <ql/testClass/muparser/muparser.h>

//sumulation용 Event

namespace QuantLib {
    
	class EventCheck 
	{
	public:
		// 소멸자 처리
		EventCheck(std::string thisEventSymbolName,
				   //const std::vector<std::string,QuantLib::Index>& baseIndex,
				   const std::vector<std::string>& baseIndex,
				   bool dailyFlag,
				   std::vector<Date> eventDates, //2개들어왔을때의 구분. //daily로 setting인 경우 계산 기준일자 사용함.
				   const std::vector<boost::shared_ptr<IndexTransManager>>& indexM_Event,
				   const std::vector<boost::shared_ptr<EventFunctionManager>>& eventFunctionMs,
				   //boost::shared_ptr<EventFunctionManager> amortizeM,				   
				   //const Date& payoffDates,	   // payoffManager 에서 가지고 들어옴.
				   //const boost::shared_ptr<IndexTransManager>& indexM_Payoff, // payoff를 위한 IndexTransform
				   const boost::shared_ptr<PayoffManager>& payoffManager,
				   const boost::shared_ptr<JointEvent>& functionJointEvent_,
				   const boost::shared_ptr<JointEvent>& subJointEvent_,
				   const boost::shared_ptr<JointEvent>& functionAndSubEvent_,
				   const boost::shared_ptr<JointEvent>& timeJointEvent_,
				   bool autoCallable = false,
				   const std::vector<boost::shared_ptr<EventCheck>>& subEventchecks = std::vector<boost::shared_ptr<EventCheck>>()
				   
				   // 생셩자에 sub event 를 넣어야 하는가?
				   );

		// 자신의 symbol 을 등록해야함. class 형태로 가지 않고 여기에 추가하는 형식으로 확장할거임.
		// 지금은 count symbol 하나임

//		virtual ~EventCheck() {}

		//member function

		void gridInitialize(const TimeGrid& timeGrid, const Calendar& calendar); //timeGrid 받아서 date -> location int
		void addSymbolEvent(const std::string& symbolName);
		void defineConst(const std::string varStr,Real constValue);
		void defineBaseIndex(const std::string varStr);
		void defineVar(const std::string varStr);
		void calculate(const MultiPath& multiPath);
		Real payoff(const MultiPath& multiPath);

//		virtual bool eventCal(){return thisEventOccFlag_;}  // sub 이벤트의 조합방법.

		//bool isEventDate(Size pathIndexK);
		//bool isPayoffDate(Size pathIndexK);

		bool thisEventOccFlag(Size k){return this->timeEventJoint_Cal(0,k);}
		//eventCalFunction
		bool functionEventsJoint_Cal();
		bool SubEventJoint_Cal();
		bool funcAndSubJointEvent_Cal();
		bool timeEventJoint_Cal(Size startDatePosition,Size refDatePosition);
		
		//others
		//void registEvent(const boost::shared_ptr<EventCheck>& eventcheck,bool TF);
		Size payoffIndexLocation() const;
		void setBaseIndexValue(const MultiPath& multiPath,int payoffDatesPosition);
		void reset();

		const std::vector<Date>& eventDates() const{return eventDates_;}
		std::string thisCountSymbol() const{
			//return thisCountSymbol_;
			return "Count";
		}
		const std::string& thisEventSymbolName() const{return thisEventSymbolName_;}
		
		bool isCalFlag_Flag() const{return isCalFlag_;};
		
	//Constructor initialize Const variable
	private:
		bool dailyFlag_;
		bool autoCallableFlag_;

		Size eventDatesPositionNum_;
		Size eventFunctionMNums_;
		Size subEventNum_;

		std::string thisEventSymbolName_;
		std::vector<std::string> baseIndex_;
		std::vector<std::string> thisStoredSymbolIndex_; //Counter Symbol 같은거 , indexSymbol까지 가지고 있음.
		std::vector<std::string> thisStoredSymbolEvent_; //ex) subEvent 의 Counter Symbol 같은거

		boost::shared_ptr<JointEvent> functionJointEvent_;
		boost::shared_ptr<JointEvent> subJointEvent_;
		boost::shared_ptr<JointEvent> functionAndSubEvent_;
		boost::shared_ptr<JointEvent> timeJointEvent_;
		
		std::vector<Date> eventDates_;
		Date payoffDate_;

		mu::Parser parser_;
		TimeGrid timeGrid_;

		//parser를 위한 배열..
		std::vector<double*> baseIndexValue_;
		std::vector<double*> indexM_EventSymbolValue_;

		//이거 포인터 만들어야하나..? 2012-11-16
		//std::vector<double*> symbolValue_;
		
		std::vector<boost::shared_ptr<EventCheck>> subEventchecks_;

		std::vector<boost::shared_ptr<IndexTransManager>> indexM_Event_;
		std::vector<boost::shared_ptr<EventFunctionManager>> eventFunctionMs_;

		boost::shared_ptr<PayoffManager> payoffManager_;

		std::vector<std::string> eventFunctionSymbols_;

		
	//initializer initialize
	private:
		Calendar calendar_;
		Size payoffAutoCallLocation_;
		std::vector<Size> eventDatesPosition_;
		Size startDatePosition_;
		Size payoffDatesPosition_;

	private:

		//bool isCalFlag_;
		Real payoffValue_;
		Size eventOccCounter_; // 이벤트가 일어난 개수
		bool isCalFlag_;

		//결과물임. set은 class에서 되서 옴.
		std::vector<bool> eventFunctionOccFlags_;
		bool functionEventJointOccFlag_; // cal by functionEventsJoint_Cal()
		Size functionEventOccCount_;

		std::vector<bool> subEventOccFlags_;
		bool SubEventJointOccFlag_;
		Size subEventJointOccCount_;

		std::vector<bool> funcAndSubJointEventOccFlag_; //functionEventJointOccFlag_ ,SubEventJointOccFlag_ 두개로 조합됨.

		bool timeEventJointOccFlag_; //funcAndSubJointEventOccFlag_ 이걸 이용해서 구함.
		Size timeEventJointOccCount_;

		//calValue();

		//Date referenceDate_Calculated_; // 계산되었을경우 기준일자.
		
		// bool dayilyPayoffFlag_; //이벤트 Day 마다 payoff가 발생하는가.
		//std::vector<Size> averRelativeDatesPosition_;
		// symbolNames
		//std::vector<std::string,QuantLib::Index> baseIndex_;

	};


}

#endif