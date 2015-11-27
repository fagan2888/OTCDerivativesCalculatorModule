// InterestRateSwapPayoff.cpp 
#include "InterestRateSwapPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestRateSwapPayoff::InterestRateSwapPayoff(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //couponPartNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponPartNode = xmlNode->FirstChildElement("couponPart");

   if(couponPartNode){couponPartIsNull_ = false;}
   else{couponPartIsNull_ = true;}

   if(couponPartNode)
   {
      for(couponPartNode; couponPartNode; couponPartNode = couponPartNode->NextSiblingElement("couponPart")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponPartNode , address : " << couponPartNode << std::endl;
          #endif
          couponPart_.push_back(boost::shared_ptr<CouponPart>(new CouponPart(couponPartNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponPartNode , address : " << couponPartNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<CouponPart>> InterestRateSwapPayoff::getCouponPart()
{
   if(!this->couponPartIsNull_){
        return this->couponPart_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CouponPart>>();
   }
}
}

