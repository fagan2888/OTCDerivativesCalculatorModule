// DateRelativeToPaymentDates.cpp 
#include "DateRelativeToPaymentDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateRelativeToPaymentDates::DateRelativeToPaymentDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //paymentDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDatesReferenceNode = xmlNode->FirstChildElement("paymentDatesReference");

   if(paymentDatesReferenceNode){paymentDatesReferenceIsNull_ = false;}
   else{paymentDatesReferenceIsNull_ = true;}

   if(paymentDatesReferenceNode)
   {
      for(paymentDatesReferenceNode; paymentDatesReferenceNode; paymentDatesReferenceNode = paymentDatesReferenceNode->NextSiblingElement("paymentDatesReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesReferenceNode , address : " << paymentDatesReferenceNode << std::endl;
          #endif
          if(paymentDatesReferenceNode->Attribute("href") || paymentDatesReferenceNode->Attribute("id"))
          {
              if(paymentDatesReferenceNode->Attribute("id"))
              {
                  paymentDatesReferenceIDRef_ = paymentDatesReferenceNode->Attribute("id");
                  paymentDatesReference_.push_back(boost::shared_ptr<PaymentDatesReference>(new PaymentDatesReference(paymentDatesReferenceNode)));
                  paymentDatesReference_.back()->setID(paymentDatesReferenceIDRef_);
                  IDManager::instance().setID(paymentDatesReferenceIDRef_, paymentDatesReference_.back());
              }
              else if(paymentDatesReferenceNode->Attribute("href")) { paymentDatesReferenceIDRef_ = paymentDatesReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { paymentDatesReference_.push_back(boost::shared_ptr<PaymentDatesReference>(new PaymentDatesReference(paymentDatesReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesReferenceNode , address : " << paymentDatesReferenceNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PaymentDatesReference>> DateRelativeToPaymentDates::getPaymentDatesReference()
{
   if(!this->paymentDatesReferenceIsNull_){
        if(paymentDatesReferenceIDRef_ != ""){
             return this->paymentDatesReference_;
        }else{
             return this->paymentDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PaymentDatesReference>>();
   }
}
}

