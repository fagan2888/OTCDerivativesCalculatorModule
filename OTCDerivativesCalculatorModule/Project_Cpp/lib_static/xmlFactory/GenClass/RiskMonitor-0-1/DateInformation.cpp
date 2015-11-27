// DateInformation.cpp 
#include "DateInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateInformation::DateInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //dailyIntervalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dailyIntervalNode = xmlNode->FirstChildElement("dailyInterval");

   if(dailyIntervalNode){dailyIntervalIsNull_ = false;}
   else{dailyIntervalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dailyIntervalNode , address : " << dailyIntervalNode << std::endl;
   #endif
   if(dailyIntervalNode)
   {
       dailyInterval_ = boost::shared_ptr<DailyInterval>(new DailyInterval(dailyIntervalNode));
   }

   //dateListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateListNode = xmlNode->FirstChildElement("dateList");

   if(dateListNode){dateListIsNull_ = false;}
   else{dateListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateListNode , address : " << dateListNode << std::endl;
   #endif
   if(dateListNode)
   {
       dateList_ = boost::shared_ptr<DateList>(new DateList(dateListNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> DateInformation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<DailyInterval> DateInformation::getDailyInterval()
{
   if(!this->dailyIntervalIsNull_){
        return this->dailyInterval_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DailyInterval>();
   }
}
boost::shared_ptr<DateList> DateInformation::getDateList()
{
   if(!this->dateListIsNull_){
        return this->dateList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateList>();
   }
}
}

