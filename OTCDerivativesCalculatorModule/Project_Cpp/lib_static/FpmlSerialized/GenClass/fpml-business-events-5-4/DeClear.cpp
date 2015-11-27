// DeClear.cpp 
#include "DeClear.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DeClear::DeClear(TiXmlNode* xmlNode)
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

   if(tradeIdentifierNode)
   {
      for(tradeIdentifierNode; tradeIdentifierNode; tradeIdentifierNode = tradeIdentifierNode->NextSiblingElement("tradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
          #endif
          if(tradeIdentifierNode->Attribute("href") || tradeIdentifierNode->Attribute("id"))
          {
              if(tradeIdentifierNode->Attribute("id"))
              {
                  tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("id");
                  tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));
                  tradeIdentifier_.back()->setID(tradeIdentifierIDRef_);
                  IDManager::instance().setID(tradeIdentifierIDRef_, tradeIdentifier_.back());
              }
              else if(tradeIdentifierNode->Attribute("href")) { tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
       #endif
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));}
   }

   //reasonNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reasonNode = xmlNode->FirstChildElement("reason");

   if(reasonNode){reasonIsNull_ = false;}
   else{reasonIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
   #endif
   if(reasonNode)
   {
      if(reasonNode->Attribute("href") || reasonNode->Attribute("id"))
      {
          if(reasonNode->Attribute("id"))
          {
             reasonIDRef_ = reasonNode->Attribute("id");
             reason_ = boost::shared_ptr<DeclearReason>(new DeclearReason(reasonNode));
             reason_->setID(reasonIDRef_);
             IDManager::instance().setID(reasonIDRef_,reason_);
          }
          else if(reasonNode->Attribute("href")) { reasonIDRef_ = reasonNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { reason_ = boost::shared_ptr<DeclearReason>(new DeclearReason(reasonNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> DeClear::getTradeIdentifier()
{
   if(!this->tradeIdentifierIsNull_){
        if(tradeIdentifierIDRef_ != ""){
             return this->tradeIdentifier_;
        }else{
             return this->tradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
boost::shared_ptr<XsdTypeDate> DeClear::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<DeclearReason> DeClear::getReason()
{
   if(!this->reasonIsNull_){
        if(reasonIDRef_ != ""){
             return boost::shared_static_cast<DeclearReason>(IDManager::instance().getID(reasonIDRef_));
        }else{
             return this->reason_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeclearReason>();
   }
}
}

