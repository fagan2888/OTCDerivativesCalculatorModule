// EquitySwapTransactionSupplement.hpp 
#ifndef FpmlSerialized_EquitySwapTransactionSupplement_hpp
#define FpmlSerialized_EquitySwapTransactionSupplement_hpp

#include <fpml-eq-shared-5-4/ReturnSwapBase.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/FeeElectionEnum.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>
#include <fpml-eq-shared-5-4/ExtraordinaryEvents.hpp>

namespace FpmlSerialized {

class EquitySwapTransactionSupplement : public ReturnSwapBase { 
   public: 
       EquitySwapTransactionSupplement(TiXmlNode* xmlNode);

       bool isMutualEarlyTermination(){return this->mutualEarlyTerminationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMutualEarlyTermination();
      std::string getMutualEarlyTerminationIDRef(){return mutualEarlyTerminationIDRef_;}

       bool isOptionalEarlyTermination(){return this->optionalEarlyTerminationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getOptionalEarlyTermination();
      std::string getOptionalEarlyTerminationIDRef(){return optionalEarlyTerminationIDRef_;}

       bool isBreakFundingRecovery(){return this->breakFundingRecoveryIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getBreakFundingRecovery();
      std::string getBreakFundingRecoveryIDRef(){return breakFundingRecoveryIDRef_;}

       bool isBreakFeeElection(){return this->breakFeeElectionIsNull_;}
       boost::shared_ptr<FeeElectionEnum> getBreakFeeElection();
      std::string getBreakFeeElectionIDRef(){return breakFeeElectionIDRef_;}

       bool isBreakFeeRate(){return this->breakFeeRateIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getBreakFeeRate();
      std::string getBreakFeeRateIDRef(){return breakFeeRateIDRef_;}

       bool isMultipleExchangeIndexAnnexFallback(){return this->multipleExchangeIndexAnnexFallbackIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMultipleExchangeIndexAnnexFallback();
      std::string getMultipleExchangeIndexAnnexFallbackIDRef(){return multipleExchangeIndexAnnexFallbackIDRef_;}

       bool isComponentSecurityIndexAnnexFallback(){return this->componentSecurityIndexAnnexFallbackIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getComponentSecurityIndexAnnexFallback();
      std::string getComponentSecurityIndexAnnexFallbackIDRef(){return componentSecurityIndexAnnexFallbackIDRef_;}

       bool isLocalJurisdiction(){return this->localJurisdictionIsNull_;}
       boost::shared_ptr<CountryCode> getLocalJurisdiction();
      std::string getLocalJurisdictionIDRef(){return localJurisdictionIDRef_;}

       bool isRelevantJurisdiction(){return this->relevantJurisdictionIsNull_;}
       boost::shared_ptr<CountryCode> getRelevantJurisdiction();
      std::string getRelevantJurisdictionIDRef(){return relevantJurisdictionIDRef_;}

       bool isExtraordinaryEvents(){return this->extraordinaryEventsIsNull_;}
       boost::shared_ptr<ExtraordinaryEvents> getExtraordinaryEvents();
      std::string getExtraordinaryEventsIDRef(){return extraordinaryEventsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!mutualEarlyTerminationIsNull_){
                count += 1;
                str = "mutualEarlyTermination" ;
           }
           if(!optionalEarlyTerminationIsNull_){
                count += 1;
                str = "optionalEarlyTermination" ;
           }
           if(!breakFundingRecoveryIsNull_){
                count += 1;
                str = "breakFundingRecovery" ;
           }
           if(!breakFeeElectionIsNull_){
                count += 1;
                str = "breakFeeElection" ;
           }
           if(!breakFeeRateIsNull_){
                count += 1;
                str = "breakFeeRate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!multipleExchangeIndexAnnexFallbackIsNull_){
                count += 1;
                str = "multipleExchangeIndexAnnexFallback" ;
           }
           if(!componentSecurityIndexAnnexFallbackIsNull_){
                count += 1;
                str = "componentSecurityIndexAnnexFallback" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<XsdTypeBoolean> mutualEarlyTermination_;     //choice
       std::string mutualEarlyTerminationIDRef_;
       bool mutualEarlyTerminationIsNull_;
         boost::shared_ptr<XsdTypeBoolean> optionalEarlyTermination_;     //choice
       std::string optionalEarlyTerminationIDRef_;
       bool optionalEarlyTerminationIsNull_;
         boost::shared_ptr<XsdTypeBoolean> breakFundingRecovery_;     //choice
       std::string breakFundingRecoveryIDRef_;
       bool breakFundingRecoveryIsNull_;
         boost::shared_ptr<FeeElectionEnum> breakFeeElection_;     //choice
       std::string breakFeeElectionIDRef_;
       bool breakFeeElectionIsNull_;
         boost::shared_ptr<NonNegativeDecimal> breakFeeRate_;     //choice
       std::string breakFeeRateIDRef_;
       bool breakFeeRateIsNull_;
         boost::shared_ptr<XsdTypeBoolean> multipleExchangeIndexAnnexFallback_;     //choice
       std::string multipleExchangeIndexAnnexFallbackIDRef_;
       bool multipleExchangeIndexAnnexFallbackIsNull_;
         boost::shared_ptr<XsdTypeBoolean> componentSecurityIndexAnnexFallback_;     //choice
       std::string componentSecurityIndexAnnexFallbackIDRef_;
       bool componentSecurityIndexAnnexFallbackIsNull_;
       boost::shared_ptr<CountryCode> localJurisdiction_;
       std::string localJurisdictionIDRef_;
       bool localJurisdictionIsNull_;
       boost::shared_ptr<CountryCode> relevantJurisdiction_;
       std::string relevantJurisdictionIDRef_;
       bool relevantJurisdictionIsNull_;
       boost::shared_ptr<ExtraordinaryEvents> extraordinaryEvents_;
       std::string extraordinaryEventsIDRef_;
       bool extraordinaryEventsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

