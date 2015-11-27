// CreditDefaultSwap.cpp 
#include "CreditDefaultSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditDefaultSwap::CreditDefaultSwap(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //protectionPartNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* protectionPartNode = xmlNode->FirstChildElement("protectionPart");

   if(protectionPartNode){protectionPartIsNull_ = false;}
   else{protectionPartIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- protectionPartNode , address : " << protectionPartNode << std::endl;
   #endif
   if(protectionPartNode)
   {
       protectionPart_ = boost::shared_ptr<ProtectionPart>(new ProtectionPart(protectionPartNode));
   }

   //couponPartNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponPartNode = xmlNode->FirstChildElement("couponPart");

   if(couponPartNode){couponPartIsNull_ = false;}
   else{couponPartIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponPartNode , address : " << couponPartNode << std::endl;
   #endif
   if(couponPartNode)
   {
       couponPart_ = boost::shared_ptr<CouponPart>(new CouponPart(couponPartNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ProtectionPart> CreditDefaultSwap::getProtectionPart()
{
   if(!this->protectionPartIsNull_){
        return this->protectionPart_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProtectionPart>();
   }
}
boost::shared_ptr<CouponPart> CreditDefaultSwap::getCouponPart()
{
   if(!this->couponPartIsNull_){
        return this->couponPart_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CouponPart>();
   }
}
}

