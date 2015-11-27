// PaymentReference.hpp 
#ifndef FpmlSerialized_PaymentReference_hpp
#define FpmlSerialized_PaymentReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class PaymentReference : public Reference { 
   public: 
       PaymentReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

