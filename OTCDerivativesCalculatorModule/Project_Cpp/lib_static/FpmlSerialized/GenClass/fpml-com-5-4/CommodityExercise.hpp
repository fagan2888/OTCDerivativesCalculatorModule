// CommodityExercise.hpp 
#ifndef FpmlSerialized_CommodityExercise_hpp
#define FpmlSerialized_CommodityExercise_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityAmericanExercise.hpp>
#include <fpml-com-5-4/CommodityEuropeanExercise.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/IdentifiedCurrency.hpp>
#include <fpml-com-5-4/CommodityFx.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-com-5-4/CommodityRelativePaymentDates.hpp>
#include <fpml-shared-5-4/AdjustableDatesOrRelativeDateOffset.hpp>

namespace FpmlSerialized {

class CommodityExercise : public ISerialized { 
   public: 
       CommodityExercise(TiXmlNode* xmlNode);

       bool isAmericanExercise(){return this->americanExerciseIsNull_;}
       boost::shared_ptr<CommodityAmericanExercise> getAmericanExercise();
      std::string getAmericanExerciseIDRef(){return americanExerciseIDRef_;}

       bool isEuropeanExercise(){return this->europeanExerciseIsNull_;}
       boost::shared_ptr<CommodityEuropeanExercise> getEuropeanExercise();
      std::string getEuropeanExerciseIDRef(){return europeanExerciseIDRef_;}

       bool isAutomaticExercise(){return this->automaticExerciseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAutomaticExercise();
      std::string getAutomaticExerciseIDRef(){return automaticExerciseIDRef_;}

       bool isWrittenConfirmation(){return this->writtenConfirmationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getWrittenConfirmation();
      std::string getWrittenConfirmationIDRef(){return writtenConfirmationIDRef_;}

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<IdentifiedCurrency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       bool isFx(){return this->fxIsNull_;}
       boost::shared_ptr<CommodityFx> getFx();
      std::string getFxIDRef(){return fxIDRef_;}

       bool isConversionFactor(){return this->conversionFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getConversionFactor();
      std::string getConversionFactorIDRef(){return conversionFactorIDRef_;}

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
           if(!americanExerciseIsNull_){
                count += 1;
                str = "americanExercise" ;
           }
           if(!europeanExerciseIsNull_){
                count += 1;
                str = "europeanExercise" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!relativePaymentDatesIsNull_){
                count += 1;
                str = "relativePaymentDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
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
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
   protected: 
         boost::shared_ptr<CommodityAmericanExercise> americanExercise_;     //choice
       std::string americanExerciseIDRef_;
       bool americanExerciseIsNull_;
         boost::shared_ptr<CommodityEuropeanExercise> europeanExercise_;     //choice
       std::string europeanExerciseIDRef_;
       bool europeanExerciseIsNull_;
       boost::shared_ptr<XsdTypeBoolean> automaticExercise_;
       std::string automaticExerciseIDRef_;
       bool automaticExerciseIsNull_;
       boost::shared_ptr<XsdTypeBoolean> writtenConfirmation_;
       std::string writtenConfirmationIDRef_;
       bool writtenConfirmationIsNull_;
       boost::shared_ptr<IdentifiedCurrency> settlementCurrency_;
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;
       boost::shared_ptr<CommodityFx> fx_;
       std::string fxIDRef_;
       bool fxIsNull_;
       boost::shared_ptr<XsdTypeDecimal> conversionFactor_;
       std::string conversionFactorIDRef_;
       bool conversionFactorIsNull_;
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
       std::string choiceStr_2_;

};

} //namespaceFpmlSerialized end
#endif

