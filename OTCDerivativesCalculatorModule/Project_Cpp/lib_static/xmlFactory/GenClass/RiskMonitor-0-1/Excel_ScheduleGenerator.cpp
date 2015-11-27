// Excel_ScheduleGenerator.cpp 
#include "Excel_ScheduleGenerator.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_ScheduleGenerator::Excel_ScheduleGenerator(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
       effectiveDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(effectiveDateNode));
   }

   //maturityDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityDateNode = xmlNode->FirstChildElement("maturityDate");

   if(maturityDateNode){maturityDateIsNull_ = false;}
   else{maturityDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityDateNode , address : " << maturityDateNode << std::endl;
   #endif
   if(maturityDateNode)
   {
       maturityDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(maturityDateNode));
   }

   //tenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNode = xmlNode->FirstChildElement("tenor");

   if(tenorNode){tenorIsNull_ = false;}
   else{tenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
   #endif
   if(tenorNode)
   {
       tenor_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(tenorNode));
   }

   //paymentDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDaysNode = xmlNode->FirstChildElement("paymentDays");

   if(paymentDaysNode){paymentDaysIsNull_ = false;}
   else{paymentDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDaysNode , address : " << paymentDaysNode << std::endl;
   #endif
   if(paymentDaysNode)
   {
       paymentDays_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(paymentDaysNode));
   }

   //calendarsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calendarsNode = xmlNode->FirstChildElement("calendars");

   if(calendarsNode){calendarsIsNull_ = false;}
   else{calendarsIsNull_ = true;}

   if(calendarsNode)
   {
      for(calendarsNode; calendarsNode; calendarsNode = calendarsNode->NextSiblingElement("calendars")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calendarsNode , address : " << calendarsNode << std::endl;
          #endif
          calendars_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calendarsNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calendarsNode , address : " << calendarsNode << std::endl;
       #endif
   }

   //businessDayConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConventionNode = xmlNode->FirstChildElement("businessDayConvention");

   if(businessDayConventionNode){businessDayConventionIsNull_ = false;}
   else{businessDayConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConventionNode , address : " << businessDayConventionNode << std::endl;
   #endif
   if(businessDayConventionNode)
   {
       businessDayConvention_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(businessDayConventionNode));
   }

   //dateGenerationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateGenerationNode = xmlNode->FirstChildElement("dateGeneration");

   if(dateGenerationNode){dateGenerationIsNull_ = false;}
   else{dateGenerationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateGenerationNode , address : " << dateGenerationNode << std::endl;
   #endif
   if(dateGenerationNode)
   {
       dateGeneration_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dateGenerationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_ScheduleGenerator::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        return this->effectiveDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_ScheduleGenerator::getMaturityDate()
{
   if(!this->maturityDateIsNull_){
        return this->maturityDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_ScheduleGenerator::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_ScheduleGenerator::getPaymentDays()
{
   if(!this->paymentDaysIsNull_){
        return this->paymentDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<XsdTypeToken>> Excel_ScheduleGenerator::getCalendars()
{
   if(!this->calendarsIsNull_){
        return this->calendars_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_ScheduleGenerator::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        return this->businessDayConvention_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_ScheduleGenerator::getDateGeneration()
{
   if(!this->dateGenerationIsNull_){
        return this->dateGeneration_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

