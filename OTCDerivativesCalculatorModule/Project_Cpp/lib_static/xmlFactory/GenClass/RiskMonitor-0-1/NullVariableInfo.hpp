// NullVariableInfo.hpp 
#ifndef FpmlSerialized_NullVariableInfo_hpp
#define FpmlSerialized_NullVariableInfo_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class NullVariableInfo : public ISerialized { 
   public: 
       NullVariableInfo(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

