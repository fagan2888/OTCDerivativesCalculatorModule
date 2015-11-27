// NonDeliverableSettlement.cpp 
#include "NonDeliverableSettlement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NonDeliverableSettlement::NonDeliverableSettlement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCurrencyNode = xmlNode->FirstChildElement("referenceCurrency");

   if(referenceCurrencyNode){referenceCurrencyIsNull_ = false;}
   else{referenceCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCurrencyNode , address : " << referenceCurrencyNode << std::endl;
   #endif
   if(referenceCurrencyNode)
   {
      if(referenceCurrencyNode->Attribute("href") || referenceCurrencyNode->Attribute("id"))
      {
          if(referenceCurrencyNode->Attribute("id"))
          {
             referenceCurrencyIDRef_ = referenceCurrencyNode->Attribute("id");
             referenceCurrency_ = boost::shared_ptr<Currency>(new Currency(referenceCurrencyNode));
             referenceCurrency_->setID(referenceCurrencyIDRef_);
             IDManager::instance().setID(referenceCurrencyIDRef_,referenceCurrency_);
          }
          else if(referenceCurrencyNode->Attribute("href")) { referenceCurrencyIDRef_ = referenceCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceCurrency_ = boost::shared_ptr<Currency>(new Currency(referenceCurrencyNode));}
   }

   //fxFixingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxFixingDateNode = xmlNode->FirstChildElement("fxFixingDate");

   if(fxFixingDateNode){fxFixingDateIsNull_ = false;}
   else{fxFixingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxFixingDateNode , address : " << fxFixingDateNode << std::endl;
   #endif
   if(fxFixingDateNode)
   {
      if(fxFixingDateNode->Attribute("href") || fxFixingDateNode->Attribute("id"))
      {
          if(fxFixingDateNode->Attribute("id"))
          {
             fxFixingDateIDRef_ = fxFixingDateNode->Attribute("id");
             fxFixingDate_ = boost::shared_ptr<FxFixingDate>(new FxFixingDate(fxFixingDateNode));
             fxFixingDate_->setID(fxFixingDateIDRef_);
             IDManager::instance().setID(fxFixingDateIDRef_,fxFixingDate_);
          }
          else if(fxFixingDateNode->Attribute("href")) { fxFixingDateIDRef_ = fxFixingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxFixingDate_ = boost::shared_ptr<FxFixingDate>(new FxFixingDate(fxFixingDateNode));}
   }

   //fxFixingScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxFixingScheduleNode = xmlNode->FirstChildElement("fxFixingSchedule");

   if(fxFixingScheduleNode){fxFixingScheduleIsNull_ = false;}
   else{fxFixingScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxFixingScheduleNode , address : " << fxFixingScheduleNode << std::endl;
   #endif
   if(fxFixingScheduleNode)
   {
      if(fxFixingScheduleNode->Attribute("href") || fxFixingScheduleNode->Attribute("id"))
      {
          if(fxFixingScheduleNode->Attribute("id"))
          {
             fxFixingScheduleIDRef_ = fxFixingScheduleNode->Attribute("id");
             fxFixingSchedule_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(fxFixingScheduleNode));
             fxFixingSchedule_->setID(fxFixingScheduleIDRef_);
             IDManager::instance().setID(fxFixingScheduleIDRef_,fxFixingSchedule_);
          }
          else if(fxFixingScheduleNode->Attribute("href")) { fxFixingScheduleIDRef_ = fxFixingScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxFixingSchedule_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(fxFixingScheduleNode));}
   }

   //settlementRateOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementRateOptionNode = xmlNode->FirstChildElement("settlementRateOption");

   if(settlementRateOptionNode){settlementRateOptionIsNull_ = false;}
   else{settlementRateOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementRateOptionNode , address : " << settlementRateOptionNode << std::endl;
   #endif
   if(settlementRateOptionNode)
   {
      if(settlementRateOptionNode->Attribute("href") || settlementRateOptionNode->Attribute("id"))
      {
          if(settlementRateOptionNode->Attribute("id"))
          {
             settlementRateOptionIDRef_ = settlementRateOptionNode->Attribute("id");
             settlementRateOption_ = boost::shared_ptr<SettlementRateOption>(new SettlementRateOption(settlementRateOptionNode));
             settlementRateOption_->setID(settlementRateOptionIDRef_);
             IDManager::instance().setID(settlementRateOptionIDRef_,settlementRateOption_);
          }
          else if(settlementRateOptionNode->Attribute("href")) { settlementRateOptionIDRef_ = settlementRateOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementRateOption_ = boost::shared_ptr<SettlementRateOption>(new SettlementRateOption(settlementRateOptionNode));}
   }

   //priceSourceDisruptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* priceSourceDisruptionNode = xmlNode->FirstChildElement("priceSourceDisruption");

   if(priceSourceDisruptionNode){priceSourceDisruptionIsNull_ = false;}
   else{priceSourceDisruptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- priceSourceDisruptionNode , address : " << priceSourceDisruptionNode << std::endl;
   #endif
   if(priceSourceDisruptionNode)
   {
      if(priceSourceDisruptionNode->Attribute("href") || priceSourceDisruptionNode->Attribute("id"))
      {
          if(priceSourceDisruptionNode->Attribute("id"))
          {
             priceSourceDisruptionIDRef_ = priceSourceDisruptionNode->Attribute("id");
             priceSourceDisruption_ = boost::shared_ptr<PriceSourceDisruption>(new PriceSourceDisruption(priceSourceDisruptionNode));
             priceSourceDisruption_->setID(priceSourceDisruptionIDRef_);
             IDManager::instance().setID(priceSourceDisruptionIDRef_,priceSourceDisruption_);
          }
          else if(priceSourceDisruptionNode->Attribute("href")) { priceSourceDisruptionIDRef_ = priceSourceDisruptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { priceSourceDisruption_ = boost::shared_ptr<PriceSourceDisruption>(new PriceSourceDisruption(priceSourceDisruptionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> NonDeliverableSettlement::getReferenceCurrency()
{
   if(!this->referenceCurrencyIsNull_){
        if(referenceCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(referenceCurrencyIDRef_));
        }else{
             return this->referenceCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<FxFixingDate> NonDeliverableSettlement::getFxFixingDate()
{
   if(!this->fxFixingDateIsNull_){
        if(fxFixingDateIDRef_ != ""){
             return boost::shared_static_cast<FxFixingDate>(IDManager::instance().getID(fxFixingDateIDRef_));
        }else{
             return this->fxFixingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxFixingDate>();
   }
}
boost::shared_ptr<AdjustableDates> NonDeliverableSettlement::getFxFixingSchedule()
{
   if(!this->fxFixingScheduleIsNull_){
        if(fxFixingScheduleIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDates>(IDManager::instance().getID(fxFixingScheduleIDRef_));
        }else{
             return this->fxFixingSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDates>();
   }
}
boost::shared_ptr<SettlementRateOption> NonDeliverableSettlement::getSettlementRateOption()
{
   if(!this->settlementRateOptionIsNull_){
        if(settlementRateOptionIDRef_ != ""){
             return boost::shared_static_cast<SettlementRateOption>(IDManager::instance().getID(settlementRateOptionIDRef_));
        }else{
             return this->settlementRateOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementRateOption>();
   }
}
boost::shared_ptr<PriceSourceDisruption> NonDeliverableSettlement::getPriceSourceDisruption()
{
   if(!this->priceSourceDisruptionIsNull_){
        if(priceSourceDisruptionIDRef_ != ""){
             return boost::shared_static_cast<PriceSourceDisruption>(IDManager::instance().getID(priceSourceDisruptionIDRef_));
        }else{
             return this->priceSourceDisruption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PriceSourceDisruption>();
   }
}
}

