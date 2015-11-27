// Excel_couponScheduleList.cpp 
#include "Excel_couponScheduleList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_couponScheduleList::Excel_couponScheduleList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_couponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_couponScheduleNode = xmlNode->FirstChildElement("excel_couponSchedule");

   if(excel_couponScheduleNode){excel_couponScheduleIsNull_ = false;}
   else{excel_couponScheduleIsNull_ = true;}

   if(excel_couponScheduleNode)
   {
      for(excel_couponScheduleNode; excel_couponScheduleNode; excel_couponScheduleNode = excel_couponScheduleNode->NextSiblingElement("excel_couponSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_couponScheduleNode , address : " << excel_couponScheduleNode << std::endl;
          #endif
          excel_couponSchedule_.push_back(boost::shared_ptr<Excel_couponSchedule>(new Excel_couponSchedule(excel_couponScheduleNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_couponScheduleNode , address : " << excel_couponScheduleNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_couponSchedule>> Excel_couponScheduleList::getExcel_couponSchedule()
{
   if(!this->excel_couponScheduleIsNull_){
        return this->excel_couponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_couponSchedule>>();
   }
}
}

