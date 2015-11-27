// ScheduledDates.cpp 
#include "ScheduledDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ScheduledDates::ScheduledDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //scheduledDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* scheduledDateNode = xmlNode->FirstChildElement("scheduledDate");

   if(scheduledDateNode){scheduledDateIsNull_ = false;}
   else{scheduledDateIsNull_ = true;}

   if(scheduledDateNode)
   {
      for(scheduledDateNode; scheduledDateNode; scheduledDateNode = scheduledDateNode->NextSiblingElement("scheduledDate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduledDateNode , address : " << scheduledDateNode << std::endl;
          #endif
          if(scheduledDateNode->Attribute("href") || scheduledDateNode->Attribute("id"))
          {
              if(scheduledDateNode->Attribute("id"))
              {
                  scheduledDateIDRef_ = scheduledDateNode->Attribute("id");
                  scheduledDate_.push_back(boost::shared_ptr<ScheduledDate>(new ScheduledDate(scheduledDateNode)));
                  scheduledDate_.back()->setID(scheduledDateIDRef_);
                  IDManager::instance().setID(scheduledDateIDRef_, scheduledDate_.back());
              }
              else if(scheduledDateNode->Attribute("href")) { scheduledDateIDRef_ = scheduledDateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { scheduledDate_.push_back(boost::shared_ptr<ScheduledDate>(new ScheduledDate(scheduledDateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduledDateNode , address : " << scheduledDateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ScheduledDate>> ScheduledDates::getScheduledDate()
{
   if(!this->scheduledDateIsNull_){
        if(scheduledDateIDRef_ != ""){
             return this->scheduledDate_;
        }else{
             return this->scheduledDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ScheduledDate>>();
   }
}
}

