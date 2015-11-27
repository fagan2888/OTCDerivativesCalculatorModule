// SettlementMethod.hpp 
#ifndef FpmlSerialized_SettlementMethod_hpp
#define FpmlSerialized_SettlementMethod_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class SettlementMethod : public Scheme { 
   public: 
       SettlementMethod(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

