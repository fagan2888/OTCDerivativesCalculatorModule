// GeneralScheduleInfo.cpp 
#include "GeneralScheduleInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GeneralScheduleInfo::GeneralScheduleInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<GeneralSchedule>> GeneralScheduleInfo::getGeneralSchedule()
{
   if(!this->generalScheduleIsNull_){
        return this->generalSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<GeneralSchedule>>();
   }
}
}

