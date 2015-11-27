// MetalDelivery.cpp 
#include "MetalDelivery.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MetalDelivery::MetalDelivery(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //totalQuantityToleranceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* totalQuantityToleranceNode = xmlNode->FirstChildElement("totalQuantityTolerance");

   if(totalQuantityToleranceNode){totalQuantityToleranceIsNull_ = false;}
   else{totalQuantityToleranceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- totalQuantityToleranceNode , address : " << totalQuantityToleranceNode << std::endl;
   #endif
   if(totalQuantityToleranceNode)
   {
      if(totalQuantityToleranceNode->Attribute("href") || totalQuantityToleranceNode->Attribute("id"))
      {
          if(totalQuantityToleranceNode->Attribute("id"))
          {
             totalQuantityToleranceIDRef_ = totalQuantityToleranceNode->Attribute("id");
             totalQuantityTolerance_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(totalQuantityToleranceNode));
             totalQuantityTolerance_->setID(totalQuantityToleranceIDRef_);
             IDManager::instance().setID(totalQuantityToleranceIDRef_,totalQuantityTolerance_);
          }
          else if(totalQuantityToleranceNode->Attribute("href")) { totalQuantityToleranceIDRef_ = totalQuantityToleranceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { totalQuantityTolerance_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(totalQuantityToleranceNode));}
   }

   //periodQuantityToleranceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* periodQuantityToleranceNode = xmlNode->FirstChildElement("periodQuantityTolerance");

   if(periodQuantityToleranceNode){periodQuantityToleranceIsNull_ = false;}
   else{periodQuantityToleranceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- periodQuantityToleranceNode , address : " << periodQuantityToleranceNode << std::endl;
   #endif
   if(periodQuantityToleranceNode)
   {
      if(periodQuantityToleranceNode->Attribute("href") || periodQuantityToleranceNode->Attribute("id"))
      {
          if(periodQuantityToleranceNode->Attribute("id"))
          {
             periodQuantityToleranceIDRef_ = periodQuantityToleranceNode->Attribute("id");
             periodQuantityTolerance_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(periodQuantityToleranceNode));
             periodQuantityTolerance_->setID(periodQuantityToleranceIDRef_);
             IDManager::instance().setID(periodQuantityToleranceIDRef_,periodQuantityTolerance_);
          }
          else if(periodQuantityToleranceNode->Attribute("href")) { periodQuantityToleranceIDRef_ = periodQuantityToleranceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { periodQuantityTolerance_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(periodQuantityToleranceNode));}
   }

   //titleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* titleNode = xmlNode->FirstChildElement("title");

   if(titleNode){titleIsNull_ = false;}
   else{titleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- titleNode , address : " << titleNode << std::endl;
   #endif
   if(titleNode)
   {
      if(titleNode->Attribute("href") || titleNode->Attribute("id"))
      {
          if(titleNode->Attribute("id"))
          {
             titleIDRef_ = titleNode->Attribute("id");
             title_ = boost::shared_ptr<MetalTitleEnum>(new MetalTitleEnum(titleNode));
             title_->setID(titleIDRef_);
             IDManager::instance().setID(titleIDRef_,title_);
          }
          else if(titleNode->Attribute("href")) { titleIDRef_ = titleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { title_ = boost::shared_ptr<MetalTitleEnum>(new MetalTitleEnum(titleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityDeliveryPoint> MetalDelivery::getDeliveryLocation()
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
boost::shared_ptr<CommodityDeliveryRisk> MetalDelivery::getRisk()
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
boost::shared_ptr<XsdTypeDecimal> MetalDelivery::getTotalQuantityTolerance()
{
   if(!this->totalQuantityToleranceIsNull_){
        if(totalQuantityToleranceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(totalQuantityToleranceIDRef_));
        }else{
             return this->totalQuantityTolerance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> MetalDelivery::getPeriodQuantityTolerance()
{
   if(!this->periodQuantityToleranceIsNull_){
        if(periodQuantityToleranceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(periodQuantityToleranceIDRef_));
        }else{
             return this->periodQuantityTolerance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<MetalTitleEnum> MetalDelivery::getTitle()
{
   if(!this->titleIsNull_){
        if(titleIDRef_ != ""){
             return boost::shared_static_cast<MetalTitleEnum>(IDManager::instance().getID(titleIDRef_));
        }else{
             return this->title_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MetalTitleEnum>();
   }
}
}

