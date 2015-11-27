// MetalPhysicalLeg.cpp 
#include "MetalPhysicalLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MetalPhysicalLeg::MetalPhysicalLeg(TiXmlNode* xmlNode)
: PhysicalForwardLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //metalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* metalNode = xmlNode->FirstChildElement("metal");

   if(metalNode){metalIsNull_ = false;}
   else{metalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- metalNode , address : " << metalNode << std::endl;
   #endif
   if(metalNode)
   {
      if(metalNode->Attribute("href") || metalNode->Attribute("id"))
      {
          if(metalNode->Attribute("id"))
          {
             metalIDRef_ = metalNode->Attribute("id");
             metal_ = boost::shared_ptr<Metal>(new Metal(metalNode));
             metal_->setID(metalIDRef_);
             IDManager::instance().setID(metalIDRef_,metal_);
          }
          else if(metalNode->Attribute("href")) { metalIDRef_ = metalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { metal_ = boost::shared_ptr<Metal>(new Metal(metalNode));}
   }

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
             deliveryConditions_ = boost::shared_ptr<MetalDelivery>(new MetalDelivery(deliveryConditionsNode));
             deliveryConditions_->setID(deliveryConditionsIDRef_);
             IDManager::instance().setID(deliveryConditionsIDRef_,deliveryConditions_);
          }
          else if(deliveryConditionsNode->Attribute("href")) { deliveryConditionsIDRef_ = deliveryConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryConditions_ = boost::shared_ptr<MetalDelivery>(new MetalDelivery(deliveryConditionsNode));}
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

   //conversionFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* conversionFactorNode = xmlNode->FirstChildElement("conversionFactor");

   if(conversionFactorNode){conversionFactorIsNull_ = false;}
   else{conversionFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- conversionFactorNode , address : " << conversionFactorNode << std::endl;
   #endif
   if(conversionFactorNode)
   {
      if(conversionFactorNode->Attribute("href") || conversionFactorNode->Attribute("id"))
      {
          if(conversionFactorNode->Attribute("id"))
          {
             conversionFactorIDRef_ = conversionFactorNode->Attribute("id");
             conversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(conversionFactorNode));
             conversionFactor_->setID(conversionFactorIDRef_);
             IDManager::instance().setID(conversionFactorIDRef_,conversionFactor_);
          }
          else if(conversionFactorNode->Attribute("href")) { conversionFactorIDRef_ = conversionFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { conversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(conversionFactorNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Metal> MetalPhysicalLeg::getMetal()
{
   if(!this->metalIsNull_){
        if(metalIDRef_ != ""){
             return boost::shared_static_cast<Metal>(IDManager::instance().getID(metalIDRef_));
        }else{
             return this->metal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Metal>();
   }
}
boost::shared_ptr<CommodityDeliveryPeriods> MetalPhysicalLeg::getDeliveryPeriods()
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
boost::shared_ptr<MetalDelivery> MetalPhysicalLeg::getDeliveryConditions()
{
   if(!this->deliveryConditionsIsNull_){
        if(deliveryConditionsIDRef_ != ""){
             return boost::shared_static_cast<MetalDelivery>(IDManager::instance().getID(deliveryConditionsIDRef_));
        }else{
             return this->deliveryConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MetalDelivery>();
   }
}
boost::shared_ptr<CommodityNotionalQuantity> MetalPhysicalLeg::getPhysicalQuantity()
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
boost::shared_ptr<CommodityPhysicalQuantitySchedule> MetalPhysicalLeg::getPhysicalQuantitySchedule()
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
boost::shared_ptr<UnitQuantity> MetalPhysicalLeg::getTotalPhysicalQuantity()
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
boost::shared_ptr<XsdTypeDecimal> MetalPhysicalLeg::getConversionFactor()
{
   if(!this->conversionFactorIsNull_){
        if(conversionFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(conversionFactorIDRef_));
        }else{
             return this->conversionFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

