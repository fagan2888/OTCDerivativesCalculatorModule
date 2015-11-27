// PaymentRule.hpp 
#ifndef FpmlSerialized_PaymentRule_hpp
#define FpmlSerialized_PaymentRule_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class PaymentRule : public ISerialized { 
   public: 
       PaymentRule(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

