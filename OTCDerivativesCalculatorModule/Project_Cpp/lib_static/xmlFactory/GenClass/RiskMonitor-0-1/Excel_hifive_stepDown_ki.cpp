// Excel_hifive_stepDown_ki.cpp 
#include "Excel_hifive_stepDown_ki.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_hifive_stepDown_ki::Excel_hifive_stepDown_ki(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underlyingCalcTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingCalcTypeNode = xmlNode->FirstChildElement("underlyingCalcType");

   if(underlyingCalcTypeNode){underlyingCalcTypeIsNull_ = false;}
   else{underlyingCalcTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingCalcTypeNode , address : " << underlyingCalcTypeNode << std::endl;
   #endif
   if(underlyingCalcTypeNode)
   {
       underlyingCalcType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(underlyingCalcTypeNode));
   }

   //maturityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityNode = xmlNode->FirstChildElement("maturity");

   if(maturityNode){maturityIsNull_ = false;}
   else{maturityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityNode , address : " << maturityNode << std::endl;
   #endif
   if(maturityNode)
   {
       maturity_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(maturityNode));
   }

   //maturityPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityPeriodNode = xmlNode->FirstChildElement("maturityPeriod");

   if(maturityPeriodNode){maturityPeriodIsNull_ = false;}
   else{maturityPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityPeriodNode , address : " << maturityPeriodNode << std::endl;
   #endif
   if(maturityPeriodNode)
   {
       maturityPeriod_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(maturityPeriodNode));
   }

   //couponTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponTenorNode = xmlNode->FirstChildElement("couponTenor");

   if(couponTenorNode){couponTenorIsNull_ = false;}
   else{couponTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponTenorNode , address : " << couponTenorNode << std::endl;
   #endif
   if(couponTenorNode)
   {
       couponTenor_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(couponTenorNode));
   }

   //couponTenorPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponTenorPeriodNode = xmlNode->FirstChildElement("couponTenorPeriod");

   if(couponTenorPeriodNode){couponTenorPeriodIsNull_ = false;}
   else{couponTenorPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponTenorPeriodNode , address : " << couponTenorPeriodNode << std::endl;
   #endif
   if(couponTenorPeriodNode)
   {
       couponTenorPeriod_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(couponTenorPeriodNode));
   }

   //excel_stepDownKI_subScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_stepDownKI_subScheduleNode = xmlNode->FirstChildElement("excel_stepDownKI_subSchedule");

   if(excel_stepDownKI_subScheduleNode){excel_stepDownKI_subScheduleIsNull_ = false;}
   else{excel_stepDownKI_subScheduleIsNull_ = true;}

   if(excel_stepDownKI_subScheduleNode)
   {
      for(excel_stepDownKI_subScheduleNode; excel_stepDownKI_subScheduleNode; excel_stepDownKI_subScheduleNode = excel_stepDownKI_subScheduleNode->NextSiblingElement("excel_stepDownKI_subSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_stepDownKI_subScheduleNode , address : " << excel_stepDownKI_subScheduleNode << std::endl;
          #endif
          excel_stepDownKI_subSchedule_.push_back(boost::shared_ptr<Excel_stepDownKI_subSchedule>(new Excel_stepDownKI_subSchedule(excel_stepDownKI_subScheduleNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_stepDownKI_subScheduleNode , address : " << excel_stepDownKI_subScheduleNode << std::endl;
       #endif
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

   //kiNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* kiNode = xmlNode->FirstChildElement("ki");

   if(kiNode){kiIsNull_ = false;}
   else{kiIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- kiNode , address : " << kiNode << std::endl;
   #endif
   if(kiNode)
   {
       ki_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(kiNode));
   }

   //kiObStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* kiObStartDateNode = xmlNode->FirstChildElement("kiObStartDate");

   if(kiObStartDateNode){kiObStartDateIsNull_ = false;}
   else{kiObStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- kiObStartDateNode , address : " << kiObStartDateNode << std::endl;
   #endif
   if(kiObStartDateNode)
   {
       kiObStartDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(kiObStartDateNode));
   }

   //kiObEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* kiObEndDateNode = xmlNode->FirstChildElement("kiObEndDate");

   if(kiObEndDateNode){kiObEndDateIsNull_ = false;}
   else{kiObEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- kiObEndDateNode , address : " << kiObEndDateNode << std::endl;
   #endif
   if(kiObEndDateNode)
   {
       kiObEndDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(kiObEndDateNode));
   }

   //settlementDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementDaysNode = xmlNode->FirstChildElement("settlementDays");

   if(settlementDaysNode){settlementDaysIsNull_ = false;}
   else{settlementDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementDaysNode , address : " << settlementDaysNode << std::endl;
   #endif
   if(settlementDaysNode)
   {
       settlementDays_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(settlementDaysNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getUnderlyingCalcType()
{
   if(!this->underlyingCalcTypeIsNull_){
        return this->underlyingCalcType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getMaturity()
{
   if(!this->maturityIsNull_){
        return this->maturity_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getMaturityPeriod()
{
   if(!this->maturityPeriodIsNull_){
        return this->maturityPeriod_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getCouponTenor()
{
   if(!this->couponTenorIsNull_){
        return this->couponTenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getCouponTenorPeriod()
{
   if(!this->couponTenorPeriodIsNull_){
        return this->couponTenorPeriod_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_stepDownKI_subSchedule>> Excel_hifive_stepDown_ki::getExcel_stepDownKI_subSchedule()
{
   if(!this->excel_stepDownKI_subScheduleIsNull_){
        return this->excel_stepDownKI_subSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_stepDownKI_subSchedule>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getCoupon()
{
   if(!this->couponIsNull_){
        return this->coupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getKi()
{
   if(!this->kiIsNull_){
        return this->ki_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getKiObStartDate()
{
   if(!this->kiObStartDateIsNull_){
        return this->kiObStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getKiObEndDate()
{
   if(!this->kiObEndDateIsNull_){
        return this->kiObEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_stepDown_ki::getSettlementDays()
{
   if(!this->settlementDaysIsNull_){
        return this->settlementDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

