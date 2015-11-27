// IdentifiedPayerReceiver.hpp 
#ifndef FpmlSerialized_IdentifiedPayerReceiver_hpp
#define FpmlSerialized_IdentifiedPayerReceiver_hpp

#include <fpml-enum-5-4/PayerReceiverEnum.hpp>

namespace FpmlSerialized {

class IdentifiedPayerReceiver : public PayerReceiverEnum { 
   public: 
       IdentifiedPayerReceiver(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

