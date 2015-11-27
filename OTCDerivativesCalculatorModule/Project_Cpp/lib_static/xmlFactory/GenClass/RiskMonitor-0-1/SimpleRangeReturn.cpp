// SimpleRangeReturn.cpp 
#include "SimpleRangeReturn.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleRangeReturn::SimpleRangeReturn(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //simpleRangeEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeEventCalNode = xmlNode->FirstChildElement("simpleRangeEventCal");

   if(simpleRangeEventCalNode){simpleRangeEventCalIsNull_ = false;}
   else{simpleRangeEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeEventCalNode , address : " << simpleRangeEventCalNode << std::endl;
   #endif
   if(simpleRangeEventCalNode)
   {
       simpleRangeEventCal_ = boost::shared_ptr<SimpleRangeEventCal>(new SimpleRangeEventCal(simpleRangeEventCalNode));
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
boost::shared_ptr<SimpleRangeEventCal> SimpleRangeReturn::getSimpleRangeEventCal()
{
   if(!this->simpleRangeEventCalIsNull_){
        return this->simpleRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeEventCal>();
   }
}
boost::shared_ptr<ReturnCalculation> SimpleRangeReturn::getReturnCalculation()
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

