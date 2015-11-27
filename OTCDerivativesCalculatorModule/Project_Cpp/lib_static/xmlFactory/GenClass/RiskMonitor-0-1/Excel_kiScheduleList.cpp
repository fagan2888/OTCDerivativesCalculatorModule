// Excel_kiScheduleList.cpp 
#include "Excel_kiScheduleList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_kiScheduleList::Excel_kiScheduleList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_scheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_scheduleNode = xmlNode->FirstChildElement("excel_schedule");

   if(excel_scheduleNode){excel_scheduleIsNull_ = false;}
   else{excel_scheduleIsNull_ = true;}

   if(excel_scheduleNode)
   {
      for(excel_scheduleNode; excel_scheduleNode; excel_scheduleNode = excel_scheduleNode->NextSiblingElement("excel_schedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_scheduleNode , address : " << excel_scheduleNode << std::endl;
          #endif
          excel_schedule_.push_back(boost::shared_ptr<Excel_schedule>(new Excel_schedule(excel_scheduleNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_scheduleNode , address : " << excel_scheduleNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_schedule>> Excel_kiScheduleList::getExcel_schedule()
{
   if(!this->excel_scheduleIsNull_){
        return this->excel_schedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_schedule>>();
   }
}
}

