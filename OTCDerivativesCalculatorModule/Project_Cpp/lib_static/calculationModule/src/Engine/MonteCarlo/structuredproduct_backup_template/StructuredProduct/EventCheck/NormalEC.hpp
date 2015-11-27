#ifndef calculationModule_normalEC_hpp
#define calculationModule_normalEC_hpp

#include <src/Engine/MonteCarlo/StructuredProduct/EventCheck/EventCheckBase.hpp>

namespace QuantLib {

template<class ITM,class PM,class FEM,class SubEvent,class FSEvent,class TEvent = IdentityJointEvent>
class NormalEC : public  EventCheckBase<ITM,PM,FEM,SubEvent,FSEvent,TEvent> {
	public:
		NormalEC(std::string thisEventSymbolName,
				const ITM& itm,
				const FEM& fem,
				const PM& pm,
				const SubEvent& subJointEvent,
				const FSEvent& functionAndSubEvent,
				Date eventDates,
				boost::shared_ptr<IEventCheck>& subEventchecks = boost::shared_ptr<IEventCheck>());

		void calculate();
};

}


#endif
