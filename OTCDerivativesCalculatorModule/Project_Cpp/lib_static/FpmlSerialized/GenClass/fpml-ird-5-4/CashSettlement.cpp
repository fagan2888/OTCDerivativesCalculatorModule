// CashSettlement.cpp 
#include "CashSettlement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashSettlement::CashSettlement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cashSettlementValuationTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementValuationTimeNode = xmlNode->FirstChildElement("cashSettlementValuationTime");

   if(cashSettlementValuationTimeNode){cashSettlementValuationTimeIsNull_ = false;}
   else{cashSettlementValuationTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementValuationTimeNode , address : " << cashSettlementValuationTimeNode << std::endl;
   #endif
   if(cashSettlementValuationTimeNode)
   {
      if(cashSettlementValuationTimeNode->Attribute("href") || cashSettlementValuationTimeNode->Attribute("id"))
      {
          if(cashSettlementValuationTimeNode->Attribute("id"))
          {
             cashSettlementValuationTimeIDRef_ = cashSettlementValuationTimeNode->Attribute("id");
             cashSettlementValuationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(cashSettlementValuationTimeNode));
             cashSettlementValuationTime_->setID(cashSettlementValuationTimeIDRef_);
             IDManager::instance().setID(cashSettlementValuationTimeIDRef_,cashSettlementValuationTime_);
          }
          else if(cashSettlementValuationTimeNode->Attribute("href")) { cashSettlementValuationTimeIDRef_ = cashSettlementValuationTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementValuationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(cashSettlementValuationTimeNode));}
   }

   //cashSettlementValuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementValuationDateNode = xmlNode->FirstChildElement("cashSettlementValuationDate");

   if(cashSettlementValuationDateNode){cashSettlementValuationDateIsNull_ = false;}
   else{cashSettlementValuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementValuationDateNode , address : " << cashSettlementValuationDateNode << std::endl;
   #endif
   if(cashSettlementValuationDateNode)
   {
      if(cashSettlementValuationDateNode->Attribute("href") || cashSettlementValuationDateNode->Attribute("id"))
      {
          if(cashSettlementValuationDateNode->Attribute("id"))
          {
             cashSettlementValuationDateIDRef_ = cashSettlementValuationDateNode->Attribute("id");
             cashSettlementValuationDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(cashSettlementValuationDateNode));
             cashSettlementValuationDate_->setID(cashSettlementValuationDateIDRef_);
             IDManager::instance().setID(cashSettlementValuationDateIDRef_,cashSettlementValuationDate_);
          }
          else if(cashSettlementValuationDateNode->Attribute("href")) { cashSettlementValuationDateIDRef_ = cashSettlementValuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementValuationDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(cashSettlementValuationDateNode));}
   }

   //cashSettlementPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementPaymentDateNode = xmlNode->FirstChildElement("cashSettlementPaymentDate");

   if(cashSettlementPaymentDateNode){cashSettlementPaymentDateIsNull_ = false;}
   else{cashSettlementPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementPaymentDateNode , address : " << cashSettlementPaymentDateNode << std::endl;
   #endif
   if(cashSettlementPaymentDateNode)
   {
      if(cashSettlementPaymentDateNode->Attribute("href") || cashSettlementPaymentDateNode->Attribute("id"))
      {
          if(cashSettlementPaymentDateNode->Attribute("id"))
          {
             cashSettlementPaymentDateIDRef_ = cashSettlementPaymentDateNode->Attribute("id");
             cashSettlementPaymentDate_ = boost::shared_ptr<CashSettlementPaymentDate>(new CashSettlementPaymentDate(cashSettlementPaymentDateNode));
             cashSettlementPaymentDate_->setID(cashSettlementPaymentDateIDRef_);
             IDManager::instance().setID(cashSettlementPaymentDateIDRef_,cashSettlementPaymentDate_);
          }
          else if(cashSettlementPaymentDateNode->Attribute("href")) { cashSettlementPaymentDateIDRef_ = cashSettlementPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementPaymentDate_ = boost::shared_ptr<CashSettlementPaymentDate>(new CashSettlementPaymentDate(cashSettlementPaymentDateNode));}
   }

   //cashPriceMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashPriceMethodNode = xmlNode->FirstChildElement("cashPriceMethod");

   if(cashPriceMethodNode){cashPriceMethodIsNull_ = false;}
   else{cashPriceMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashPriceMethodNode , address : " << cashPriceMethodNode << std::endl;
   #endif
   if(cashPriceMethodNode)
   {
      if(cashPriceMethodNode->Attribute("href") || cashPriceMethodNode->Attribute("id"))
      {
          if(cashPriceMethodNode->Attribute("id"))
          {
             cashPriceMethodIDRef_ = cashPriceMethodNode->Attribute("id");
             cashPriceMethod_ = boost::shared_ptr<CashPriceMethod>(new CashPriceMethod(cashPriceMethodNode));
             cashPriceMethod_->setID(cashPriceMethodIDRef_);
             IDManager::instance().setID(cashPriceMethodIDRef_,cashPriceMethod_);
          }
          else if(cashPriceMethodNode->Attribute("href")) { cashPriceMethodIDRef_ = cashPriceMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashPriceMethod_ = boost::shared_ptr<CashPriceMethod>(new CashPriceMethod(cashPriceMethodNode));}
   }

   //cashPriceAlternateMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashPriceAlternateMethodNode = xmlNode->FirstChildElement("cashPriceAlternateMethod");

   if(cashPriceAlternateMethodNode){cashPriceAlternateMethodIsNull_ = false;}
   else{cashPriceAlternateMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashPriceAlternateMethodNode , address : " << cashPriceAlternateMethodNode << std::endl;
   #endif
   if(cashPriceAlternateMethodNode)
   {
      if(cashPriceAlternateMethodNode->Attribute("href") || cashPriceAlternateMethodNode->Attribute("id"))
      {
          if(cashPriceAlternateMethodNode->Attribute("id"))
          {
             cashPriceAlternateMethodIDRef_ = cashPriceAlternateMethodNode->Attribute("id");
             cashPriceAlternateMethod_ = boost::shared_ptr<CashPriceMethod>(new CashPriceMethod(cashPriceAlternateMethodNode));
             cashPriceAlternateMethod_->setID(cashPriceAlternateMethodIDRef_);
             IDManager::instance().setID(cashPriceAlternateMethodIDRef_,cashPriceAlternateMethod_);
          }
          else if(cashPriceAlternateMethodNode->Attribute("href")) { cashPriceAlternateMethodIDRef_ = cashPriceAlternateMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashPriceAlternateMethod_ = boost::shared_ptr<CashPriceMethod>(new CashPriceMethod(cashPriceAlternateMethodNode));}
   }

   //parYieldCurveAdjustedMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parYieldCurveAdjustedMethodNode = xmlNode->FirstChildElement("parYieldCurveAdjustedMethod");

   if(parYieldCurveAdjustedMethodNode){parYieldCurveAdjustedMethodIsNull_ = false;}
   else{parYieldCurveAdjustedMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parYieldCurveAdjustedMethodNode , address : " << parYieldCurveAdjustedMethodNode << std::endl;
   #endif
   if(parYieldCurveAdjustedMethodNode)
   {
      if(parYieldCurveAdjustedMethodNode->Attribute("href") || parYieldCurveAdjustedMethodNode->Attribute("id"))
      {
          if(parYieldCurveAdjustedMethodNode->Attribute("id"))
          {
             parYieldCurveAdjustedMethodIDRef_ = parYieldCurveAdjustedMethodNode->Attribute("id");
             parYieldCurveAdjustedMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(parYieldCurveAdjustedMethodNode));
             parYieldCurveAdjustedMethod_->setID(parYieldCurveAdjustedMethodIDRef_);
             IDManager::instance().setID(parYieldCurveAdjustedMethodIDRef_,parYieldCurveAdjustedMethod_);
          }
          else if(parYieldCurveAdjustedMethodNode->Attribute("href")) { parYieldCurveAdjustedMethodIDRef_ = parYieldCurveAdjustedMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parYieldCurveAdjustedMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(parYieldCurveAdjustedMethodNode));}
   }

   //zeroCouponYieldAdjustedMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* zeroCouponYieldAdjustedMethodNode = xmlNode->FirstChildElement("zeroCouponYieldAdjustedMethod");

   if(zeroCouponYieldAdjustedMethodNode){zeroCouponYieldAdjustedMethodIsNull_ = false;}
   else{zeroCouponYieldAdjustedMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- zeroCouponYieldAdjustedMethodNode , address : " << zeroCouponYieldAdjustedMethodNode << std::endl;
   #endif
   if(zeroCouponYieldAdjustedMethodNode)
   {
      if(zeroCouponYieldAdjustedMethodNode->Attribute("href") || zeroCouponYieldAdjustedMethodNode->Attribute("id"))
      {
          if(zeroCouponYieldAdjustedMethodNode->Attribute("id"))
          {
             zeroCouponYieldAdjustedMethodIDRef_ = zeroCouponYieldAdjustedMethodNode->Attribute("id");
             zeroCouponYieldAdjustedMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(zeroCouponYieldAdjustedMethodNode));
             zeroCouponYieldAdjustedMethod_->setID(zeroCouponYieldAdjustedMethodIDRef_);
             IDManager::instance().setID(zeroCouponYieldAdjustedMethodIDRef_,zeroCouponYieldAdjustedMethod_);
          }
          else if(zeroCouponYieldAdjustedMethodNode->Attribute("href")) { zeroCouponYieldAdjustedMethodIDRef_ = zeroCouponYieldAdjustedMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { zeroCouponYieldAdjustedMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(zeroCouponYieldAdjustedMethodNode));}
   }

   //parYieldCurveUnadjustedMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parYieldCurveUnadjustedMethodNode = xmlNode->FirstChildElement("parYieldCurveUnadjustedMethod");

   if(parYieldCurveUnadjustedMethodNode){parYieldCurveUnadjustedMethodIsNull_ = false;}
   else{parYieldCurveUnadjustedMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parYieldCurveUnadjustedMethodNode , address : " << parYieldCurveUnadjustedMethodNode << std::endl;
   #endif
   if(parYieldCurveUnadjustedMethodNode)
   {
      if(parYieldCurveUnadjustedMethodNode->Attribute("href") || parYieldCurveUnadjustedMethodNode->Attribute("id"))
      {
          if(parYieldCurveUnadjustedMethodNode->Attribute("id"))
          {
             parYieldCurveUnadjustedMethodIDRef_ = parYieldCurveUnadjustedMethodNode->Attribute("id");
             parYieldCurveUnadjustedMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(parYieldCurveUnadjustedMethodNode));
             parYieldCurveUnadjustedMethod_->setID(parYieldCurveUnadjustedMethodIDRef_);
             IDManager::instance().setID(parYieldCurveUnadjustedMethodIDRef_,parYieldCurveUnadjustedMethod_);
          }
          else if(parYieldCurveUnadjustedMethodNode->Attribute("href")) { parYieldCurveUnadjustedMethodIDRef_ = parYieldCurveUnadjustedMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parYieldCurveUnadjustedMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(parYieldCurveUnadjustedMethodNode));}
   }

   //crossCurrencyMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* crossCurrencyMethodNode = xmlNode->FirstChildElement("crossCurrencyMethod");

   if(crossCurrencyMethodNode){crossCurrencyMethodIsNull_ = false;}
   else{crossCurrencyMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- crossCurrencyMethodNode , address : " << crossCurrencyMethodNode << std::endl;
   #endif
   if(crossCurrencyMethodNode)
   {
      if(crossCurrencyMethodNode->Attribute("href") || crossCurrencyMethodNode->Attribute("id"))
      {
          if(crossCurrencyMethodNode->Attribute("id"))
          {
             crossCurrencyMethodIDRef_ = crossCurrencyMethodNode->Attribute("id");
             crossCurrencyMethod_ = boost::shared_ptr<CrossCurrencyMethod>(new CrossCurrencyMethod(crossCurrencyMethodNode));
             crossCurrencyMethod_->setID(crossCurrencyMethodIDRef_);
             IDManager::instance().setID(crossCurrencyMethodIDRef_,crossCurrencyMethod_);
          }
          else if(crossCurrencyMethodNode->Attribute("href")) { crossCurrencyMethodIDRef_ = crossCurrencyMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { crossCurrencyMethod_ = boost::shared_ptr<CrossCurrencyMethod>(new CrossCurrencyMethod(crossCurrencyMethodNode));}
   }

   //collateralizedCashPriceMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* collateralizedCashPriceMethodNode = xmlNode->FirstChildElement("collateralizedCashPriceMethod");

   if(collateralizedCashPriceMethodNode){collateralizedCashPriceMethodIsNull_ = false;}
   else{collateralizedCashPriceMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralizedCashPriceMethodNode , address : " << collateralizedCashPriceMethodNode << std::endl;
   #endif
   if(collateralizedCashPriceMethodNode)
   {
      if(collateralizedCashPriceMethodNode->Attribute("href") || collateralizedCashPriceMethodNode->Attribute("id"))
      {
          if(collateralizedCashPriceMethodNode->Attribute("id"))
          {
             collateralizedCashPriceMethodIDRef_ = collateralizedCashPriceMethodNode->Attribute("id");
             collateralizedCashPriceMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(collateralizedCashPriceMethodNode));
             collateralizedCashPriceMethod_->setID(collateralizedCashPriceMethodIDRef_);
             IDManager::instance().setID(collateralizedCashPriceMethodIDRef_,collateralizedCashPriceMethod_);
          }
          else if(collateralizedCashPriceMethodNode->Attribute("href")) { collateralizedCashPriceMethodIDRef_ = collateralizedCashPriceMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { collateralizedCashPriceMethod_ = boost::shared_ptr<YieldCurveMethod>(new YieldCurveMethod(collateralizedCashPriceMethodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BusinessCenterTime> CashSettlement::getCashSettlementValuationTime()
{
   if(!this->cashSettlementValuationTimeIsNull_){
        if(cashSettlementValuationTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(cashSettlementValuationTimeIDRef_));
        }else{
             return this->cashSettlementValuationTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<RelativeDateOffset> CashSettlement::getCashSettlementValuationDate()
{
   if(!this->cashSettlementValuationDateIsNull_){
        if(cashSettlementValuationDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(cashSettlementValuationDateIDRef_));
        }else{
             return this->cashSettlementValuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<CashSettlementPaymentDate> CashSettlement::getCashSettlementPaymentDate()
{
   if(!this->cashSettlementPaymentDateIsNull_){
        if(cashSettlementPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<CashSettlementPaymentDate>(IDManager::instance().getID(cashSettlementPaymentDateIDRef_));
        }else{
             return this->cashSettlementPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashSettlementPaymentDate>();
   }
}
boost::shared_ptr<CashPriceMethod> CashSettlement::getCashPriceMethod()
{
   if(!this->cashPriceMethodIsNull_){
        if(cashPriceMethodIDRef_ != ""){
             return boost::shared_static_cast<CashPriceMethod>(IDManager::instance().getID(cashPriceMethodIDRef_));
        }else{
             return this->cashPriceMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashPriceMethod>();
   }
}
boost::shared_ptr<CashPriceMethod> CashSettlement::getCashPriceAlternateMethod()
{
   if(!this->cashPriceAlternateMethodIsNull_){
        if(cashPriceAlternateMethodIDRef_ != ""){
             return boost::shared_static_cast<CashPriceMethod>(IDManager::instance().getID(cashPriceAlternateMethodIDRef_));
        }else{
             return this->cashPriceAlternateMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashPriceMethod>();
   }
}
boost::shared_ptr<YieldCurveMethod> CashSettlement::getParYieldCurveAdjustedMethod()
{
   if(!this->parYieldCurveAdjustedMethodIsNull_){
        if(parYieldCurveAdjustedMethodIDRef_ != ""){
             return boost::shared_static_cast<YieldCurveMethod>(IDManager::instance().getID(parYieldCurveAdjustedMethodIDRef_));
        }else{
             return this->parYieldCurveAdjustedMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldCurveMethod>();
   }
}
boost::shared_ptr<YieldCurveMethod> CashSettlement::getZeroCouponYieldAdjustedMethod()
{
   if(!this->zeroCouponYieldAdjustedMethodIsNull_){
        if(zeroCouponYieldAdjustedMethodIDRef_ != ""){
             return boost::shared_static_cast<YieldCurveMethod>(IDManager::instance().getID(zeroCouponYieldAdjustedMethodIDRef_));
        }else{
             return this->zeroCouponYieldAdjustedMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldCurveMethod>();
   }
}
boost::shared_ptr<YieldCurveMethod> CashSettlement::getParYieldCurveUnadjustedMethod()
{
   if(!this->parYieldCurveUnadjustedMethodIsNull_){
        if(parYieldCurveUnadjustedMethodIDRef_ != ""){
             return boost::shared_static_cast<YieldCurveMethod>(IDManager::instance().getID(parYieldCurveUnadjustedMethodIDRef_));
        }else{
             return this->parYieldCurveUnadjustedMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldCurveMethod>();
   }
}
boost::shared_ptr<CrossCurrencyMethod> CashSettlement::getCrossCurrencyMethod()
{
   if(!this->crossCurrencyMethodIsNull_){
        if(crossCurrencyMethodIDRef_ != ""){
             return boost::shared_static_cast<CrossCurrencyMethod>(IDManager::instance().getID(crossCurrencyMethodIDRef_));
        }else{
             return this->crossCurrencyMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CrossCurrencyMethod>();
   }
}
boost::shared_ptr<YieldCurveMethod> CashSettlement::getCollateralizedCashPriceMethod()
{
   if(!this->collateralizedCashPriceMethodIsNull_){
        if(collateralizedCashPriceMethodIDRef_ != ""){
             return boost::shared_static_cast<YieldCurveMethod>(IDManager::instance().getID(collateralizedCashPriceMethodIDRef_));
        }else{
             return this->collateralizedCashPriceMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldCurveMethod>();
   }
}
}

