// ExchangeTradedCalculatedPrice.cpp 
#include "ExchangeTradedCalculatedPrice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExchangeTradedCalculatedPrice::ExchangeTradedCalculatedPrice(TiXmlNode* xmlNode)
: ExchangeTraded(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //constituentExchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constituentExchangeIdNode = xmlNode->FirstChildElement("constituentExchangeId");

   if(constituentExchangeIdNode){constituentExchangeIdIsNull_ = false;}
   else{constituentExchangeIdIsNull_ = true;}

   if(constituentExchangeIdNode)
   {
      for(constituentExchangeIdNode; constituentExchangeIdNode; constituentExchangeIdNode = constituentExchangeIdNode->NextSiblingElement("constituentExchangeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constituentExchangeIdNode , address : " << constituentExchangeIdNode << std::endl;
          #endif
          if(constituentExchangeIdNode->Attribute("href") || constituentExchangeIdNode->Attribute("id"))
          {
              if(constituentExchangeIdNode->Attribute("id"))
              {
                  constituentExchangeIdIDRef_ = constituentExchangeIdNode->Attribute("id");
                  constituentExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(constituentExchangeIdNode)));
                  constituentExchangeId_.back()->setID(constituentExchangeIdIDRef_);
                  IDManager::instance().setID(constituentExchangeIdIDRef_, constituentExchangeId_.back());
              }
              else if(constituentExchangeIdNode->Attribute("href")) { constituentExchangeIdIDRef_ = constituentExchangeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { constituentExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(constituentExchangeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constituentExchangeIdNode , address : " << constituentExchangeIdNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ExchangeId>> ExchangeTradedCalculatedPrice::getConstituentExchangeId()
{
   if(!this->constituentExchangeIdIsNull_){
        if(constituentExchangeIdIDRef_ != ""){
             return this->constituentExchangeId_;
        }else{
             return this->constituentExchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExchangeId>>();
   }
}
}

