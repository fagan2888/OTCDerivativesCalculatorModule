// ElectricityPhysicalLeg.cpp 
#include "ElectricityPhysicalLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityPhysicalLeg::ElectricityPhysicalLeg(TiXmlNode* xmlNode)
: PhysicalSwapLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //deliveryPeriodsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryPeriodsNode = xmlNode->FirstChildElement("deliveryPeriods");

   if(deliveryPeriodsNode){deliveryPeriodsIsNull_ = false;}
   else{deliveryPeriodsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryPeriodsNode , address : " << deliveryPeriodsNode << std::endl;
   #endif
   if(deliveryPeriodsNode)
   {
      if(deliveryPeriodsNode->Attribute("href") || deliveryPeriodsNode->Attribute("id"))
      {
          if(deliveryPeriodsNode->Attribute("id"))
          {
             deliveryPeriodsIDRef_ = deliveryPeriodsNode->Attribute("id");
             deliveryPeriods_ = boost::shared_ptr<CommodityDeliveryPeriods>(new CommodityDeliveryPeriods(deliveryPeriodsNode));
             deliveryPeriods_->setID(deliveryPeriodsIDRef_);
             IDManager::instance().setID(deliveryPeriodsIDRef_,deliveryPeriods_);
          }
          else if(deliveryPeriodsNode->Attribute("href")) { deliveryPeriodsIDRef_ = deliveryPeriodsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryPeriods_ = boost::shared_ptr<CommodityDeliveryPeriods>(new CommodityDeliveryPeriods(deliveryPeriodsNode));}
   }

   //settlementPeriodsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsNode = xmlNode->FirstChildElement("settlementPeriods");

   if(settlementPeriodsNode){settlementPeriodsIsNull_ = false;}
   else{settlementPeriodsIsNull_ = true;}

   if(settlementPeriodsNode)
   {
      for(settlementPeriodsNode; settlementPeriodsNode; settlementPeriodsNode = settlementPeriodsNode->NextSiblingElement("settlementPeriods")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNode , address : " << settlementPeriodsNode << std::endl;
          #endif
          if(settlementPeriodsNode->Attribute("href") || settlementPeriodsNode->Attribute("id"))
          {
              if(settlementPeriodsNode->Attribute("id"))
              {
                  settlementPeriodsIDRef_ = settlementPeriodsNode->Attribute("id");
                  settlementPeriods_.push_back(boost::shared_ptr<SettlementPeriods>(new SettlementPeriods(settlementPeriodsNode)));
                  settlementPeriods_.back()->setID(settlementPeriodsIDRef_);
                  IDManager::instance().setID(settlementPeriodsIDRef_, settlementPeriods_.back());
              }
              else if(settlementPeriodsNode->Attribute("href")) { settlementPeriodsIDRef_ = settlementPeriodsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriods_.push_back(boost::shared_ptr<SettlementPeriods>(new SettlementPeriods(settlementPeriodsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNode , address : " << settlementPeriodsNode << std::endl;
       #endif
   }

   //settlementPeriodsScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsScheduleNode = xmlNode->FirstChildElement("settlementPeriodsSchedule");

   if(settlementPeriodsScheduleNode){settlementPeriodsScheduleIsNull_ = false;}
   else{settlementPeriodsScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsScheduleNode , address : " << settlementPeriodsScheduleNode << std::endl;
   #endif
   if(settlementPeriodsScheduleNode)
   {
      if(settlementPeriodsScheduleNode->Attribute("href") || settlementPeriodsScheduleNode->Attribute("id"))
      {
          if(settlementPeriodsScheduleNode->Attribute("id"))
          {
             settlementPeriodsScheduleIDRef_ = settlementPeriodsScheduleNode->Attribute("id");
             settlementPeriodsSchedule_ = boost::shared_ptr<SettlementPeriodsSchedule>(new SettlementPeriodsSchedule(settlementPeriodsScheduleNode));
             settlementPeriodsSchedule_->setID(settlementPeriodsScheduleIDRef_);
             IDManager::instance().setID(settlementPeriodsScheduleIDRef_,settlementPeriodsSchedule_);
          }
          else if(settlementPeriodsScheduleNode->Attribute("href")) { settlementPeriodsScheduleIDRef_ = settlementPeriodsScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementPeriodsSchedule_ = boost::shared_ptr<SettlementPeriodsSchedule>(new SettlementPeriodsSchedule(settlementPeriodsScheduleNode));}
   }

   //loadTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* loadTypeNode = xmlNode->FirstChildElement("loadType");

   if(loadTypeNode){loadTypeIsNull_ = false;}
   else{loadTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- loadTypeNode , address : " << loadTypeNode << std::endl;
   #endif
   if(loadTypeNode)
   {
      if(loadTypeNode->Attribute("href") || loadTypeNode->Attribute("id"))
      {
          if(loadTypeNode->Attribute("id"))
          {
             loadTypeIDRef_ = loadTypeNode->Attribute("id");
             loadType_ = boost::shared_ptr<LoadTypeEnum>(new LoadTypeEnum(loadTypeNode));
             loadType_->setID(loadTypeIDRef_);
             IDManager::instance().setID(loadTypeIDRef_,loadType_);
          }
          else if(loadTypeNode->Attribute("href")) { loadTypeIDRef_ = loadTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { loadType_ = boost::shared_ptr<LoadTypeEnum>(new LoadTypeEnum(loadTypeNode));}
   }

   //electricityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* electricityNode = xmlNode->FirstChildElement("electricity");

   if(electricityNode){electricityIsNull_ = false;}
   else{electricityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- electricityNode , address : " << electricityNode << std::endl;
   #endif
   if(electricityNode)
   {
      if(electricityNode->Attribute("href") || electricityNode->Attribute("id"))
      {
          if(electricityNode->Attribute("id"))
          {
             electricityIDRef_ = electricityNode->Attribute("id");
             electricity_ = boost::shared_ptr<ElectricityProduct>(new ElectricityProduct(electricityNode));
             electricity_->setID(electricityIDRef_);
             IDManager::instance().setID(electricityIDRef_,electricity_);
          }
          else if(electricityNode->Attribute("href")) { electricityIDRef_ = electricityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { electricity_ = boost::shared_ptr<ElectricityProduct>(new ElectricityProduct(electricityNode));}
   }

   //deliveryConditionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryConditionsNode = xmlNode->FirstChildElement("deliveryConditions");

   if(deliveryConditionsNode){deliveryConditionsIsNull_ = false;}
   else{deliveryConditionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryConditionsNode , address : " << deliveryConditionsNode << std::endl;
   #endif
   if(deliveryConditionsNode)
   {
      if(deliveryConditionsNode->Attribute("href") || deliveryConditionsNode->Attribute("id"))
      {
          if(deliveryConditionsNode->Attribute("id"))
          {
             deliveryConditionsIDRef_ = deliveryConditionsNode->Attribute("id");
             deliveryConditions_ = boost::shared_ptr<ElectricityDelivery>(new ElectricityDelivery(deliveryConditionsNode));
             deliveryConditions_->setID(deliveryConditionsIDRef_);
             IDManager::instance().setID(deliveryConditionsIDRef_,deliveryConditions_);
          }
          else if(deliveryConditionsNode->Attribute("href")) { deliveryConditionsIDRef_ = deliveryConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryConditions_ = boost::shared_ptr<ElectricityDelivery>(new ElectricityDelivery(deliveryConditionsNode));}
   }

   //deliveryQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryQuantityNode = xmlNode->FirstChildElement("deliveryQuantity");

   if(deliveryQuantityNode){deliveryQuantityIsNull_ = false;}
   else{deliveryQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryQuantityNode , address : " << deliveryQuantityNode << std::endl;
   #endif
   if(deliveryQuantityNode)
   {
      if(deliveryQuantityNode->Attribute("href") || deliveryQuantityNode->Attribute("id"))
      {
          if(deliveryQuantityNode->Attribute("id"))
          {
             deliveryQuantityIDRef_ = deliveryQuantityNode->Attribute("id");
             deliveryQuantity_ = boost::shared_ptr<ElectricityPhysicalQuantity>(new ElectricityPhysicalQuantity(deliveryQuantityNode));
             deliveryQuantity_->setID(deliveryQuantityIDRef_);
             IDManager::instance().setID(deliveryQuantityIDRef_,deliveryQuantity_);
          }
          else if(deliveryQuantityNode->Attribute("href")) { deliveryQuantityIDRef_ = deliveryQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryQuantity_ = boost::shared_ptr<ElectricityPhysicalQuantity>(new ElectricityPhysicalQuantity(deliveryQuantityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityDeliveryPeriods> ElectricityPhysicalLeg::getDeliveryPeriods()
{
   if(!this->deliveryPeriodsIsNull_){
        if(deliveryPeriodsIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPeriods>(IDManager::instance().getID(deliveryPeriodsIDRef_));
        }else{
             return this->deliveryPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPeriods>();
   }
}
std::vector<boost::shared_ptr<SettlementPeriods>> ElectricityPhysicalLeg::getSettlementPeriods()
{
   if(!this->settlementPeriodsIsNull_){
        if(settlementPeriodsIDRef_ != ""){
             return this->settlementPeriods_;
        }else{
             return this->settlementPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriods>>();
   }
}
boost::shared_ptr<SettlementPeriodsSchedule> ElectricityPhysicalLeg::getSettlementPeriodsSchedule()
{
   if(!this->settlementPeriodsScheduleIsNull_){
        if(settlementPeriodsScheduleIDRef_ != ""){
             return boost::shared_static_cast<SettlementPeriodsSchedule>(IDManager::instance().getID(settlementPeriodsScheduleIDRef_));
        }else{
             return this->settlementPeriodsSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementPeriodsSchedule>();
   }
}
boost::shared_ptr<LoadTypeEnum> ElectricityPhysicalLeg::getLoadType()
{
   if(!this->loadTypeIsNull_){
        if(loadTypeIDRef_ != ""){
             return boost::shared_static_cast<LoadTypeEnum>(IDManager::instance().getID(loadTypeIDRef_));
        }else{
             return this->loadType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LoadTypeEnum>();
   }
}
boost::shared_ptr<ElectricityProduct> ElectricityPhysicalLeg::getElectricity()
{
   if(!this->electricityIsNull_){
        if(electricityIDRef_ != ""){
             return boost::shared_static_cast<ElectricityProduct>(IDManager::instance().getID(electricityIDRef_));
        }else{
             return this->electricity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityProduct>();
   }
}
boost::shared_ptr<ElectricityDelivery> ElectricityPhysicalLeg::getDeliveryConditions()
{
   if(!this->deliveryConditionsIsNull_){
        if(deliveryConditionsIDRef_ != ""){
             return boost::shared_static_cast<ElectricityDelivery>(IDManager::instance().getID(deliveryConditionsIDRef_));
        }else{
             return this->deliveryConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityDelivery>();
   }
}
boost::shared_ptr<ElectricityPhysicalQuantity> ElectricityPhysicalLeg::getDeliveryQuantity()
{
   if(!this->deliveryQuantityIsNull_){
        if(deliveryQuantityIDRef_ != ""){
             return boost::shared_static_cast<ElectricityPhysicalQuantity>(IDManager::instance().getID(deliveryQuantityIDRef_));
        }else{
             return this->deliveryQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityPhysicalQuantity>();
   }
}
}

