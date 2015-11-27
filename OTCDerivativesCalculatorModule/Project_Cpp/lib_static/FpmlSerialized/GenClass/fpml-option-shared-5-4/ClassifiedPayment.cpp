// ClassifiedPayment.cpp 
#include "ClassifiedPayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ClassifiedPayment::ClassifiedPayment(TiXmlNode* xmlNode)
: NonNegativePayment(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //paymentTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentTypeNode = xmlNode->FirstChildElement("paymentType");

   if(paymentTypeNode){paymentTypeIsNull_ = false;}
   else{paymentTypeIsNull_ = true;}

   if(paymentTypeNode)
   {
      for(paymentTypeNode; paymentTypeNode; paymentTypeNode = paymentTypeNode->NextSiblingElement("paymentType")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentTypeNode , address : " << paymentTypeNode << std::endl;
          #endif
          if(paymentTypeNode->Attribute("href") || paymentTypeNode->Attribute("id"))
          {
              if(paymentTypeNode->Attribute("id"))
              {
                  paymentTypeIDRef_ = paymentTypeNode->Attribute("id");
                  paymentType_.push_back(boost::shared_ptr<PaymentType>(new PaymentType(paymentTypeNode)));
                  paymentType_.back()->setID(paymentTypeIDRef_);
                  IDManager::instance().setID(paymentTypeIDRef_, paymentType_.back());
              }
              else if(paymentTypeNode->Attribute("href")) { paymentTypeIDRef_ = paymentTypeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { paymentType_.push_back(boost::shared_ptr<PaymentType>(new PaymentType(paymentTypeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentTypeNode , address : " << paymentTypeNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PaymentType>> ClassifiedPayment::getPaymentType()
{
   if(!this->paymentTypeIsNull_){
        if(paymentTypeIDRef_ != ""){
             return this->paymentType_;
        }else{
             return this->paymentType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PaymentType>>();
   }
}
}

