// PercentageRule.cpp 
#include "PercentageRule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PercentageRule::PercentageRule(TiXmlNode* xmlNode)
: PaymentRule(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //paymentPercentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentPercentNode = xmlNode->FirstChildElement("paymentPercent");

   if(paymentPercentNode){paymentPercentIsNull_ = false;}
   else{paymentPercentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentPercentNode , address : " << paymentPercentNode << std::endl;
   #endif
   if(paymentPercentNode)
   {
      if(paymentPercentNode->Attribute("href") || paymentPercentNode->Attribute("id"))
      {
          if(paymentPercentNode->Attribute("id"))
          {
             paymentPercentIDRef_ = paymentPercentNode->Attribute("id");
             paymentPercent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(paymentPercentNode));
             paymentPercent_->setID(paymentPercentIDRef_);
             IDManager::instance().setID(paymentPercentIDRef_,paymentPercent_);
          }
          else if(paymentPercentNode->Attribute("href")) { paymentPercentIDRef_ = paymentPercentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentPercent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(paymentPercentNode));}
   }

   //notionalAmountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAmountReferenceNode = xmlNode->FirstChildElement("notionalAmountReference");

   if(notionalAmountReferenceNode){notionalAmountReferenceIsNull_ = false;}
   else{notionalAmountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAmountReferenceNode , address : " << notionalAmountReferenceNode << std::endl;
   #endif
   if(notionalAmountReferenceNode)
   {
      if(notionalAmountReferenceNode->Attribute("href") || notionalAmountReferenceNode->Attribute("id"))
      {
          if(notionalAmountReferenceNode->Attribute("id"))
          {
             notionalAmountReferenceIDRef_ = notionalAmountReferenceNode->Attribute("id");
             notionalAmountReference_ = boost::shared_ptr<NotionalAmountReference>(new NotionalAmountReference(notionalAmountReferenceNode));
             notionalAmountReference_->setID(notionalAmountReferenceIDRef_);
             IDManager::instance().setID(notionalAmountReferenceIDRef_,notionalAmountReference_);
          }
          else if(notionalAmountReferenceNode->Attribute("href")) { notionalAmountReferenceIDRef_ = notionalAmountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAmountReference_ = boost::shared_ptr<NotionalAmountReference>(new NotionalAmountReference(notionalAmountReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> PercentageRule::getPaymentPercent()
{
   if(!this->paymentPercentIsNull_){
        if(paymentPercentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(paymentPercentIDRef_));
        }else{
             return this->paymentPercent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<NotionalAmountReference> PercentageRule::getNotionalAmountReference()
{
   if(!this->notionalAmountReferenceIsNull_){
        if(notionalAmountReferenceIDRef_ != ""){
             return boost::shared_static_cast<NotionalAmountReference>(IDManager::instance().getID(notionalAmountReferenceIDRef_));
        }else{
             return this->notionalAmountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotionalAmountReference>();
   }
}
}

