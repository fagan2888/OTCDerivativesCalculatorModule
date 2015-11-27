// PositivePayment.cpp 
#include "PositivePayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PositivePayment::PositivePayment(TiXmlNode* xmlNode)
: PaymentBaseExtended(xmlNode)
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
             paymentAmount_ = boost::shared_ptr<PositiveMoney>(new PositiveMoney(paymentAmountNode));
             paymentAmount_->setID(paymentAmountIDRef_);
             IDManager::instance().setID(paymentAmountIDRef_,paymentAmount_);
          }
          else if(paymentAmountNode->Attribute("href")) { paymentAmountIDRef_ = paymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentAmount_ = boost::shared_ptr<PositiveMoney>(new PositiveMoney(paymentAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveMoney> PositivePayment::getPaymentAmount()
{
   if(!this->paymentAmountIsNull_){
        if(paymentAmountIDRef_ != ""){
             return boost::shared_static_cast<PositiveMoney>(IDManager::instance().getID(paymentAmountIDRef_));
        }else{
             return this->paymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveMoney>();
   }
}
}

