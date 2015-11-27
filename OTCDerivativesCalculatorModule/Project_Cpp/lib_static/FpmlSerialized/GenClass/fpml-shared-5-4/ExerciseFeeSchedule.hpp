// ExerciseFeeSchedule.hpp 
#ifndef FpmlSerialized_ExerciseFeeSchedule_hpp
#define FpmlSerialized_ExerciseFeeSchedule_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/ScheduleReference.hpp>
#include <fpml-shared-5-4/AmountSchedule.hpp>
#include <fpml-shared-5-4/Schedule.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>

namespace FpmlSerialized {

class ExerciseFeeSchedule : public ISerialized { 
   public: 
       ExerciseFeeSchedule(TiXmlNode* xmlNode);

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
       boost::shared_ptr<ScheduleReference> getNotionalReference();
      std::string getNotionalReferenceIDRef(){return notionalReferenceIDRef_;}

       bool isFeeAmountSchedule(){return this->feeAmountScheduleIsNull_;}
       boost::shared_ptr<AmountSchedule> getFeeAmountSchedule();
      std::string getFeeAmountScheduleIDRef(){return feeAmountScheduleIDRef_;}

       bool isFeeRateSchedule(){return this->feeRateScheduleIsNull_;}
       boost::shared_ptr<Schedule> getFeeRateSchedule();
      std::string getFeeRateScheduleIDRef(){return feeRateScheduleIDRef_;}

       bool isFeePaymentDate(){return this->feePaymentDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getFeePaymentDate();
      std::string getFeePaymentDateIDRef(){return feePaymentDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!feeAmountScheduleIsNull_){
                count += 1;
                str = "feeAmountSchedule" ;
           }
           if(!feeRateScheduleIsNull_){
                count += 1;
                str = "feeRateSchedule" ;
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
       boost::shared_ptr<ScheduleReference> notionalReference_;
       std::string notionalReferenceIDRef_;
       bool notionalReferenceIsNull_;
         boost::shared_ptr<AmountSchedule> feeAmountSchedule_;     //choice
       std::string feeAmountScheduleIDRef_;
       bool feeAmountScheduleIsNull_;
         boost::shared_ptr<Schedule> feeRateSchedule_;     //choice
       std::string feeRateScheduleIDRef_;
       bool feeRateScheduleIsNull_;
       boost::shared_ptr<RelativeDateOffset> feePaymentDate_;
       std::string feePaymentDateIDRef_;
       bool feePaymentDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

