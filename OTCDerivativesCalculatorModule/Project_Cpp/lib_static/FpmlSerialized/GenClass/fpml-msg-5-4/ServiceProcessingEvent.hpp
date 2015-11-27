// ServiceProcessingEvent.hpp 
#ifndef FpmlSerialized_ServiceProcessingEvent_hpp
#define FpmlSerialized_ServiceProcessingEvent_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class ServiceProcessingEvent : public Scheme { 
   public: 
       ServiceProcessingEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

