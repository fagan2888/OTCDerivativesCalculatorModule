// OilTransferDelivery.cpp 
#include "OilTransferDelivery.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OilTransferDelivery::OilTransferDelivery(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //applicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* applicableNode = xmlNode->FirstChildElement("applicable");

   if(applicableNode){applicableIsNull_ = false;}
   else{applicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableNode , address : " << applicableNode << std::endl;
   #endif
   if(applicableNode)
   {
      if(applicableNode->Attribute("href") || applicableNode->Attribute("id"))
      {
          if(applicableNode->Attribute("id"))
          {
             applicableIDRef_ = applicableNode->Attribute("id");
             applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));
             applicable_->setID(applicableIDRef_);
             IDManager::instance().setID(applicableIDRef_,applicable_);
          }
          else if(applicableNode->Attribute("href")) { applicableIDRef_ = applicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));}
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
             deliveryLocation_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(deliveryLocationNode));
             deliveryLocation_->setID(deliveryLocationIDRef_);
             IDManager::instance().setID(deliveryLocationIDRef_,deliveryLocation_);
          }
          else if(deliveryLocationNode->Attribute("href")) { deliveryLocationIDRef_ = deliveryLocationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryLocation_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(deliveryLocationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> OilTransferDelivery::getApplicable()
{
   if(!this->applicableIsNull_){
        if(applicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(applicableIDRef_));
        }else{
             return this->applicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CommodityDeliveryPoint> OilTransferDelivery::getDeliveryLocation()
{
   if(!this->deliveryLocationIsNull_){
        if(deliveryLocationIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(deliveryLocationIDRef_));
        }else{
             return this->deliveryLocation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
}

