// BestFitTrade.cpp 
#include "BestFitTrade.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BestFitTrade::BestFitTrade(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierNode = xmlNode->FirstChildElement("tradeIdentifier");

   if(tradeIdentifierNode){tradeIdentifierIsNull_ = false;}
   else{tradeIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
   #endif
   if(tradeIdentifierNode)
   {
      if(tradeIdentifierNode->Attribute("href") || tradeIdentifierNode->Attribute("id"))
      {
          if(tradeIdentifierNode->Attribute("id"))
          {
             tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("id");
             tradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(tradeIdentifierNode));
             tradeIdentifier_->setID(tradeIdentifierIDRef_);
             IDManager::instance().setID(tradeIdentifierIDRef_,tradeIdentifier_);
          }
          else if(tradeIdentifierNode->Attribute("href")) { tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(tradeIdentifierNode));}
   }

   //differencesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* differencesNode = xmlNode->FirstChildElement("differences");

   if(differencesNode){differencesIsNull_ = false;}
   else{differencesIsNull_ = true;}

   if(differencesNode)
   {
      for(differencesNode; differencesNode; differencesNode = differencesNode->NextSiblingElement("differences")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- differencesNode , address : " << differencesNode << std::endl;
          #endif
          if(differencesNode->Attribute("href") || differencesNode->Attribute("id"))
          {
              if(differencesNode->Attribute("id"))
              {
                  differencesIDRef_ = differencesNode->Attribute("id");
                  differences_.push_back(boost::shared_ptr<TradeDifference>(new TradeDifference(differencesNode)));
                  differences_.back()->setID(differencesIDRef_);
                  IDManager::instance().setID(differencesIDRef_, differences_.back());
              }
              else if(differencesNode->Attribute("href")) { differencesIDRef_ = differencesNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { differences_.push_back(boost::shared_ptr<TradeDifference>(new TradeDifference(differencesNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- differencesNode , address : " << differencesNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TradeIdentifier> BestFitTrade::getTradeIdentifier()
{
   if(!this->tradeIdentifierIsNull_){
        if(tradeIdentifierIDRef_ != ""){
             return boost::shared_static_cast<TradeIdentifier>(IDManager::instance().getID(tradeIdentifierIDRef_));
        }else{
             return this->tradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeIdentifier>();
   }
}
std::vector<boost::shared_ptr<TradeDifference>> BestFitTrade::getDifferences()
{
   if(!this->differencesIsNull_){
        if(differencesIDRef_ != ""){
             return this->differences_;
        }else{
             return this->differences_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeDifference>>();
   }
}
}

