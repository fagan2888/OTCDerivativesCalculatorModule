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

//sumulation�� Event

namespace QuantLib {
    
	class EventCheck 
	{
	public:
		// �Ҹ��� ó��
		EventCheck(std::string thisEventSymbolName,
				   //const std::vector<std::string,QuantLib::Index>& baseIndex,
				   const std::vector<std::string>& baseIndex,
				   bool dailyFlag,
				   std::vector<Date> eventDates, //2������������ ����. //daily�� setting�� ��� ��� �������� �����.
				   const std::vector<boost::shared_ptr<IndexTransManager>>& indexM_Event,
				   const std::vector<boost::shared_ptr<EventFunctionManager>>& eventFunctionMs,
				   //boost::shared_ptr<EventFunctionManager> amortizeM,				   
				   //const Date& payoffDates,	   // payoffManager ���� ������ ����.
				   //const boost::shared_ptr<IndexTransManager>& indexM_Payoff, // payoff�� ���� IndexTransform
				   const boost::shared_ptr<PayoffManager>& payoffManager,
				   const boost::shared_ptr<JointEvent>& functionJointEvent_,
				   const boost::shared_ptr<JointEvent>& subJointEvent_,
				   const boost::shared_ptr<JointEvent>& functionAndSubEvent_,
				   const boost::shared_ptr<JointEvent>& timeJointEvent_,
				   bool autoCallable = false,
				   const std::vector<boost::shared_ptr<EventCheck>>& subEventchecks = std::vector<boost::shared_ptr<EventCheck>>()
				   
				   // �����ڿ� sub event �� �־�� �ϴ°�?
				   );

		// �ڽ��� symbol �� ����ؾ���. class ���·� ���� �ʰ� ���⿡ �߰��ϴ� �������� Ȯ���Ұ���.
		// ������ count symbol �ϳ���

//		virtual ~EventCheck() {}

		//member function

		void gridInitialize(const TimeGrid& timeGrid, const Calendar& calendar); //timeGrid �޾Ƽ� date -> location int
		void addSymbolEvent(const std::string& symbolName);
		void defineConst(const std::string varStr,Real constValue);
		void defineBaseIndex(const std::string varStr);
		void defineVar(const std::string varStr);
		void calculate(const MultiPath& multiPath);
		Real payoff(const MultiPath& multiPath);

//		virtual bool eventCal(){return thisEventOccFlag_;}  // sub �̺�Ʈ�� ���չ��.

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
		std::vector<std::string> thisStoredSymbolIndex_; //Counter Symbol ������ , indexSymbol���� ������ ����.
		std::vector<std::string> thisStoredSymbolEvent_; //ex) subEvent �� Counter Symbol ������

		boost::shared_ptr<JointEvent> functionJointEvent_;
		boost::shared_ptr<JointEvent> subJointEvent_;
		boost::shared_ptr<JointEvent> functionAndSubEvent_;
		boost::shared_ptr<JointEvent> timeJointEvent_;
		
		std::vector<Date> eventDates_;
		Date payoffDate_;

		mu::Parser parser_;
		TimeGrid timeGrid_;

		//parser�� ���� �迭..
		std::vector<double*> baseIndexValue_;
		std::vector<double*> indexM_EventSymbolValue_;

		//�̰� ������ �������ϳ�..? 2012-11-16
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
		Size eventOccCounter_; // �̺�Ʈ�� �Ͼ ����
		bool isCalFlag_;

		//�������. set�� class���� �Ǽ� ��.
		std::vector<bool> eventFunctionOccFlags_;
		bool functionEventJointOccFlag_; // cal by functionEventsJoint_Cal()
		Size functionEventOccCount_;

		std::vector<bool> subEventOccFlags_;
		bool SubEventJointOccFlag_;
		Size subEventJointOccCount_;

		std::vector<bool> funcAndSubJointEventOccFlag_; //functionEventJointOccFlag_ ,SubEventJointOccFlag_ �ΰ��� ���յ�.

		bool timeEventJointOccFlag_; //funcAndSubJointEventOccFlag_ �̰� �̿��ؼ� ����.
		Size timeEventJointOccCount_;

		//calValue();

		//Date referenceDate_Calculated_; // ���Ǿ������ ��������.
		
		// bool dayilyPayoffFlag_; //�̺�Ʈ Day ���� payoff�� �߻��ϴ°�.
		//std::vector<Size> averRelativeDatesPosition_;
		// symbolNames
		//std::vector<std::string,QuantLib::Index> baseIndex_;

	};


}

#endif