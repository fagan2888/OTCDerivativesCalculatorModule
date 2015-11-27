// AccountId.hpp 
#ifndef FpmlSerialized_AccountId_hpp
#define FpmlSerialized_AccountId_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class AccountId : public Scheme { 
   public: 
       AccountId(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

