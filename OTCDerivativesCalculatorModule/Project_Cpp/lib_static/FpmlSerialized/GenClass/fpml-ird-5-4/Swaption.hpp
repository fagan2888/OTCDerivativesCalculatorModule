// Swaption.hpp 
#ifndef FpmlSerialized_Swaption_hpp
#define FpmlSerialized_Swaption_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/Payment.hpp>
#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AmericanExercise.hpp>
#include <fpml-shared-5-4/BermudaExercise.hpp>
#include <fpml-shared-5-4/EuropeanExercise.hpp>
#include <fpml-shared-5-4/ExerciseProcedure.hpp>
#include <fpml-shared-5-4/CalculationAgent.hpp>
#include <fpml-ird-5-4/CashSettlement.hpp>
#include <fpml-ird-5-4/SwaptionPhysicalSettlement.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-ird-5-4/SwaptionAdjustedDates.hpp>
#include <fpml-ird-5-4/Swap.hpp>

namespace FpmlSerialized {

class Swaption : public Product { 
   public: 
       Swaption(TiXmlNode* xmlNode);

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

       bool isPremium(){return this->premiumIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getPremium();
      std::string getPremiumIDRef(){return premiumIDRef_;}

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

       bool isExerciseProcedure(){return this->exerciseProcedureIsNull_;}
       boost::shared_ptr<ExerciseProcedure> getExerciseProcedure();
      std::string getExerciseProcedureIDRef(){return exerciseProcedureIDRef_;}

       bool isCalculationAgent(){return this->calculationAgentIsNull_;}
       boost::shared_ptr<CalculationAgent> getCalculationAgent();
      std::string getCalculationAgentIDRef(){return calculationAgentIDRef_;}

       bool isCashSettlement(){return this->cashSettlementIsNull_;}
       boost::shared_ptr<CashSettlement> getCashSettlement();
      std::string getCashSettlementIDRef(){return cashSettlementIDRef_;}

       bool isPhysicalSettlement(){return this->physicalSettlementIsNull_;}
       boost::shared_ptr<SwaptionPhysicalSettlement> getPhysicalSettlement();
      std::string getPhysicalSettlementIDRef(){return physicalSettlementIDRef_;}

       bool isSwaptionStraddle(){return this->swaptionStraddleIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSwaptionStraddle();
      std::string getSwaptionStraddleIDRef(){return swaptionStraddleIDRef_;}

       bool isSwaptionAdjustedDates(){return this->swaptionAdjustedDatesIsNull_;}
       boost::shared_ptr<SwaptionAdjustedDates> getSwaptionAdjustedDates();
      std::string getSwaptionAdjustedDatesIDRef(){return swaptionAdjustedDatesIDRef_;}

       bool isSwap(){return this->swapIsNull_;}
       boost::shared_ptr<Swap> getSwap();
      std::string getSwapIDRef(){return swapIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!cashSettlementIsNull_){
                count += 1;
                str = "cashSettlement" ;
           }
           if(!physicalSettlementIsNull_){
                count += 1;
                str = "physicalSettlement" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
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
       std::vector<boost::shared_ptr<Payment>> premium_;
       std::string premiumIDRef_;
       bool premiumIsNull_;
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
       boost::shared_ptr<ExerciseProcedure> exerciseProcedure_;
       std::string exerciseProcedureIDRef_;
       bool exerciseProcedureIsNull_;
       boost::shared_ptr<CalculationAgent> calculationAgent_;
       std::string calculationAgentIDRef_;
       bool calculationAgentIsNull_;
         boost::shared_ptr<CashSettlement> cashSettlement_;     //choice
       std::string cashSettlementIDRef_;
       bool cashSettlementIsNull_;
         boost::shared_ptr<SwaptionPhysicalSettlement> physicalSettlement_;     //choice
       std::string physicalSettlementIDRef_;
       bool physicalSettlementIsNull_;
       boost::shared_ptr<XsdTypeBoolean> swaptionStraddle_;
       std::string swaptionStraddleIDRef_;
       bool swaptionStraddleIsNull_;
       boost::shared_ptr<SwaptionAdjustedDates> swaptionAdjustedDates_;
       std::string swaptionAdjustedDatesIDRef_;
       bool swaptionAdjustedDatesIsNull_;
       boost::shared_ptr<Swap> swap_;
       std::string swapIDRef_;
       bool swapIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

