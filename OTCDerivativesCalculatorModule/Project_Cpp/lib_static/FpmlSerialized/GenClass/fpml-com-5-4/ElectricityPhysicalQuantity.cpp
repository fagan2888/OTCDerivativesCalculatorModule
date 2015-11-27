// ElectricityPhysicalQuantity.cpp 
#include "ElectricityPhysicalQuantity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityPhysicalQuantity::ElectricityPhysicalQuantity(TiXmlNode* xmlNode)
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

   if(physicalQuantityNode)
   {
      for(physicalQuantityNode; physicalQuantityNode; physicalQuantityNode = physicalQuantityNode->NextSiblingElement("physicalQuantity")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityNode , address : " << physicalQuantityNode << std::endl;
          #endif
          if(physicalQuantityNode->Attribute("href") || physicalQuantityNode->Attribute("id"))
          {
              if(physicalQuantityNode->Attribute("id"))
              {
                  physicalQuantityIDRef_ = physicalQuantityNode->Attribute("id");
                  physicalQuantity_.push_back(boost::shared_ptr<ElectricityPhysicalDeliveryQuantity>(new ElectricityPhysicalDeliveryQuantity(physicalQuantityNode)));
                  physicalQuantity_.back()->setID(physicalQuantityIDRef_);
                  IDManager::instance().setID(physicalQuantityIDRef_, physicalQuantity_.back());
              }
              else if(physicalQuantityNode->Attribute("href")) { physicalQuantityIDRef_ = physicalQuantityNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { physicalQuantity_.push_back(boost::shared_ptr<ElectricityPhysicalDeliveryQuantity>(new ElectricityPhysicalDeliveryQuantity(physicalQuantityNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityNode , address : " << physicalQuantityNode << std::endl;
       #endif
   }

   //physicalQuantityScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalQuantityScheduleNode = xmlNode->FirstChildElement("physicalQuantitySchedule");

   if(physicalQuantityScheduleNode){physicalQuantityScheduleIsNull_ = false;}
   else{physicalQuantityScheduleIsNull_ = true;}

   if(physicalQuantityScheduleNode)
   {
      for(physicalQuantityScheduleNode; physicalQuantityScheduleNode; physicalQuantityScheduleNode = physicalQuantityScheduleNode->NextSiblingElement("physicalQuantitySchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityScheduleNode , address : " << physicalQuantityScheduleNode << std::endl;
          #endif
          if(physicalQuantityScheduleNode->Attribute("href") || physicalQuantityScheduleNode->Attribute("id"))
          {
              if(physicalQuantityScheduleNode->Attribute("id"))
              {
                  physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("id");
                  physicalQuantitySchedule_.push_back(boost::shared_ptr<ElectricityPhysicalDeliveryQuantitySchedule>(new ElectricityPhysicalDeliveryQuantitySchedule(physicalQuantityScheduleNode)));
                  physicalQuantitySchedule_.back()->setID(physicalQuantityScheduleIDRef_);
                  IDManager::instance().setID(physicalQuantityScheduleIDRef_, physicalQuantitySchedule_.back());
              }
              else if(physicalQuantityScheduleNode->Attribute("href")) { physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { physicalQuantitySchedule_.push_back(boost::shared_ptr<ElectricityPhysicalDeliveryQuantitySchedule>(new ElectricityPhysicalDeliveryQuantitySchedule(physicalQuantityScheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityScheduleNode , address : " << physicalQuantityScheduleNode << std::endl;
       #endif
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
std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantity>> ElectricityPhysicalQuantity::getPhysicalQuantity()
{
   if(!this->physicalQuantityIsNull_){
        if(physicalQuantityIDRef_ != ""){
             return this->physicalQuantity_;
        }else{
             return this->physicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantity>>();
   }
}
std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantitySchedule>> ElectricityPhysicalQuantity::getPhysicalQuantitySchedule()
{
   if(!this->physicalQuantityScheduleIsNull_){
        if(physicalQuantityScheduleIDRef_ != ""){
             return this->physicalQuantitySchedule_;
        }else{
             return this->physicalQuantitySchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantitySchedule>>();
   }
}
boost::shared_ptr<UnitQuantity> ElectricityPhysicalQuantity::getTotalPhysicalQuantity()
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

