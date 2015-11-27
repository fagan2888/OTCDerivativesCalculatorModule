// ElectricityDelivery.cpp 
#include "ElectricityDelivery.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityDelivery::ElectricityDelivery(TiXmlNode* xmlNode)
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
             deliveryPoint_ = boost::shared_ptr<ElectricityDeliveryPoint>(new ElectricityDeliveryPoint(deliveryPointNode));
             deliveryPoint_->setID(deliveryPointIDRef_);
             IDManager::instance().setID(deliveryPointIDRef_,deliveryPoint_);
          }
          else if(deliveryPointNode->Attribute("href")) { deliveryPointIDRef_ = deliveryPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryPoint_ = boost::shared_ptr<ElectricityDeliveryPoint>(new ElectricityDeliveryPoint(deliveryPointNode));}
   }

   //deliveryTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryTypeNode = xmlNode->FirstChildElement("deliveryType");

   if(deliveryTypeNode){deliveryTypeIsNull_ = false;}
   else{deliveryTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryTypeNode , address : " << deliveryTypeNode << std::endl;
   #endif
   if(deliveryTypeNode)
   {
      if(deliveryTypeNode->Attribute("href") || deliveryTypeNode->Attribute("id"))
      {
          if(deliveryTypeNode->Attribute("id"))
          {
             deliveryTypeIDRef_ = deliveryTypeNode->Attribute("id");
             deliveryType_ = boost::shared_ptr<ElectricityDeliveryType>(new ElectricityDeliveryType(deliveryTypeNode));
             deliveryType_->setID(deliveryTypeIDRef_);
             IDManager::instance().setID(deliveryTypeIDRef_,deliveryType_);
          }
          else if(deliveryTypeNode->Attribute("href")) { deliveryTypeIDRef_ = deliveryTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryType_ = boost::shared_ptr<ElectricityDeliveryType>(new ElectricityDeliveryType(deliveryTypeNode));}
   }

   //transmissionContingencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transmissionContingencyNode = xmlNode->FirstChildElement("transmissionContingency");

   if(transmissionContingencyNode){transmissionContingencyIsNull_ = false;}
   else{transmissionContingencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transmissionContingencyNode , address : " << transmissionContingencyNode << std::endl;
   #endif
   if(transmissionContingencyNode)
   {
      if(transmissionContingencyNode->Attribute("href") || transmissionContingencyNode->Attribute("id"))
      {
          if(transmissionContingencyNode->Attribute("id"))
          {
             transmissionContingencyIDRef_ = transmissionContingencyNode->Attribute("id");
             transmissionContingency_ = boost::shared_ptr<ElectricityTransmissionContingency>(new ElectricityTransmissionContingency(transmissionContingencyNode));
             transmissionContingency_->setID(transmissionContingencyIDRef_);
             IDManager::instance().setID(transmissionContingencyIDRef_,transmissionContingency_);
          }
          else if(transmissionContingencyNode->Attribute("href")) { transmissionContingencyIDRef_ = transmissionContingencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transmissionContingency_ = boost::shared_ptr<ElectricityTransmissionContingency>(new ElectricityTransmissionContingency(transmissionContingencyNode));}
   }

   //deliveryZoneNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryZoneNode = xmlNode->FirstChildElement("deliveryZone");

   if(deliveryZoneNode){deliveryZoneIsNull_ = false;}
   else{deliveryZoneIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryZoneNode , address : " << deliveryZoneNode << std::endl;
   #endif
   if(deliveryZoneNode)
   {
      if(deliveryZoneNode->Attribute("href") || deliveryZoneNode->Attribute("id"))
      {
          if(deliveryZoneNode->Attribute("id"))
          {
             deliveryZoneIDRef_ = deliveryZoneNode->Attribute("id");
             deliveryZone_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(deliveryZoneNode));
             deliveryZone_->setID(deliveryZoneIDRef_);
             IDManager::instance().setID(deliveryZoneIDRef_,deliveryZone_);
          }
          else if(deliveryZoneNode->Attribute("href")) { deliveryZoneIDRef_ = deliveryZoneNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryZone_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(deliveryZoneNode));}
   }

   //electingPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* electingPartyReferenceNode = xmlNode->FirstChildElement("electingPartyReference");

   if(electingPartyReferenceNode){electingPartyReferenceIsNull_ = false;}
   else{electingPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- electingPartyReferenceNode , address : " << electingPartyReferenceNode << std::endl;
   #endif
   if(electingPartyReferenceNode)
   {
      if(electingPartyReferenceNode->Attribute("href") || electingPartyReferenceNode->Attribute("id"))
      {
          if(electingPartyReferenceNode->Attribute("id"))
          {
             electingPartyReferenceIDRef_ = electingPartyReferenceNode->Attribute("id");
             electingPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(electingPartyReferenceNode));
             electingPartyReference_->setID(electingPartyReferenceIDRef_);
             IDManager::instance().setID(electingPartyReferenceIDRef_,electingPartyReference_);
          }
          else if(electingPartyReferenceNode->Attribute("href")) { electingPartyReferenceIDRef_ = electingPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { electingPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(electingPartyReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ElectricityDeliveryPoint> ElectricityDelivery::getDeliveryPoint()
{
   if(!this->deliveryPointIsNull_){
        if(deliveryPointIDRef_ != ""){
             return boost::shared_static_cast<ElectricityDeliveryPoint>(IDManager::instance().getID(deliveryPointIDRef_));
        }else{
             return this->deliveryPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityDeliveryPoint>();
   }
}
boost::shared_ptr<ElectricityDeliveryType> ElectricityDelivery::getDeliveryType()
{
   if(!this->deliveryTypeIsNull_){
        if(deliveryTypeIDRef_ != ""){
             return boost::shared_static_cast<ElectricityDeliveryType>(IDManager::instance().getID(deliveryTypeIDRef_));
        }else{
             return this->deliveryType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityDeliveryType>();
   }
}
boost::shared_ptr<ElectricityTransmissionContingency> ElectricityDelivery::getTransmissionContingency()
{
   if(!this->transmissionContingencyIsNull_){
        if(transmissionContingencyIDRef_ != ""){
             return boost::shared_static_cast<ElectricityTransmissionContingency>(IDManager::instance().getID(transmissionContingencyIDRef_));
        }else{
             return this->transmissionContingency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityTransmissionContingency>();
   }
}
boost::shared_ptr<CommodityDeliveryPoint> ElectricityDelivery::getDeliveryZone()
{
   if(!this->deliveryZoneIsNull_){
        if(deliveryZoneIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(deliveryZoneIDRef_));
        }else{
             return this->deliveryZone_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
boost::shared_ptr<PartyReference> ElectricityDelivery::getElectingPartyReference()
{
   if(!this->electingPartyReferenceIsNull_){
        if(electingPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(electingPartyReferenceIDRef_));
        }else{
             return this->electingPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

