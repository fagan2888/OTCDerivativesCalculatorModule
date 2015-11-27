// FxCashSettlement.cpp 
#include "FxCashSettlement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxCashSettlement::FxCashSettlement(TiXmlNode* xmlNode)
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

   //fixingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingNode = xmlNode->FirstChildElement("fixing");

   if(fixingNode){fixingIsNull_ = false;}
   else{fixingIsNull_ = true;}

   if(fixingNode)
   {
      for(fixingNode; fixingNode; fixingNode = fixingNode->NextSiblingElement("fixing")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingNode , address : " << fixingNode << std::endl;
          #endif
          if(fixingNode->Attribute("href") || fixingNode->Attribute("id"))
          {
              if(fixingNode->Attribute("id"))
              {
                  fixingIDRef_ = fixingNode->Attribute("id");
                  fixing_.push_back(boost::shared_ptr<FxFixing>(new FxFixing(fixingNode)));
                  fixing_.back()->setID(fixingIDRef_);
                  IDManager::instance().setID(fixingIDRef_, fixing_.back());
              }
              else if(fixingNode->Attribute("href")) { fixingIDRef_ = fixingNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fixing_.push_back(boost::shared_ptr<FxFixing>(new FxFixing(fixingNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingNode , address : " << fixingNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> FxCashSettlement::getSettlementCurrency()
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
std::vector<boost::shared_ptr<FxFixing>> FxCashSettlement::getFixing()
{
   if(!this->fixingIsNull_){
        if(fixingIDRef_ != ""){
             return this->fixing_;
        }else{
             return this->fixing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxFixing>>();
   }
}
}

