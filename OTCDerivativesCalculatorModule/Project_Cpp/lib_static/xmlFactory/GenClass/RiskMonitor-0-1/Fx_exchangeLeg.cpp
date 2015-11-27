// Fx_exchangeLeg.cpp 
#include "Fx_exchangeLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Fx_exchangeLeg::Fx_exchangeLeg(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //targetNotionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* targetNotionalNode = xmlNode->FirstChildElement("targetNotional");

   if(targetNotionalNode){targetNotionalIsNull_ = false;}
   else{targetNotionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- targetNotionalNode , address : " << targetNotionalNode << std::endl;
   #endif
   if(targetNotionalNode)
   {
       targetNotional_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(targetNotionalNode));
   }

   //targetCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* targetCurrencyNode = xmlNode->FirstChildElement("targetCurrency");

   if(targetCurrencyNode){targetCurrencyIsNull_ = false;}
   else{targetCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- targetCurrencyNode , address : " << targetCurrencyNode << std::endl;
   #endif
   if(targetCurrencyNode)
   {
       targetCurrency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(targetCurrencyNode));
   }

   //baseNotionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseNotionalNode = xmlNode->FirstChildElement("baseNotional");

   if(baseNotionalNode){baseNotionalIsNull_ = false;}
   else{baseNotionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseNotionalNode , address : " << baseNotionalNode << std::endl;
   #endif
   if(baseNotionalNode)
   {
       baseNotional_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(baseNotionalNode));
   }

   //baseCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseCurrencyNode = xmlNode->FirstChildElement("baseCurrency");

   if(baseCurrencyNode){baseCurrencyIsNull_ = false;}
   else{baseCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseCurrencyNode , address : " << baseCurrencyNode << std::endl;
   #endif
   if(baseCurrencyNode)
   {
       baseCurrency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(baseCurrencyNode));
   }

   //exchangeTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeTypeNode = xmlNode->FirstChildElement("exchangeType");

   if(exchangeTypeNode){exchangeTypeIsNull_ = false;}
   else{exchangeTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeTypeNode , address : " << exchangeTypeNode << std::endl;
   #endif
   if(exchangeTypeNode)
   {
       exchangeType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(exchangeTypeNode));
   }

   //exchangeRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeRateNode = xmlNode->FirstChildElement("exchangeRate");

   if(exchangeRateNode){exchangeRateIsNull_ = false;}
   else{exchangeRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeRateNode , address : " << exchangeRateNode << std::endl;
   #endif
   if(exchangeRateNode)
   {
       exchangeRate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(exchangeRateNode));
   }

   //calculationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationDateNode = xmlNode->FirstChildElement("calculationDate");

   if(calculationDateNode){calculationDateIsNull_ = false;}
   else{calculationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationDateNode , address : " << calculationDateNode << std::endl;
   #endif
   if(calculationDateNode)
   {
       calculationDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calculationDateNode));
   }

   //paymentDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDaysNode = xmlNode->FirstChildElement("paymentDays");

   if(paymentDaysNode){paymentDaysIsNull_ = false;}
   else{paymentDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDaysNode , address : " << paymentDaysNode << std::endl;
   #endif
   if(paymentDaysNode)
   {
       paymentDays_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(paymentDaysNode));
   }

   //paymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDateNode = xmlNode->FirstChildElement("paymentDate");

   if(paymentDateNode){paymentDateIsNull_ = false;}
   else{paymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDateNode , address : " << paymentDateNode << std::endl;
   #endif
   if(paymentDateNode)
   {
       paymentDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(paymentDateNode));
   }

   //forwardFlagNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardFlagNode = xmlNode->FirstChildElement("forwardFlag");

   if(forwardFlagNode){forwardFlagIsNull_ = false;}
   else{forwardFlagIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardFlagNode , address : " << forwardFlagNode << std::endl;
   #endif
   if(forwardFlagNode)
   {
       forwardFlag_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(forwardFlagNode));
   }

   //forwardPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardPointNode = xmlNode->FirstChildElement("forwardPoint");

   if(forwardPointNode){forwardPointIsNull_ = false;}
   else{forwardPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardPointNode , address : " << forwardPointNode << std::endl;
   #endif
   if(forwardPointNode)
   {
       forwardPoint_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(forwardPointNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getTargetNotional()
{
   if(!this->targetNotionalIsNull_){
        return this->targetNotional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getTargetCurrency()
{
   if(!this->targetCurrencyIsNull_){
        return this->targetCurrency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getBaseNotional()
{
   if(!this->baseNotionalIsNull_){
        return this->baseNotional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getBaseCurrency()
{
   if(!this->baseCurrencyIsNull_){
        return this->baseCurrency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getExchangeType()
{
   if(!this->exchangeTypeIsNull_){
        return this->exchangeType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getExchangeRate()
{
   if(!this->exchangeRateIsNull_){
        return this->exchangeRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getCalculationDate()
{
   if(!this->calculationDateIsNull_){
        return this->calculationDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getPaymentDays()
{
   if(!this->paymentDaysIsNull_){
        return this->paymentDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        return this->paymentDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getForwardFlag()
{
   if(!this->forwardFlagIsNull_){
        return this->forwardFlag_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Fx_exchangeLeg::getForwardPoint()
{
   if(!this->forwardPointIsNull_){
        return this->forwardPoint_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

