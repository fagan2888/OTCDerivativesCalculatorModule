// SingleBarrier.cpp 
#include "SingleBarrier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SingleBarrier::SingleBarrier(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payoffDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateInfoNode = xmlNode->FirstChildElement("payoffDateInfo");

   if(payoffDateInfoNode){payoffDateInfoIsNull_ = false;}
   else{payoffDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateInfoNode , address : " << payoffDateInfoNode << std::endl;
   #endif
   if(payoffDateInfoNode)
   {
       payoffDateInfo_ = boost::shared_ptr<PayoffDateInfo>(new PayoffDateInfo(payoffDateInfoNode));
   }

   //participateRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* participateRateNode = xmlNode->FirstChildElement("participateRate");

   if(participateRateNode){participateRateIsNull_ = false;}
   else{participateRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- participateRateNode , address : " << participateRateNode << std::endl;
   #endif
   if(participateRateNode)
   {
       participateRate_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(participateRateNode));
   }

   //barrierInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierInfoNode = xmlNode->FirstChildElement("barrierInfo");

   if(barrierInfoNode){barrierInfoIsNull_ = false;}
   else{barrierInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierInfoNode , address : " << barrierInfoNode << std::endl;
   #endif
   if(barrierInfoNode)
   {
       barrierInfo_ = boost::shared_ptr<BarrierInfo>(new BarrierInfo(barrierInfoNode));
   }

   //rebateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rebateNode = xmlNode->FirstChildElement("rebate");

   if(rebateNode){rebateIsNull_ = false;}
   else{rebateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rebateNode , address : " << rebateNode << std::endl;
   #endif
   if(rebateNode)
   {
       rebate_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(rebateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PayoffDateInfo> SingleBarrier::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> SingleBarrier::getParticipateRate()
{
   if(!this->participateRateIsNull_){
        return this->participateRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<BarrierInfo> SingleBarrier::getBarrierInfo()
{
   if(!this->barrierInfoIsNull_){
        return this->barrierInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BarrierInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> SingleBarrier::getRebate()
{
   if(!this->rebateIsNull_){
        return this->rebate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

