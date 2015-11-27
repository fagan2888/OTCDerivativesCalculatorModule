// CoalPhysicalLeg.cpp 
#include "CoalPhysicalLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CoalPhysicalLeg::CoalPhysicalLeg(TiXmlNode* xmlNode)
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

   //coalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coalNode = xmlNode->FirstChildElement("coal");

   if(coalNode){coalIsNull_ = false;}
   else{coalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coalNode , address : " << coalNode << std::endl;
   #endif
   if(coalNode)
   {
      if(coalNode->Attribute("href") || coalNode->Attribute("id"))
      {
          if(coalNode->Attribute("id"))
          {
             coalIDRef_ = coalNode->Attribute("id");
             coal_ = boost::shared_ptr<CoalProduct>(new CoalProduct(coalNode));
             coal_->setID(coalIDRef_);
             IDManager::instance().setID(coalIDRef_,coal_);
          }
          else if(coalNode->Attribute("href")) { coalIDRef_ = coalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coal_ = boost::shared_ptr<CoalProduct>(new CoalProduct(coalNode));}
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
             deliveryConditions_ = boost::shared_ptr<CoalDelivery>(new CoalDelivery(deliveryConditionsNode));
             deliveryConditions_->setID(deliveryConditionsIDRef_);
             IDManager::instance().setID(deliveryConditionsIDRef_,deliveryConditions_);
          }
          else if(deliveryConditionsNode->Attribute("href")) { deliveryConditionsIDRef_ = deliveryConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryConditions_ = boost::shared_ptr<CoalDelivery>(new CoalDelivery(deliveryConditionsNode));}
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
boost::shared_ptr<CommodityDeliveryPeriods> CoalPhysicalLeg::getDeliveryPeriods()
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
boost::shared_ptr<CoalProduct> CoalPhysicalLeg::getCoal()
{
   if(!this->coalIsNull_){
        if(coalIDRef_ != ""){
             return boost::shared_static_cast<CoalProduct>(IDManager::instance().getID(coalIDRef_));
        }else{
             return this->coal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalProduct>();
   }
}
boost::shared_ptr<CoalDelivery> CoalPhysicalLeg::getDeliveryConditions()
{
   if(!this->deliveryConditionsIsNull_){
        if(deliveryConditionsIDRef_ != ""){
             return boost::shared_static_cast<CoalDelivery>(IDManager::instance().getID(deliveryConditionsIDRef_));
        }else{
             return this->deliveryConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalDelivery>();
   }
}
boost::shared_ptr<CommodityPhysicalQuantity> CoalPhysicalLeg::getDeliveryQuantity()
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

