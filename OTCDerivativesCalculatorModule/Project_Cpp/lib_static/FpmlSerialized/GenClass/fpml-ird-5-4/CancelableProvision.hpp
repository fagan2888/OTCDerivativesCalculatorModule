// CancelableProvision.hpp 
#ifndef FpmlSerialized_CancelableProvision_hpp
#define FpmlSerialized_CancelableProvision_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AmericanExercise.hpp>
#include <fpml-shared-5-4/BermudaExercise.hpp>
#include <fpml-shared-5-4/EuropeanExercise.hpp>
#include <fpml-shared-5-4/ExerciseNotice.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-ird-5-4/CancelableProvisionAdjustedDates.hpp>
#include <fpml-ird-5-4/FinalCalculationPeriodDateAdjustment.hpp>
#include <fpml-shared-5-4/SimplePayment.hpp>

namespace FpmlSerialized {

class CancelableProvision : public ISerialized { 
   public: 
       CancelableProvision(TiXmlNode* xmlNode);

       bool isBuyerPartyReference(){return this->buyerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getBuyerPartyReference();
      std::string getBuyerPartyReferenceIDRef(){return buyerPartyReferenceIDRef_;}

       bool isBuyerAccountReference(){return this->buyerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getBuyerAccountReference();
      std::string getBuyerAccountReferenceIDRef(){return buyerAccountReferenceIDRef_;}

       bool isSellerPartyReference(){return this->sellerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getSellerPartyReference();
      std::string getSellerPartyReferenceIDRef(){return sellerPartyReferenceIDRef_;}

       bool isSellerAccountReference(){return this->sellerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getSellerAccountReference();
      std::string getSellerAccountReferenceIDRef(){return sellerAccountReferenceIDRef_;}

       bool isExercise(){return this->exerciseIsNull_;}
       boost::shared_ptr<Exercise> getExercise();
      std::string getExerciseIDRef(){return exerciseIDRef_;}

       bool isAmericanExercise(){return this->americanExerciseIsNull_;}
       boost::shared_ptr<AmericanExercise> getAmericanExercise();
      std::string getAmericanExerciseIDRef(){return americanExerciseIDRef_;}

       bool isBermudaExercise(){return this->bermudaExerciseIsNull_;}
       boost::shared_ptr<BermudaExercise> getBermudaExercise();
      std::string getBermudaExerciseIDRef(){return bermudaExerciseIDRef_;}

       bool isEuropeanExercise(){return this->europeanExerciseIsNull_;}
       boost::shared_ptr<EuropeanExercise> getEuropeanExercise();
      std::string getEuropeanExerciseIDRef(){return europeanExerciseIDRef_;}

       bool isExerciseNotice(){return this->exerciseNoticeIsNull_;}
       boost::shared_ptr<ExerciseNotice> getExerciseNotice();
      std::string getExerciseNoticeIDRef(){return exerciseNoticeIDRef_;}

       bool isFollowUpConfirmation(){return this->followUpConfirmationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFollowUpConfirmation();
      std::string getFollowUpConfirmationIDRef(){return followUpConfirmationIDRef_;}

       bool isCancelableProvisionAdjustedDates(){return this->cancelableProvisionAdjustedDatesIsNull_;}
       boost::shared_ptr<CancelableProvisionAdjustedDates> getCancelableProvisionAdjustedDates();
      std::string getCancelableProvisionAdjustedDatesIDRef(){return cancelableProvisionAdjustedDatesIDRef_;}

       bool isFinalCalculationPeriodDateAdjustment(){return this->finalCalculationPeriodDateAdjustmentIsNull_;}
       std::vector<boost::shared_ptr<FinalCalculationPeriodDateAdjustment>> getFinalCalculationPeriodDateAdjustment();
      std::string getFinalCalculationPeriodDateAdjustmentIDRef(){return finalCalculationPeriodDateAdjustmentIDRef_;}

       bool isInitialFee(){return this->initialFeeIsNull_;}
       boost::shared_ptr<SimplePayment> getInitialFee();
      std::string getInitialFeeIDRef(){return initialFeeIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> buyerPartyReference_;
       std::string buyerPartyReferenceIDRef_;
       bool buyerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> buyerAccountReference_;
       std::string buyerAccountReferenceIDRef_;
       bool buyerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> sellerPartyReference_;
       std::string sellerPartyReferenceIDRef_;
       bool sellerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> sellerAccountReference_;
       std::string sellerAccountReferenceIDRef_;
       bool sellerAccountReferenceIsNull_;
       boost::shared_ptr<Exercise> exercise_;
       std::string exerciseIDRef_;
       bool exerciseIsNull_;
       boost::shared_ptr<AmericanExercise> americanExercise_;     //substitude 
       std::string americanExerciseIDRef_;
       bool americanExerciseIsNull_;
       boost::shared_ptr<BermudaExercise> bermudaExercise_;     //substitude 
       std::string bermudaExerciseIDRef_;
       bool bermudaExerciseIsNull_;
       boost::shared_ptr<EuropeanExercise> europeanExercise_;     //substitude 
       std::string europeanExerciseIDRef_;
       bool europeanExerciseIsNull_;
       boost::shared_ptr<ExerciseNotice> exerciseNotice_;
       std::string exerciseNoticeIDRef_;
       bool exerciseNoticeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> followUpConfirmation_;
       std::string followUpConfirmationIDRef_;
       bool followUpConfirmationIsNull_;
       boost::shared_ptr<CancelableProvisionAdjustedDates> cancelableProvisionAdjustedDates_;
       std::string cancelableProvisionAdjustedDatesIDRef_;
       bool cancelableProvisionAdjustedDatesIsNull_;
       std::vector<boost::shared_ptr<FinalCalculationPeriodDateAdjustment>> finalCalculationPeriodDateAdjustment_;
       std::string finalCalculationPeriodDateAdjustmentIDRef_;
       bool finalCalculationPeriodDateAdjustmentIsNull_;
       boost::shared_ptr<SimplePayment> initialFee_;
       std::string initialFeeIDRef_;
       bool initialFeeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

