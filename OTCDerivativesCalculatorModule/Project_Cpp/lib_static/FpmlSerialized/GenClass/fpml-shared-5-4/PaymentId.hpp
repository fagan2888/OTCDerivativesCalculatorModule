// PaymentId.hpp 
#ifndef FpmlSerialized_PaymentId_hpp
#define FpmlSerialized_PaymentId_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class PaymentId : public Scheme { 
   public: 
       PaymentId(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

