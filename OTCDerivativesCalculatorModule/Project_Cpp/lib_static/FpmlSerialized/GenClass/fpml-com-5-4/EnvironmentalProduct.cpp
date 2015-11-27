// EnvironmentalProduct.cpp 
#include "EnvironmentalProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EnvironmentalProduct::EnvironmentalProduct(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //productTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productTypeNode = xmlNode->FirstChildElement("productType");

   if(productTypeNode){productTypeIsNull_ = false;}
   else{productTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productTypeNode , address : " << productTypeNode << std::endl;
   #endif
   if(productTypeNode)
   {
      if(productTypeNode->Attribute("href") || productTypeNode->Attribute("id"))
      {
          if(productTypeNode->Attribute("id"))
          {
             productTypeIDRef_ = productTypeNode->Attribute("id");
             productType_ = boost::shared_ptr<EnvironmentalProductTypeEnum>(new EnvironmentalProductTypeEnum(productTypeNode));
             productType_->setID(productTypeIDRef_);
             IDManager::instance().setID(productTypeIDRef_,productType_);
          }
          else if(productTypeNode->Attribute("href")) { productTypeIDRef_ = productTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { productType_ = boost::shared_ptr<EnvironmentalProductTypeEnum>(new EnvironmentalProductTypeEnum(productTypeNode));}
   }

   //compliancePeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compliancePeriodNode = xmlNode->FirstChildElement("compliancePeriod");

   if(compliancePeriodNode){compliancePeriodIsNull_ = false;}
   else{compliancePeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compliancePeriodNode , address : " << compliancePeriodNode << std::endl;
   #endif
   if(compliancePeriodNode)
   {
      if(compliancePeriodNode->Attribute("href") || compliancePeriodNode->Attribute("id"))
      {
          if(compliancePeriodNode->Attribute("id"))
          {
             compliancePeriodIDRef_ = compliancePeriodNode->Attribute("id");
             compliancePeriod_ = boost::shared_ptr<EnvironmentalProductComplaincePeriod>(new EnvironmentalProductComplaincePeriod(compliancePeriodNode));
             compliancePeriod_->setID(compliancePeriodIDRef_);
             IDManager::instance().setID(compliancePeriodIDRef_,compliancePeriod_);
          }
          else if(compliancePeriodNode->Attribute("href")) { compliancePeriodIDRef_ = compliancePeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compliancePeriod_ = boost::shared_ptr<EnvironmentalProductComplaincePeriod>(new EnvironmentalProductComplaincePeriod(compliancePeriodNode));}
   }

   //vintageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vintageNode = xmlNode->FirstChildElement("vintage");

   if(vintageNode){vintageIsNull_ = false;}
   else{vintageIsNull_ = true;}

   if(vintageNode)
   {
      for(vintageNode; vintageNode; vintageNode = vintageNode->NextSiblingElement("vintage")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vintageNode , address : " << vintageNode << std::endl;
          #endif
          if(vintageNode->Attribute("href") || vintageNode->Attribute("id"))
          {
              if(vintageNode->Attribute("id"))
              {
                  vintageIDRef_ = vintageNode->Attribute("id");
                  vintage_.push_back(boost::shared_ptr<XsdTypeGYear>(new XsdTypeGYear(vintageNode)));
                  vintage_.back()->setID(vintageIDRef_);
                  IDManager::instance().setID(vintageIDRef_, vintage_.back());
              }
              else if(vintageNode->Attribute("href")) { vintageIDRef_ = vintageNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { vintage_.push_back(boost::shared_ptr<XsdTypeGYear>(new XsdTypeGYear(vintageNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vintageNode , address : " << vintageNode << std::endl;
       #endif
   }

   //applicableLawNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* applicableLawNode = xmlNode->FirstChildElement("applicableLaw");

   if(applicableLawNode){applicableLawIsNull_ = false;}
   else{applicableLawIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableLawNode , address : " << applicableLawNode << std::endl;
   #endif
   if(applicableLawNode)
   {
      if(applicableLawNode->Attribute("href") || applicableLawNode->Attribute("id"))
      {
          if(applicableLawNode->Attribute("id"))
          {
             applicableLawIDRef_ = applicableLawNode->Attribute("id");
             applicableLaw_ = boost::shared_ptr<EnvironmentalProductApplicableLaw>(new EnvironmentalProductApplicableLaw(applicableLawNode));
             applicableLaw_->setID(applicableLawIDRef_);
             IDManager::instance().setID(applicableLawIDRef_,applicableLaw_);
          }
          else if(applicableLawNode->Attribute("href")) { applicableLawIDRef_ = applicableLawNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { applicableLaw_ = boost::shared_ptr<EnvironmentalProductApplicableLaw>(new EnvironmentalProductApplicableLaw(applicableLawNode));}
   }

   //trackingSystemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* trackingSystemNode = xmlNode->FirstChildElement("trackingSystem");

   if(trackingSystemNode){trackingSystemIsNull_ = false;}
   else{trackingSystemIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- trackingSystemNode , address : " << trackingSystemNode << std::endl;
   #endif
   if(trackingSystemNode)
   {
      if(trackingSystemNode->Attribute("href") || trackingSystemNode->Attribute("id"))
      {
          if(trackingSystemNode->Attribute("id"))
          {
             trackingSystemIDRef_ = trackingSystemNode->Attribute("id");
             trackingSystem_ = boost::shared_ptr<EnvironmentalTrackingSystem>(new EnvironmentalTrackingSystem(trackingSystemNode));
             trackingSystem_->setID(trackingSystemIDRef_);
             IDManager::instance().setID(trackingSystemIDRef_,trackingSystem_);
          }
          else if(trackingSystemNode->Attribute("href")) { trackingSystemIDRef_ = trackingSystemNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { trackingSystem_ = boost::shared_ptr<EnvironmentalTrackingSystem>(new EnvironmentalTrackingSystem(trackingSystemNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EnvironmentalProductTypeEnum> EnvironmentalProduct::getProductType()
{
   if(!this->productTypeIsNull_){
        if(productTypeIDRef_ != ""){
             return boost::shared_static_cast<EnvironmentalProductTypeEnum>(IDManager::instance().getID(productTypeIDRef_));
        }else{
             return this->productType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EnvironmentalProductTypeEnum>();
   }
}
boost::shared_ptr<EnvironmentalProductComplaincePeriod> EnvironmentalProduct::getCompliancePeriod()
{
   if(!this->compliancePeriodIsNull_){
        if(compliancePeriodIDRef_ != ""){
             return boost::shared_static_cast<EnvironmentalProductComplaincePeriod>(IDManager::instance().getID(compliancePeriodIDRef_));
        }else{
             return this->compliancePeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EnvironmentalProductComplaincePeriod>();
   }
}
std::vector<boost::shared_ptr<XsdTypeGYear>> EnvironmentalProduct::getVintage()
{
   if(!this->vintageIsNull_){
        if(vintageIDRef_ != ""){
             return this->vintage_;
        }else{
             return this->vintage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeGYear>>();
   }
}
boost::shared_ptr<EnvironmentalProductApplicableLaw> EnvironmentalProduct::getApplicableLaw()
{
   if(!this->applicableLawIsNull_){
        if(applicableLawIDRef_ != ""){
             return boost::shared_static_cast<EnvironmentalProductApplicableLaw>(IDManager::instance().getID(applicableLawIDRef_));
        }else{
             return this->applicableLaw_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EnvironmentalProductApplicableLaw>();
   }
}
boost::shared_ptr<EnvironmentalTrackingSystem> EnvironmentalProduct::getTrackingSystem()
{
   if(!this->trackingSystemIsNull_){
        if(trackingSystemIDRef_ != ""){
             return boost::shared_static_cast<EnvironmentalTrackingSystem>(IDManager::instance().getID(trackingSystemIDRef_));
        }else{
             return this->trackingSystem_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EnvironmentalTrackingSystem>();
   }
}
}

