#ifndef xmlFactory_eventCheck_Factory_hpp
#define xmlFactory_eventCheck_Factory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/eventCheck.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/jointEvent.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunctionManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/eventsymbolmanager.hpp>

#include <xmlFactory/Factory/Instrument/StructuredProduct/FunctionEventsFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/indexTransMFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/payoffManagerFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/jointFunctionFactory.hpp>

namespace XmlTest{
	class EventCheckFactory {
		public:
			EventCheckFactory();
			void initialize();
		protected:
			//boost::shared_ptr<EventCheck> getEventChecks(TiXmlNode* xmlNode,const std::vector<std::string>& baseIndex);
			
			boost::shared_ptr<EventCheck> getEventChecks(TiXmlNode* xmlNode);

			std::vector<std::string> baseIndex();

			void parseXml(TiXmlNode* xmlNode);
			

		//member 
		protected:
			
			void build();

			boost::shared_ptr<EventCheck> eventCheck_;

			boost::shared_ptr<IndexTransMFactory> eventCheckIndexTrans_;
			boost::shared_ptr<IndexTransMFactory> payoffIndexTrans_;
			boost::shared_ptr<FunctionEventsFactory> functionEvents_;
			boost::shared_ptr<DateFacotry> eventDate_;
			boost::shared_ptr<PayoffManagerFactory> payoff_;

			
			boost::shared_ptr<JointFunctionFactory>& subJointEvent_;
			boost::shared_ptr<JointFunctionFactory>& functionAndSubEvent_;
			boost::shared_ptr<JointFunctionFactory>& timeJointEvent_;

		protected:
			std::string eventCheckSymbol_;

	};
}
#endif