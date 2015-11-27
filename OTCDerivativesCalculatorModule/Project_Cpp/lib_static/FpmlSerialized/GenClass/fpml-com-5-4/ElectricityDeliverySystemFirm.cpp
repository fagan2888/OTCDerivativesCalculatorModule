// ElectricityDeliverySystemFirm.cpp 
#include "ElectricityDeliverySystemFirm.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityDeliverySystemFirm::ElectricityDeliverySystemFirm(TiXmlNode* xmlNode)
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

   //systemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* systemNode = xmlNode->FirstChildElement("system");

   if(systemNode){systemIsNull_ = false;}
   else{systemIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- systemNode , address : " << systemNode << std::endl;
   #endif
   if(systemNode)
   {
      if(systemNode->Attribute("href") || systemNode->Attribute("id"))
      {
          if(systemNode->Attribute("id"))
          {
             systemIDRef_ = systemNode->Attribute("id");
             system_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(systemNode));
             system_->setID(systemIDRef_);
             IDManager::instance().setID(systemIDRef_,system_);
          }
          else if(systemNode->Attribute("href")) { systemIDRef_ = systemNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { system_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(systemNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> ElectricityDeliverySystemFirm::getApplicable()
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
boost::shared_ptr<CommodityDeliveryPoint> ElectricityDeliverySystemFirm::getSystem()
{
   if(!this->systemIsNull_){
        if(systemIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(systemIDRef_));
        }else{
             return this->system_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
}

