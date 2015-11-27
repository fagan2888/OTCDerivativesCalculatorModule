// CommodityPhysicalQuantity.cpp 
#include "CommodityPhysicalQuantity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityPhysicalQuantity::CommodityPhysicalQuantity(TiXmlNode* xmlNode)
: CommodityPhysicalQuantityBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //physicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalQuantityNode = xmlNode->FirstChildElement("physicalQuantity");

   if(physicalQuantityNode){physicalQuantityIsNull_ = false;}
   else{physicalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityNode , address : " << physicalQuantityNode << std::endl;
   #endif
   if(physicalQuantityNode)
   {
      if(physicalQuantityNode->Attribute("href") || physicalQuantityNode->Attribute("id"))
      {
          if(physicalQuantityNode->Attribute("id"))
          {
             physicalQuantityIDRef_ = physicalQuantityNode->Attribute("id");
             physicalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(physicalQuantityNode));
             physicalQuantity_->setID(physicalQuantityIDRef_);
             IDManager::instance().setID(physicalQuantityIDRef_,physicalQuantity_);
          }
          else if(physicalQuantityNode->Attribute("href")) { physicalQuantityIDRef_ = physicalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(physicalQuantityNode));}
   }

   //physicalQuantityScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalQuantityScheduleNode = xmlNode->FirstChildElement("physicalQuantitySchedule");

   if(physicalQuantityScheduleNode){physicalQuantityScheduleIsNull_ = false;}
   else{physicalQuantityScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityScheduleNode , address : " << physicalQuantityScheduleNode << std::endl;
   #endif
   if(physicalQuantityScheduleNode)
   {
      if(physicalQuantityScheduleNode->Attribute("href") || physicalQuantityScheduleNode->Attribute("id"))
      {
          if(physicalQuantityScheduleNode->Attribute("id"))
          {
             physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("id");
             physicalQuantitySchedule_ = boost::shared_ptr<CommodityPhysicalQuantitySchedule>(new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode));
             physicalQuantitySchedule_->setID(physicalQuantityScheduleIDRef_);
             IDManager::instance().setID(physicalQuantityScheduleIDRef_,physicalQuantitySchedule_);
          }
          else if(physicalQuantityScheduleNode->Attribute("href")) { physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalQuantitySchedule_ = boost::shared_ptr<CommodityPhysicalQuantitySchedule>(new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode));}
   }

   //totalPhysicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* totalPhysicalQuantityNode = xmlNode->FirstChildElement("totalPhysicalQuantity");

   if(totalPhysicalQuantityNode){totalPhysicalQuantityIsNull_ = false;}
   else{totalPhysicalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- totalPhysicalQuantityNode , address : " << totalPhysicalQuantityNode << std::endl;
   #endif
   if(totalPhysicalQuantityNode)
   {
      if(totalPhysicalQuantityNode->Attribute("href") || totalPhysicalQuantityNode->Attribute("id"))
      {
          if(totalPhysicalQuantityNode->Attribute("id"))
          {
             totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode->Attribute("id");
             totalPhysicalQuantity_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(totalPhysicalQuantityNode));
             totalPhysicalQuantity_->setID(totalPhysicalQuantityIDRef_);
             IDManager::instance().setID(totalPhysicalQuantityIDRef_,totalPhysicalQuantity_);
          }
          else if(totalPhysicalQuantityNode->Attribute("href")) { totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { totalPhysicalQuantity_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(totalPhysicalQuantityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityNotionalQuantity> CommodityPhysicalQuantity::getPhysicalQuantity()
{
   if(!this->physicalQuantityIsNull_){
        if(physicalQuantityIDRef_ != ""){
             return boost::shared_static_cast<CommodityNotionalQuantity>(IDManager::instance().getID(physicalQuantityIDRef_));
        }else{
             return this->physicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityNotionalQuantity>();
   }
}
boost::shared_ptr<CommodityPhysicalQuantitySchedule> CommodityPhysicalQuantity::getPhysicalQuantitySchedule()
{
   if(!this->physicalQuantityScheduleIsNull_){
        if(physicalQuantityScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalQuantitySchedule>(IDManager::instance().getID(physicalQuantityScheduleIDRef_));
        }else{
             return this->physicalQuantitySchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalQuantitySchedule>();
   }
}
boost::shared_ptr<UnitQuantity> CommodityPhysicalQuantity::getTotalPhysicalQuantity()
{
   if(!this->totalPhysicalQuantityIsNull_){
        if(totalPhysicalQuantityIDRef_ != ""){
             return boost::shared_static_cast<UnitQuantity>(IDManager::instance().getID(totalPhysicalQuantityIDRef_));
        }else{
             return this->totalPhysicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnitQuantity>();
   }
}
}

