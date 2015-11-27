// DividendPeriodPayment.cpp 
#include "DividendPeriodPayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendPeriodPayment::DividendPeriodPayment(TiXmlNode* xmlNode)
: DividendPeriod(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixedStrikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedStrikeNode = xmlNode->FirstChildElement("fixedStrike");

   if(fixedStrikeNode){fixedStrikeIsNull_ = false;}
   else{fixedStrikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedStrikeNode , address : " << fixedStrikeNode << std::endl;
   #endif
   if(fixedStrikeNode)
   {
      if(fixedStrikeNode->Attribute("href") || fixedStrikeNode->Attribute("id"))
      {
          if(fixedStrikeNode->Attribute("id"))
          {
             fixedStrikeIDRef_ = fixedStrikeNode->Attribute("id");
             fixedStrike_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(fixedStrikeNode));
             fixedStrike_->setID(fixedStrikeIDRef_);
             IDManager::instance().setID(fixedStrikeIDRef_,fixedStrike_);
          }
          else if(fixedStrikeNode->Attribute("href")) { fixedStrikeIDRef_ = fixedStrikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedStrike_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(fixedStrikeNode));}
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
      if(paymentDateNode->Attribute("href") || paymentDateNode->Attribute("id"))
      {
          if(paymentDateNode->Attribute("id"))
          {
             paymentDateIDRef_ = paymentDateNode->Attribute("id");
             paymentDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(paymentDateNode));
             paymentDate_->setID(paymentDateIDRef_);
             IDManager::instance().setID(paymentDateIDRef_,paymentDate_);
          }
          else if(paymentDateNode->Attribute("href")) { paymentDateIDRef_ = paymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(paymentDateNode));}
   }

   //valuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationDateNode = xmlNode->FirstChildElement("valuationDate");

   if(valuationDateNode){valuationDateIsNull_ = false;}
   else{valuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationDateNode , address : " << valuationDateNode << std::endl;
   #endif
   if(valuationDateNode)
   {
      if(valuationDateNode->Attribute("href") || valuationDateNode->Attribute("id"))
      {
          if(valuationDateNode->Attribute("id"))
          {
             valuationDateIDRef_ = valuationDateNode->Attribute("id");
             valuationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(valuationDateNode));
             valuationDate_->setID(valuationDateIDRef_);
             IDManager::instance().setID(valuationDateIDRef_,valuationDate_);
          }
          else if(valuationDateNode->Attribute("href")) { valuationDateIDRef_ = valuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(valuationDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveDecimal> DividendPeriodPayment::getFixedStrike()
{
   if(!this->fixedStrikeIsNull_){
        if(fixedStrikeIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(fixedStrikeIDRef_));
        }else{
             return this->fixedStrike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> DividendPeriodPayment::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        if(paymentDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(paymentDateIDRef_));
        }else{
             return this->paymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> DividendPeriodPayment::getValuationDate()
{
   if(!this->valuationDateIsNull_){
        if(valuationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(valuationDateIDRef_));
        }else{
             return this->valuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

