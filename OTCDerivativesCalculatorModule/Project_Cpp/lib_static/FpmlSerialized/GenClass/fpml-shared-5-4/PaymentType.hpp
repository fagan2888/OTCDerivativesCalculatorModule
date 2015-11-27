// PaymentType.hpp 
#ifndef FpmlSerialized_PaymentType_hpp
#define FpmlSerialized_PaymentType_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class PaymentType : public Scheme { 
   public: 
       PaymentType(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

