// LegalEntityReference.hpp 
#ifndef FpmlSerialized_LegalEntityReference_hpp
#define FpmlSerialized_LegalEntityReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class LegalEntityReference : public Reference { 
   public: 
       LegalEntityReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

