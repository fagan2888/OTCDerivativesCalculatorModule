#ifndef calculationModule_autoCallEC_hpp
#define calculationModule_autoCallEC_hpp

#include <src/Engine/MonteCarlo/StructuredProduct/EventCheck/EventCheckBase.hpp>

namespace QuantLib {

EV_TEMPLATE
class NormalTimeEC : public EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent> {
	public:

		typedef typename EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent> baseEV;

		NormalTimeEC(std::string thisEventSymbolName,
				    const std::vector<std::string>& baseIndex,
				    const ITM& itm,
				    const FEM& functionEventsM,
					const PM& pm,
				    const FSEvent& functionAndSubEvent,
					const TEvent& timeEvent,
				    std::vector<Date> eventDates);
				    //boost::shared_ptr<EventCheckBase>& subEventchecks = boost::shared_ptr<EventCheckBase>());
		  

		void calculate();

	private:
		TEvent timeEvent_;

	
};



}


#endif