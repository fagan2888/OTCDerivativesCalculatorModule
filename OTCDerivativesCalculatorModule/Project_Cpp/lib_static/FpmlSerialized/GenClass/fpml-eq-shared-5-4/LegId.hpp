// LegId.hpp 
#ifndef FpmlSerialized_LegId_hpp
#define FpmlSerialized_LegId_hpp

#include <fpml-shared-5-4/Token60.hpp>

namespace FpmlSerialized {

class LegId : public Token60 { 
   public: 
       LegId(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

