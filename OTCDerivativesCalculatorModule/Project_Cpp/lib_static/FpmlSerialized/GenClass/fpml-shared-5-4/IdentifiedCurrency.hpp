// IdentifiedCurrency.hpp 
#ifndef FpmlSerialized_IdentifiedCurrency_hpp
#define FpmlSerialized_IdentifiedCurrency_hpp

#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class IdentifiedCurrency : public Currency { 
   public: 
       IdentifiedCurrency(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

