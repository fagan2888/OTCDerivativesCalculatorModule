// Excel_condi_structuredAccrualCouponSchedule.cpp 
#include "Excel_condi_structuredAccrualCouponSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_condi_structuredAccrualCouponSchedule::Excel_condi_structuredAccrualCouponSchedule(TiXmlNode* xmlNode)
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

   //range1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* range1DNode = xmlNode->FirstChildElement("range1D");

   if(range1DNode){range1DIsNull_ = false;}
   else{range1DIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- range1DNode , address : " << range1DNode << std::endl;
   #endif
   if(range1DNode)
   {
       range1D_ = boost::shared_ptr<Range1D>(new Range1D(range1DNode));
   }

   //excel_returnCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_returnCalcInfoNode = xmlNode->FirstChildElement("excel_returnCalcInfo");

   if(excel_returnCalcInfoNode){excel_returnCalcInfoIsNull_ = false;}
   else{excel_returnCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_returnCalcInfoNode , address : " << excel_returnCalcInfoNode << std::endl;
   #endif
   if(excel_returnCalcInfoNode)
   {
       excel_returnCalcInfo_ = boost::shared_ptr<Excel_returnCalcInfo>(new Excel_returnCalcInfo(excel_returnCalcInfoNode));
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
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getCalculationStartDate()
{
   if(!this->calculationStartDateIsNull_){
        return this->calculationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getCalculationEndDate()
{
   if(!this->calculationEndDateIsNull_){
        return this->calculationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getDescription()
{
   if(!this->descriptionIsNull_){
        return this->description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Range1D> Excel_condi_structuredAccrualCouponSchedule::getRange1D()
{
   if(!this->range1DIsNull_){
        return this->range1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Range1D>();
   }
}
boost::shared_ptr<Excel_returnCalcInfo> Excel_condi_structuredAccrualCouponSchedule::getExcel_returnCalcInfo()
{
   if(!this->excel_returnCalcInfoIsNull_){
        return this->excel_returnCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_returnCalcInfo>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        return this->dayCounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_condi_structuredAccrualCouponSchedule::getDetailScheduleType()
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

