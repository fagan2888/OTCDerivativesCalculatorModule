// Excel_vanillaFloatingCouponScheduleList.cpp 
#include "Excel_vanillaFloatingCouponScheduleList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_vanillaFloatingCouponScheduleList::Excel_vanillaFloatingCouponScheduleList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateNode = xmlNode->FirstChildElement("fixedRate");

   if(fixedRateNode){fixedRateIsNull_ = false;}
   else{fixedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateNode , address : " << fixedRateNode << std::endl;
   #endif
   if(fixedRateNode)
   {
       fixedRate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(fixedRateNode));
   }

   //dayCounterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCounterNode = xmlNode->FirstChildElement("dayCounter");

   if(dayCounterNode){dayCounterIsNull_ = false;}
   else{dayCounterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCounterNode , address : " << dayCounterNode << std::endl;
   #endif
   if(dayCounterNode)
   {
       dayCounter_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dayCounterNode));
   }

   //excel_vanillaFloatingCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingCouponScheduleNode = xmlNode->FirstChildElement("excel_vanillaFloatingCouponSchedule");

   if(excel_vanillaFloatingCouponScheduleNode){excel_vanillaFloatingCouponScheduleIsNull_ = false;}
   else{excel_vanillaFloatingCouponScheduleIsNull_ = true;}

   if(excel_vanillaFloatingCouponScheduleNode)
   {
      for(excel_vanillaFloatingCouponScheduleNode; excel_vanillaFloatingCouponScheduleNode; excel_vanillaFloatingCouponScheduleNode = excel_vanillaFloatingCouponScheduleNode->NextSiblingElement("excel_vanillaFloatingCouponSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingCouponScheduleNode , address : " << excel_vanillaFloatingCouponScheduleNode << std::endl;
          #endif
          excel_vanillaFloatingCouponSchedule_.push_back(boost::shared_ptr<Excel_vanillaFloatingCouponSchedule>(new Excel_vanillaFloatingCouponSchedule(excel_vanillaFloatingCouponScheduleNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingCouponScheduleNode , address : " << excel_vanillaFloatingCouponScheduleNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingCouponScheduleList::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        return this->fixedRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingCouponScheduleList::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        return this->dayCounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_vanillaFloatingCouponSchedule>> Excel_vanillaFloatingCouponScheduleList::getExcel_vanillaFloatingCouponSchedule()
{
   if(!this->excel_vanillaFloatingCouponScheduleIsNull_){
        return this->excel_vanillaFloatingCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_vanillaFloatingCouponSchedule>>();
   }
}
}

