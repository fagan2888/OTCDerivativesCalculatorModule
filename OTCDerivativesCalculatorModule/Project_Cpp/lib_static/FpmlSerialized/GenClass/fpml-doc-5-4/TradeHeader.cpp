// TradeHeader.cpp 
#include "TradeHeader.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeHeader::TradeHeader(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //partyTradeInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyTradeInformationNode = xmlNode->FirstChildElement("partyTradeInformation");

   if(partyTradeInformationNode){partyTradeInformationIsNull_ = false;}
   else{partyTradeInformationIsNull_ = true;}

   if(partyTradeInformationNode)
   {
      for(partyTradeInformationNode; partyTradeInformationNode; partyTradeInformationNode = partyTradeInformationNode->NextSiblingElement("partyTradeInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeInformationNode , address : " << partyTradeInformationNode << std::endl;
          #endif
          if(partyTradeInformationNode->Attribute("href") || partyTradeInformationNode->Attribute("id"))
          {
              if(partyTradeInformationNode->Attribute("id"))
              {
                  partyTradeInformationIDRef_ = partyTradeInformationNode->Attribute("id");
                  partyTradeInformation_.push_back(boost::shared_ptr<PartyTradeInformation>(new PartyTradeInformation(partyTradeInformationNode)));
                  partyTradeInformation_.back()->setID(partyTradeInformationIDRef_);
                  IDManager::instance().setID(partyTradeInformationIDRef_, partyTradeInformation_.back());
              }
              else if(partyTradeInformationNode->Attribute("href")) { partyTradeInformationIDRef_ = partyTradeInformationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partyTradeInformation_.push_back(boost::shared_ptr<PartyTradeInformation>(new PartyTradeInformation(partyTradeInformationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeInformationNode , address : " << partyTradeInformationNode << std::endl;
       #endif
   }

   //tradeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeDateNode = xmlNode->FirstChildElement("tradeDate");

   if(tradeDateNode){tradeDateIsNull_ = false;}
   else{tradeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeDateNode , address : " << tradeDateNode << std::endl;
   #endif
   if(tradeDateNode)
   {
      if(tradeDateNode->Attribute("href") || tradeDateNode->Attribute("id"))
      {
          if(tradeDateNode->Attribute("id"))
          {
             tradeDateIDRef_ = tradeDateNode->Attribute("id");
             tradeDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(tradeDateNode));
             tradeDate_->setID(tradeDateIDRef_);
             IDManager::instance().setID(tradeDateIDRef_,tradeDate_);
          }
          else if(tradeDateNode->Attribute("href")) { tradeDateIDRef_ = tradeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(tradeDateNode));}
   }

   //clearedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearedDateNode = xmlNode->FirstChildElement("clearedDate");

   if(clearedDateNode){clearedDateIsNull_ = false;}
   else{clearedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearedDateNode , address : " << clearedDateNode << std::endl;
   #endif
   if(clearedDateNode)
   {
      if(clearedDateNode->Attribute("href") || clearedDateNode->Attribute("id"))
      {
          if(clearedDateNode->Attribute("id"))
          {
             clearedDateIDRef_ = clearedDateNode->Attribute("id");
             clearedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(clearedDateNode));
             clearedDate_->setID(clearedDateIDRef_);
             IDManager::instance().setID(clearedDateIDRef_,clearedDate_);
          }
          else if(clearedDateNode->Attribute("href")) { clearedDateIDRef_ = clearedDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { clearedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(clearedDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> TradeHeader::getPartyTradeIdentifier()
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
std::vector<boost::shared_ptr<PartyTradeInformation>> TradeHeader::getPartyTradeInformation()
{
   if(!this->partyTradeInformationIsNull_){
        if(partyTradeInformationIDRef_ != ""){
             return this->partyTradeInformation_;
        }else{
             return this->partyTradeInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeInformation>>();
   }
}
boost::shared_ptr<IdentifiedDate> TradeHeader::getTradeDate()
{
   if(!this->tradeDateIsNull_){
        if(tradeDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(tradeDateIDRef_));
        }else{
             return this->tradeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<IdentifiedDate> TradeHeader::getClearedDate()
{
   if(!this->clearedDateIsNull_){
        if(clearedDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(clearedDateIDRef_));
        }else{
             return this->clearedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
}

