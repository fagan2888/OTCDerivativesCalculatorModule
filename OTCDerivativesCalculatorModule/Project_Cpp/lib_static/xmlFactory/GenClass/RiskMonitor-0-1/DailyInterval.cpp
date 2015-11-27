// DailyInterval.cpp 
#include "DailyInterval.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DailyInterval::DailyInterval(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //observationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationStartDateNode = xmlNode->FirstChildElement("observationStartDate");

   if(observationStartDateNode){observationStartDateIsNull_ = false;}
   else{observationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationStartDateNode , address : " << observationStartDateNode << std::endl;
   #endif
   if(observationStartDateNode)
   {
       observationStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(observationStartDateNode));
   }

   //observationEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationEndDateNode = xmlNode->FirstChildElement("observationEndDate");

   if(observationEndDateNode){observationEndDateIsNull_ = false;}
   else{observationEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationEndDateNode , address : " << observationEndDateNode << std::endl;
   #endif
   if(observationEndDateNode)
   {
       observationEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(observationEndDateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> DailyInterval::getObservationStartDate()
{
   if(!this->observationStartDateIsNull_){
        return this->observationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> DailyInterval::getObservationEndDate()
{
   if(!this->observationEndDateIsNull_){
        return this->observationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

