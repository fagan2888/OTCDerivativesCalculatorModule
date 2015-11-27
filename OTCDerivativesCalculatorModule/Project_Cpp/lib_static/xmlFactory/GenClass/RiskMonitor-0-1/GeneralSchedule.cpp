// GeneralSchedule.cpp 
#include "GeneralSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GeneralSchedule::GeneralSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateNode = xmlNode->FirstChildElement("eventDate");

   if(eventDateNode){eventDateIsNull_ = false;}
   else{eventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateNode , address : " << eventDateNode << std::endl;
   #endif
   if(eventDateNode)
   {
       eventDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(eventDateNode));
   }

   //detailScheduleTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* detailScheduleTypeNode = xmlNode->FirstChildElement("detailScheduleType");

   if(detailScheduleTypeNode){detailScheduleTypeIsNull_ = false;}
   else{detailScheduleTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- detailScheduleTypeNode , address : " << detailScheduleTypeNode << std::endl;
   #endif
   if(detailScheduleTypeNode)
   {
       detailScheduleType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(detailScheduleTypeNode));
   }

   //generalScheduleDeatilNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generalScheduleDeatilNode = xmlNode->FirstChildElement("generalScheduleDeatil");

   if(generalScheduleDeatilNode){generalScheduleDeatilIsNull_ = false;}
   else{generalScheduleDeatilIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalScheduleDeatilNode , address : " << generalScheduleDeatilNode << std::endl;
   #endif
   if(generalScheduleDeatilNode)
   {
       generalScheduleDeatil_ = boost::shared_ptr<GeneralScheduleDeatil>(new GeneralScheduleDeatil(generalScheduleDeatilNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> GeneralSchedule::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> GeneralSchedule::getDetailScheduleType()
{
   if(!this->detailScheduleTypeIsNull_){
        return this->detailScheduleType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<GeneralScheduleDeatil> GeneralSchedule::getGeneralScheduleDeatil()
{
   if(!this->generalScheduleDeatilIsNull_){
        return this->generalScheduleDeatil_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GeneralScheduleDeatil>();
   }
}
}

