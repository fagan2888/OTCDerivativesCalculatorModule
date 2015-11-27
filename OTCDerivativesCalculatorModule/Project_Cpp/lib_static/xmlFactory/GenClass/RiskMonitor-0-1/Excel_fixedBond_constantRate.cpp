// Excel_fixedBond_constantRate.cpp 
#include "Excel_fixedBond_constantRate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_fixedBond_constantRate::Excel_fixedBond_constantRate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //excel_fixedBond_subScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fixedBond_subScheduleNode = xmlNode->FirstChildElement("excel_fixedBond_subSchedule");

   if(excel_fixedBond_subScheduleNode){excel_fixedBond_subScheduleIsNull_ = false;}
   else{excel_fixedBond_subScheduleIsNull_ = true;}

   if(excel_fixedBond_subScheduleNode)
   {
      for(excel_fixedBond_subScheduleNode; excel_fixedBond_subScheduleNode; excel_fixedBond_subScheduleNode = excel_fixedBond_subScheduleNode->NextSiblingElement("excel_fixedBond_subSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedBond_subScheduleNode , address : " << excel_fixedBond_subScheduleNode << std::endl;
          #endif
          excel_fixedBond_subSchedule_.push_back(boost::shared_ptr<Excel_fixedBond_subSchedule>(new Excel_fixedBond_subSchedule(excel_fixedBond_subScheduleNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedBond_subScheduleNode , address : " << excel_fixedBond_subScheduleNode << std::endl;
       #endif
   }

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
boost::shared_ptr<XsdTypeToken> Excel_fixedBond_constantRate::getMaturity()
{
   if(!this->maturityIsNull_){
        return this->maturity_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_fixedBond_constantRate::getMaturityPeriod()
{
   if(!this->maturityPeriodIsNull_){
        return this->maturityPeriod_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_fixedBond_constantRate::getCouponTenor()
{
   if(!this->couponTenorIsNull_){
        return this->couponTenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_fixedBond_constantRate::getCouponTenorPeriod()
{
   if(!this->couponTenorPeriodIsNull_){
        return this->couponTenorPeriod_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_fixedBond_subSchedule>> Excel_fixedBond_constantRate::getExcel_fixedBond_subSchedule()
{
   if(!this->excel_fixedBond_subScheduleIsNull_){
        return this->excel_fixedBond_subSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_fixedBond_subSchedule>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_fixedBond_constantRate::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        return this->fixedRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_fixedBond_constantRate::getSettlementDays()
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

