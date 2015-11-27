// NullVariableEventInfo.hpp 
#ifndef FpmlSerialized_NullVariableEventInfo_hpp
#define FpmlSerialized_NullVariableEventInfo_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class NullVariableEventInfo : public ISerialized { 
   public: 
       NullVariableEventInfo(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

