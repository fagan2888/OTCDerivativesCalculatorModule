// BankruptcyEvent.hpp 
#ifndef FpmlSerialized_BankruptcyEvent_hpp
#define FpmlSerialized_BankruptcyEvent_hpp

#include <fpml-credit-event-notification-5-4/CreditEvent.hpp>

namespace FpmlSerialized {

class BankruptcyEvent : public CreditEvent { 
   public: 
       BankruptcyEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

