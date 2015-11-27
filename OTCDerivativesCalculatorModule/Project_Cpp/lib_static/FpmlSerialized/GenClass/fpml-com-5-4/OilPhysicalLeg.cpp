// OilPhysicalLeg.cpp 
#include "OilPhysicalLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OilPhysicalLeg::OilPhysicalLeg(TiXmlNode* xmlNode)
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

   //oilNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* oilNode = xmlNode->FirstChildElement("oil");

   if(oilNode){oilIsNull_ = false;}
   else{oilIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- oilNode , address : " << oilNode << std::endl;
   #endif
   if(oilNode)
   {
      if(oilNode->Attribute("href") || oilNode->Attribute("id"))
      {
          if(oilNode->Attribute("id"))
          {
             oilIDRef_ = oilNode->Attribute("id");
             oil_ = boost::shared_ptr<OilProduct>(new OilProduct(oilNode));
             oil_->setID(oilIDRef_);
             IDManager::instance().setID(oilIDRef_,oil_);
          }
          else if(oilNode->Attribute("href")) { oilIDRef_ = oilNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { oil_ = boost::shared_ptr<OilProduct>(new OilProduct(oilNode));}
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
             deliveryConditions_ = boost::shared_ptr<OilDelivery>(new OilDelivery(deliveryConditionsNode));
             deliveryConditions_->setID(deliveryConditionsIDRef_);
             IDManager::instance().setID(deliveryConditionsIDRef_,deliveryConditions_);
          }
          else if(deliveryConditionsNode->Attribute("href")) { deliveryConditionsIDRef_ = deliveryConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryConditions_ = boost::shared_ptr<OilDelivery>(new OilDelivery(deliveryConditionsNode));}
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
             deliveryQuantity_ = boost::shared_ptr<CommodityPhysicalQuantity>(new CommodityPhysicalQuantity(deliveryQuantityNode));
             deliveryQuantity_->setID(deliveryQuantityIDRef_);
             IDManager::instance().setID(deliveryQuantityIDRef_,deliveryQuantity_);
          }
          else if(deliveryQuantityNode->Attribute("href")) { deliveryQuantityIDRef_ = deliveryQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryQuantity_ = boost::shared_ptr<CommodityPhysicalQuantity>(new CommodityPhysicalQuantity(deliveryQuantityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityDeliveryPeriods> OilPhysicalLeg::getDeliveryPeriods()
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
boost::shared_ptr<OilProduct> OilPhysicalLeg::getOil()
{
   if(!this->oilIsNull_){
        if(oilIDRef_ != ""){
             return boost::shared_static_cast<OilProduct>(IDManager::instance().getID(oilIDRef_));
        }else{
             return this->oil_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OilProduct>();
   }
}
boost::shared_ptr<OilDelivery> OilPhysicalLeg::getDeliveryConditions()
{
   if(!this->deliveryConditionsIsNull_){
        if(deliveryConditionsIDRef_ != ""){
             return boost::shared_static_cast<OilDelivery>(IDManager::instance().getID(deliveryConditionsIDRef_));
        }else{
             return this->deliveryConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OilDelivery>();
   }
}
boost::shared_ptr<CommodityPhysicalQuantity> OilPhysicalLeg::getDeliveryQuantity()
{
   if(!this->deliveryQuantityIsNull_){
        if(deliveryQuantityIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalQuantity>(IDManager::instance().getID(deliveryQuantityIDRef_));
        }else{
             return this->deliveryQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalQuantity>();
   }
}
}

