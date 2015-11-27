// FixedPaymentAmount.cpp 
#include "FixedPaymentAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedPaymentAmount::FixedPaymentAmount(TiXmlNode* xmlNode)
: PaymentBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
             paymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(paymentAmountNode));
             paymentAmount_->setID(paymentAmountIDRef_);
             IDManager::instance().setID(paymentAmountIDRef_,paymentAmount_);
          }
          else if(paymentAmountNode->Attribute("href")) { paymentAmountIDRef_ = paymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(paymentAmountNode));}
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
             paymentDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(paymentDateNode));
             paymentDate_->setID(paymentDateIDRef_);
             IDManager::instance().setID(paymentDateIDRef_,paymentDate_);
          }
          else if(paymentDateNode->Attribute("href")) { paymentDateIDRef_ = paymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(paymentDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> FixedPaymentAmount::getPaymentAmount()
{
   if(!this->paymentAmountIsNull_){
        if(paymentAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(paymentAmountIDRef_));
        }else{
             return this->paymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<RelativeDateOffset> FixedPaymentAmount::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        if(paymentDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(paymentDateIDRef_));
        }else{
             return this->paymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
}

