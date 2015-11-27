// VanillaRateCalculation.cpp 
#include "VanillaRateCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VanillaRateCalculation::VanillaRateCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rateCouponCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateCouponCalculationNode = xmlNode->FirstChildElement("rateCouponCalculation");

   if(rateCouponCalculationNode){rateCouponCalculationIsNull_ = false;}
   else{rateCouponCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateCouponCalculationNode , address : " << rateCouponCalculationNode << std::endl;
   #endif
   if(rateCouponCalculationNode)
   {
       rateCouponCalculation_ = boost::shared_ptr<RateCouponCalculation>(new RateCouponCalculation(rateCouponCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RateCouponCalculation> VanillaRateCalculation::getRateCouponCalculation()
{
   if(!this->rateCouponCalculationIsNull_){
        return this->rateCouponCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RateCouponCalculation>();
   }
}
}

