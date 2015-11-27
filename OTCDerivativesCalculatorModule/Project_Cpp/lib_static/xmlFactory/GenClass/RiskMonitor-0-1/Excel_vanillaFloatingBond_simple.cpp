// Excel_vanillaFloatingBond_simple.cpp 
#include "Excel_vanillaFloatingBond_simple.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_vanillaFloatingBond_simple::Excel_vanillaFloatingBond_simple(TiXmlNode* xmlNode)
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

   //excel_vanillaFloatingBond_subScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingBond_subScheduleNode = xmlNode->FirstChildElement("excel_vanillaFloatingBond_subSchedule");

   if(excel_vanillaFloatingBond_subScheduleNode){excel_vanillaFloatingBond_subScheduleIsNull_ = false;}
   else{excel_vanillaFloatingBond_subScheduleIsNull_ = true;}

   if(excel_vanillaFloatingBond_subScheduleNode)
   {
      for(excel_vanillaFloatingBond_subScheduleNode; excel_vanillaFloatingBond_subScheduleNode; excel_vanillaFloatingBond_subScheduleNode = excel_vanillaFloatingBond_subScheduleNode->NextSiblingElement("excel_vanillaFloatingBond_subSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingBond_subScheduleNode , address : " << excel_vanillaFloatingBond_subScheduleNode << std::endl;
          #endif
          excel_vanillaFloatingBond_subSchedule_.push_back(boost::shared_ptr<Excel_vanillaFloatingBond_subSchedule>(new Excel_vanillaFloatingBond_subSchedule(excel_vanillaFloatingBond_subScheduleNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingBond_subScheduleNode , address : " << excel_vanillaFloatingBond_subScheduleNode << std::endl;
       #endif
   }

   //gearingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gearingNode = xmlNode->FirstChildElement("gearing");

   if(gearingNode){gearingIsNull_ = false;}
   else{gearingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gearingNode , address : " << gearingNode << std::endl;
   #endif
   if(gearingNode)
   {
       gearing_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(gearingNode));
   }

   //spreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadNode = xmlNode->FirstChildElement("spread");

   if(spreadNode){spreadIsNull_ = false;}
   else{spreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadNode , address : " << spreadNode << std::endl;
   #endif
   if(spreadNode)
   {
       spread_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(spreadNode));
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
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_simple::getMaturity()
{
   if(!this->maturityIsNull_){
        return this->maturity_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_simple::getMaturityPeriod()
{
   if(!this->maturityPeriodIsNull_){
        return this->maturityPeriod_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_simple::getCouponTenor()
{
   if(!this->couponTenorIsNull_){
        return this->couponTenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_simple::getCouponTenorPeriod()
{
   if(!this->couponTenorPeriodIsNull_){
        return this->couponTenorPeriod_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_vanillaFloatingBond_subSchedule>> Excel_vanillaFloatingBond_simple::getExcel_vanillaFloatingBond_subSchedule()
{
   if(!this->excel_vanillaFloatingBond_subScheduleIsNull_){
        return this->excel_vanillaFloatingBond_subSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_vanillaFloatingBond_subSchedule>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_simple::getGearing()
{
   if(!this->gearingIsNull_){
        return this->gearing_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_simple::getSpread()
{
   if(!this->spreadIsNull_){
        return this->spread_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_simple::getSettlementDays()
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

