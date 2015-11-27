// CoalDelivery.cpp 
#include "CoalDelivery.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CoalDelivery::CoalDelivery(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //deliveryPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryPointNode = xmlNode->FirstChildElement("deliveryPoint");

   if(deliveryPointNode){deliveryPointIsNull_ = false;}
   else{deliveryPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryPointNode , address : " << deliveryPointNode << std::endl;
   #endif
   if(deliveryPointNode)
   {
      if(deliveryPointNode->Attribute("href") || deliveryPointNode->Attribute("id"))
      {
          if(deliveryPointNode->Attribute("id"))
          {
             deliveryPointIDRef_ = deliveryPointNode->Attribute("id");
             deliveryPoint_ = boost::shared_ptr<CoalDeliveryPoint>(new CoalDeliveryPoint(deliveryPointNode));
             deliveryPoint_->setID(deliveryPointIDRef_);
             IDManager::instance().setID(deliveryPointIDRef_,deliveryPoint_);
          }
          else if(deliveryPointNode->Attribute("href")) { deliveryPointIDRef_ = deliveryPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryPoint_ = boost::shared_ptr<CoalDeliveryPoint>(new CoalDeliveryPoint(deliveryPointNode));}
   }

   //deliveryAtSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryAtSourceNode = xmlNode->FirstChildElement("deliveryAtSource");

   if(deliveryAtSourceNode){deliveryAtSourceIsNull_ = false;}
   else{deliveryAtSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryAtSourceNode , address : " << deliveryAtSourceNode << std::endl;
   #endif
   if(deliveryAtSourceNode)
   {
      if(deliveryAtSourceNode->Attribute("href") || deliveryAtSourceNode->Attribute("id"))
      {
          if(deliveryAtSourceNode->Attribute("id"))
          {
             deliveryAtSourceIDRef_ = deliveryAtSourceNode->Attribute("id");
             deliveryAtSource_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deliveryAtSourceNode));
             deliveryAtSource_->setID(deliveryAtSourceIDRef_);
             IDManager::instance().setID(deliveryAtSourceIDRef_,deliveryAtSource_);
          }
          else if(deliveryAtSourceNode->Attribute("href")) { deliveryAtSourceIDRef_ = deliveryAtSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryAtSource_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deliveryAtSourceNode));}
   }

   //quantityVariationAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quantityVariationAdjustmentNode = xmlNode->FirstChildElement("quantityVariationAdjustment");

   if(quantityVariationAdjustmentNode){quantityVariationAdjustmentIsNull_ = false;}
   else{quantityVariationAdjustmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quantityVariationAdjustmentNode , address : " << quantityVariationAdjustmentNode << std::endl;
   #endif
   if(quantityVariationAdjustmentNode)
   {
      if(quantityVariationAdjustmentNode->Attribute("href") || quantityVariationAdjustmentNode->Attribute("id"))
      {
          if(quantityVariationAdjustmentNode->Attribute("id"))
          {
             quantityVariationAdjustmentIDRef_ = quantityVariationAdjustmentNode->Attribute("id");
             quantityVariationAdjustment_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(quantityVariationAdjustmentNode));
             quantityVariationAdjustment_->setID(quantityVariationAdjustmentIDRef_);
             IDManager::instance().setID(quantityVariationAdjustmentIDRef_,quantityVariationAdjustment_);
          }
          else if(quantityVariationAdjustmentNode->Attribute("href")) { quantityVariationAdjustmentIDRef_ = quantityVariationAdjustmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quantityVariationAdjustment_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(quantityVariationAdjustmentNode));}
   }

   //transportationEquipmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transportationEquipmentNode = xmlNode->FirstChildElement("transportationEquipment");

   if(transportationEquipmentNode){transportationEquipmentIsNull_ = false;}
   else{transportationEquipmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transportationEquipmentNode , address : " << transportationEquipmentNode << std::endl;
   #endif
   if(transportationEquipmentNode)
   {
      if(transportationEquipmentNode->Attribute("href") || transportationEquipmentNode->Attribute("id"))
      {
          if(transportationEquipmentNode->Attribute("id"))
          {
             transportationEquipmentIDRef_ = transportationEquipmentNode->Attribute("id");
             transportationEquipment_ = boost::shared_ptr<CoalTransportationEquipment>(new CoalTransportationEquipment(transportationEquipmentNode));
             transportationEquipment_->setID(transportationEquipmentIDRef_);
             IDManager::instance().setID(transportationEquipmentIDRef_,transportationEquipment_);
          }
          else if(transportationEquipmentNode->Attribute("href")) { transportationEquipmentIDRef_ = transportationEquipmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transportationEquipment_ = boost::shared_ptr<CoalTransportationEquipment>(new CoalTransportationEquipment(transportationEquipmentNode));}
   }

   //riskNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* riskNode = xmlNode->FirstChildElement("risk");

   if(riskNode){riskIsNull_ = false;}
   else{riskIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- riskNode , address : " << riskNode << std::endl;
   #endif
   if(riskNode)
   {
      if(riskNode->Attribute("href") || riskNode->Attribute("id"))
      {
          if(riskNode->Attribute("id"))
          {
             riskIDRef_ = riskNode->Attribute("id");
             risk_ = boost::shared_ptr<CommodityDeliveryRisk>(new CommodityDeliveryRisk(riskNode));
             risk_->setID(riskIDRef_);
             IDManager::instance().setID(riskIDRef_,risk_);
          }
          else if(riskNode->Attribute("href")) { riskIDRef_ = riskNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { risk_ = boost::shared_ptr<CommodityDeliveryRisk>(new CommodityDeliveryRisk(riskNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CoalDeliveryPoint> CoalDelivery::getDeliveryPoint()
{
   if(!this->deliveryPointIsNull_){
        if(deliveryPointIDRef_ != ""){
             return boost::shared_static_cast<CoalDeliveryPoint>(IDManager::instance().getID(deliveryPointIDRef_));
        }else{
             return this->deliveryPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalDeliveryPoint>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CoalDelivery::getDeliveryAtSource()
{
   if(!this->deliveryAtSourceIsNull_){
        if(deliveryAtSourceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(deliveryAtSourceIDRef_));
        }else{
             return this->deliveryAtSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CoalDelivery::getQuantityVariationAdjustment()
{
   if(!this->quantityVariationAdjustmentIsNull_){
        if(quantityVariationAdjustmentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(quantityVariationAdjustmentIDRef_));
        }else{
             return this->quantityVariationAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CoalTransportationEquipment> CoalDelivery::getTransportationEquipment()
{
   if(!this->transportationEquipmentIsNull_){
        if(transportationEquipmentIDRef_ != ""){
             return boost::shared_static_cast<CoalTransportationEquipment>(IDManager::instance().getID(transportationEquipmentIDRef_));
        }else{
             return this->transportationEquipment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalTransportationEquipment>();
   }
}
boost::shared_ptr<CommodityDeliveryRisk> CoalDelivery::getRisk()
{
   if(!this->riskIsNull_){
        if(riskIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryRisk>(IDManager::instance().getID(riskIDRef_));
        }else{
             return this->risk_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryRisk>();
   }
}
}

