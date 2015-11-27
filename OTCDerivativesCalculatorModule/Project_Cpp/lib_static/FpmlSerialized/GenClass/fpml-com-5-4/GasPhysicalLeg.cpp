// GasPhysicalLeg.cpp 
#include "GasPhysicalLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GasPhysicalLeg::GasPhysicalLeg(TiXmlNode* xmlNode)
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
             deliveryPeriods_ = boost::shared_ptr<GasDeliveryPeriods>(new GasDeliveryPeriods(deliveryPeriodsNode));
             deliveryPeriods_->setID(deliveryPeriodsIDRef_);
             IDManager::instance().setID(deliveryPeriodsIDRef_,deliveryPeriods_);
          }
          else if(deliveryPeriodsNode->Attribute("href")) { deliveryPeriodsIDRef_ = deliveryPeriodsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryPeriods_ = boost::shared_ptr<GasDeliveryPeriods>(new GasDeliveryPeriods(deliveryPeriodsNode));}
   }

   //gasNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gasNode = xmlNode->FirstChildElement("gas");

   if(gasNode){gasIsNull_ = false;}
   else{gasIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gasNode , address : " << gasNode << std::endl;
   #endif
   if(gasNode)
   {
      if(gasNode->Attribute("href") || gasNode->Attribute("id"))
      {
          if(gasNode->Attribute("id"))
          {
             gasIDRef_ = gasNode->Attribute("id");
             gas_ = boost::shared_ptr<GasProduct>(new GasProduct(gasNode));
             gas_->setID(gasIDRef_);
             IDManager::instance().setID(gasIDRef_,gas_);
          }
          else if(gasNode->Attribute("href")) { gasIDRef_ = gasNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { gas_ = boost::shared_ptr<GasProduct>(new GasProduct(gasNode));}
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
             deliveryConditions_ = boost::shared_ptr<GasDelivery>(new GasDelivery(deliveryConditionsNode));
             deliveryConditions_->setID(deliveryConditionsIDRef_);
             IDManager::instance().setID(deliveryConditionsIDRef_,deliveryConditions_);
          }
          else if(deliveryConditionsNode->Attribute("href")) { deliveryConditionsIDRef_ = deliveryConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryConditions_ = boost::shared_ptr<GasDelivery>(new GasDelivery(deliveryConditionsNode));}
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
             deliveryQuantity_ = boost::shared_ptr<GasPhysicalQuantity>(new GasPhysicalQuantity(deliveryQuantityNode));
             deliveryQuantity_->setID(deliveryQuantityIDRef_);
             IDManager::instance().setID(deliveryQuantityIDRef_,deliveryQuantity_);
          }
          else if(deliveryQuantityNode->Attribute("href")) { deliveryQuantityIDRef_ = deliveryQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryQuantity_ = boost::shared_ptr<GasPhysicalQuantity>(new GasPhysicalQuantity(deliveryQuantityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<GasDeliveryPeriods> GasPhysicalLeg::getDeliveryPeriods()
{
   if(!this->deliveryPeriodsIsNull_){
        if(deliveryPeriodsIDRef_ != ""){
             return boost::shared_static_cast<GasDeliveryPeriods>(IDManager::instance().getID(deliveryPeriodsIDRef_));
        }else{
             return this->deliveryPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasDeliveryPeriods>();
   }
}
boost::shared_ptr<GasProduct> GasPhysicalLeg::getGas()
{
   if(!this->gasIsNull_){
        if(gasIDRef_ != ""){
             return boost::shared_static_cast<GasProduct>(IDManager::instance().getID(gasIDRef_));
        }else{
             return this->gas_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasProduct>();
   }
}
boost::shared_ptr<GasDelivery> GasPhysicalLeg::getDeliveryConditions()
{
   if(!this->deliveryConditionsIsNull_){
        if(deliveryConditionsIDRef_ != ""){
             return boost::shared_static_cast<GasDelivery>(IDManager::instance().getID(deliveryConditionsIDRef_));
        }else{
             return this->deliveryConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasDelivery>();
   }
}
boost::shared_ptr<GasPhysicalQuantity> GasPhysicalLeg::getDeliveryQuantity()
{
   if(!this->deliveryQuantityIsNull_){
        if(deliveryQuantityIDRef_ != ""){
             return boost::shared_static_cast<GasPhysicalQuantity>(IDManager::instance().getID(deliveryQuantityIDRef_));
        }else{
             return this->deliveryQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasPhysicalQuantity>();
   }
}
}

