// VerificationMethod.hpp 
#ifndef FpmlSerialized_VerificationMethod_hpp
#define FpmlSerialized_VerificationMethod_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class VerificationMethod : public Scheme { 
   public: 
       VerificationMethod(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

