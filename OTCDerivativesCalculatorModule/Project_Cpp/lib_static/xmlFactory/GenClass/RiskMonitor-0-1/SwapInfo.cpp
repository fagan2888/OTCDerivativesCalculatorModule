// SwapInfo.cpp 
#include "SwapInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwapInfo::SwapInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
       notional_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(notionalNode));
   }

   //tradeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeDateNode = xmlNode->FirstChildElement("tradeDate");

   if(tradeDateNode){tradeDateIsNull_ = false;}
   else{tradeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeDateNode , address : " << tradeDateNode << std::endl;
   #endif
   if(tradeDateNode)
   {
       tradeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(tradeDateNode));
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
       effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));
   }

   //maturityDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityDateNode = xmlNode->FirstChildElement("maturityDate");

   if(maturityDateNode){maturityDateIsNull_ = false;}
   else{maturityDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityDateNode , address : " << maturityDateNode << std::endl;
   #endif
   if(maturityDateNode)
   {
       maturityDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityDateNode));
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

   //premiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumNode = xmlNode->FirstChildElement("premium");

   if(premiumNode){premiumIsNull_ = false;}
   else{premiumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
   #endif
   if(premiumNode)
   {
       premium_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(premiumNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> SwapInfo::getNotional()
{
   if(!this->notionalIsNull_){
        return this->notional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> SwapInfo::getTradeDate()
{
   if(!this->tradeDateIsNull_){
        return this->tradeDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> SwapInfo::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        return this->effectiveDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> SwapInfo::getMaturityDate()
{
   if(!this->maturityDateIsNull_){
        return this->maturityDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<CalculationAmount> SwapInfo::getCalculationAmount()
{
   if(!this->calculationAmountIsNull_){
        return this->calculationAmount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAmount>();
   }
}
boost::shared_ptr<XsdTypeDouble> SwapInfo::getPremium()
{
   if(!this->premiumIsNull_){
        return this->premium_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

