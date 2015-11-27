// UpfrontPremium.hpp 
#ifndef FpmlSerialized_UpfrontPremium_hpp
#define FpmlSerialized_UpfrontPremium_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class UpfrontPremium : public ISerialized { 
   public: 
       UpfrontPremium(TiXmlNode* xmlNode);

       bool isPayerPartyReference(){return this->payerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPayerPartyReference();
      std::string getPayerPartyReferenceIDRef(){return payerPartyReferenceIDRef_;}

       bool isReceiverPartyReference(){return this->receiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getReceiverPartyReference();
      std::string getReceiverPartyReferenceIDRef(){return receiverPartyReferenceIDRef_;}

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

       bool isExchangeDate(){return this->exchangeDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getExchangeDate();
      std::string getExchangeDateIDRef(){return exchangeDateIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> payerPartyReference_;
       std::string payerPartyReferenceIDRef_;
       bool payerPartyReferenceIsNull_;
       boost::shared_ptr<PartyReference> receiverPartyReference_;
       std::string receiverPartyReferenceIDRef_;
       bool receiverPartyReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;
       boost::shared_ptr<XsdTypeDate> exchangeDate_;
       std::string exchangeDateIDRef_;
       bool exchangeDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

