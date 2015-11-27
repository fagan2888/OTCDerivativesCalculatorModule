// PaymentDetail.cpp 
#include "PaymentDetail.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PaymentDetail::PaymentDetail(TiXmlNode* xmlNode)
: PaymentBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //paymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentAmountNode = xmlNode->FirstChildElement("paymentAmount");

   if(paymentAmountNode){paymentAmountIsNull_ = false;}
   else{paymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentAmountNode , address : " << paymentAmountNode << std::endl;
   #endif
   if(paymentAmountNode)
   {
      if(paymentAmountNode->Attribute("href") || paymentAmountNode->Attribute("id"))
      {
          if(paymentAmountNode->Attribute("id"))
          {
             paymentAmountIDRef_ = paymentAmountNode->Attribute("id");
             paymentAmount_ = boost::shared_ptr<Money>(new Money(paymentAmountNode));
             paymentAmount_->setID(paymentAmountIDRef_);
             IDManager::instance().setID(paymentAmountIDRef_,paymentAmount_);
          }
          else if(paymentAmountNode->Attribute("href")) { paymentAmountIDRef_ = paymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentAmount_ = boost::shared_ptr<Money>(new Money(paymentAmountNode));}
   }

   //paymentRuleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentRuleNode = xmlNode->FirstChildElement("paymentRule");

   if(paymentRuleNode){paymentRuleIsNull_ = false;}
   else{paymentRuleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentRuleNode , address : " << paymentRuleNode << std::endl;
   #endif
   if(paymentRuleNode)
   {
      if(paymentRuleNode->Attribute("href") || paymentRuleNode->Attribute("id"))
      {
          if(paymentRuleNode->Attribute("id"))
          {
             paymentRuleIDRef_ = paymentRuleNode->Attribute("id");
             paymentRule_ = boost::shared_ptr<PaymentRule>(new PaymentRule(paymentRuleNode));
             paymentRule_->setID(paymentRuleIDRef_);
             IDManager::instance().setID(paymentRuleIDRef_,paymentRule_);
          }
          else if(paymentRuleNode->Attribute("href")) { paymentRuleIDRef_ = paymentRuleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentRule_ = boost::shared_ptr<PaymentRule>(new PaymentRule(paymentRuleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> PaymentDetail::getPaymentDate()
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
boost::shared_ptr<Money> PaymentDetail::getPaymentAmount()
{
   if(!this->paymentAmountIsNull_){
        if(paymentAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(paymentAmountIDRef_));
        }else{
             return this->paymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<PaymentRule> PaymentDetail::getPaymentRule()
{
   if(!this->paymentRuleIsNull_){
        if(paymentRuleIDRef_ != ""){
             return boost::shared_static_cast<PaymentRule>(IDManager::instance().getID(paymentRuleIDRef_));
        }else{
             return this->paymentRule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PaymentRule>();
   }
}
}

