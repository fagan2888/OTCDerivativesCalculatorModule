// AdjustedPaymentDates.cpp 
#include "AdjustedPaymentDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustedPaymentDates::AdjustedPaymentDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustedPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedPaymentDateNode = xmlNode->FirstChildElement("adjustedPaymentDate");

   if(adjustedPaymentDateNode){adjustedPaymentDateIsNull_ = false;}
   else{adjustedPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedPaymentDateNode , address : " << adjustedPaymentDateNode << std::endl;
   #endif
   if(adjustedPaymentDateNode)
   {
      if(adjustedPaymentDateNode->Attribute("href") || adjustedPaymentDateNode->Attribute("id"))
      {
          if(adjustedPaymentDateNode->Attribute("id"))
          {
             adjustedPaymentDateIDRef_ = adjustedPaymentDateNode->Attribute("id");
             adjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPaymentDateNode));
             adjustedPaymentDate_->setID(adjustedPaymentDateIDRef_);
             IDManager::instance().setID(adjustedPaymentDateIDRef_,adjustedPaymentDate_);
          }
          else if(adjustedPaymentDateNode->Attribute("href")) { adjustedPaymentDateIDRef_ = adjustedPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPaymentDateNode));}
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> AdjustedPaymentDates::getAdjustedPaymentDate()
{
   if(!this->adjustedPaymentDateIsNull_){
        if(adjustedPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedPaymentDateIDRef_));
        }else{
             return this->adjustedPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<Money> AdjustedPaymentDates::getPaymentAmount()
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
}

