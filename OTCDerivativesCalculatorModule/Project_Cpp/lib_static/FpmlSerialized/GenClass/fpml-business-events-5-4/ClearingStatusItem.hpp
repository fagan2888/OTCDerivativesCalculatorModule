// ClearingStatusItem.hpp 
#ifndef FpmlSerialized_ClearingStatusItem_hpp
#define FpmlSerialized_ClearingStatusItem_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/TradeIdentifier.hpp>
#include <fpml-business-events-5-4/TradeReferenceInformation.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <fpml-doc-5-4/ClearingStatusValue.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>
#include <fpml-msg-5-4/Reason.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class ClearingStatusItem : public ISerialized { 
   public: 
       ClearingStatusItem(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<TradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isTradeReferenceInformation(){return this->tradeReferenceInformationIsNull_;}
       boost::shared_ptr<TradeReferenceInformation> getTradeReferenceInformation();
      std::string getTradeReferenceInformationIDRef(){return tradeReferenceInformationIDRef_;}

       bool isTrade(){return this->tradeIsNull_;}
       boost::shared_ptr<Trade> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isClearingStatusValue(){return this->clearingStatusValueIsNull_;}
       boost::shared_ptr<ClearingStatusValue> getClearingStatusValue();
      std::string getClearingStatusValueIDRef(){return clearingStatusValueIDRef_;}

       bool isUpdatedDateTime(){return this->updatedDateTimeIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getUpdatedDateTime();
      std::string getUpdatedDateTimeIDRef(){return updatedDateTimeIDRef_;}

       bool isReason(){return this->reasonIsNull_;}
       std::vector<boost::shared_ptr<Reason>> getReason();
      std::string getReasonIDRef(){return reasonIDRef_;}

       bool isStatusAppliesTo(){return this->statusAppliesToIsNull_;}
       std::vector<boost::shared_ptr<PartyReference>> getStatusAppliesTo();
      std::string getStatusAppliesToIDRef(){return statusAppliesToIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!tradeIdentifierIsNull_){
                count += 1;
                str = "tradeIdentifier" ;
           }
           if(!tradeReferenceInformationIsNull_){
                count += 1;
                str = "tradeReferenceInformation" ;
           }
           if(!tradeIsNull_){
                count += 1;
                str = "trade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         std::vector<boost::shared_ptr<TradeIdentifier>> tradeIdentifier_;     //choice
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
         boost::shared_ptr<TradeReferenceInformation> tradeReferenceInformation_;     //choice
       std::string tradeReferenceInformationIDRef_;
       bool tradeReferenceInformationIsNull_;
         boost::shared_ptr<Trade> trade_;     //choice
       std::string tradeIDRef_;
       bool tradeIsNull_;
       boost::shared_ptr<ClearingStatusValue> clearingStatusValue_;
       std::string clearingStatusValueIDRef_;
       bool clearingStatusValueIsNull_;
       boost::shared_ptr<XsdTypeDateTime> updatedDateTime_;
       std::string updatedDateTimeIDRef_;
       bool updatedDateTimeIsNull_;
       std::vector<boost::shared_ptr<Reason>> reason_;
       std::string reasonIDRef_;
       bool reasonIsNull_;
       std::vector<boost::shared_ptr<PartyReference>> statusAppliesTo_;
       std::string statusAppliesToIDRef_;
       bool statusAppliesToIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

