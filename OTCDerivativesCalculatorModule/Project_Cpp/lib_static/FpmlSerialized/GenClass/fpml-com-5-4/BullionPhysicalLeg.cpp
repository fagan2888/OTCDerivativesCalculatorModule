// BullionPhysicalLeg.cpp 
#include "BullionPhysicalLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BullionPhysicalLeg::BullionPhysicalLeg(TiXmlNode* xmlNode)
: PhysicalForwardLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //bullionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bullionTypeNode = xmlNode->FirstChildElement("bullionType");

   if(bullionTypeNode){bullionTypeIsNull_ = false;}
   else{bullionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bullionTypeNode , address : " << bullionTypeNode << std::endl;
   #endif
   if(bullionTypeNode)
   {
      if(bullionTypeNode->Attribute("href") || bullionTypeNode->Attribute("id"))
      {
          if(bullionTypeNode->Attribute("id"))
          {
             bullionTypeIDRef_ = bullionTypeNode->Attribute("id");
             bullionType_ = boost::shared_ptr<BullionTypeEnum>(new BullionTypeEnum(bullionTypeNode));
             bullionType_->setID(bullionTypeIDRef_);
             IDManager::instance().setID(bullionTypeIDRef_,bullionType_);
          }
          else if(bullionTypeNode->Attribute("href")) { bullionTypeIDRef_ = bullionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bullionType_ = boost::shared_ptr<BullionTypeEnum>(new BullionTypeEnum(bullionTypeNode));}
   }

   //deliveryLocationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryLocationNode = xmlNode->FirstChildElement("deliveryLocation");

   if(deliveryLocationNode){deliveryLocationIsNull_ = false;}
   else{deliveryLocationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryLocationNode , address : " << deliveryLocationNode << std::endl;
   #endif
   if(deliveryLocationNode)
   {
      if(deliveryLocationNode->Attribute("href") || deliveryLocationNode->Attribute("id"))
      {
          if(deliveryLocationNode->Attribute("id"))
          {
             deliveryLocationIDRef_ = deliveryLocationNode->Attribute("id");
             deliveryLocation_ = boost::shared_ptr<BullionDeliveryLocation>(new BullionDeliveryLocation(deliveryLocationNode));
             deliveryLocation_->setID(deliveryLocationIDRef_);
             IDManager::instance().setID(deliveryLocationIDRef_,deliveryLocation_);
          }
          else if(deliveryLocationNode->Attribute("href")) { deliveryLocationIDRef_ = deliveryLocationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryLocation_ = boost::shared_ptr<BullionDeliveryLocation>(new BullionDeliveryLocation(deliveryLocationNode));}
   }

   //physicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalQuantityNode = xmlNode->FirstChildElement("physicalQuantity");

   if(physicalQuantityNode){physicalQuantityIsNull_ = false;}
   else{physicalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityNode , address : " << physicalQuantityNode << std::endl;
   #endif
   if(physicalQuantityNode)
   {
      if(physicalQuantityNode->Attribute("href") || physicalQuantityNode->Attribute("id"))
      {
          if(physicalQuantityNode->Attribute("id"))
          {
             physicalQuantityIDRef_ = physicalQuantityNode->Attribute("id");
             physicalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(physicalQuantityNode));
             physicalQuantity_->setID(physicalQuantityIDRef_);
             IDManager::instance().setID(physicalQuantityIDRef_,physicalQuantity_);
          }
          else if(physicalQuantityNode->Attribute("href")) { physicalQuantityIDRef_ = physicalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(physicalQuantityNode));}
   }

   //physicalQuantityScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalQuantityScheduleNode = xmlNode->FirstChildElement("physicalQuantitySchedule");

   if(physicalQuantityScheduleNode){physicalQuantityScheduleIsNull_ = false;}
   else{physicalQuantityScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityScheduleNode , address : " << physicalQuantityScheduleNode << std::endl;
   #endif
   if(physicalQuantityScheduleNode)
   {
      if(physicalQuantityScheduleNode->Attribute("href") || physicalQuantityScheduleNode->Attribute("id"))
      {
          if(physicalQuantityScheduleNode->Attribute("id"))
          {
             physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("id");
             physicalQuantitySchedule_ = boost::shared_ptr<CommodityPhysicalQuantitySchedule>(new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode));
             physicalQuantitySchedule_->setID(physicalQuantityScheduleIDRef_);
             IDManager::instance().setID(physicalQuantityScheduleIDRef_,physicalQuantitySchedule_);
          }
          else if(physicalQuantityScheduleNode->Attribute("href")) { physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalQuantitySchedule_ = boost::shared_ptr<CommodityPhysicalQuantitySchedule>(new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode));}
   }

   //totalPhysicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* totalPhysicalQuantityNode = xmlNode->FirstChildElement("totalPhysicalQuantity");

   if(totalPhysicalQuantityNode){totalPhysicalQuantityIsNull_ = false;}
   else{totalPhysicalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- totalPhysicalQuantityNode , address : " << totalPhysicalQuantityNode << std::endl;
   #endif
   if(totalPhysicalQuantityNode)
   {
      if(totalPhysicalQuantityNode->Attribute("href") || totalPhysicalQuantityNode->Attribute("id"))
      {
          if(totalPhysicalQuantityNode->Attribute("id"))
          {
             totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode->Attribute("id");
             totalPhysicalQuantity_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(totalPhysicalQuantityNode));
             totalPhysicalQuantity_->setID(totalPhysicalQuantityIDRef_);
             IDManager::instance().setID(totalPhysicalQuantityIDRef_,totalPhysicalQuantity_);
          }
          else if(totalPhysicalQuantityNode->Attribute("href")) { totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { totalPhysicalQuantity_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(totalPhysicalQuantityNode));}
   }

   //settlementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementDateNode = xmlNode->FirstChildElement("settlementDate");

   if(settlementDateNode){settlementDateIsNull_ = false;}
   else{settlementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementDateNode , address : " << settlementDateNode << std::endl;
   #endif
   if(settlementDateNode)
   {
      if(settlementDateNode->Attribute("href") || settlementDateNode->Attribute("id"))
      {
          if(settlementDateNode->Attribute("id"))
          {
             settlementDateIDRef_ = settlementDateNode->Attribute("id");
             settlementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(settlementDateNode));
             settlementDate_->setID(settlementDateIDRef_);
             IDManager::instance().setID(settlementDateIDRef_,settlementDate_);
          }
          else if(settlementDateNode->Attribute("href")) { settlementDateIDRef_ = settlementDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(settlementDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BullionTypeEnum> BullionPhysicalLeg::getBullionType()
{
   if(!this->bullionTypeIsNull_){
        if(bullionTypeIDRef_ != ""){
             return boost::shared_static_cast<BullionTypeEnum>(IDManager::instance().getID(bullionTypeIDRef_));
        }else{
             return this->bullionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BullionTypeEnum>();
   }
}
boost::shared_ptr<BullionDeliveryLocation> BullionPhysicalLeg::getDeliveryLocation()
{
   if(!this->deliveryLocationIsNull_){
        if(deliveryLocationIDRef_ != ""){
             return boost::shared_static_cast<BullionDeliveryLocation>(IDManager::instance().getID(deliveryLocationIDRef_));
        }else{
             return this->deliveryLocation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BullionDeliveryLocation>();
   }
}
boost::shared_ptr<CommodityNotionalQuantity> BullionPhysicalLeg::getPhysicalQuantity()
{
   if(!this->physicalQuantityIsNull_){
        if(physicalQuantityIDRef_ != ""){
             return boost::shared_static_cast<CommodityNotionalQuantity>(IDManager::instance().getID(physicalQuantityIDRef_));
        }else{
             return this->physicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityNotionalQuantity>();
   }
}
boost::shared_ptr<CommodityPhysicalQuantitySchedule> BullionPhysicalLeg::getPhysicalQuantitySchedule()
{
   if(!this->physicalQuantityScheduleIsNull_){
        if(physicalQuantityScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalQuantitySchedule>(IDManager::instance().getID(physicalQuantityScheduleIDRef_));
        }else{
             return this->physicalQuantitySchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalQuantitySchedule>();
   }
}
boost::shared_ptr<UnitQuantity> BullionPhysicalLeg::getTotalPhysicalQuantity()
{
   if(!this->totalPhysicalQuantityIsNull_){
        if(totalPhysicalQuantityIDRef_ != ""){
             return boost::shared_static_cast<UnitQuantity>(IDManager::instance().getID(totalPhysicalQuantityIDRef_));
        }else{
             return this->totalPhysicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnitQuantity>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> BullionPhysicalLeg::getSettlementDate()
{
   if(!this->settlementDateIsNull_){
        if(settlementDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(settlementDateIDRef_));
        }else{
             return this->settlementDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

