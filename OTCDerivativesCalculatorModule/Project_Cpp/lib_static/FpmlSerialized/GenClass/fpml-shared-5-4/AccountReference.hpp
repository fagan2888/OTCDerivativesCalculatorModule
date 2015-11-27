// AccountReference.hpp 
#ifndef FpmlSerialized_AccountReference_hpp
#define FpmlSerialized_AccountReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class AccountReference : public Reference { 
   public: 
       AccountReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

