// RateCouponCalculation.cpp 
#include "RateCouponCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RateCouponCalculation::RateCouponCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //fixedRateCouponCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateCouponCalculationNode = xmlNode->FirstChildElement("fixedRateCouponCalculation");

   if(fixedRateCouponCalculationNode){fixedRateCouponCalculationIsNull_ = false;}
   else{fixedRateCouponCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateCouponCalculationNode , address : " << fixedRateCouponCalculationNode << std::endl;
   #endif
   if(fixedRateCouponCalculationNode)
   {
       fixedRateCouponCalculation_ = boost::shared_ptr<FixedRateCouponCalculation>(new FixedRateCouponCalculation(fixedRateCouponCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> RateCouponCalculation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixedRateCouponCalculation> RateCouponCalculation::getFixedRateCouponCalculation()
{
   if(!this->fixedRateCouponCalculationIsNull_){
        return this->fixedRateCouponCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedRateCouponCalculation>();
   }
}
}

