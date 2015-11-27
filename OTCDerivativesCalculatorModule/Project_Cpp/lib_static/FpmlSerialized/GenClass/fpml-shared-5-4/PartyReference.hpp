// PartyReference.hpp 
#ifndef FpmlSerialized_PartyReference_hpp
#define FpmlSerialized_PartyReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class PartyReference : public Reference { 
   public: 
       PartyReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

