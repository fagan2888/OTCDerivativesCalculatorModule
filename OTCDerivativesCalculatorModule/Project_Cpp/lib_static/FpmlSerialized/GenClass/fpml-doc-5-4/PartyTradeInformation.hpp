// PartyTradeInformation.hpp 
#ifndef FpmlSerialized_PartyTradeInformation_hpp
#define FpmlSerialized_PartyTradeInformation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/RelatedParty.hpp>
#include <fpml-doc-5-4/ReportingRole.hpp>
#include <fpml-shared-5-4/Unit.hpp>
#include <fpml-shared-5-4/RelatedBusinessUnit.hpp>
#include <fpml-shared-5-4/RelatedPerson.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-doc-5-4/TradeCategory.hpp>
#include <fpml-doc-5-4/Trader.hpp>
#include <fpml-doc-5-4/ExecutionDateTime.hpp>
#include <fpml-doc-5-4/TradeProcessingTimestamps.hpp>
#include <fpml-doc-5-4/AllocationReportingStatus.hpp>
#include <fpml-doc-5-4/ClearingStatusValue.hpp>
#include <fpml-doc-5-4/CollateralizationType.hpp>
#include <fpml-doc-5-4/ReportingRegime.hpp>
#include <fpml-doc-5-4/EndUserExceptionDeclaration.hpp>
#include <fpml-doc-5-4/ExecutionType.hpp>
#include <fpml-doc-5-4/ExecutionVenueType.hpp>
#include <fpml-doc-5-4/VerificationMethod.hpp>
#include <fpml-doc-5-4/ConfirmationMethod.hpp>

namespace FpmlSerialized {

class PartyTradeInformation : public ISerialized { 
   public: 
       PartyTradeInformation(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isAccountReference(){return this->accountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getAccountReference();
      std::string getAccountReferenceIDRef(){return accountReferenceIDRef_;}

       bool isRelatedParty(){return this->relatedPartyIsNull_;}
       std::vector<boost::shared_ptr<RelatedParty>> getRelatedParty();
      std::string getRelatedPartyIDRef(){return relatedPartyIDRef_;}

       bool isReportingRole(){return this->reportingRoleIsNull_;}
       boost::shared_ptr<ReportingRole> getReportingRole();
      std::string getReportingRoleIDRef(){return reportingRoleIDRef_;}

       bool isUnit(){return this->unitIsNull_;}
       std::vector<boost::shared_ptr<Unit>> getUnit();
      std::string getUnitIDRef(){return unitIDRef_;}

       bool isRelatedBusinessUnit(){return this->relatedBusinessUnitIsNull_;}
       std::vector<boost::shared_ptr<RelatedBusinessUnit>> getRelatedBusinessUnit();
      std::string getRelatedBusinessUnitIDRef(){return relatedBusinessUnitIDRef_;}

       bool isRelatedPerson(){return this->relatedPersonIsNull_;}
       std::vector<boost::shared_ptr<RelatedPerson>> getRelatedPerson();
      std::string getRelatedPersonIDRef(){return relatedPersonIDRef_;}

       bool isIsAccountingHedge(){return this->isAccountingHedgeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsAccountingHedge();
      std::string getIsAccountingHedgeIDRef(){return isAccountingHedgeIDRef_;}

       bool isCategory(){return this->categoryIsNull_;}
       std::vector<boost::shared_ptr<TradeCategory>> getCategory();
      std::string getCategoryIDRef(){return categoryIDRef_;}

       bool isTrader(){return this->traderIsNull_;}
       std::vector<boost::shared_ptr<Trader>> getTrader();
      std::string getTraderIDRef(){return traderIDRef_;}

       bool isExecutionDateTime(){return this->executionDateTimeIsNull_;}
       boost::shared_ptr<ExecutionDateTime> getExecutionDateTime();
      std::string getExecutionDateTimeIDRef(){return executionDateTimeIDRef_;}

       bool isTimestamps(){return this->timestampsIsNull_;}
       boost::shared_ptr<TradeProcessingTimestamps> getTimestamps();
      std::string getTimestampsIDRef(){return timestampsIDRef_;}

       bool isIntentToAllocate(){return this->intentToAllocateIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIntentToAllocate();
      std::string getIntentToAllocateIDRef(){return intentToAllocateIDRef_;}

       bool isAllocationStatus(){return this->allocationStatusIsNull_;}
       boost::shared_ptr<AllocationReportingStatus> getAllocationStatus();
      std::string getAllocationStatusIDRef(){return allocationStatusIDRef_;}

       bool isIntentToClear(){return this->intentToClearIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIntentToClear();
      std::string getIntentToClearIDRef(){return intentToClearIDRef_;}

       bool isClearingStatus(){return this->clearingStatusIsNull_;}
       boost::shared_ptr<ClearingStatusValue> getClearingStatus();
      std::string getClearingStatusIDRef(){return clearingStatusIDRef_;}

       bool isCollateralizationType(){return this->collateralizationTypeIsNull_;}
       boost::shared_ptr<CollateralizationType> getCollateralizationType();
      std::string getCollateralizationTypeIDRef(){return collateralizationTypeIDRef_;}

       bool isReportingRegime(){return this->reportingRegimeIsNull_;}
       std::vector<boost::shared_ptr<ReportingRegime>> getReportingRegime();
      std::string getReportingRegimeIDRef(){return reportingRegimeIDRef_;}

       bool isEndUserException(){return this->endUserExceptionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getEndUserException();
      std::string getEndUserExceptionIDRef(){return endUserExceptionIDRef_;}

       bool isEndUserExceptionDeclaration(){return this->endUserExceptionDeclarationIsNull_;}
       boost::shared_ptr<EndUserExceptionDeclaration> getEndUserExceptionDeclaration();
      std::string getEndUserExceptionDeclarationIDRef(){return endUserExceptionDeclarationIDRef_;}

       bool isNonStandardTerms(){return this->nonStandardTermsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNonStandardTerms();
      std::string getNonStandardTermsIDRef(){return nonStandardTermsIDRef_;}

       bool isOffMarketPrice(){return this->offMarketPriceIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getOffMarketPrice();
      std::string getOffMarketPriceIDRef(){return offMarketPriceIDRef_;}

       bool isLargeSizeTrade(){return this->largeSizeTradeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getLargeSizeTrade();
      std::string getLargeSizeTradeIDRef(){return largeSizeTradeIDRef_;}

       bool isExecutionType(){return this->executionTypeIsNull_;}
       boost::shared_ptr<ExecutionType> getExecutionType();
      std::string getExecutionTypeIDRef(){return executionTypeIDRef_;}

       bool isExecutionVenueType(){return this->executionVenueTypeIsNull_;}
       boost::shared_ptr<ExecutionVenueType> getExecutionVenueType();
      std::string getExecutionVenueTypeIDRef(){return executionVenueTypeIDRef_;}

       bool isVerificationMethod(){return this->verificationMethodIsNull_;}
       boost::shared_ptr<VerificationMethod> getVerificationMethod();
      std::string getVerificationMethodIDRef(){return verificationMethodIDRef_;}

       bool isConfirmationMethod(){return this->confirmationMethodIsNull_;}
       boost::shared_ptr<ConfirmationMethod> getConfirmationMethod();
      std::string getConfirmationMethodIDRef(){return confirmationMethodIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!endUserExceptionIsNull_){
                count += 1;
                str = "endUserException" ;
           }
           if(!endUserExceptionDeclarationIsNull_){
                count += 1;
                str = "endUserExceptionDeclaration" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       boost::shared_ptr<AccountReference> accountReference_;
       std::string accountReferenceIDRef_;
       bool accountReferenceIsNull_;
       std::vector<boost::shared_ptr<RelatedParty>> relatedParty_;
       std::string relatedPartyIDRef_;
       bool relatedPartyIsNull_;
       boost::shared_ptr<ReportingRole> reportingRole_;
       std::string reportingRoleIDRef_;
       bool reportingRoleIsNull_;
       std::vector<boost::shared_ptr<Unit>> unit_;
       std::string unitIDRef_;
       bool unitIsNull_;
       std::vector<boost::shared_ptr<RelatedBusinessUnit>> relatedBusinessUnit_;
       std::string relatedBusinessUnitIDRef_;
       bool relatedBusinessUnitIsNull_;
       std::vector<boost::shared_ptr<RelatedPerson>> relatedPerson_;
       std::string relatedPersonIDRef_;
       bool relatedPersonIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isAccountingHedge_;
       std::string isAccountingHedgeIDRef_;
       bool isAccountingHedgeIsNull_;
       std::vector<boost::shared_ptr<TradeCategory>> category_;
       std::string categoryIDRef_;
       bool categoryIsNull_;
       std::vector<boost::shared_ptr<Trader>> trader_;
       std::string traderIDRef_;
       bool traderIsNull_;
       boost::shared_ptr<ExecutionDateTime> executionDateTime_;
       std::string executionDateTimeIDRef_;
       bool executionDateTimeIsNull_;
       boost::shared_ptr<TradeProcessingTimestamps> timestamps_;
       std::string timestampsIDRef_;
       bool timestampsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> intentToAllocate_;
       std::string intentToAllocateIDRef_;
       bool intentToAllocateIsNull_;
       boost::shared_ptr<AllocationReportingStatus> allocationStatus_;
       std::string allocationStatusIDRef_;
       bool allocationStatusIsNull_;
       boost::shared_ptr<XsdTypeBoolean> intentToClear_;
       std::string intentToClearIDRef_;
       bool intentToClearIsNull_;
       boost::shared_ptr<ClearingStatusValue> clearingStatus_;
       std::string clearingStatusIDRef_;
       bool clearingStatusIsNull_;
       boost::shared_ptr<CollateralizationType> collateralizationType_;
       std::string collateralizationTypeIDRef_;
       bool collateralizationTypeIsNull_;
       std::vector<boost::shared_ptr<ReportingRegime>> reportingRegime_;
       std::string reportingRegimeIDRef_;
       bool reportingRegimeIsNull_;
         boost::shared_ptr<XsdTypeBoolean> endUserException_;     //choice
       std::string endUserExceptionIDRef_;
       bool endUserExceptionIsNull_;
         boost::shared_ptr<EndUserExceptionDeclaration> endUserExceptionDeclaration_;     //choice
       std::string endUserExceptionDeclarationIDRef_;
       bool endUserExceptionDeclarationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> nonStandardTerms_;
       std::string nonStandardTermsIDRef_;
       bool nonStandardTermsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> offMarketPrice_;
       std::string offMarketPriceIDRef_;
       bool offMarketPriceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> largeSizeTrade_;
       std::string largeSizeTradeIDRef_;
       bool largeSizeTradeIsNull_;
       boost::shared_ptr<ExecutionType> executionType_;
       std::string executionTypeIDRef_;
       bool executionTypeIsNull_;
       boost::shared_ptr<ExecutionVenueType> executionVenueType_;
       std::string executionVenueTypeIDRef_;
       bool executionVenueTypeIsNull_;
       boost::shared_ptr<VerificationMethod> verificationMethod_;
       std::string verificationMethodIDRef_;
       bool verificationMethodIsNull_;
       boost::shared_ptr<ConfirmationMethod> confirmationMethod_;
       std::string confirmationMethodIDRef_;
       bool confirmationMethodIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

