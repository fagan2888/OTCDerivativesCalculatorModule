// General_scheduleDetail_fixedAmount.cpp 
#include "General_scheduleDetail_fixedAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

General_scheduleDetail_fixedAmount::General_scheduleDetail_fixedAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixedAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedAmountNode = xmlNode->FirstChildElement("fixedAmount");

   if(fixedAmountNode){fixedAmountIsNull_ = false;}
   else{fixedAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedAmountNode , address : " << fixedAmountNode << std::endl;
   #endif
   if(fixedAmountNode)
   {
       fixedAmount_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(fixedAmountNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> General_scheduleDetail_fixedAmount::getFixedAmount()
{
   if(!this->fixedAmountIsNull_){
        return this->fixedAmount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

