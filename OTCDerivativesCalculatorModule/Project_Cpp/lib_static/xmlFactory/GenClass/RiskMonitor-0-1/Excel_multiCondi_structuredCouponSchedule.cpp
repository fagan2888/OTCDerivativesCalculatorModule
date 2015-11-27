// Excel_multiCondi_structuredCouponSchedule.cpp 
#include "Excel_multiCondi_structuredCouponSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_multiCondi_structuredCouponSchedule::Excel_multiCondi_structuredCouponSchedule(TiXmlNode* xmlNode)
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

   //payoffDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateNode = xmlNode->FirstChildElement("payoffDate");

   if(payoffDateNode){payoffDateIsNull_ = false;}
   else{payoffDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateNode , address : " << payoffDateNode << std::endl;
   #endif
   if(payoffDateNode)
   {
       payoffDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffDateNode));
   }

   //calculationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationStartDateNode = xmlNode->FirstChildElement("calculationStartDate");

   if(calculationStartDateNode){calculationStartDateIsNull_ = false;}
   else{calculationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationStartDateNode , address : " << calculationStartDateNode << std::endl;
   #endif
   if(calculationStartDateNode)
   {
       calculationStartDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calculationStartDateNode));
   }

   //calculationEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationEndDateNode = xmlNode->FirstChildElement("calculationEndDate");

   if(calculationEndDateNode){calculationEndDateIsNull_ = false;}
   else{calculationEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationEndDateNode , address : " << calculationEndDateNode << std::endl;
   #endif
   if(calculationEndDateNode)
   {
       calculationEndDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calculationEndDateNode));
   }

   //descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* descriptionNode = xmlNode->FirstChildElement("description");

   if(descriptionNode){descriptionIsNull_ = false;}
   else{descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- descriptionNode , address : " << descriptionNode << std::endl;
   #endif
   if(descriptionNode)
   {
       description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(descriptionNode));
   }

   //vba_descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vba_descriptionNode = xmlNode->FirstChildElement("vba_description");

   if(vba_descriptionNode){vba_descriptionIsNull_ = false;}
   else{vba_descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vba_descriptionNode , address : " << vba_descriptionNode << std::endl;
   #endif
   if(vba_descriptionNode)
   {
       vba_description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(vba_descriptionNode));
   }

   //excel_eventCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_eventCalcInfoNode = xmlNode->FirstChildElement("excel_eventCalcInfo");

   if(excel_eventCalcInfoNode){excel_eventCalcInfoIsNull_ = false;}
   else{excel_eventCalcInfoIsNull_ = true;}

   if(excel_eventCalcInfoNode)
   {
      for(excel_eventCalcInfoNode; excel_eventCalcInfoNode; excel_eventCalcInfoNode = excel_eventCalcInfoNode->NextSiblingElement("excel_eventCalcInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_eventCalcInfoNode , address : " << excel_eventCalcInfoNode << std::endl;
          #endif
          excel_eventCalcInfo_.push_back(boost::shared_ptr<Excel_eventCalcInfo>(new Excel_eventCalcInfo(excel_eventCalcInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_eventCalcInfoNode , address : " << excel_eventCalcInfoNode << std::endl;
       #endif
   }

   //excel_returnCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_returnCalcInfoNode = xmlNode->FirstChildElement("excel_returnCalcInfo");

   if(excel_returnCalcInfoNode){excel_returnCalcInfoIsNull_ = false;}
   else{excel_returnCalcInfoIsNull_ = true;}

   if(excel_returnCalcInfoNode)
   {
      for(excel_returnCalcInfoNode; excel_returnCalcInfoNode; excel_returnCalcInfoNode = excel_returnCalcInfoNode->NextSiblingElement("excel_returnCalcInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_returnCalcInfoNode , address : " << excel_returnCalcInfoNode << std::endl;
          #endif
          excel_returnCalcInfo_.push_back(boost::shared_ptr<Excel_returnCalcInfo>(new Excel_returnCalcInfo(excel_returnCalcInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_returnCalcInfoNode , address : " << excel_returnCalcInfoNode << std::endl;
       #endif
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getCalculationStartDate()
{
   if(!this->calculationStartDateIsNull_){
        return this->calculationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getCalculationEndDate()
{
   if(!this->calculationEndDateIsNull_){
        return this->calculationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getDescription()
{
   if(!this->descriptionIsNull_){
        return this->description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_eventCalcInfo>> Excel_multiCondi_structuredCouponSchedule::getExcel_eventCalcInfo()
{
   if(!this->excel_eventCalcInfoIsNull_){
        return this->excel_eventCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_eventCalcInfo>>();
   }
}
std::vector<boost::shared_ptr<Excel_returnCalcInfo>> Excel_multiCondi_structuredCouponSchedule::getExcel_returnCalcInfo()
{
   if(!this->excel_returnCalcInfoIsNull_){
        return this->excel_returnCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_returnCalcInfo>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        return this->dayCounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiCondi_structuredCouponSchedule::getDetailScheduleType()
{
   if(!this->detailScheduleTypeIsNull_){
        return this->detailScheduleType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

