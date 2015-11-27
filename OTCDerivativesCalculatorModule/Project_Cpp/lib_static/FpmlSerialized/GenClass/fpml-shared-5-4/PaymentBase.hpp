// PaymentBase.hpp 
#ifndef FpmlSerialized_PaymentBase_hpp
#define FpmlSerialized_PaymentBase_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class PaymentBase : public ISerialized { 
   public: 
       PaymentBase(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

