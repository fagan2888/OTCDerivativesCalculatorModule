// ElectricityDeliveryUnitFirm.cpp 
#include "ElectricityDeliveryUnitFirm.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityDeliveryUnitFirm::ElectricityDeliveryUnitFirm(TiXmlNode* xmlNode)
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

   //generationAssetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generationAssetNode = xmlNode->FirstChildElement("generationAsset");

   if(generationAssetNode){generationAssetIsNull_ = false;}
   else{generationAssetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generationAssetNode , address : " << generationAssetNode << std::endl;
   #endif
   if(generationAssetNode)
   {
      if(generationAssetNode->Attribute("href") || generationAssetNode->Attribute("id"))
      {
          if(generationAssetNode->Attribute("id"))
          {
             generationAssetIDRef_ = generationAssetNode->Attribute("id");
             generationAsset_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(generationAssetNode));
             generationAsset_->setID(generationAssetIDRef_);
             IDManager::instance().setID(generationAssetIDRef_,generationAsset_);
          }
          else if(generationAssetNode->Attribute("href")) { generationAssetIDRef_ = generationAssetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { generationAsset_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(generationAssetNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> ElectricityDeliveryUnitFirm::getApplicable()
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
boost::shared_ptr<CommodityDeliveryPoint> ElectricityDeliveryUnitFirm::getGenerationAsset()
{
   if(!this->generationAssetIsNull_){
        if(generationAssetIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(generationAssetIDRef_));
        }else{
             return this->generationAsset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
}

