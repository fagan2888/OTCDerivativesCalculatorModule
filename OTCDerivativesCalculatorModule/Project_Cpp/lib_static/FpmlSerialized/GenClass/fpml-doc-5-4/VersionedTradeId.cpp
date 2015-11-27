// VersionedTradeId.cpp 
#include "VersionedTradeId.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VersionedTradeId::VersionedTradeId(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdNode = xmlNode->FirstChildElement("tradeId");

   if(tradeIdNode){tradeIdIsNull_ = false;}
   else{tradeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdNode , address : " << tradeIdNode << std::endl;
   #endif
   if(tradeIdNode)
   {
      if(tradeIdNode->Attribute("href") || tradeIdNode->Attribute("id"))
      {
          if(tradeIdNode->Attribute("id"))
          {
             tradeIdIDRef_ = tradeIdNode->Attribute("id");
             tradeId_ = boost::shared_ptr<TradeId>(new TradeId(tradeIdNode));
             tradeId_->setID(tradeIdIDRef_);
             IDManager::instance().setID(tradeIdIDRef_,tradeId_);
          }
          else if(tradeIdNode->Attribute("href")) { tradeIdIDRef_ = tradeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeId_ = boost::shared_ptr<TradeId>(new TradeId(tradeIdNode));}
   }

   //versionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* versionNode = xmlNode->FirstChildElement("version");

   if(versionNode){versionIsNull_ = false;}
   else{versionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionNode , address : " << versionNode << std::endl;
   #endif
   if(versionNode)
   {
      if(versionNode->Attribute("href") || versionNode->Attribute("id"))
      {
          if(versionNode->Attribute("id"))
          {
             versionIDRef_ = versionNode->Attribute("id");
             version_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(versionNode));
             version_->setID(versionIDRef_);
             IDManager::instance().setID(versionIDRef_,version_);
          }
          else if(versionNode->Attribute("href")) { versionIDRef_ = versionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { version_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(versionNode));}
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
             effectiveDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(effectiveDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TradeId> VersionedTradeId::getTradeId()
{
   if(!this->tradeIdIsNull_){
        if(tradeIdIDRef_ != ""){
             return boost::shared_static_cast<TradeId>(IDManager::instance().getID(tradeIdIDRef_));
        }else{
             return this->tradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeId>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> VersionedTradeId::getVersion()
{
   if(!this->versionIsNull_){
        if(versionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(versionIDRef_));
        }else{
             return this->version_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<IdentifiedDate> VersionedTradeId::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
}

