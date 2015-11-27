// Bond.cpp 
#include "Bond.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Bond::Bond(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //instrumentIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentIdNode = xmlNode->FirstChildElement("instrumentId");

   if(instrumentIdNode){instrumentIdIsNull_ = false;}
   else{instrumentIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentIdNode , address : " << instrumentIdNode << std::endl;
   #endif
   if(instrumentIdNode)
   {
       instrumentId_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(instrumentIdNode));
   }

   //couponRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponRateNode = xmlNode->FirstChildElement("couponRate");

   if(couponRateNode){couponRateIsNull_ = false;}
   else{couponRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponRateNode , address : " << couponRateNode << std::endl;
   #endif
   if(couponRateNode)
   {
       couponRate_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(couponRateNode));
   }

   //maturityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityNode = xmlNode->FirstChildElement("maturity");

   if(maturityNode){maturityIsNull_ = false;}
   else{maturityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityNode , address : " << maturityNode << std::endl;
   #endif
   if(maturityNode)
   {
       maturity_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityNode));
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
       currency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currencyNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Bond::getInstrumentId()
{
   if(!this->instrumentIdIsNull_){
        return this->instrumentId_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDouble> Bond::getCouponRate()
{
   if(!this->couponRateIsNull_){
        return this->couponRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDate> Bond::getMaturity()
{
   if(!this->maturityIsNull_){
        return this->maturity_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeToken> Bond::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

