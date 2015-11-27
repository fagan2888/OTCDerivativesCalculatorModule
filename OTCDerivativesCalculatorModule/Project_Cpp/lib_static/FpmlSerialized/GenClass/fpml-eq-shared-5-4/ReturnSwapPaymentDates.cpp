// ReturnSwapPaymentDates.cpp 
#include "ReturnSwapPaymentDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwapPaymentDates::ReturnSwapPaymentDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //paymentDatesInterimNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDatesInterimNode = xmlNode->FirstChildElement("paymentDatesInterim");

   if(paymentDatesInterimNode){paymentDatesInterimIsNull_ = false;}
   else{paymentDatesInterimIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesInterimNode , address : " << paymentDatesInterimNode << std::endl;
   #endif
   if(paymentDatesInterimNode)
   {
      if(paymentDatesInterimNode->Attribute("href") || paymentDatesInterimNode->Attribute("id"))
      {
          if(paymentDatesInterimNode->Attribute("id"))
          {
             paymentDatesInterimIDRef_ = paymentDatesInterimNode->Attribute("id");
             paymentDatesInterim_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(paymentDatesInterimNode));
             paymentDatesInterim_->setID(paymentDatesInterimIDRef_);
             IDManager::instance().setID(paymentDatesInterimIDRef_,paymentDatesInterim_);
          }
          else if(paymentDatesInterimNode->Attribute("href")) { paymentDatesInterimIDRef_ = paymentDatesInterimNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDatesInterim_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(paymentDatesInterimNode));}
   }

   //paymentDateFinalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDateFinalNode = xmlNode->FirstChildElement("paymentDateFinal");

   if(paymentDateFinalNode){paymentDateFinalIsNull_ = false;}
   else{paymentDateFinalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDateFinalNode , address : " << paymentDateFinalNode << std::endl;
   #endif
   if(paymentDateFinalNode)
   {
      if(paymentDateFinalNode->Attribute("href") || paymentDateFinalNode->Attribute("id"))
      {
          if(paymentDateFinalNode->Attribute("id"))
          {
             paymentDateFinalIDRef_ = paymentDateFinalNode->Attribute("id");
             paymentDateFinal_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(paymentDateFinalNode));
             paymentDateFinal_->setID(paymentDateFinalIDRef_);
             IDManager::instance().setID(paymentDateFinalIDRef_,paymentDateFinal_);
          }
          else if(paymentDateFinalNode->Attribute("href")) { paymentDateFinalIDRef_ = paymentDateFinalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDateFinal_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(paymentDateFinalNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDates> ReturnSwapPaymentDates::getPaymentDatesInterim()
{
   if(!this->paymentDatesInterimIsNull_){
        if(paymentDatesInterimIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDates>(IDManager::instance().getID(paymentDatesInterimIDRef_));
        }else{
             return this->paymentDatesInterim_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDates>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> ReturnSwapPaymentDates::getPaymentDateFinal()
{
   if(!this->paymentDateFinalIsNull_){
        if(paymentDateFinalIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(paymentDateFinalIDRef_));
        }else{
             return this->paymentDateFinal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

