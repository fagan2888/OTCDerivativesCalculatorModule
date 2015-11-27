// GasDeliveryPeriods.cpp 
#include "GasDeliveryPeriods.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GasDeliveryPeriods::GasDeliveryPeriods(TiXmlNode* xmlNode)
: CommodityDeliveryPeriods(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //supplyStartTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* supplyStartTimeNode = xmlNode->FirstChildElement("supplyStartTime");

   if(supplyStartTimeNode){supplyStartTimeIsNull_ = false;}
   else{supplyStartTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- supplyStartTimeNode , address : " << supplyStartTimeNode << std::endl;
   #endif
   if(supplyStartTimeNode)
   {
      if(supplyStartTimeNode->Attribute("href") || supplyStartTimeNode->Attribute("id"))
      {
          if(supplyStartTimeNode->Attribute("id"))
          {
             supplyStartTimeIDRef_ = supplyStartTimeNode->Attribute("id");
             supplyStartTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(supplyStartTimeNode));
             supplyStartTime_->setID(supplyStartTimeIDRef_);
             IDManager::instance().setID(supplyStartTimeIDRef_,supplyStartTime_);
          }
          else if(supplyStartTimeNode->Attribute("href")) { supplyStartTimeIDRef_ = supplyStartTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { supplyStartTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(supplyStartTimeNode));}
   }

   //supplyEndTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* supplyEndTimeNode = xmlNode->FirstChildElement("supplyEndTime");

   if(supplyEndTimeNode){supplyEndTimeIsNull_ = false;}
   else{supplyEndTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- supplyEndTimeNode , address : " << supplyEndTimeNode << std::endl;
   #endif
   if(supplyEndTimeNode)
   {
      if(supplyEndTimeNode->Attribute("href") || supplyEndTimeNode->Attribute("id"))
      {
          if(supplyEndTimeNode->Attribute("id"))
          {
             supplyEndTimeIDRef_ = supplyEndTimeNode->Attribute("id");
             supplyEndTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(supplyEndTimeNode));
             supplyEndTime_->setID(supplyEndTimeIDRef_);
             IDManager::instance().setID(supplyEndTimeIDRef_,supplyEndTime_);
          }
          else if(supplyEndTimeNode->Attribute("href")) { supplyEndTimeIDRef_ = supplyEndTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { supplyEndTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(supplyEndTimeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PrevailingTime> GasDeliveryPeriods::getSupplyStartTime()
{
   if(!this->supplyStartTimeIsNull_){
        if(supplyStartTimeIDRef_ != ""){
             return boost::shared_static_cast<PrevailingTime>(IDManager::instance().getID(supplyStartTimeIDRef_));
        }else{
             return this->supplyStartTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrevailingTime>();
   }
}
boost::shared_ptr<PrevailingTime> GasDeliveryPeriods::getSupplyEndTime()
{
   if(!this->supplyEndTimeIsNull_){
        if(supplyEndTimeIDRef_ != ""){
             return boost::shared_static_cast<PrevailingTime>(IDManager::instance().getID(supplyEndTimeIDRef_));
        }else{
             return this->supplyEndTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrevailingTime>();
   }
}
}

