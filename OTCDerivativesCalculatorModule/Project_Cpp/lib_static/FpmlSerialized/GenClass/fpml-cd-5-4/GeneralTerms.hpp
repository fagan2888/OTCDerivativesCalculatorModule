// GeneralTerms.hpp 
#ifndef FpmlSerialized_GeneralTerms_hpp
#define FpmlSerialized_GeneralTerms_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDate2.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>
#include <fpml-cd-5-4/ReferenceInformation.hpp>
#include <fpml-cd-5-4/IndexReferenceInformation.hpp>
#include <fpml-cd-5-4/BasketReferenceInformation.hpp>
#include <fpml-cd-5-4/AdditionalTerm.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class GeneralTerms : public ISerialized { 
   public: 
       GeneralTerms(TiXmlNode* xmlNode);

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableDate2> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isScheduledTerminationDate(){return this->scheduledTerminationDateIsNull_;}
       boost::shared_ptr<AdjustableDate2> getScheduledTerminationDate();
      std::string getScheduledTerminationDateIDRef(){return scheduledTerminationDateIDRef_;}

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

       bool isDateAdjustments(){return this->dateAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getDateAdjustments();
      std::string getDateAdjustmentsIDRef(){return dateAdjustmentsIDRef_;}

       bool isReferenceInformation(){return this->referenceInformationIsNull_;}
       boost::shared_ptr<ReferenceInformation> getReferenceInformation();
      std::string getReferenceInformationIDRef(){return referenceInformationIDRef_;}

       bool isIndexReferenceInformation(){return this->indexReferenceInformationIsNull_;}
       boost::shared_ptr<IndexReferenceInformation> getIndexReferenceInformation();
      std::string getIndexReferenceInformationIDRef(){return indexReferenceInformationIDRef_;}

       bool isBasketReferenceInformation(){return this->basketReferenceInformationIsNull_;}
       boost::shared_ptr<BasketReferenceInformation> getBasketReferenceInformation();
      std::string getBasketReferenceInformationIDRef(){return basketReferenceInformationIDRef_;}

       bool isAdditionalTerm(){return this->additionalTermIsNull_;}
       std::vector<boost::shared_ptr<AdditionalTerm>> getAdditionalTerm();
      std::string getAdditionalTermIDRef(){return additionalTermIDRef_;}

       bool isSubstitution(){return this->substitutionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSubstitution();
      std::string getSubstitutionIDRef(){return substitutionIDRef_;}

       bool isModifiedEquityDelivery(){return this->modifiedEquityDeliveryIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getModifiedEquityDelivery();
      std::string getModifiedEquityDeliveryIDRef(){return modifiedEquityDeliveryIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!referenceInformationIsNull_){
                count += 1;
                str = "referenceInformation" ;
           }
           if(!indexReferenceInformationIsNull_){
                count += 1;
                str = "indexReferenceInformation" ;
           }
           if(!basketReferenceInformationIsNull_){
                count += 1;
                str = "basketReferenceInformation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<AdjustableDate2> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<AdjustableDate2> scheduledTerminationDate_;
       std::string scheduledTerminationDateIDRef_;
       bool scheduledTerminationDateIsNull_;
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
       boost::shared_ptr<BusinessDayAdjustments> dateAdjustments_;
       std::string dateAdjustmentsIDRef_;
       bool dateAdjustmentsIsNull_;
         boost::shared_ptr<ReferenceInformation> referenceInformation_;     //choice
       std::string referenceInformationIDRef_;
       bool referenceInformationIsNull_;
         boost::shared_ptr<IndexReferenceInformation> indexReferenceInformation_;     //choice
       std::string indexReferenceInformationIDRef_;
       bool indexReferenceInformationIsNull_;
         boost::shared_ptr<BasketReferenceInformation> basketReferenceInformation_;     //choice
       std::string basketReferenceInformationIDRef_;
       bool basketReferenceInformationIsNull_;
       std::vector<boost::shared_ptr<AdditionalTerm>> additionalTerm_;
       std::string additionalTermIDRef_;
       bool additionalTermIsNull_;
       boost::shared_ptr<XsdTypeBoolean> substitution_;
       std::string substitutionIDRef_;
       bool substitutionIsNull_;
       boost::shared_ptr<XsdTypeBoolean> modifiedEquityDelivery_;
       std::string modifiedEquityDeliveryIDRef_;
       bool modifiedEquityDeliveryIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

