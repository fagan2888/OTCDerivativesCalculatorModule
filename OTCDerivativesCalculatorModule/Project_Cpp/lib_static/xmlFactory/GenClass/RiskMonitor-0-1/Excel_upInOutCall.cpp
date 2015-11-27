// Excel_upInOutCall.cpp 
#include "Excel_upInOutCall.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_upInOutCall::Excel_upInOutCall(TiXmlNode* xmlNode)
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

   //inOutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inOutNode = xmlNode->FirstChildElement("inOut");

   if(inOutNode){inOutIsNull_ = false;}
   else{inOutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inOutNode , address : " << inOutNode << std::endl;
   #endif
   if(inOutNode)
   {
       inOut_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(inOutNode));
   }

   //underlyingCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingCodeNode = xmlNode->FirstChildElement("underlyingCode");

   if(underlyingCodeNode){underlyingCodeIsNull_ = false;}
   else{underlyingCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingCodeNode , address : " << underlyingCodeNode << std::endl;
   #endif
   if(underlyingCodeNode)
   {
       underlyingCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(underlyingCodeNode));
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

   //partiRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partiRateNode = xmlNode->FirstChildElement("partiRate");

   if(partiRateNode){partiRateIsNull_ = false;}
   else{partiRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partiRateNode , address : " << partiRateNode << std::endl;
   #endif
   if(partiRateNode)
   {
       partiRate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(partiRateNode));
   }

   //barrierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierNode = xmlNode->FirstChildElement("barrier");

   if(barrierNode){barrierIsNull_ = false;}
   else{barrierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierNode , address : " << barrierNode << std::endl;
   #endif
   if(barrierNode)
   {
       barrier_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(barrierNode));
   }

   //barrierValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierValueNode = xmlNode->FirstChildElement("barrierValue");

   if(barrierValueNode){barrierValueIsNull_ = false;}
   else{barrierValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierValueNode , address : " << barrierValueNode << std::endl;
   #endif
   if(barrierValueNode)
   {
       barrierValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(barrierValueNode));
   }

   //rebateCouponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rebateCouponNode = xmlNode->FirstChildElement("rebateCoupon");

   if(rebateCouponNode){rebateCouponIsNull_ = false;}
   else{rebateCouponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rebateCouponNode , address : " << rebateCouponNode << std::endl;
   #endif
   if(rebateCouponNode)
   {
       rebateCoupon_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(rebateCouponNode));
   }

   //rebateCouponValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rebateCouponValueNode = xmlNode->FirstChildElement("rebateCouponValue");

   if(rebateCouponValueNode){rebateCouponValueIsNull_ = false;}
   else{rebateCouponValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rebateCouponValueNode , address : " << rebateCouponValueNode << std::endl;
   #endif
   if(rebateCouponValueNode)
   {
       rebateCouponValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(rebateCouponValueNode));
   }

   //observationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationStartDateNode = xmlNode->FirstChildElement("observationStartDate");

   if(observationStartDateNode){observationStartDateIsNull_ = false;}
   else{observationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationStartDateNode , address : " << observationStartDateNode << std::endl;
   #endif
   if(observationStartDateNode)
   {
       observationStartDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(observationStartDateNode));
   }

   //observationEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationEndDateNode = xmlNode->FirstChildElement("observationEndDate");

   if(observationEndDateNode){observationEndDateIsNull_ = false;}
   else{observationEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationEndDateNode , address : " << observationEndDateNode << std::endl;
   #endif
   if(observationEndDateNode)
   {
       observationEndDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(observationEndDateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getExerciseDate()
{
   if(!this->exerciseDateIsNull_){
        return this->exerciseDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getInOut()
{
   if(!this->inOutIsNull_){
        return this->inOut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getUnderlyingCode()
{
   if(!this->underlyingCodeIsNull_){
        return this->underlyingCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getBaseUnderlyingValue()
{
   if(!this->baseUnderlyingValueIsNull_){
        return this->baseUnderlyingValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getBaseCoupon()
{
   if(!this->baseCouponIsNull_){
        return this->baseCoupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getStrike()
{
   if(!this->strikeIsNull_){
        return this->strike_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getStrikeValue()
{
   if(!this->strikeValueIsNull_){
        return this->strikeValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getPartiRate()
{
   if(!this->partiRateIsNull_){
        return this->partiRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getBarrier()
{
   if(!this->barrierIsNull_){
        return this->barrier_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getBarrierValue()
{
   if(!this->barrierValueIsNull_){
        return this->barrierValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getRebateCoupon()
{
   if(!this->rebateCouponIsNull_){
        return this->rebateCoupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getRebateCouponValue()
{
   if(!this->rebateCouponValueIsNull_){
        return this->rebateCouponValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getObservationStartDate()
{
   if(!this->observationStartDateIsNull_){
        return this->observationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_upInOutCall::getObservationEndDate()
{
   if(!this->observationEndDateIsNull_){
        return this->observationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

