// SinglePayment.cpp 
#include "SinglePayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SinglePayment::SinglePayment(TiXmlNode* xmlNode)
: PaymentBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustablePaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustablePaymentDateNode = xmlNode->FirstChildElement("adjustablePaymentDate");

   if(adjustablePaymentDateNode){adjustablePaymentDateIsNull_ = false;}
   else{adjustablePaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustablePaymentDateNode , address : " << adjustablePaymentDateNode << std::endl;
   #endif
   if(adjustablePaymentDateNode)
   {
      if(adjustablePaymentDateNode->Attribute("href") || adjustablePaymentDateNode->Attribute("id"))
      {
          if(adjustablePaymentDateNode->Attribute("id"))
          {
             adjustablePaymentDateIDRef_ = adjustablePaymentDateNode->Attribute("id");
             adjustablePaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustablePaymentDateNode));
             adjustablePaymentDate_->setID(adjustablePaymentDateIDRef_);
             IDManager::instance().setID(adjustablePaymentDateIDRef_,adjustablePaymentDate_);
          }
          else if(adjustablePaymentDateNode->Attribute("href")) { adjustablePaymentDateIDRef_ = adjustablePaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustablePaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustablePaymentDateNode));}
   }

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

   //fixedAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedAmountNode = xmlNode->FirstChildElement("fixedAmount");

   if(fixedAmountNode){fixedAmountIsNull_ = false;}
   else{fixedAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedAmountNode , address : " << fixedAmountNode << std::endl;
   #endif
   if(fixedAmountNode)
   {
      if(fixedAmountNode->Attribute("href") || fixedAmountNode->Attribute("id"))
      {
          if(fixedAmountNode->Attribute("id"))
          {
             fixedAmountIDRef_ = fixedAmountNode->Attribute("id");
             fixedAmount_ = boost::shared_ptr<Money>(new Money(fixedAmountNode));
             fixedAmount_->setID(fixedAmountIDRef_);
             IDManager::instance().setID(fixedAmountIDRef_,fixedAmount_);
          }
          else if(fixedAmountNode->Attribute("href")) { fixedAmountIDRef_ = fixedAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedAmount_ = boost::shared_ptr<Money>(new Money(fixedAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> SinglePayment::getAdjustablePaymentDate()
{
   if(!this->adjustablePaymentDateIsNull_){
        if(adjustablePaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustablePaymentDateIDRef_));
        }else{
             return this->adjustablePaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> SinglePayment::getAdjustedPaymentDate()
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
boost::shared_ptr<Money> SinglePayment::getFixedAmount()
{
   if(!this->fixedAmountIsNull_){
        if(fixedAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(fixedAmountIDRef_));
        }else{
             return this->fixedAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

