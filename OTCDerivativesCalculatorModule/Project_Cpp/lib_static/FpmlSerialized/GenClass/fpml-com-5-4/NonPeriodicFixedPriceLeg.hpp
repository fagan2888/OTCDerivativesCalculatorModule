// NonPeriodicFixedPriceLeg.hpp 
#ifndef FpmlSerialized_NonPeriodicFixedPriceLeg_hpp
#define FpmlSerialized_NonPeriodicFixedPriceLeg_hpp

#include <fpml-com-5-4/CommoditySwapLeg.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-com-5-4/FixedPrice.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-com-5-4/QuantityReference.hpp>
#include <fpml-com-5-4/CommodityRelativePaymentDates.hpp>
#include <fpml-shared-5-4/AdjustableDatesOrRelativeDateOffset.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class NonPeriodicFixedPriceLeg : public CommoditySwapLeg { 
   public: 
       NonPeriodicFixedPriceLeg(TiXmlNode* xmlNode);

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

       bool isFixedPrice(){return this->fixedPriceIsNull_;}
       boost::shared_ptr<FixedPrice> getFixedPrice();
      std::string getFixedPriceIDRef(){return fixedPriceIDRef_;}

       bool isTotalPrice(){return this->totalPriceIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getTotalPrice();
      std::string getTotalPriceIDRef(){return totalPriceIDRef_;}

       bool isQuantityReference(){return this->quantityReferenceIsNull_;}
       boost::shared_ptr<QuantityReference> getQuantityReference();
      std::string getQuantityReferenceIDRef(){return quantityReferenceIDRef_;}

       bool isRelativePaymentDates(){return this->relativePaymentDatesIsNull_;}
       boost::shared_ptr<CommodityRelativePaymentDates> getRelativePaymentDates();
      std::string getRelativePaymentDatesIDRef(){return relativePaymentDatesIDRef_;}

       bool isPaymentDates(){return this->paymentDatesIsNull_;}
       boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> getPaymentDates();
      std::string getPaymentDatesIDRef(){return paymentDatesIDRef_;}

       bool isMasterAgreementPaymentDates(){return this->masterAgreementPaymentDatesIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMasterAgreementPaymentDates();
      std::string getMasterAgreementPaymentDatesIDRef(){return masterAgreementPaymentDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!relativePaymentDatesIsNull_){
                count += 1;
                str = "relativePaymentDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!paymentDatesIsNull_){
                count += 1;
                str = "paymentDates" ;
           }
           if(!masterAgreementPaymentDatesIsNull_){
                count += 1;
                str = "masterAgreementPaymentDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
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
       boost::shared_ptr<FixedPrice> fixedPrice_;
       std::string fixedPriceIDRef_;
       bool fixedPriceIsNull_;
       boost::shared_ptr<NonNegativeMoney> totalPrice_;
       std::string totalPriceIDRef_;
       bool totalPriceIsNull_;
       boost::shared_ptr<QuantityReference> quantityReference_;
       std::string quantityReferenceIDRef_;
       bool quantityReferenceIsNull_;
         boost::shared_ptr<CommodityRelativePaymentDates> relativePaymentDates_;     //choice
       std::string relativePaymentDatesIDRef_;
       bool relativePaymentDatesIsNull_;
         boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> paymentDates_;     //choice
       std::string paymentDatesIDRef_;
       bool paymentDatesIsNull_;
         boost::shared_ptr<XsdTypeBoolean> masterAgreementPaymentDates_;     //choice
       std::string masterAgreementPaymentDatesIDRef_;
       bool masterAgreementPaymentDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

