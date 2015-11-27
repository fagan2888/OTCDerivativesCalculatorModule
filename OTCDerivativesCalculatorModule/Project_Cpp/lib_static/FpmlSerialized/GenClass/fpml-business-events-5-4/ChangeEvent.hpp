// ChangeEvent.hpp 
#ifndef FpmlSerialized_ChangeEvent_hpp
#define FpmlSerialized_ChangeEvent_hpp

#include <fpml-business-events-5-4/AbstractEvent.hpp>

namespace FpmlSerialized {

class ChangeEvent : public AbstractEvent { 
   public: 
       ChangeEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

