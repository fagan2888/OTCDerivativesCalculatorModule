// NotionalValue.cpp 
#include "NotionalValue.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NotionalValue::NotionalValue(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAmountNode = xmlNode->FirstChildElement("notionalAmount");

   if(notionalAmountNode){notionalAmountIsNull_ = false;}
   else{notionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAmountNode , address : " << notionalAmountNode << std::endl;
   #endif
   if(notionalAmountNode)
   {
      if(notionalAmountNode->Attribute("href") || notionalAmountNode->Attribute("id"))
      {
          if(notionalAmountNode->Attribute("id"))
          {
             notionalAmountIDRef_ = notionalAmountNode->Attribute("id");
             notionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalAmountNode));
             notionalAmount_->setID(notionalAmountIDRef_);
             IDManager::instance().setID(notionalAmountIDRef_,notionalAmount_);
          }
          else if(notionalAmountNode->Attribute("href")) { notionalAmountIDRef_ = notionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> NotionalValue::getNotionalAmount()
{
   if(!this->notionalAmountIsNull_){
        if(notionalAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(notionalAmountIDRef_));
        }else{
             return this->notionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

