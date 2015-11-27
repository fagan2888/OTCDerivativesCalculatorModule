// PendingPayment.cpp 
#include "PendingPayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PendingPayment::PendingPayment(TiXmlNode* xmlNode)
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
             paymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(paymentDateNode));
             paymentDate_->setID(paymentDateIDRef_);
             IDManager::instance().setID(paymentDateIDRef_,paymentDate_);
          }
          else if(paymentDateNode->Attribute("href")) { paymentDateIDRef_ = paymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(paymentDateNode));}
   }

   //amountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountNode = xmlNode->FirstChildElement("amount");

   if(amountNode){amountIsNull_ = false;}
   else{amountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountNode , address : " << amountNode << std::endl;
   #endif
   if(amountNode)
   {
      if(amountNode->Attribute("href") || amountNode->Attribute("id"))
      {
          if(amountNode->Attribute("id"))
          {
             amountIDRef_ = amountNode->Attribute("id");
             amount_ = boost::shared_ptr<Money>(new Money(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<Money>(new Money(amountNode));}
   }

   //accruedInterestNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accruedInterestNode = xmlNode->FirstChildElement("accruedInterest");

   if(accruedInterestNode){accruedInterestIsNull_ = false;}
   else{accruedInterestIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accruedInterestNode , address : " << accruedInterestNode << std::endl;
   #endif
   if(accruedInterestNode)
   {
      if(accruedInterestNode->Attribute("href") || accruedInterestNode->Attribute("id"))
      {
          if(accruedInterestNode->Attribute("id"))
          {
             accruedInterestIDRef_ = accruedInterestNode->Attribute("id");
             accruedInterest_ = boost::shared_ptr<Money>(new Money(accruedInterestNode));
             accruedInterest_->setID(accruedInterestIDRef_);
             IDManager::instance().setID(accruedInterestIDRef_,accruedInterest_);
          }
          else if(accruedInterestNode->Attribute("href")) { accruedInterestIDRef_ = accruedInterestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accruedInterest_ = boost::shared_ptr<Money>(new Money(accruedInterestNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> PendingPayment::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        if(paymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(paymentDateIDRef_));
        }else{
             return this->paymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<Money> PendingPayment::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<Money> PendingPayment::getAccruedInterest()
{
   if(!this->accruedInterestIsNull_){
        if(accruedInterestIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(accruedInterestIDRef_));
        }else{
             return this->accruedInterest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

