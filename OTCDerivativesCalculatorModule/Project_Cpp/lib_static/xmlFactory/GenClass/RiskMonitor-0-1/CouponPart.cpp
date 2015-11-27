// CouponPart.cpp 
#include "CouponPart.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CouponPart::CouponPart(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payRecieveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payRecieveNode = xmlNode->FirstChildElement("payRecieve");

   if(payRecieveNode){payRecieveIsNull_ = false;}
   else{payRecieveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payRecieveNode , address : " << payRecieveNode << std::endl;
   #endif
   if(payRecieveNode)
   {
       payRecieve_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payRecieveNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CouponPart::getPayRecieve()
{
   if(!this->payRecieveIsNull_){
        return this->payRecieve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

