// SimpleRangeAccrualRateTrigger.cpp 
#include "SimpleRangeAccrualRateTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleRangeAccrualRateTrigger::SimpleRangeAccrualRateTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //calculationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationStartDateNode = xmlNode->FirstChildElement("calculationStartDate");

   if(calculationStartDateNode){calculationStartDateIsNull_ = false;}
   else{calculationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationStartDateNode , address : " << calculationStartDateNode << std::endl;
   #endif
   if(calculationStartDateNode)
   {
       calculationStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(calculationStartDateNode));
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
       calculationEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(calculationEndDateNode));
   }

   //referenceCalculationInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCalculationInfoNode = xmlNode->FirstChildElement("referenceCalculationInfo");

   if(referenceCalculationInfoNode){referenceCalculationInfoIsNull_ = false;}
   else{referenceCalculationInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCalculationInfoNode , address : " << referenceCalculationInfoNode << std::endl;
   #endif
   if(referenceCalculationInfoNode)
   {
       referenceCalculationInfo_ = boost::shared_ptr<ReferenceCalculationInfo>(new ReferenceCalculationInfo(referenceCalculationInfoNode));
   }

   //simpleRangeEventListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeEventListNode = xmlNode->FirstChildElement("simpleRangeEventList");

   if(simpleRangeEventListNode){simpleRangeEventListIsNull_ = false;}
   else{simpleRangeEventListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeEventListNode , address : " << simpleRangeEventListNode << std::endl;
   #endif
   if(simpleRangeEventListNode)
   {
       simpleRangeEventList_ = boost::shared_ptr<SimpleRangeEventList>(new SimpleRangeEventList(simpleRangeEventListNode));
   }

   //payoffDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateInfoNode = xmlNode->FirstChildElement("payoffDateInfo");

   if(payoffDateInfoNode){payoffDateInfoIsNull_ = false;}
   else{payoffDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateInfoNode , address : " << payoffDateInfoNode << std::endl;
   #endif
   if(payoffDateInfoNode)
   {
       payoffDateInfo_ = boost::shared_ptr<PayoffDateInfo>(new PayoffDateInfo(payoffDateInfoNode));
   }

   //denumerDateNumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* denumerDateNumNode = xmlNode->FirstChildElement("denumerDateNum");

   if(denumerDateNumNode){denumerDateNumIsNull_ = false;}
   else{denumerDateNumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- denumerDateNumNode , address : " << denumerDateNumNode << std::endl;
   #endif
   if(denumerDateNumNode)
   {
       denumerDateNum_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(denumerDateNumNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> SimpleRangeAccrualRateTrigger::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        return this->dayCounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDate> SimpleRangeAccrualRateTrigger::getCalculationStartDate()
{
   if(!this->calculationStartDateIsNull_){
        return this->calculationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> SimpleRangeAccrualRateTrigger::getCalculationEndDate()
{
   if(!this->calculationEndDateIsNull_){
        return this->calculationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<ReferenceCalculationInfo> SimpleRangeAccrualRateTrigger::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
boost::shared_ptr<SimpleRangeEventList> SimpleRangeAccrualRateTrigger::getSimpleRangeEventList()
{
   if(!this->simpleRangeEventListIsNull_){
        return this->simpleRangeEventList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeEventList>();
   }
}
boost::shared_ptr<PayoffDateInfo> SimpleRangeAccrualRateTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeToken> SimpleRangeAccrualRateTrigger::getDenumerDateNum()
{
   if(!this->denumerDateNumIsNull_){
        return this->denumerDateNum_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

