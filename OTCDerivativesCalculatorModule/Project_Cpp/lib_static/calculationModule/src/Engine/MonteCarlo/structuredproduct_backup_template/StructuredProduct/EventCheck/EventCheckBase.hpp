#ifndef calculationModule_eventcheckbase_hpp
#define calculationModule_eventcheckbase_hpp

#include <ql/math/array.hpp>
#include <ql/time/date.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/EventCheck/IEventCheck.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/IndexTran/indextransBase.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/Payoff/payoffBase.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventfunction.hpp>
#include <src/Engine/MonteCarlo/StructuredProduct/JointEvent/jointEvent.hpp>


//#include <ql/testClass/muparser/muparser.h>

//sumulation용 Event

namespace QuantLib {
    
	#define EV_TEMPLATE template<class ITM,class PM,class FEM,class SubEvent,class FSEvent, class TEvent >

	template<class ITM,class PM,class FEM,class SubEvent,class FSEvent, class TEvent = IdentityJointEvent>
	class EventCheckBase : public IEventCheck
	{
	public:
		// 소멸자 처리
		EventCheckBase(std::string thisEventSymbolName,
				   const std::vector<std::string>& baseIndex,
				   const ITM& itm,
				   const FEM& eventFunctionMs,
				   const PM& payoffManager,
				   const SubEvent& subJointEvent,
				   const FSEvent& functionAndSubEvent,
				   std::vector<Date> eventDates, //2개들어왔을때의 구분. //daily로 setting인 경우 계산 기준일자 사용함.
				   boost::shared_ptr<IEventCheck>& subEventchecks = boost::shared_ptr<IEventCheck>()
				   );

		// 자신의 symbol 을 등록해야함. class 형태로 가지 않고 여기에 추가하는 형식으로 확장할거임.
		// 지금은 count symbol 하나임

//		virtual ~EventCheck() {}

		//member function

		virtual void gridInitialize(const TimeGrid& timeGrid, const Calendar& calendar); //timeGrid 받아서 date -> location int
		virtual void addSymbolEvent(const std::string& symbolName);
		virtual void defineConst(const std::string varStr,Real constValue);
		virtual void defineBaseIndex(const std::string varStr);
		virtual void defineVar(const std::string varStr);
		
		void eventRefSymSet();
		
		virtual void calculate() = 0;

		Real payoff();

	private:
		bool thisEventOccFlag(Size k){return this->timeEventJoint_Cal(0,k);}
		//eventCalFunction

		inline bool functionEventsJoint_Cal();
		inline bool SubEventJoint_Cal();
		inline bool funcAndSubJointEvent_Cal();
		inline bool timeEventJoint_Cal(Size startDatePosition,Size refDatePosition);
		
		//others
		//void registEvent(const boost::shared_ptr<EventCheck>& eventcheck,bool TF);
		Size payoffIndexLocation() const;
		void reset();

		const std::vector<Date>& eventDates() const{return eventDates_;}

		std::string thisCountSymbol() const{
			//return thisCountSymbol_;
			return "Count";
		}
		const std::string& thisEventSymbolName() const{return thisEventSymbolName_;}
		
		bool isCalFlag_Flag() const{return isCalFlag_;};
		bool isExpired();
		
	//Constructor initialize Const variable
	private:
		bool dailyFlag_;
		bool autoCallableFlag_;

		Size eventDatesPositionNum_;
		Size eventFunctionMNums_;
		Size subEventNum_;

		std::string thisEventSymbolName_;
		std::vector<std::string> thisStoredSymbolIndex_; //Counter Symbol 같은거 , indexSymbol까지 가지고 있음.
		std::vector<std::string> thisStoredSymbolEvent_; //ex) subEvent 의 Counter Symbol 같은거

		std::vector<Date> eventDates_;
		Date payoffDate_;

		//mu::Parser parser_;
		//TimeGrid timeGrid_;

		std::vector<boost::shared_ptr<IEventCheck>> subEventchecks_;

		const std::vector<std::string>& baseIndex;
		
		//boost::shared_ptr<ITM> itM_;
		//boost::shared_ptr<FEM>> feM_;
		//boost::shared_ptr<PM> pm_;
		//boost::shared_ptr<SubEvent> subJointEvent_;
		//boost::shared_ptr<FSEvent> functionAndSubEvent_;
		//boost::shared_ptr<TEvent> timeEvent_;

		ITM itM_;
		FEM feM_;
		PM pm_;
		SubEvent subJointEvent_;
		FSEvent functionAndSubEvent_;
		TEvent timeEvent_;

		std::vector<std::string> eventFunctionSymbols_;
		
	//initializer initialize
	private:
		Calendar calendar_;
		std::vector<Size> eventDatesPosition_;
		Size startDatePosition_;
		Size payoffDatesPosition_;

	private:

		Real payoffValue_;
		bool isCalFlag_;

		//결과물임. set은 class에서 되서 옴.
		std::vector<bool> eventFunctionOccFlags_;
		bool functionEventJointOccFlag_; // cal by functionEventsJoint_Cal()

		bool SubEventJointOccFlag_;

		std::vector<bool> subEventOccFlags_;
		std::vector<bool> funcAndSubJointEventOccFlag_; //functionEventJointOccFlag_ ,SubEventJointOccFlag_ 두개로 조합됨.


	};


}

#endif