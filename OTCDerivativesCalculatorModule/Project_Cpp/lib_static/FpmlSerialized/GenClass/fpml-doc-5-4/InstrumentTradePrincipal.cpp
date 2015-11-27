// InstrumentTradePrincipal.cpp 
#include "InstrumentTradePrincipal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentTradePrincipal::InstrumentTradePrincipal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //principalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalAmountNode = xmlNode->FirstChildElement("principalAmount");

   if(principalAmountNode){principalAmountIsNull_ = false;}
   else{principalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalAmountNode , address : " << principalAmountNode << std::endl;
   #endif
   if(principalAmountNode)
   {
      if(principalAmountNode->Attribute("href") || principalAmountNode->Attribute("id"))
      {
          if(principalAmountNode->Attribute("id"))
          {
             principalAmountIDRef_ = principalAmountNode->Attribute("id");
             principalAmount_ = boost::shared_ptr<NetAndGross>(new NetAndGross(principalAmountNode));
             principalAmount_->setID(principalAmountIDRef_);
             IDManager::instance().setID(principalAmountIDRef_,principalAmount_);
          }
          else if(principalAmountNode->Attribute("href")) { principalAmountIDRef_ = principalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principalAmount_ = boost::shared_ptr<NetAndGross>(new NetAndGross(principalAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NetAndGross> InstrumentTradePrincipal::getPrincipalAmount()
{
   if(!this->principalAmountIsNull_){
        if(principalAmountIDRef_ != ""){
             return boost::shared_static_cast<NetAndGross>(IDManager::instance().getID(principalAmountIDRef_));
        }else{
             return this->principalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NetAndGross>();
   }
}
}

