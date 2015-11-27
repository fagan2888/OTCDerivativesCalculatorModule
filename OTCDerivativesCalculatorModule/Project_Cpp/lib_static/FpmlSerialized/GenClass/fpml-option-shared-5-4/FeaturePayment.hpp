// FeaturePayment.hpp 
#ifndef FpmlSerialized_FeaturePayment_hpp
#define FpmlSerialized_FeaturePayment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <fpml-enum-5-4/TimeTypeEnum.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class FeaturePayment : public PaymentBase { 
   public: 
       FeaturePayment(TiXmlNode* xmlNode);

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

       bool isLevelPercentage(){return this->levelPercentageIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getLevelPercentage();
      std::string getLevelPercentageIDRef(){return levelPercentageIDRef_;}

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

       bool isTime(){return this->timeIsNull_;}
       boost::shared_ptr<TimeTypeEnum> getTime();
      std::string getTimeIDRef(){return timeIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isFeaturePaymentDate(){return this->featurePaymentDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getFeaturePaymentDate();
      std::string getFeaturePaymentDateIDRef(){return featurePaymentDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!levelPercentageIsNull_){
                count += 1;
                str = "levelPercentage" ;
           }
           if(!amountIsNull_){
                count += 1;
                str = "amount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
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
         boost::shared_ptr<XsdTypeDecimal> levelPercentage_;     //choice
       std::string levelPercentageIDRef_;
       bool levelPercentageIsNull_;
         boost::shared_ptr<NonNegativeDecimal> amount_;     //choice
       std::string amountIDRef_;
       bool amountIsNull_;
       boost::shared_ptr<TimeTypeEnum> time_;
       std::string timeIDRef_;
       bool timeIsNull_;
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> featurePaymentDate_;
       std::string featurePaymentDateIDRef_;
       bool featurePaymentDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

