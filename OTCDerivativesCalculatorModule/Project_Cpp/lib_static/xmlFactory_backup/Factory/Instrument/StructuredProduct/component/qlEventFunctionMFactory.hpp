#ifndef xmlFactory_qlEventFunctionMFactory_hpp
#define xmlFactory_qlEventFunctionMFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunction.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/functionEvents.hpp>

namespace XmlFactory {

	class qlEventFunctionMFactory {
		public:
			qlEventFunctionMFactory();
			qlEventFunctionMFactory(TiXmlNode* xmlNode);
			
			void parseXml(TiXmlNode* xmlNode);
			void build();
		
			boost::shared_ptr<EventFunctionManager> getEventFunctionM(){return eventFunctionM_;}

		protected:
			
			boost::shared_ptr<EventFunctionManager> eventFunctionM_;

		private:
			void parseEventFunction(TiXmlNode* xmlNode);
	};
}

#endif