// ExchangeTradedFund.cpp 
#include "ExchangeTradedFund.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExchangeTradedFund::ExchangeTradedFund(TiXmlNode* xmlNode)
: ExchangeTradedCalculatedPrice(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
boost::shared_ptr<XsdTypeString> ExchangeTradedFund::getFundManager()
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

