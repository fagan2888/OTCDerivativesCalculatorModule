// CoalProductSpecifications.cpp 
#include "CoalProductSpecifications.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CoalProductSpecifications::CoalProductSpecifications(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //standardQualityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardQualityNode = xmlNode->FirstChildElement("standardQuality");

   if(standardQualityNode){standardQualityIsNull_ = false;}
   else{standardQualityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardQualityNode , address : " << standardQualityNode << std::endl;
   #endif
   if(standardQualityNode)
   {
      if(standardQualityNode->Attribute("href") || standardQualityNode->Attribute("id"))
      {
          if(standardQualityNode->Attribute("id"))
          {
             standardQualityIDRef_ = standardQualityNode->Attribute("id");
             standardQuality_ = boost::shared_ptr<CoalStandardQuality>(new CoalStandardQuality(standardQualityNode));
             standardQuality_->setID(standardQualityIDRef_);
             IDManager::instance().setID(standardQualityIDRef_,standardQuality_);
          }
          else if(standardQualityNode->Attribute("href")) { standardQualityIDRef_ = standardQualityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { standardQuality_ = boost::shared_ptr<CoalStandardQuality>(new CoalStandardQuality(standardQualityNode));}
   }

   //standardQualityScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardQualityScheduleNode = xmlNode->FirstChildElement("standardQualitySchedule");

   if(standardQualityScheduleNode){standardQualityScheduleIsNull_ = false;}
   else{standardQualityScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardQualityScheduleNode , address : " << standardQualityScheduleNode << std::endl;
   #endif
   if(standardQualityScheduleNode)
   {
      if(standardQualityScheduleNode->Attribute("href") || standardQualityScheduleNode->Attribute("id"))
      {
          if(standardQualityScheduleNode->Attribute("id"))
          {
             standardQualityScheduleIDRef_ = standardQualityScheduleNode->Attribute("id");
             standardQualitySchedule_ = boost::shared_ptr<CoalStandardQualitySchedule>(new CoalStandardQualitySchedule(standardQualityScheduleNode));
             standardQualitySchedule_->setID(standardQualityScheduleIDRef_);
             IDManager::instance().setID(standardQualityScheduleIDRef_,standardQualitySchedule_);
          }
          else if(standardQualityScheduleNode->Attribute("href")) { standardQualityScheduleIDRef_ = standardQualityScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { standardQualitySchedule_ = boost::shared_ptr<CoalStandardQualitySchedule>(new CoalStandardQualitySchedule(standardQualityScheduleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CoalStandardQuality> CoalProductSpecifications::getStandardQuality()
{
   if(!this->standardQualityIsNull_){
        if(standardQualityIDRef_ != ""){
             return boost::shared_static_cast<CoalStandardQuality>(IDManager::instance().getID(standardQualityIDRef_));
        }else{
             return this->standardQuality_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalStandardQuality>();
   }
}
boost::shared_ptr<CoalStandardQualitySchedule> CoalProductSpecifications::getStandardQualitySchedule()
{
   if(!this->standardQualityScheduleIsNull_){
        if(standardQualityScheduleIDRef_ != ""){
             return boost::shared_static_cast<CoalStandardQualitySchedule>(IDManager::instance().getID(standardQualityScheduleIDRef_));
        }else{
             return this->standardQualitySchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalStandardQualitySchedule>();
   }
}
}

