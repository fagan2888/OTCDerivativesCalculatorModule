// Excel_multiAsset_digitalCallPut.cpp 
#include "Excel_multiAsset_digitalCallPut.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_multiAsset_digitalCallPut::Excel_multiAsset_digitalCallPut(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payoffDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateNode = xmlNode->FirstChildElement("payoffDate");

   if(payoffDateNode){payoffDateIsNull_ = false;}
   else{payoffDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateNode , address : " << payoffDateNode << std::endl;
   #endif
   if(payoffDateNode)
   {
       payoffDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffDateNode));
   }

   //exerciseDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseDateNode = xmlNode->FirstChildElement("exerciseDate");

   if(exerciseDateNode){exerciseDateIsNull_ = false;}
   else{exerciseDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseDateNode , address : " << exerciseDateNode << std::endl;
   #endif
   if(exerciseDateNode)
   {
       exerciseDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(exerciseDateNode));
   }

   //callPutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* callPutNode = xmlNode->FirstChildElement("callPut");

   if(callPutNode){callPutIsNull_ = false;}
   else{callPutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- callPutNode , address : " << callPutNode << std::endl;
   #endif
   if(callPutNode)
   {
       callPut_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(callPutNode));
   }

   //baseUnderlyingValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseUnderlyingValueNode = xmlNode->FirstChildElement("baseUnderlyingValue");

   if(baseUnderlyingValueNode){baseUnderlyingValueIsNull_ = false;}
   else{baseUnderlyingValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseUnderlyingValueNode , address : " << baseUnderlyingValueNode << std::endl;
   #endif
   if(baseUnderlyingValueNode)
   {
       baseUnderlyingValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(baseUnderlyingValueNode));
   }

   //baseCouponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseCouponNode = xmlNode->FirstChildElement("baseCoupon");

   if(baseCouponNode){baseCouponIsNull_ = false;}
   else{baseCouponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseCouponNode , address : " << baseCouponNode << std::endl;
   #endif
   if(baseCouponNode)
   {
       baseCoupon_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(baseCouponNode));
   }

   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
   #endif
   if(strikeNode)
   {
       strike_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(strikeNode));
   }

   //strikeValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeValueNode = xmlNode->FirstChildElement("strikeValue");

   if(strikeValueNode){strikeValueIsNull_ = false;}
   else{strikeValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeValueNode , address : " << strikeValueNode << std::endl;
   #endif
   if(strikeValueNode)
   {
       strikeValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(strikeValueNode));
   }

   //couponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponNode = xmlNode->FirstChildElement("coupon");

   if(couponNode){couponIsNull_ = false;}
   else{couponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponNode , address : " << couponNode << std::endl;
   #endif
   if(couponNode)
   {
       coupon_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(couponNode));
   }

   //couponValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponValueNode = xmlNode->FirstChildElement("couponValue");

   if(couponValueNode){couponValueIsNull_ = false;}
   else{couponValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponValueNode , address : " << couponValueNode << std::endl;
   #endif
   if(couponValueNode)
   {
       couponValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(couponValueNode));
   }

   //excel_underlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingCalcIDNode = xmlNode->FirstChildElement("excel_underlyingCalcID");

   if(excel_underlyingCalcIDNode){excel_underlyingCalcIDIsNull_ = false;}
   else{excel_underlyingCalcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingCalcIDNode , address : " << excel_underlyingCalcIDNode << std::endl;
   #endif
   if(excel_underlyingCalcIDNode)
   {
       excel_underlyingCalcID_ = boost::shared_ptr<Excel_underlyingCalcID>(new Excel_underlyingCalcID(excel_underlyingCalcIDNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getExerciseDate()
{
   if(!this->exerciseDateIsNull_){
        return this->exerciseDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getCallPut()
{
   if(!this->callPutIsNull_){
        return this->callPut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getBaseUnderlyingValue()
{
   if(!this->baseUnderlyingValueIsNull_){
        return this->baseUnderlyingValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getBaseCoupon()
{
   if(!this->baseCouponIsNull_){
        return this->baseCoupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getStrike()
{
   if(!this->strikeIsNull_){
        return this->strike_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getStrikeValue()
{
   if(!this->strikeValueIsNull_){
        return this->strikeValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getCoupon()
{
   if(!this->couponIsNull_){
        return this->coupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_digitalCallPut::getCouponValue()
{
   if(!this->couponValueIsNull_){
        return this->couponValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_underlyingCalcID> Excel_multiAsset_digitalCallPut::getExcel_underlyingCalcID()
{
   if(!this->excel_underlyingCalcIDIsNull_){
        return this->excel_underlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcID>();
   }
}
}

