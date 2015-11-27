// RateCalculation.cpp 
#include "RateCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RateCalculation::RateCalculation(TiXmlNode* xmlNode)
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

   //calculationAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAmountNode = xmlNode->FirstChildElement("calculationAmount");

   if(calculationAmountNode){calculationAmountIsNull_ = false;}
   else{calculationAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAmountNode , address : " << calculationAmountNode << std::endl;
   #endif
   if(calculationAmountNode)
   {
       calculationAmount_ = boost::shared_ptr<CalculationAmount>(new CalculationAmount(calculationAmountNode));
   }

   //calculationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationStartDateNode = xmlNode->FirstChildElement("calculationStartDate");

   if(calculationStartDateNode){calculationStartDateIsNull_ = false;}
   else{calculationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationStartDateNode , address : " << calculationStartDateNode << std::endl;
   #endif
   if(calculationStartDateNode)
   {
       calculationStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(calculationStartDateNode));
   }

   //calculationEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationEndDateNode = xmlNode->FirstChildElement("calculationEndDate");

   if(calculationEndDateNode){calculationEndDateIsNull_ = false;}
   else{calculationEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationEndDateNode , address : " << calculationEndDateNode << std::endl;
   #endif
   if(calculationEndDateNode)
   {
       calculationEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(calculationEndDateNode));
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
       paymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(paymentDateNode));
   }

   //vanillaRateCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaRateCalculationNode = xmlNode->FirstChildElement("vanillaRateCalculation");

   if(vanillaRateCalculationNode){vanillaRateCalculationIsNull_ = false;}
   else{vanillaRateCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaRateCalculationNode , address : " << vanillaRateCalculationNode << std::endl;
   #endif
   if(vanillaRateCalculationNode)
   {
       vanillaRateCalculation_ = boost::shared_ptr<VanillaRateCalculation>(new VanillaRateCalculation(vanillaRateCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> RateCalculation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<CalculationAmount> RateCalculation::getCalculationAmount()
{
   if(!this->calculationAmountIsNull_){
        return this->calculationAmount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAmount>();
   }
}
boost::shared_ptr<XsdTypeDate> RateCalculation::getCalculationStartDate()
{
   if(!this->calculationStartDateIsNull_){
        return this->calculationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> RateCalculation::getCalculationEndDate()
{
   if(!this->calculationEndDateIsNull_){
        return this->calculationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> RateCalculation::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        return this->paymentDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<VanillaRateCalculation> RateCalculation::getVanillaRateCalculation()
{
   if(!this->vanillaRateCalculationIsNull_){
        return this->vanillaRateCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaRateCalculation>();
   }
}
}

