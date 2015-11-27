// Excel_stepDownKI_subSchedule.cpp 
#include "Excel_stepDownKI_subSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_stepDownKI_subSchedule::Excel_stepDownKI_subSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_typeNode = xmlNode->FirstChildElement("excel_type");

   if(excel_typeNode){excel_typeIsNull_ = false;}
   else{excel_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_typeNode , address : " << excel_typeNode << std::endl;
   #endif
   if(excel_typeNode)
   {
       excel_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(excel_typeNode));
   }

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

   //triggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerNode = xmlNode->FirstChildElement("trigger");

   if(triggerNode){triggerIsNull_ = false;}
   else{triggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerNode , address : " << triggerNode << std::endl;
   #endif
   if(triggerNode)
   {
       trigger_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(triggerNode));
   }

   //couponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponNode = xmlNode->FirstChildElement("coupon");

   if(couponNode){couponIsNull_ = false;}
   else{couponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponNode , address : " << couponNode << std::endl;
   #endif
   if(couponNode)
   {
       coupon_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(couponNode));
   }

   //averageDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averageDaysNode = xmlNode->FirstChildElement("averageDays");

   if(averageDaysNode){averageDaysIsNull_ = false;}
   else{averageDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averageDaysNode , address : " << averageDaysNode << std::endl;
   #endif
   if(averageDaysNode)
   {
       averageDays_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(averageDaysNode));
   }

   //underCalcTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underCalcTypeNode = xmlNode->FirstChildElement("underCalcType");

   if(underCalcTypeNode){underCalcTypeIsNull_ = false;}
   else{underCalcTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underCalcTypeNode , address : " << underCalcTypeNode << std::endl;
   #endif
   if(underCalcTypeNode)
   {
       underCalcType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(underCalcTypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_stepDownKI_subSchedule::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_stepDownKI_subSchedule::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_stepDownKI_subSchedule::getTrigger()
{
   if(!this->triggerIsNull_){
        return this->trigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_stepDownKI_subSchedule::getCoupon()
{
   if(!this->couponIsNull_){
        return this->coupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_stepDownKI_subSchedule::getAverageDays()
{
   if(!this->averageDaysIsNull_){
        return this->averageDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_stepDownKI_subSchedule::getUnderCalcType()
{
   if(!this->underCalcTypeIsNull_){
        return this->underCalcType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

