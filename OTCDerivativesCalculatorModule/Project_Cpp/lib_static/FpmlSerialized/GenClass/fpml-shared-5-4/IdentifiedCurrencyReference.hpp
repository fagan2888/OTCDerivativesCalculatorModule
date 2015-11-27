// IdentifiedCurrencyReference.hpp 
#ifndef FpmlSerialized_IdentifiedCurrencyReference_hpp
#define FpmlSerialized_IdentifiedCurrencyReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class IdentifiedCurrencyReference : public Reference { 
   public: 
       IdentifiedCurrencyReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

