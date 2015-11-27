// SettlementTerms.cpp 
#include "SettlementTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementTerms::SettlementTerms(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementCurrencyNode = xmlNode->FirstChildElement("settlementCurrency");

   if(settlementCurrencyNode){settlementCurrencyIsNull_ = false;}
   else{settlementCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementCurrencyNode , address : " << settlementCurrencyNode << std::endl;
   #endif
   if(settlementCurrencyNode)
   {
      if(settlementCurrencyNode->Attribute("href") || settlementCurrencyNode->Attribute("id"))
      {
          if(settlementCurrencyNode->Attribute("id"))
          {
             settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("id");
             settlementCurrency_ = boost::shared_ptr<Currency>(new Currency(settlementCurrencyNode));
             settlementCurrency_->setID(settlementCurrencyIDRef_);
             IDManager::instance().setID(settlementCurrencyIDRef_,settlementCurrency_);
          }
          else if(settlementCurrencyNode->Attribute("href")) { settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementCurrency_ = boost::shared_ptr<Currency>(new Currency(settlementCurrencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> SettlementTerms::getSettlementCurrency()
{
   if(!this->settlementCurrencyIsNull_){
        if(settlementCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(settlementCurrencyIDRef_));
        }else{
             return this->settlementCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
}

