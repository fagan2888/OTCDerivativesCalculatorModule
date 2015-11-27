// General_scheduleDetail_fixedCoupon.cpp 
#include "General_scheduleDetail_fixedCoupon.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

General_scheduleDetail_fixedCoupon::General_scheduleDetail_fixedCoupon(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> General_scheduleDetail_fixedCoupon::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        return this->fixedRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

