// ExtendibleProvision.hpp 
#ifndef FpmlSerialized_ExtendibleProvision_hpp
#define FpmlSerialized_ExtendibleProvision_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AmericanExercise.hpp>
#include <fpml-shared-5-4/BermudaExercise.hpp>
#include <fpml-shared-5-4/EuropeanExercise.hpp>
#include <fpml-shared-5-4/ExerciseNotice.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-ird-5-4/ExtendibleProvisionAdjustedDates.hpp>

namespace FpmlSerialized {

class ExtendibleProvision : public ISerialized { 
   public: 
       ExtendibleProvision(TiXmlNode* xmlNode);

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

       bool isExtendibleProvisionAdjustedDates(){return this->extendibleProvisionAdjustedDatesIsNull_;}
       boost::shared_ptr<ExtendibleProvisionAdjustedDates> getExtendibleProvisionAdjustedDates();
      std::string getExtendibleProvisionAdjustedDatesIDRef(){return extendibleProvisionAdjustedDatesIDRef_;}

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
       boost::shared_ptr<ExtendibleProvisionAdjustedDates> extendibleProvisionAdjustedDates_;
       std::string extendibleProvisionAdjustedDatesIDRef_;
       bool extendibleProvisionAdjustedDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

