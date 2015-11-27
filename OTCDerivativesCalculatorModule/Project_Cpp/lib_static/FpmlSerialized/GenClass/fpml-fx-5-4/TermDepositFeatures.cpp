// TermDepositFeatures.cpp 
#include "TermDepositFeatures.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TermDepositFeatures::TermDepositFeatures(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dualCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dualCurrencyNode = xmlNode->FirstChildElement("dualCurrency");

   if(dualCurrencyNode){dualCurrencyIsNull_ = false;}
   else{dualCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dualCurrencyNode , address : " << dualCurrencyNode << std::endl;
   #endif
   if(dualCurrencyNode)
   {
      if(dualCurrencyNode->Attribute("href") || dualCurrencyNode->Attribute("id"))
      {
          if(dualCurrencyNode->Attribute("id"))
          {
             dualCurrencyIDRef_ = dualCurrencyNode->Attribute("id");
             dualCurrency_ = boost::shared_ptr<DualCurrencyFeature>(new DualCurrencyFeature(dualCurrencyNode));
             dualCurrency_->setID(dualCurrencyIDRef_);
             IDManager::instance().setID(dualCurrencyIDRef_,dualCurrency_);
          }
          else if(dualCurrencyNode->Attribute("href")) { dualCurrencyIDRef_ = dualCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dualCurrency_ = boost::shared_ptr<DualCurrencyFeature>(new DualCurrencyFeature(dualCurrencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DualCurrencyFeature> TermDepositFeatures::getDualCurrency()
{
   if(!this->dualCurrencyIsNull_){
        if(dualCurrencyIDRef_ != ""){
             return boost::shared_static_cast<DualCurrencyFeature>(IDManager::instance().getID(dualCurrencyIDRef_));
        }else{
             return this->dualCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DualCurrencyFeature>();
   }
}
}

