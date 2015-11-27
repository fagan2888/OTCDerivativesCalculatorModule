// DividendPaymentDate.cpp 
#include "DividendPaymentDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendPaymentDate::DividendPaymentDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dividendDateReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendDateReferenceNode = xmlNode->FirstChildElement("dividendDateReference");

   if(dividendDateReferenceNode){dividendDateReferenceIsNull_ = false;}
   else{dividendDateReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendDateReferenceNode , address : " << dividendDateReferenceNode << std::endl;
   #endif
   if(dividendDateReferenceNode)
   {
      if(dividendDateReferenceNode->Attribute("href") || dividendDateReferenceNode->Attribute("id"))
      {
          if(dividendDateReferenceNode->Attribute("id"))
          {
             dividendDateReferenceIDRef_ = dividendDateReferenceNode->Attribute("id");
             dividendDateReference_ = boost::shared_ptr<DividendDateReferenceEnum>(new DividendDateReferenceEnum(dividendDateReferenceNode));
             dividendDateReference_->setID(dividendDateReferenceIDRef_);
             IDManager::instance().setID(dividendDateReferenceIDRef_,dividendDateReference_);
          }
          else if(dividendDateReferenceNode->Attribute("href")) { dividendDateReferenceIDRef_ = dividendDateReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendDateReference_ = boost::shared_ptr<DividendDateReferenceEnum>(new DividendDateReferenceEnum(dividendDateReferenceNode));}
   }

   //paymentDateOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDateOffsetNode = xmlNode->FirstChildElement("paymentDateOffset");

   if(paymentDateOffsetNode){paymentDateOffsetIsNull_ = false;}
   else{paymentDateOffsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDateOffsetNode , address : " << paymentDateOffsetNode << std::endl;
   #endif
   if(paymentDateOffsetNode)
   {
      if(paymentDateOffsetNode->Attribute("href") || paymentDateOffsetNode->Attribute("id"))
      {
          if(paymentDateOffsetNode->Attribute("id"))
          {
             paymentDateOffsetIDRef_ = paymentDateOffsetNode->Attribute("id");
             paymentDateOffset_ = boost::shared_ptr<Offset>(new Offset(paymentDateOffsetNode));
             paymentDateOffset_->setID(paymentDateOffsetIDRef_);
             IDManager::instance().setID(paymentDateOffsetIDRef_,paymentDateOffset_);
          }
          else if(paymentDateOffsetNode->Attribute("href")) { paymentDateOffsetIDRef_ = paymentDateOffsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDateOffset_ = boost::shared_ptr<Offset>(new Offset(paymentDateOffsetNode));}
   }

   //adjustableDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustableDateNode = xmlNode->FirstChildElement("adjustableDate");

   if(adjustableDateNode){adjustableDateIsNull_ = false;}
   else{adjustableDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustableDateNode , address : " << adjustableDateNode << std::endl;
   #endif
   if(adjustableDateNode)
   {
      if(adjustableDateNode->Attribute("href") || adjustableDateNode->Attribute("id"))
      {
          if(adjustableDateNode->Attribute("id"))
          {
             adjustableDateIDRef_ = adjustableDateNode->Attribute("id");
             adjustableDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(adjustableDateNode));
             adjustableDate_->setID(adjustableDateIDRef_);
             IDManager::instance().setID(adjustableDateIDRef_,adjustableDate_);
          }
          else if(adjustableDateNode->Attribute("href")) { adjustableDateIDRef_ = adjustableDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustableDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(adjustableDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DividendDateReferenceEnum> DividendPaymentDate::getDividendDateReference()
{
   if(!this->dividendDateReferenceIsNull_){
        if(dividendDateReferenceIDRef_ != ""){
             return boost::shared_static_cast<DividendDateReferenceEnum>(IDManager::instance().getID(dividendDateReferenceIDRef_));
        }else{
             return this->dividendDateReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendDateReferenceEnum>();
   }
}
boost::shared_ptr<Offset> DividendPaymentDate::getPaymentDateOffset()
{
   if(!this->paymentDateOffsetIsNull_){
        if(paymentDateOffsetIDRef_ != ""){
             return boost::shared_static_cast<Offset>(IDManager::instance().getID(paymentDateOffsetIDRef_));
        }else{
             return this->paymentDateOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Offset>();
   }
}
boost::shared_ptr<AdjustableDate> DividendPaymentDate::getAdjustableDate()
{
   if(!this->adjustableDateIsNull_){
        if(adjustableDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(adjustableDateIDRef_));
        }else{
             return this->adjustableDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
}

