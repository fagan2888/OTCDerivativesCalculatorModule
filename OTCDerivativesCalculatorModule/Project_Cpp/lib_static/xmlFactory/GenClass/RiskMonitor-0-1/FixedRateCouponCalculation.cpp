// FixedRateCouponCalculation.cpp 
#include "FixedRateCouponCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedRateCouponCalculation::FixedRateCouponCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateNode = xmlNode->FirstChildElement("rate");

   if(rateNode){rateIsNull_ = false;}
   else{rateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateNode , address : " << rateNode << std::endl;
   #endif
   if(rateNode)
   {
       rate_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(rateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> FixedRateCouponCalculation::getRate()
{
   if(!this->rateIsNull_){
        return this->rate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

