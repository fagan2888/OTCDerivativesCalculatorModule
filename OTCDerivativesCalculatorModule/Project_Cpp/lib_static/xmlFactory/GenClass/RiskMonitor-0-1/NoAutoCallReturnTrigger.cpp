// NoAutoCallReturnTrigger.cpp 
#include "NoAutoCallReturnTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NoAutoCallReturnTrigger::NoAutoCallReturnTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //returnCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnCalculationNode = xmlNode->FirstChildElement("returnCalculation");

   if(returnCalculationNode){returnCalculationIsNull_ = false;}
   else{returnCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnCalculationNode , address : " << returnCalculationNode << std::endl;
   #endif
   if(returnCalculationNode)
   {
       returnCalculation_ = boost::shared_ptr<ReturnCalculation>(new ReturnCalculation(returnCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PayoffDateInfo> NoAutoCallReturnTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<ReturnCalculation> NoAutoCallReturnTrigger::getReturnCalculation()
{
   if(!this->returnCalculationIsNull_){
        return this->returnCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnCalculation>();
   }
}
}

