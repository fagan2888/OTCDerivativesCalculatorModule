// ProtectionTerms.cpp 
#include "ProtectionTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ProtectionTerms::ProtectionTerms(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //creditEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventsNode = xmlNode->FirstChildElement("creditEvents");

   if(creditEventsNode){creditEventsIsNull_ = false;}
   else{creditEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventsNode , address : " << creditEventsNode << std::endl;
   #endif
   if(creditEventsNode)
   {
       creditEvents_ = boost::shared_ptr<CreditEvents>(new CreditEvents(creditEventsNode));
   }

   //obligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationsNode = xmlNode->FirstChildElement("obligations");

   if(obligationsNode){obligationsIsNull_ = false;}
   else{obligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationsNode , address : " << obligationsNode << std::endl;
   #endif
   if(obligationsNode)
   {
       obligations_ = boost::shared_ptr<Obligations>(new Obligations(obligationsNode));
   }

   //accrualCouponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accrualCouponNode = xmlNode->FirstChildElement("accrualCoupon");

   if(accrualCouponNode){accrualCouponIsNull_ = false;}
   else{accrualCouponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accrualCouponNode , address : " << accrualCouponNode << std::endl;
   #endif
   if(accrualCouponNode)
   {
       accrualCoupon_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(accrualCouponNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CalculationAmount> ProtectionTerms::getCalculationAmount()
{
   if(!this->calculationAmountIsNull_){
        return this->calculationAmount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAmount>();
   }
}
boost::shared_ptr<CreditEvents> ProtectionTerms::getCreditEvents()
{
   if(!this->creditEventsIsNull_){
        return this->creditEvents_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEvents>();
   }
}
boost::shared_ptr<Obligations> ProtectionTerms::getObligations()
{
   if(!this->obligationsIsNull_){
        return this->obligations_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Obligations>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ProtectionTerms::getAccrualCoupon()
{
   if(!this->accrualCouponIsNull_){
        return this->accrualCoupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

