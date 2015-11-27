#ifndef calculationModule_normalEC_hpp
#define calculationModule_normalEC_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/EventCheckBase.hpp>

namespace QuantLib {

class NormalEC : public  EventCheckBase {
	public:
		NormalEC(const std::string& thisEventSymbolName,
				const boost::shared_ptr<EventIndexTransformation>& eit,
				const boost::shared_ptr<FunctionEvents>& fe,
				const boost::shared_ptr<PayoffBase>& pb,
				const boost::shared_ptr<SubEvents>& subEvents,
				const boost::shared_ptr<JointEvent>& functionAndSubEvent,
				const Date& eventDates);

		void calculate();
		bool eventOcc();

		//history 나 그냥 eventOcc 나 여기서는 같음.
		bool eventHistoryOcc();

		void historyCalculate();
		bool bindingFlag();
		void reset();
		Real payoff();

		void variableBind();
		void variablePtrBind();
		void validFixingDates();

		std::vector<Date> indexFixingDates();
		std::vector<Date> payoffDates();
	private:
		Date eventDate_;
		Real payoffHistoryValue_;


};

}


#endif
