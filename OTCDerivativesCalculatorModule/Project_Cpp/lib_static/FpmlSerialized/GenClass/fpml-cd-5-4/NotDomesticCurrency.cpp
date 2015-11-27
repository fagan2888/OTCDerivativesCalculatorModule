// NotDomesticCurrency.cpp 
#include "NotDomesticCurrency.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NotDomesticCurrency::NotDomesticCurrency(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //applicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* applicableNode = xmlNode->FirstChildElement("applicable");

   if(applicableNode){applicableIsNull_ = false;}
   else{applicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableNode , address : " << applicableNode << std::endl;
   #endif
   if(applicableNode)
   {
      if(applicableNode->Attribute("href") || applicableNode->Attribute("id"))
      {
          if(applicableNode->Attribute("id"))
          {
             applicableIDRef_ = applicableNode->Attribute("id");
             applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));
             applicable_->setID(applicableIDRef_);
             IDManager::instance().setID(applicableIDRef_,applicable_);
          }
          else if(applicableNode->Attribute("href")) { applicableIDRef_ = applicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));}
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
      if(currencyNode->Attribute("href") || currencyNode->Attribute("id"))
      {
          if(currencyNode->Attribute("id"))
          {
             currencyIDRef_ = currencyNode->Attribute("id");
             currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> NotDomesticCurrency::getApplicable()
{
   if(!this->applicableIsNull_){
        if(applicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(applicableIDRef_));
        }else{
             return this->applicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Currency> NotDomesticCurrency::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
}

