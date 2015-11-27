// PartyTradeIdentifiers.cpp 
#include "PartyTradeIdentifiers.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PartyTradeIdentifiers::PartyTradeIdentifiers(TiXmlNode* xmlNode)
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> PartyTradeIdentifiers::getPartyTradeIdentifier()
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
}

