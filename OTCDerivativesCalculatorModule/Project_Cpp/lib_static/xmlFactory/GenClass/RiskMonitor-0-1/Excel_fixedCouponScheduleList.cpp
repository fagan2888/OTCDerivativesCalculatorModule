// Excel_fixedCouponScheduleList.cpp 
#include "Excel_fixedCouponScheduleList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_fixedCouponScheduleList::Excel_fixedCouponScheduleList(TiXmlNode* xmlNode)
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
boost::shared_ptr<XsdTypeToken> Excel_fixedCouponScheduleList::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        return this->fixedRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_fixedCouponScheduleList::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        return this->dayCounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_couponSchedule>> Excel_fixedCouponScheduleList::getExcel_couponSchedule()
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

