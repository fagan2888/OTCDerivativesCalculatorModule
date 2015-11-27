// MutualFund.cpp 
#include "MutualFund.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MutualFund::MutualFund(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //openEndedFundNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* openEndedFundNode = xmlNode->FirstChildElement("openEndedFund");

   if(openEndedFundNode){openEndedFundIsNull_ = false;}
   else{openEndedFundIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- openEndedFundNode , address : " << openEndedFundNode << std::endl;
   #endif
   if(openEndedFundNode)
   {
      if(openEndedFundNode->Attribute("href") || openEndedFundNode->Attribute("id"))
      {
          if(openEndedFundNode->Attribute("id"))
          {
             openEndedFundIDRef_ = openEndedFundNode->Attribute("id");
             openEndedFund_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(openEndedFundNode));
             openEndedFund_->setID(openEndedFundIDRef_);
             IDManager::instance().setID(openEndedFundIDRef_,openEndedFund_);
          }
          else if(openEndedFundNode->Attribute("href")) { openEndedFundIDRef_ = openEndedFundNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { openEndedFund_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(openEndedFundNode));}
   }

   //fundManagerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fundManagerNode = xmlNode->FirstChildElement("fundManager");

   if(fundManagerNode){fundManagerIsNull_ = false;}
   else{fundManagerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fundManagerNode , address : " << fundManagerNode << std::endl;
   #endif
   if(fundManagerNode)
   {
      if(fundManagerNode->Attribute("href") || fundManagerNode->Attribute("id"))
      {
          if(fundManagerNode->Attribute("id"))
          {
             fundManagerIDRef_ = fundManagerNode->Attribute("id");
             fundManager_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(fundManagerNode));
             fundManager_->setID(fundManagerIDRef_);
             IDManager::instance().setID(fundManagerIDRef_,fundManager_);
          }
          else if(fundManagerNode->Attribute("href")) { fundManagerIDRef_ = fundManagerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fundManager_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(fundManagerNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> MutualFund::getOpenEndedFund()
{
   if(!this->openEndedFundIsNull_){
        if(openEndedFundIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(openEndedFundIDRef_));
        }else{
             return this->openEndedFund_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeString> MutualFund::getFundManager()
{
   if(!this->fundManagerIsNull_){
        if(fundManagerIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(fundManagerIDRef_));
        }else{
             return this->fundManager_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

