// Excel_general.cpp 
#include "Excel_general.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_general::Excel_general(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_issueInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_issueInfoNode = xmlNode->FirstChildElement("excel_issueInfo");

   if(excel_issueInfoNode){excel_issueInfoIsNull_ = false;}
   else{excel_issueInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_issueInfoNode , address : " << excel_issueInfoNode << std::endl;
   #endif
   if(excel_issueInfoNode)
   {
       excel_issueInfo_ = boost::shared_ptr<Excel_issueInfo>(new Excel_issueInfo(excel_issueInfoNode));
   }

   //generalScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generalScheduleNode = xmlNode->FirstChildElement("generalSchedule");

   if(generalScheduleNode){generalScheduleIsNull_ = false;}
   else{generalScheduleIsNull_ = true;}

   if(generalScheduleNode)
   {
      for(generalScheduleNode; generalScheduleNode; generalScheduleNode = generalScheduleNode->NextSiblingElement("generalSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalScheduleNode , address : " << generalScheduleNode << std::endl;
          #endif
          generalSchedule_.push_back(boost::shared_ptr<GeneralSchedule>(new GeneralSchedule(generalScheduleNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalScheduleNode , address : " << generalScheduleNode << std::endl;
       #endif
   }

   //generalTerminationEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generalTerminationEventNode = xmlNode->FirstChildElement("generalTerminationEvent");

   if(generalTerminationEventNode){generalTerminationEventIsNull_ = false;}
   else{generalTerminationEventIsNull_ = true;}

   if(generalTerminationEventNode)
   {
      for(generalTerminationEventNode; generalTerminationEventNode; generalTerminationEventNode = generalTerminationEventNode->NextSiblingElement("generalTerminationEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalTerminationEventNode , address : " << generalTerminationEventNode << std::endl;
          #endif
          generalTerminationEvent_.push_back(boost::shared_ptr<GeneralTerminationEvent>(new GeneralTerminationEvent(generalTerminationEventNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalTerminationEventNode , address : " << generalTerminationEventNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_general::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
std::vector<boost::shared_ptr<GeneralSchedule>> Excel_general::getGeneralSchedule()
{
   if(!this->generalScheduleIsNull_){
        return this->generalSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<GeneralSchedule>>();
   }
}
std::vector<boost::shared_ptr<GeneralTerminationEvent>> Excel_general::getGeneralTerminationEvent()
{
   if(!this->generalTerminationEventIsNull_){
        return this->generalTerminationEvent_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<GeneralTerminationEvent>>();
   }
}
}

