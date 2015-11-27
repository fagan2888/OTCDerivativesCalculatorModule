// Allocation.hpp 
#ifndef FpmlSerialized_Allocation_hpp
#define FpmlSerialized_Allocation_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/TradeIdentifier.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-doc-5-4/Collateral.hpp>
#include <fpml-doc-5-4/Approvals.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/RelatedParty.hpp>

namespace FpmlSerialized {

class Allocation : public ISerialized { 
   public: 
       Allocation(TiXmlNode* xmlNode);

       bool isAllocationTradeId(){return this->allocationTradeIdIsNull_;}
       std::vector<boost::shared_ptr<TradeIdentifier>> getAllocationTradeId();
      std::string getAllocationTradeIdIDRef(){return allocationTradeIdIDRef_;}

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isAccountReference(){return this->accountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getAccountReference();
      std::string getAccountReferenceIDRef(){return accountReferenceIDRef_;}

       bool isAllocatedFraction(){return this->allocatedFractionIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAllocatedFraction();
      std::string getAllocatedFractionIDRef(){return allocatedFractionIDRef_;}

       bool isAllocatedNotional(){return this->allocatedNotionalIsNull_;}
       std::vector<boost::shared_ptr<Money>> getAllocatedNotional();
      std::string getAllocatedNotionalIDRef(){return allocatedNotionalIDRef_;}

       bool isCollateral(){return this->collateralIsNull_;}
       boost::shared_ptr<Collateral> getCollateral();
      std::string getCollateralIDRef(){return collateralIDRef_;}

       bool isCreditChargeAmount(){return this->creditChargeAmountIsNull_;}
       boost::shared_ptr<Money> getCreditChargeAmount();
      std::string getCreditChargeAmountIDRef(){return creditChargeAmountIDRef_;}

       bool isApprovals(){return this->approvalsIsNull_;}
       boost::shared_ptr<Approvals> getApprovals();
      std::string getApprovalsIDRef(){return approvalsIDRef_;}

       bool isMasterConfirmationDate(){return this->masterConfirmationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMasterConfirmationDate();
      std::string getMasterConfirmationDateIDRef(){return masterConfirmationDateIDRef_;}

       bool isRelatedParty(){return this->relatedPartyIsNull_;}
       std::vector<boost::shared_ptr<RelatedParty>> getRelatedParty();
      std::string getRelatedPartyIDRef(){return relatedPartyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!allocatedFractionIsNull_){
                count += 1;
                str = "allocatedFraction" ;
           }
           if(!allocatedNotionalIsNull_){
                count += 1;
                str = "allocatedNotional" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       std::vector<boost::shared_ptr<TradeIdentifier>> allocationTradeId_;
       std::string allocationTradeIdIDRef_;
       bool allocationTradeIdIsNull_;
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       boost::shared_ptr<AccountReference> accountReference_;
       std::string accountReferenceIDRef_;
       bool accountReferenceIsNull_;
         boost::shared_ptr<XsdTypeDecimal> allocatedFraction_;     //choice
       std::string allocatedFractionIDRef_;
       bool allocatedFractionIsNull_;
         std::vector<boost::shared_ptr<Money>> allocatedNotional_;     //choice
       std::string allocatedNotionalIDRef_;
       bool allocatedNotionalIsNull_;
       boost::shared_ptr<Collateral> collateral_;
       std::string collateralIDRef_;
       bool collateralIsNull_;
       boost::shared_ptr<Money> creditChargeAmount_;
       std::string creditChargeAmountIDRef_;
       bool creditChargeAmountIsNull_;
       boost::shared_ptr<Approvals> approvals_;
       std::string approvalsIDRef_;
       bool approvalsIsNull_;
       boost::shared_ptr<XsdTypeDate> masterConfirmationDate_;
       std::string masterConfirmationDateIDRef_;
       bool masterConfirmationDateIsNull_;
       std::vector<boost::shared_ptr<RelatedParty>> relatedParty_;
       std::string relatedPartyIDRef_;
       bool relatedPartyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

