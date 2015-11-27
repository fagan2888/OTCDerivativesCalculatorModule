// ExerciseFee.hpp 
#ifndef FpmlSerialized_ExerciseFee_hpp
#define FpmlSerialized_ExerciseFee_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/NotionalReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>

namespace FpmlSerialized {

class ExerciseFee : public ISerialized { 
   public: 
       ExerciseFee(TiXmlNode* xmlNode);

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

       bool isNotionalReference(){return this->notionalReferenceIsNull_;}
       boost::shared_ptr<NotionalReference> getNotionalReference();
      std::string getNotionalReferenceIDRef(){return notionalReferenceIDRef_;}

       bool isFeeAmount(){return this->feeAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFeeAmount();
      std::string getFeeAmountIDRef(){return feeAmountIDRef_;}

       bool isFeeRate(){return this->feeRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFeeRate();
      std::string getFeeRateIDRef(){return feeRateIDRef_;}

       bool isFeePaymentDate(){return this->feePaymentDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getFeePaymentDate();
      std::string getFeePaymentDateIDRef(){return feePaymentDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!feeAmountIsNull_){
                count += 1;
                str = "feeAmount" ;
           }
           if(!feeRateIsNull_){
                count += 1;
                str = "feeRate" ;
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
       boost::shared_ptr<NotionalReference> notionalReference_;
       std::string notionalReferenceIDRef_;
       bool notionalReferenceIsNull_;
         boost::shared_ptr<XsdTypeDecimal> feeAmount_;     //choice
       std::string feeAmountIDRef_;
       bool feeAmountIsNull_;
         boost::shared_ptr<XsdTypeDecimal> feeRate_;     //choice
       std::string feeRateIDRef_;
       bool feeRateIsNull_;
       boost::shared_ptr<RelativeDateOffset> feePaymentDate_;
       std::string feePaymentDateIDRef_;
       bool feePaymentDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

