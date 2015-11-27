#ifndef xmlFactory_EventFunctionMFactory_hpp
#define xmlFactory_EventFunctionMFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunction.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunctionManager.hpp>

namespace XmlFactory {
	class EventFunctionMFactory {
		public:
			EventFunctionMFactory();
			EventFunctionMFactory(TiXmlNode* xmlNode);
			
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