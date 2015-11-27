// TradeReferenceInformation.hpp 
#ifndef FpmlSerialized_TradeReferenceInformation_hpp
#define FpmlSerialized_TradeReferenceInformation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/OriginatingEvent.hpp>
#include <fpml-business-events-5-4/TerminatingEvent.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-doc-5-4/PartyTradeInformation.hpp>
#include <fpml-shared-5-4/ProductType.hpp>
#include <fpml-shared-5-4/ProductId.hpp>

namespace FpmlSerialized {

class TradeReferenceInformation : public ISerialized { 
   public: 
       TradeReferenceInformation(TiXmlNode* xmlNode);

       bool isOriginatingEvent(){return this->originatingEventIsNull_;}
       boost::shared_ptr<OriginatingEvent> getOriginatingEvent();
      std::string getOriginatingEventIDRef(){return originatingEventIDRef_;}

       bool isTerminatingEvent(){return this->terminatingEventIsNull_;}
       boost::shared_ptr<TerminatingEvent> getTerminatingEvent();
      std::string getTerminatingEventIDRef(){return terminatingEventIDRef_;}

       bool isPartyTradeIdentifier(){return this->partyTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getPartyTradeIdentifier();
      std::string getPartyTradeIdentifierIDRef(){return partyTradeIdentifierIDRef_;}

       bool isPartyTradeInformation(){return this->partyTradeInformationIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeInformation>> getPartyTradeInformation();
      std::string getPartyTradeInformationIDRef(){return partyTradeInformationIDRef_;}

       bool isProductType(){return this->productTypeIsNull_;}
       boost::shared_ptr<ProductType> getProductType();
      std::string getProductTypeIDRef(){return productTypeIDRef_;}

       bool isProductId(){return this->productIdIsNull_;}
       boost::shared_ptr<ProductId> getProductId();
      std::string getProductIdIDRef(){return productIdIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!originatingEventIsNull_){
                count += 1;
                str = "originatingEvent" ;
           }
           if(!terminatingEventIsNull_){
                count += 1;
                str = "terminatingEvent" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<OriginatingEvent> originatingEvent_;     //choice
       std::string originatingEventIDRef_;
       bool originatingEventIsNull_;
         boost::shared_ptr<TerminatingEvent> terminatingEvent_;     //choice
       std::string terminatingEventIDRef_;
       bool terminatingEventIsNull_;
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> partyTradeIdentifier_;
       std::string partyTradeIdentifierIDRef_;
       bool partyTradeIdentifierIsNull_;
       std::vector<boost::shared_ptr<PartyTradeInformation>> partyTradeInformation_;
       std::string partyTradeInformationIDRef_;
       bool partyTradeInformationIsNull_;
       boost::shared_ptr<ProductType> productType_;
       std::string productTypeIDRef_;
       bool productTypeIsNull_;
       boost::shared_ptr<ProductId> productId_;
       std::string productIdIDRef_;
       bool productIdIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

