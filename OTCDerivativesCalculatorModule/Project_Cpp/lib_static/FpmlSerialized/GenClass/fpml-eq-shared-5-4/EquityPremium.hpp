// EquityPremium.hpp 
#ifndef FpmlSerialized_EquityPremium_hpp
#define FpmlSerialized_EquityPremium_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-enum-5-4/PremiumTypeEnum.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class EquityPremium : public PaymentBase { 
   public: 
       EquityPremium(TiXmlNode* xmlNode);

       bool isPayerPartyReference(){return this->payerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPayerPartyReference();
      std::string getPayerPartyReferenceIDRef(){return payerPartyReferenceIDRef_;}

       bool isPayerAccountReference(){return this->payerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getPayerAccountReference();
      std::string getPayerAccountReferenceIDRef(){return payerAccountReferenceIDRef_;}

       bool isReceiverPartyReference(){return this->receiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getReceiverPartyReference();
      std::string getReceiverPartyReferenceIDRef(){return receiverPartyReferenceIDRef_;}

       bool isReceiverAccountReference(){return this->receiverAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getReceiverAccountReference();
      std::string getReceiverAccountReferenceIDRef(){return receiverAccountReferenceIDRef_;}

       bool isPremiumType(){return this->premiumTypeIsNull_;}
       boost::shared_ptr<PremiumTypeEnum> getPremiumType();
      std::string getPremiumTypeIDRef(){return premiumTypeIDRef_;}

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

       bool isSwapPremium(){return this->swapPremiumIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSwapPremium();
      std::string getSwapPremiumIDRef(){return swapPremiumIDRef_;}

       bool isPricePerOption(){return this->pricePerOptionIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPricePerOption();
      std::string getPricePerOptionIDRef(){return pricePerOptionIDRef_;}

       bool isPercentageOfNotional(){return this->percentageOfNotionalIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getPercentageOfNotional();
      std::string getPercentageOfNotionalIDRef(){return percentageOfNotionalIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> payerPartyReference_;
       std::string payerPartyReferenceIDRef_;
       bool payerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> payerAccountReference_;
       std::string payerAccountReferenceIDRef_;
       bool payerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> receiverPartyReference_;
       std::string receiverPartyReferenceIDRef_;
       bool receiverPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> receiverAccountReference_;
       std::string receiverAccountReferenceIDRef_;
       bool receiverAccountReferenceIsNull_;
       boost::shared_ptr<PremiumTypeEnum> premiumType_;
       std::string premiumTypeIDRef_;
       bool premiumTypeIsNull_;
       boost::shared_ptr<NonNegativeMoney> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;
       boost::shared_ptr<AdjustableDate> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;
       boost::shared_ptr<XsdTypeBoolean> swapPremium_;
       std::string swapPremiumIDRef_;
       bool swapPremiumIsNull_;
       boost::shared_ptr<NonNegativeMoney> pricePerOption_;
       std::string pricePerOptionIDRef_;
       bool pricePerOptionIsNull_;
       boost::shared_ptr<NonNegativeDecimal> percentageOfNotional_;
       std::string percentageOfNotionalIDRef_;
       bool percentageOfNotionalIsNull_;

};

} //namespaceFpmlSerialized end
#endif

