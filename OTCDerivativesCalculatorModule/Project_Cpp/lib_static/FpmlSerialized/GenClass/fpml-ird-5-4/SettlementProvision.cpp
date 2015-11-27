// SettlementProvision.cpp 
#include "SettlementProvision.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementProvision::SettlementProvision(TiXmlNode* xmlNode)
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

   //nonDeliverableSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonDeliverableSettlementNode = xmlNode->FirstChildElement("nonDeliverableSettlement");

   if(nonDeliverableSettlementNode){nonDeliverableSettlementIsNull_ = false;}
   else{nonDeliverableSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonDeliverableSettlementNode , address : " << nonDeliverableSettlementNode << std::endl;
   #endif
   if(nonDeliverableSettlementNode)
   {
      if(nonDeliverableSettlementNode->Attribute("href") || nonDeliverableSettlementNode->Attribute("id"))
      {
          if(nonDeliverableSettlementNode->Attribute("id"))
          {
             nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode->Attribute("id");
             nonDeliverableSettlement_ = boost::shared_ptr<NonDeliverableSettlement>(new NonDeliverableSettlement(nonDeliverableSettlementNode));
             nonDeliverableSettlement_->setID(nonDeliverableSettlementIDRef_);
             IDManager::instance().setID(nonDeliverableSettlementIDRef_,nonDeliverableSettlement_);
          }
          else if(nonDeliverableSettlementNode->Attribute("href")) { nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonDeliverableSettlement_ = boost::shared_ptr<NonDeliverableSettlement>(new NonDeliverableSettlement(nonDeliverableSettlementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> SettlementProvision::getSettlementCurrency()
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
boost::shared_ptr<NonDeliverableSettlement> SettlementProvision::getNonDeliverableSettlement()
{
   if(!this->nonDeliverableSettlementIsNull_){
        if(nonDeliverableSettlementIDRef_ != ""){
             return boost::shared_static_cast<NonDeliverableSettlement>(IDManager::instance().getID(nonDeliverableSettlementIDRef_));
        }else{
             return this->nonDeliverableSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonDeliverableSettlement>();
   }
}
}

