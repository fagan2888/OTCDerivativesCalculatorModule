// ElectricityDeliveryType.cpp 
#include "ElectricityDeliveryType.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityDeliveryType::ElectricityDeliveryType(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //firmNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firmNode = xmlNode->FirstChildElement("firm");

   if(firmNode){firmIsNull_ = false;}
   else{firmIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firmNode , address : " << firmNode << std::endl;
   #endif
   if(firmNode)
   {
      if(firmNode->Attribute("href") || firmNode->Attribute("id"))
      {
          if(firmNode->Attribute("id"))
          {
             firmIDRef_ = firmNode->Attribute("id");
             firm_ = boost::shared_ptr<ElectricityDeliveryFirm>(new ElectricityDeliveryFirm(firmNode));
             firm_->setID(firmIDRef_);
             IDManager::instance().setID(firmIDRef_,firm_);
          }
          else if(firmNode->Attribute("href")) { firmIDRef_ = firmNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firm_ = boost::shared_ptr<ElectricityDeliveryFirm>(new ElectricityDeliveryFirm(firmNode));}
   }

   //nonFirmNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonFirmNode = xmlNode->FirstChildElement("nonFirm");

   if(nonFirmNode){nonFirmIsNull_ = false;}
   else{nonFirmIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonFirmNode , address : " << nonFirmNode << std::endl;
   #endif
   if(nonFirmNode)
   {
      if(nonFirmNode->Attribute("href") || nonFirmNode->Attribute("id"))
      {
          if(nonFirmNode->Attribute("id"))
          {
             nonFirmIDRef_ = nonFirmNode->Attribute("id");
             nonFirm_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(nonFirmNode));
             nonFirm_->setID(nonFirmIDRef_);
             IDManager::instance().setID(nonFirmIDRef_,nonFirm_);
          }
          else if(nonFirmNode->Attribute("href")) { nonFirmIDRef_ = nonFirmNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonFirm_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(nonFirmNode));}
   }

   //systemFirmNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* systemFirmNode = xmlNode->FirstChildElement("systemFirm");

   if(systemFirmNode){systemFirmIsNull_ = false;}
   else{systemFirmIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- systemFirmNode , address : " << systemFirmNode << std::endl;
   #endif
   if(systemFirmNode)
   {
      if(systemFirmNode->Attribute("href") || systemFirmNode->Attribute("id"))
      {
          if(systemFirmNode->Attribute("id"))
          {
             systemFirmIDRef_ = systemFirmNode->Attribute("id");
             systemFirm_ = boost::shared_ptr<ElectricityDeliverySystemFirm>(new ElectricityDeliverySystemFirm(systemFirmNode));
             systemFirm_->setID(systemFirmIDRef_);
             IDManager::instance().setID(systemFirmIDRef_,systemFirm_);
          }
          else if(systemFirmNode->Attribute("href")) { systemFirmIDRef_ = systemFirmNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { systemFirm_ = boost::shared_ptr<ElectricityDeliverySystemFirm>(new ElectricityDeliverySystemFirm(systemFirmNode));}
   }

   //unitFirmNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unitFirmNode = xmlNode->FirstChildElement("unitFirm");

   if(unitFirmNode){unitFirmIsNull_ = false;}
   else{unitFirmIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitFirmNode , address : " << unitFirmNode << std::endl;
   #endif
   if(unitFirmNode)
   {
      if(unitFirmNode->Attribute("href") || unitFirmNode->Attribute("id"))
      {
          if(unitFirmNode->Attribute("id"))
          {
             unitFirmIDRef_ = unitFirmNode->Attribute("id");
             unitFirm_ = boost::shared_ptr<ElectricityDeliveryUnitFirm>(new ElectricityDeliveryUnitFirm(unitFirmNode));
             unitFirm_->setID(unitFirmIDRef_);
             IDManager::instance().setID(unitFirmIDRef_,unitFirm_);
          }
          else if(unitFirmNode->Attribute("href")) { unitFirmIDRef_ = unitFirmNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unitFirm_ = boost::shared_ptr<ElectricityDeliveryUnitFirm>(new ElectricityDeliveryUnitFirm(unitFirmNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ElectricityDeliveryFirm> ElectricityDeliveryType::getFirm()
{
   if(!this->firmIsNull_){
        if(firmIDRef_ != ""){
             return boost::shared_static_cast<ElectricityDeliveryFirm>(IDManager::instance().getID(firmIDRef_));
        }else{
             return this->firm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityDeliveryFirm>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ElectricityDeliveryType::getNonFirm()
{
   if(!this->nonFirmIsNull_){
        if(nonFirmIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(nonFirmIDRef_));
        }else{
             return this->nonFirm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<ElectricityDeliverySystemFirm> ElectricityDeliveryType::getSystemFirm()
{
   if(!this->systemFirmIsNull_){
        if(systemFirmIDRef_ != ""){
             return boost::shared_static_cast<ElectricityDeliverySystemFirm>(IDManager::instance().getID(systemFirmIDRef_));
        }else{
             return this->systemFirm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityDeliverySystemFirm>();
   }
}
boost::shared_ptr<ElectricityDeliveryUnitFirm> ElectricityDeliveryType::getUnitFirm()
{
   if(!this->unitFirmIsNull_){
        if(unitFirmIDRef_ != ""){
             return boost::shared_static_cast<ElectricityDeliveryUnitFirm>(IDManager::instance().getID(unitFirmIDRef_));
        }else{
             return this->unitFirm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityDeliveryUnitFirm>();
   }
}
}

