#ifndef calculationModule_autoCallEC_hpp
#define calculationModule_autoCallEC_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/EventCheckBase.hpp>

namespace QuantLib {

class NormalTimeEC : public EventCheckBase {
	public:

		NormalTimeEC(const std::string& thisEventSymbolName,
				    const boost::shared_ptr<EventIndexTransformation>& eit,
				    const boost::shared_ptr<FunctionEvents>& fe,
				    const boost::shared_ptr<PayoffBase>& pb,
				    const boost::shared_ptr<JointEvent>& functionAndSubEvent,
					const boost::shared_ptr<JointTimeEvent>& timeEvent,
				    DateIntervalMaker eventDates);

		void calculate();
		
		bool eventOcc();
		bool eventHistoryOcc();
		bool bindingFlag();
		void reset();
		Real payoff();

		void variableBind();
		void variablePtrBind();
		void validFixingDates();

		std::vector<Date> indexFixingDates();
		std::vector<Date> payoffDates();

		//void bindingPathPosition(const MultiPath& pathInfo){QL_FAIL("not implemented");}

	private:
		void historyCalculate();

		boost::shared_ptr<JointTimeEvent> timeEvent_;
		JointTimeEvent* timeEventPtr_;
		Size skippedEventDatesNum_;
		Size historyNum_;

		DateIntervalMaker eventDates_;

		bool ishistoryCalFlag_;
		



		//우선은 저장 안하고 처음에 factory에서 바로 계산 call historyInformationSet
		//std::vector<boost::shared_ptr<FunctionEvents>> historyFE_;
	
};

}


#endif