// GasDelivery.cpp 
#include "GasDelivery.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GasDelivery::GasDelivery(TiXmlNode* xmlNode)
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
             deliveryPoint_ = boost::shared_ptr<GasDeliveryPoint>(new GasDeliveryPoint(deliveryPointNode));
             deliveryPoint_->setID(deliveryPointIDRef_);
             IDManager::instance().setID(deliveryPointIDRef_,deliveryPoint_);
          }
          else if(deliveryPointNode->Attribute("href")) { deliveryPointIDRef_ = deliveryPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryPoint_ = boost::shared_ptr<GasDeliveryPoint>(new GasDeliveryPoint(deliveryPointNode));}
   }

   //entryPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entryPointNode = xmlNode->FirstChildElement("entryPoint");

   if(entryPointNode){entryPointIsNull_ = false;}
   else{entryPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entryPointNode , address : " << entryPointNode << std::endl;
   #endif
   if(entryPointNode)
   {
      if(entryPointNode->Attribute("href") || entryPointNode->Attribute("id"))
      {
          if(entryPointNode->Attribute("id"))
          {
             entryPointIDRef_ = entryPointNode->Attribute("id");
             entryPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(entryPointNode));
             entryPoint_->setID(entryPointIDRef_);
             IDManager::instance().setID(entryPointIDRef_,entryPoint_);
          }
          else if(entryPointNode->Attribute("href")) { entryPointIDRef_ = entryPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { entryPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(entryPointNode));}
   }

   //withdrawalPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* withdrawalPointNode = xmlNode->FirstChildElement("withdrawalPoint");

   if(withdrawalPointNode){withdrawalPointIsNull_ = false;}
   else{withdrawalPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- withdrawalPointNode , address : " << withdrawalPointNode << std::endl;
   #endif
   if(withdrawalPointNode)
   {
      if(withdrawalPointNode->Attribute("href") || withdrawalPointNode->Attribute("id"))
      {
          if(withdrawalPointNode->Attribute("id"))
          {
             withdrawalPointIDRef_ = withdrawalPointNode->Attribute("id");
             withdrawalPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(withdrawalPointNode));
             withdrawalPoint_->setID(withdrawalPointIDRef_);
             IDManager::instance().setID(withdrawalPointIDRef_,withdrawalPoint_);
          }
          else if(withdrawalPointNode->Attribute("href")) { withdrawalPointIDRef_ = withdrawalPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { withdrawalPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(withdrawalPointNode));}
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
             deliveryType_ = boost::shared_ptr<DeliveryTypeEnum>(new DeliveryTypeEnum(deliveryTypeNode));
             deliveryType_->setID(deliveryTypeIDRef_);
             IDManager::instance().setID(deliveryTypeIDRef_,deliveryType_);
          }
          else if(deliveryTypeNode->Attribute("href")) { deliveryTypeIDRef_ = deliveryTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryType_ = boost::shared_ptr<DeliveryTypeEnum>(new DeliveryTypeEnum(deliveryTypeNode));}
   }

   //buyerHubNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerHubNode = xmlNode->FirstChildElement("buyerHub");

   if(buyerHubNode){buyerHubIsNull_ = false;}
   else{buyerHubIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerHubNode , address : " << buyerHubNode << std::endl;
   #endif
   if(buyerHubNode)
   {
      if(buyerHubNode->Attribute("href") || buyerHubNode->Attribute("id"))
      {
          if(buyerHubNode->Attribute("id"))
          {
             buyerHubIDRef_ = buyerHubNode->Attribute("id");
             buyerHub_ = boost::shared_ptr<CommodityHub>(new CommodityHub(buyerHubNode));
             buyerHub_->setID(buyerHubIDRef_);
             IDManager::instance().setID(buyerHubIDRef_,buyerHub_);
          }
          else if(buyerHubNode->Attribute("href")) { buyerHubIDRef_ = buyerHubNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerHub_ = boost::shared_ptr<CommodityHub>(new CommodityHub(buyerHubNode));}
   }

   //sellerHubNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerHubNode = xmlNode->FirstChildElement("sellerHub");

   if(sellerHubNode){sellerHubIsNull_ = false;}
   else{sellerHubIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerHubNode , address : " << sellerHubNode << std::endl;
   #endif
   if(sellerHubNode)
   {
      if(sellerHubNode->Attribute("href") || sellerHubNode->Attribute("id"))
      {
          if(sellerHubNode->Attribute("id"))
          {
             sellerHubIDRef_ = sellerHubNode->Attribute("id");
             sellerHub_ = boost::shared_ptr<CommodityHub>(new CommodityHub(sellerHubNode));
             sellerHub_->setID(sellerHubIDRef_);
             IDManager::instance().setID(sellerHubIDRef_,sellerHub_);
          }
          else if(sellerHubNode->Attribute("href")) { sellerHubIDRef_ = sellerHubNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerHub_ = boost::shared_ptr<CommodityHub>(new CommodityHub(sellerHubNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<GasDeliveryPoint> GasDelivery::getDeliveryPoint()
{
   if(!this->deliveryPointIsNull_){
        if(deliveryPointIDRef_ != ""){
             return boost::shared_static_cast<GasDeliveryPoint>(IDManager::instance().getID(deliveryPointIDRef_));
        }else{
             return this->deliveryPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasDeliveryPoint>();
   }
}
boost::shared_ptr<CommodityDeliveryPoint> GasDelivery::getEntryPoint()
{
   if(!this->entryPointIsNull_){
        if(entryPointIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(entryPointIDRef_));
        }else{
             return this->entryPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
boost::shared_ptr<CommodityDeliveryPoint> GasDelivery::getWithdrawalPoint()
{
   if(!this->withdrawalPointIsNull_){
        if(withdrawalPointIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(withdrawalPointIDRef_));
        }else{
             return this->withdrawalPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
boost::shared_ptr<DeliveryTypeEnum> GasDelivery::getDeliveryType()
{
   if(!this->deliveryTypeIsNull_){
        if(deliveryTypeIDRef_ != ""){
             return boost::shared_static_cast<DeliveryTypeEnum>(IDManager::instance().getID(deliveryTypeIDRef_));
        }else{
             return this->deliveryType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeliveryTypeEnum>();
   }
}
boost::shared_ptr<CommodityHub> GasDelivery::getBuyerHub()
{
   if(!this->buyerHubIsNull_){
        if(buyerHubIDRef_ != ""){
             return boost::shared_static_cast<CommodityHub>(IDManager::instance().getID(buyerHubIDRef_));
        }else{
             return this->buyerHub_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityHub>();
   }
}
boost::shared_ptr<CommodityHub> GasDelivery::getSellerHub()
{
   if(!this->sellerHubIsNull_){
        if(sellerHubIDRef_ != ""){
             return boost::shared_static_cast<CommodityHub>(IDManager::instance().getID(sellerHubIDRef_));
        }else{
             return this->sellerHub_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityHub>();
   }
}
}

