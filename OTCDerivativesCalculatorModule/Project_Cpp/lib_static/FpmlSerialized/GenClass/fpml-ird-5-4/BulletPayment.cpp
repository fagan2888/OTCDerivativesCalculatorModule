// BulletPayment.cpp 
#include "BulletPayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BulletPayment::BulletPayment(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //paymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentNode = xmlNode->FirstChildElement("payment");

   if(paymentNode){paymentIsNull_ = false;}
   else{paymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
   #endif
   if(paymentNode)
   {
      if(paymentNode->Attribute("href") || paymentNode->Attribute("id"))
      {
          if(paymentNode->Attribute("id"))
          {
             paymentIDRef_ = paymentNode->Attribute("id");
             payment_ = boost::shared_ptr<Payment>(new Payment(paymentNode));
             payment_->setID(paymentIDRef_);
             IDManager::instance().setID(paymentIDRef_,payment_);
          }
          else if(paymentNode->Attribute("href")) { paymentIDRef_ = paymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payment_ = boost::shared_ptr<Payment>(new Payment(paymentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Payment> BulletPayment::getPayment()
{
   if(!this->paymentIsNull_){
        if(paymentIDRef_ != ""){
             return boost::shared_static_cast<Payment>(IDManager::instance().getID(paymentIDRef_));
        }else{
             return this->payment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Payment>();
   }
}
}

