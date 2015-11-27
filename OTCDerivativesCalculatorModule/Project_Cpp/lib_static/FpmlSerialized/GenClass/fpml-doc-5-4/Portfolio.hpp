// Portfolio.hpp 
#ifndef FpmlSerialized_Portfolio_hpp
#define FpmlSerialized_Portfolio_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyPortfolioName.hpp>
#include <fpml-doc-5-4/TradeId.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-doc-5-4/Portfolio.hpp>

namespace FpmlSerialized {

class Portfolio : public ISerialized { 
   public: 
       Portfolio(TiXmlNode* xmlNode);

       bool isPartyPortfolioName(){return this->partyPortfolioNameIsNull_;}
       boost::shared_ptr<PartyPortfolioName> getPartyPortfolioName();
      std::string getPartyPortfolioNameIDRef(){return partyPortfolioNameIDRef_;}

       bool isTradeId(){return this->tradeIdIsNull_;}
       std::vector<boost::shared_ptr<TradeId>> getTradeId();
      std::string getTradeIdIDRef(){return tradeIdIDRef_;}

       bool isPartyTradeIdentifier(){return this->partyTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getPartyTradeIdentifier();
      std::string getPartyTradeIdentifierIDRef(){return partyTradeIdentifierIDRef_;}

       bool isPortfolio(){return this->portfolioIsNull_;}
       std::vector<boost::shared_ptr<Portfolio>> getPortfolio();
      std::string getPortfolioIDRef(){return portfolioIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!tradeIdIsNull_){
                count += 1;
                str = "tradeId" ;
           }
           if(!partyTradeIdentifierIsNull_){
                count += 1;
                str = "partyTradeIdentifier" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<PartyPortfolioName> partyPortfolioName_;
       std::string partyPortfolioNameIDRef_;
       bool partyPortfolioNameIsNull_;
         std::vector<boost::shared_ptr<TradeId>> tradeId_;     //choice
       std::string tradeIdIDRef_;
       bool tradeIdIsNull_;
         std::vector<boost::shared_ptr<PartyTradeIdentifier>> partyTradeIdentifier_;     //choice
       std::string partyTradeIdentifierIDRef_;
       bool partyTradeIdentifierIsNull_;
       std::vector<boost::shared_ptr<Portfolio>> portfolio_;
       std::string portfolioIDRef_;
       bool portfolioIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

