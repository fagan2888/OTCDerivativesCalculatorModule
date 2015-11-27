#ifndef calculationModule_eventcheckbase_hpp
#define calculationModule_eventcheckbase_hpp

#include <ql/math/array.hpp>
#include <ql/time/date.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/IEventCheck.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/EventIndexTransformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/payoffBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/FunctionEvents.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SubEvents/SubEvents.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/jointEvent.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/DateIntervalMaker.hpp>

//#include <ql/testClass/muparser/muparser.h>

//sumulation�� Event

namespace QuantLib {
    
	class EventCheckBase : public IEventCheck
	{
	public:
		// �Ҹ��� ó��
		EventCheckBase(const std::string& thisEventSymbolName,
				   const boost::shared_ptr<EventIndexTransformation>& eit,
				   const boost::shared_ptr<FunctionEvents>& fe,
				   const boost::shared_ptr<PayoffBase>& pb,
				   const boost::shared_ptr<SubEvents>& subEvents,
				   const boost::shared_ptr<JointEvent>& functionAndSubEvent);

		// ������ count symbol �ϳ���

//		virtual ~EventCheck() {}

		//member function

		virtual void Initialize(); //timeGrid �޾Ƽ� date -> location int
		
		void reset() = 0;
		Size payoffIndexLocation() const;

		void eventRefSymSet();

		virtual bool eventOcc() = 0;
		virtual bool eventHistoryOcc() = 0;
		virtual void calculate() = 0;
		virtual void historyCalculate() = 0;
		virtual std::vector<Date> indexFixingDates() = 0;
		virtual bool bindingFlag() = 0;

		virtual Real payoff() = 0;

	protected:

		std::string thisCountSymbol() const{
			return "Count";
		}
		const std::string& thisEventSymbolName() const{return thisEventSymbolName_;}
		
		bool isCalFlag_Flag() const{return isCalFlag_;};
		bool isExpired();
		
	//Constructor initialize Const variable
	protected:
		bool dailyFlag_;
		bool autoCallableFlag_;

		Size eventDatesPositionNum_;
		Size eventFunctionMNums_;
		Size subEventNum_;

		std::string thisEventSymbolName_;

		//std::vector<std::string> thisStoredSymbolIndex_; //Counter Symbol ������ , indexSymbol���� ������ ����.
		//std::vector<std::string> thisStoredSymbolEvent_; //ex) subEvent �� Counter Symbol ������

		//std::vector<Date> eventDates_;
		Date payoffDate_; // from pb_;

		boost::shared_ptr<EventIndexTransformation> eit_;
		boost::shared_ptr<FunctionEvents> fe_;
		boost::shared_ptr<PayoffBase> pb_;
		boost::shared_ptr<SubEvents> subEvents_;
		boost::shared_ptr<JointEvent> functionAndSubEvent_;

		EventIndexTransformation* eitPtr_;
		FunctionEvents* fePtr_;
		PayoffBase* pbPtr_;
		SubEvents* subEventsPtr_;
		JointEvent* functionAndSubEventPtr_;

		std::vector<std::string> eventFunctionSymbols_;
		
	//initializer initialize
	protected:
		Calendar calendar_;
		std::vector<Size> eventDatesPosition_;
		Size startDatePosition_;
		Size payoffDatesPosition_;

	protected:

		Real payoffValue_;

		//�������. set�� class���� �Ǽ� ��.

		bool functionEventJointOccFlag_; // cal by functionEventsJoint_Cal()

		bool subEventJointOccFlag_;

		std::vector<bool> subEventOccFlags_;
		bool funcAndSubJointEventOccFlag_; //functionEventJointOccFlag_ ,SubEventJointOccFlag_ �ΰ��� ���յ�.

		//���� payoff���°� , �� functionevents ���ļ� ���°Ŵ� ���⿡ �����ϰ� ���߿� �����.
		// symbol�� payoffSymbol���� ������.
		Real* payoffValuePtr_; //fucntioevent�� ��ġ�� ���� ������� ������.

		boost::shared_ptr<VariableValue> thisPayoffVariableValue_;


	};


}

#endif