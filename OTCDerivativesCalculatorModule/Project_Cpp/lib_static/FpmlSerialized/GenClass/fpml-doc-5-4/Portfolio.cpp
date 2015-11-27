// Portfolio.cpp 
#include "Portfolio.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Portfolio::Portfolio(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partyPortfolioNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyPortfolioNameNode = xmlNode->FirstChildElement("partyPortfolioName");

   if(partyPortfolioNameNode){partyPortfolioNameIsNull_ = false;}
   else{partyPortfolioNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyPortfolioNameNode , address : " << partyPortfolioNameNode << std::endl;
   #endif
   if(partyPortfolioNameNode)
   {
      if(partyPortfolioNameNode->Attribute("href") || partyPortfolioNameNode->Attribute("id"))
      {
          if(partyPortfolioNameNode->Attribute("id"))
          {
             partyPortfolioNameIDRef_ = partyPortfolioNameNode->Attribute("id");
             partyPortfolioName_ = boost::shared_ptr<PartyPortfolioName>(new PartyPortfolioName(partyPortfolioNameNode));
             partyPortfolioName_->setID(partyPortfolioNameIDRef_);
             IDManager::instance().setID(partyPortfolioNameIDRef_,partyPortfolioName_);
          }
          else if(partyPortfolioNameNode->Attribute("href")) { partyPortfolioNameIDRef_ = partyPortfolioNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyPortfolioName_ = boost::shared_ptr<PartyPortfolioName>(new PartyPortfolioName(partyPortfolioNameNode));}
   }

   //tradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdNode = xmlNode->FirstChildElement("tradeId");

   if(tradeIdNode){tradeIdIsNull_ = false;}
   else{tradeIdIsNull_ = true;}

   if(tradeIdNode)
   {
      for(tradeIdNode; tradeIdNode; tradeIdNode = tradeIdNode->NextSiblingElement("tradeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdNode , address : " << tradeIdNode << std::endl;
          #endif
          if(tradeIdNode->Attribute("href") || tradeIdNode->Attribute("id"))
          {
              if(tradeIdNode->Attribute("id"))
              {
                  tradeIdIDRef_ = tradeIdNode->Attribute("id");
                  tradeId_.push_back(boost::shared_ptr<TradeId>(new TradeId(tradeIdNode)));
                  tradeId_.back()->setID(tradeIdIDRef_);
                  IDManager::instance().setID(tradeIdIDRef_, tradeId_.back());
              }
              else if(tradeIdNode->Attribute("href")) { tradeIdIDRef_ = tradeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { tradeId_.push_back(boost::shared_ptr<TradeId>(new TradeId(tradeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdNode , address : " << tradeIdNode << std::endl;
       #endif
   }

   //partyTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyTradeIdentifierNode = xmlNode->FirstChildElement("partyTradeIdentifier");

   if(partyTradeIdentifierNode){partyTradeIdentifierIsNull_ = false;}
   else{partyTradeIdentifierIsNull_ = true;}

   if(partyTradeIdentifierNode)
   {
      for(partyTradeIdentifierNode; partyTradeIdentifierNode; partyTradeIdentifierNode = partyTradeIdentifierNode->NextSiblingElement("partyTradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierNode , address : " << partyTradeIdentifierNode << std::endl;
          #endif
          if(partyTradeIdentifierNode->Attribute("href") || partyTradeIdentifierNode->Attribute("id"))
          {
              if(partyTradeIdentifierNode->Attribute("id"))
              {
                  partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("id");
                  partyTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode)));
                  partyTradeIdentifier_.back()->setID(partyTradeIdentifierIDRef_);
                  IDManager::instance().setID(partyTradeIdentifierIDRef_, partyTradeIdentifier_.back());
              }
              else if(partyTradeIdentifierNode->Attribute("href")) { partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partyTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierNode , address : " << partyTradeIdentifierNode << std::endl;
       #endif
   }

   //portfolioNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* portfolioNode = xmlNode->FirstChildElement("portfolio");

   if(portfolioNode){portfolioIsNull_ = false;}
   else{portfolioIsNull_ = true;}

   if(portfolioNode)
   {
      for(portfolioNode; portfolioNode; portfolioNode = portfolioNode->NextSiblingElement("portfolio")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioNode , address : " << portfolioNode << std::endl;
          #endif
          if(portfolioNode->Attribute("href") || portfolioNode->Attribute("id"))
          {
              if(portfolioNode->Attribute("id"))
              {
                  portfolioIDRef_ = portfolioNode->Attribute("id");
                  portfolio_.push_back(boost::shared_ptr<Portfolio>(new Portfolio(portfolioNode)));
                  portfolio_.back()->setID(portfolioIDRef_);
                  IDManager::instance().setID(portfolioIDRef_, portfolio_.back());
              }
              else if(portfolioNode->Attribute("href")) { portfolioIDRef_ = portfolioNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { portfolio_.push_back(boost::shared_ptr<Portfolio>(new Portfolio(portfolioNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioNode , address : " << portfolioNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyPortfolioName> Portfolio::getPartyPortfolioName()
{
   if(!this->partyPortfolioNameIsNull_){
        if(partyPortfolioNameIDRef_ != ""){
             return boost::shared_static_cast<PartyPortfolioName>(IDManager::instance().getID(partyPortfolioNameIDRef_));
        }else{
             return this->partyPortfolioName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyPortfolioName>();
   }
}
std::vector<boost::shared_ptr<TradeId>> Portfolio::getTradeId()
{
   if(!this->tradeIdIsNull_){
        if(tradeIdIDRef_ != ""){
             return this->tradeId_;
        }else{
             return this->tradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeId>>();
   }
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> Portfolio::getPartyTradeIdentifier()
{
   if(!this->partyTradeIdentifierIsNull_){
        if(partyTradeIdentifierIDRef_ != ""){
             return this->partyTradeIdentifier_;
        }else{
             return this->partyTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
std::vector<boost::shared_ptr<Portfolio>> Portfolio::getPortfolio()
{
   if(!this->portfolioIsNull_){
        if(portfolioIDRef_ != ""){
             return this->portfolio_;
        }else{
             return this->portfolio_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Portfolio>>();
   }
}
}

