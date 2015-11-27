// MoneyReference.hpp 
#ifndef FpmlSerialized_MoneyReference_hpp
#define FpmlSerialized_MoneyReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class MoneyReference : public Reference { 
   public: 
       MoneyReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

