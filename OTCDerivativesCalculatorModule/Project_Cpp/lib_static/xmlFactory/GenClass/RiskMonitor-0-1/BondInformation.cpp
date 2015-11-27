// BondInformation.cpp 
#include "BondInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BondInformation::BondInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //irFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* irFrequencyNode = xmlNode->FirstChildElement("irFrequency");

   if(irFrequencyNode){irFrequencyIsNull_ = false;}
   else{irFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- irFrequencyNode , address : " << irFrequencyNode << std::endl;
   #endif
   if(irFrequencyNode)
   {
       irFrequency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(irFrequencyNode));
   }

   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
       notional_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notionalNode));
   }

   //issueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* issueDateNode = xmlNode->FirstChildElement("issueDate");

   if(issueDateNode){issueDateIsNull_ = false;}
   else{issueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- issueDateNode , address : " << issueDateNode << std::endl;
   #endif
   if(issueDateNode)
   {
       issueDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(issueDateNode));
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

   //calendarNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calendarNode = xmlNode->FirstChildElement("calendar");

   if(calendarNode){calendarIsNull_ = false;}
   else{calendarIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calendarNode , address : " << calendarNode << std::endl;
   #endif
   if(calendarNode)
   {
       calendar_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calendarNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> BondInformation::getIrFrequency()
{
   if(!this->irFrequencyIsNull_){
        return this->irFrequency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> BondInformation::getNotional()
{
   if(!this->notionalIsNull_){
        return this->notional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> BondInformation::getIssueDate()
{
   if(!this->issueDateIsNull_){
        return this->issueDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> BondInformation::getMaturityDate()
{
   if(!this->maturityDateIsNull_){
        return this->maturityDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> BondInformation::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        return this->dayCounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> BondInformation::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        return this->businessDayConvention_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> BondInformation::getCalendar()
{
   if(!this->calendarIsNull_){
        return this->calendar_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

