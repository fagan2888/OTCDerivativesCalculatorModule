// BondCouponInfo.cpp 
#include "BondCouponInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BondCouponInfo::BondCouponInfo(TiXmlNode* xmlNode)
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

   //fixedRateTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateTypeNode = xmlNode->FirstChildElement("fixedRateType");

   if(fixedRateTypeNode){fixedRateTypeIsNull_ = false;}
   else{fixedRateTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateTypeNode , address : " << fixedRateTypeNode << std::endl;
   #endif
   if(fixedRateTypeNode)
   {
       fixedRateType_ = boost::shared_ptr<FixedRateType>(new FixedRateType(fixedRateTypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> BondCouponInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixedRateType> BondCouponInfo::getFixedRateType()
{
   if(!this->fixedRateTypeIsNull_){
        return this->fixedRateType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedRateType>();
   }
}
}

