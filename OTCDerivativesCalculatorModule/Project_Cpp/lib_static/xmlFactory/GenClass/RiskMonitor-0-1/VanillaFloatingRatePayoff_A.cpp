// VanillaFloatingRatePayoff_A.cpp 
#include "VanillaFloatingRatePayoff_A.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VanillaFloatingRatePayoff_A::VanillaFloatingRatePayoff_A(TiXmlNode* xmlNode)
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

   //gearingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gearingNode = xmlNode->FirstChildElement("gearing");

   if(gearingNode){gearingIsNull_ = false;}
   else{gearingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gearingNode , address : " << gearingNode << std::endl;
   #endif
   if(gearingNode)
   {
       gearing_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(gearingNode));
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
       spread_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(spreadNode));
   }

   //referenceStrNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceStrNode = xmlNode->FirstChildElement("referenceStr");

   if(referenceStrNode){referenceStrIsNull_ = false;}
   else{referenceStrIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceStrNode , address : " << referenceStrNode << std::endl;
   #endif
   if(referenceStrNode)
   {
       referenceStr_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(referenceStrNode));
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

   //capFloorOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* capFloorOptionNode = xmlNode->FirstChildElement("capFloorOption");

   if(capFloorOptionNode){capFloorOptionIsNull_ = false;}
   else{capFloorOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capFloorOptionNode , address : " << capFloorOptionNode << std::endl;
   #endif
   if(capFloorOptionNode)
   {
       capFloorOption_ = boost::shared_ptr<CapFloorOption>(new CapFloorOption(capFloorOptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> VanillaFloatingRatePayoff_A::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        return this->dayCounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDate> VanillaFloatingRatePayoff_A::getCalculationStartDate()
{
   if(!this->calculationStartDateIsNull_){
        return this->calculationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> VanillaFloatingRatePayoff_A::getCalculationEndDate()
{
   if(!this->calculationEndDateIsNull_){
        return this->calculationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDouble> VanillaFloatingRatePayoff_A::getGearing()
{
   if(!this->gearingIsNull_){
        return this->gearing_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> VanillaFloatingRatePayoff_A::getSpread()
{
   if(!this->spreadIsNull_){
        return this->spread_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeToken> VanillaFloatingRatePayoff_A::getReferenceStr()
{
   if(!this->referenceStrIsNull_){
        return this->referenceStr_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> VanillaFloatingRatePayoff_A::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<CapFloorOption> VanillaFloatingRatePayoff_A::getCapFloorOption()
{
   if(!this->capFloorOptionIsNull_){
        return this->capFloorOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CapFloorOption>();
   }
}
}

