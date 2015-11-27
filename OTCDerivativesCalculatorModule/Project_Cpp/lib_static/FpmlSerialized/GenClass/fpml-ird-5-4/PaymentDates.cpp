// PaymentDates.cpp 
#include "PaymentDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PaymentDates::PaymentDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationPeriodDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChildElement("calculationPeriodDatesReference");

   if(calculationPeriodDatesReferenceNode){calculationPeriodDatesReferenceIsNull_ = false;}
   else{calculationPeriodDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesReferenceNode , address : " << calculationPeriodDatesReferenceNode << std::endl;
   #endif
   if(calculationPeriodDatesReferenceNode)
   {
      if(calculationPeriodDatesReferenceNode->Attribute("href") || calculationPeriodDatesReferenceNode->Attribute("id"))
      {
          if(calculationPeriodDatesReferenceNode->Attribute("id"))
          {
             calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("id");
             calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));
             calculationPeriodDatesReference_->setID(calculationPeriodDatesReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodDatesReferenceIDRef_,calculationPeriodDatesReference_);
          }
          else if(calculationPeriodDatesReferenceNode->Attribute("href")) { calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));}
   }

   //resetDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetDatesReferenceNode = xmlNode->FirstChildElement("resetDatesReference");

   if(resetDatesReferenceNode){resetDatesReferenceIsNull_ = false;}
   else{resetDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetDatesReferenceNode , address : " << resetDatesReferenceNode << std::endl;
   #endif
   if(resetDatesReferenceNode)
   {
      if(resetDatesReferenceNode->Attribute("href") || resetDatesReferenceNode->Attribute("id"))
      {
          if(resetDatesReferenceNode->Attribute("id"))
          {
             resetDatesReferenceIDRef_ = resetDatesReferenceNode->Attribute("id");
             resetDatesReference_ = boost::shared_ptr<ResetDatesReference>(new ResetDatesReference(resetDatesReferenceNode));
             resetDatesReference_->setID(resetDatesReferenceIDRef_);
             IDManager::instance().setID(resetDatesReferenceIDRef_,resetDatesReference_);
          }
          else if(resetDatesReferenceNode->Attribute("href")) { resetDatesReferenceIDRef_ = resetDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resetDatesReference_ = boost::shared_ptr<ResetDatesReference>(new ResetDatesReference(resetDatesReferenceNode));}
   }

   //valuationDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationDatesReferenceNode = xmlNode->FirstChildElement("valuationDatesReference");

   if(valuationDatesReferenceNode){valuationDatesReferenceIsNull_ = false;}
   else{valuationDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationDatesReferenceNode , address : " << valuationDatesReferenceNode << std::endl;
   #endif
   if(valuationDatesReferenceNode)
   {
      if(valuationDatesReferenceNode->Attribute("href") || valuationDatesReferenceNode->Attribute("id"))
      {
          if(valuationDatesReferenceNode->Attribute("id"))
          {
             valuationDatesReferenceIDRef_ = valuationDatesReferenceNode->Attribute("id");
             valuationDatesReference_ = boost::shared_ptr<ValuationDatesReference>(new ValuationDatesReference(valuationDatesReferenceNode));
             valuationDatesReference_->setID(valuationDatesReferenceIDRef_);
             IDManager::instance().setID(valuationDatesReferenceIDRef_,valuationDatesReference_);
          }
          else if(valuationDatesReferenceNode->Attribute("href")) { valuationDatesReferenceIDRef_ = valuationDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDatesReference_ = boost::shared_ptr<ValuationDatesReference>(new ValuationDatesReference(valuationDatesReferenceNode));}
   }

   //paymentFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentFrequencyNode = xmlNode->FirstChildElement("paymentFrequency");

   if(paymentFrequencyNode){paymentFrequencyIsNull_ = false;}
   else{paymentFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentFrequencyNode , address : " << paymentFrequencyNode << std::endl;
   #endif
   if(paymentFrequencyNode)
   {
      if(paymentFrequencyNode->Attribute("href") || paymentFrequencyNode->Attribute("id"))
      {
          if(paymentFrequencyNode->Attribute("id"))
          {
             paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("id");
             paymentFrequency_ = boost::shared_ptr<Frequency>(new Frequency(paymentFrequencyNode));
             paymentFrequency_->setID(paymentFrequencyIDRef_);
             IDManager::instance().setID(paymentFrequencyIDRef_,paymentFrequency_);
          }
          else if(paymentFrequencyNode->Attribute("href")) { paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentFrequency_ = boost::shared_ptr<Frequency>(new Frequency(paymentFrequencyNode));}
   }

   //firstPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstPaymentDateNode = xmlNode->FirstChildElement("firstPaymentDate");

   if(firstPaymentDateNode){firstPaymentDateIsNull_ = false;}
   else{firstPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstPaymentDateNode , address : " << firstPaymentDateNode << std::endl;
   #endif
   if(firstPaymentDateNode)
   {
      if(firstPaymentDateNode->Attribute("href") || firstPaymentDateNode->Attribute("id"))
      {
          if(firstPaymentDateNode->Attribute("id"))
          {
             firstPaymentDateIDRef_ = firstPaymentDateNode->Attribute("id");
             firstPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstPaymentDateNode));
             firstPaymentDate_->setID(firstPaymentDateIDRef_);
             IDManager::instance().setID(firstPaymentDateIDRef_,firstPaymentDate_);
          }
          else if(firstPaymentDateNode->Attribute("href")) { firstPaymentDateIDRef_ = firstPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstPaymentDateNode));}
   }

   //lastRegularPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lastRegularPaymentDateNode = xmlNode->FirstChildElement("lastRegularPaymentDate");

   if(lastRegularPaymentDateNode){lastRegularPaymentDateIsNull_ = false;}
   else{lastRegularPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lastRegularPaymentDateNode , address : " << lastRegularPaymentDateNode << std::endl;
   #endif
   if(lastRegularPaymentDateNode)
   {
      if(lastRegularPaymentDateNode->Attribute("href") || lastRegularPaymentDateNode->Attribute("id"))
      {
          if(lastRegularPaymentDateNode->Attribute("id"))
          {
             lastRegularPaymentDateIDRef_ = lastRegularPaymentDateNode->Attribute("id");
             lastRegularPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastRegularPaymentDateNode));
             lastRegularPaymentDate_->setID(lastRegularPaymentDateIDRef_);
             IDManager::instance().setID(lastRegularPaymentDateIDRef_,lastRegularPaymentDate_);
          }
          else if(lastRegularPaymentDateNode->Attribute("href")) { lastRegularPaymentDateIDRef_ = lastRegularPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lastRegularPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastRegularPaymentDateNode));}
   }

   //payRelativeToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payRelativeToNode = xmlNode->FirstChildElement("payRelativeTo");

   if(payRelativeToNode){payRelativeToIsNull_ = false;}
   else{payRelativeToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payRelativeToNode , address : " << payRelativeToNode << std::endl;
   #endif
   if(payRelativeToNode)
   {
      if(payRelativeToNode->Attribute("href") || payRelativeToNode->Attribute("id"))
      {
          if(payRelativeToNode->Attribute("id"))
          {
             payRelativeToIDRef_ = payRelativeToNode->Attribute("id");
             payRelativeTo_ = boost::shared_ptr<PayRelativeToEnum>(new PayRelativeToEnum(payRelativeToNode));
             payRelativeTo_->setID(payRelativeToIDRef_);
             IDManager::instance().setID(payRelativeToIDRef_,payRelativeTo_);
          }
          else if(payRelativeToNode->Attribute("href")) { payRelativeToIDRef_ = payRelativeToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payRelativeTo_ = boost::shared_ptr<PayRelativeToEnum>(new PayRelativeToEnum(payRelativeToNode));}
   }

   //paymentDaysOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDaysOffsetNode = xmlNode->FirstChildElement("paymentDaysOffset");

   if(paymentDaysOffsetNode){paymentDaysOffsetIsNull_ = false;}
   else{paymentDaysOffsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDaysOffsetNode , address : " << paymentDaysOffsetNode << std::endl;
   #endif
   if(paymentDaysOffsetNode)
   {
      if(paymentDaysOffsetNode->Attribute("href") || paymentDaysOffsetNode->Attribute("id"))
      {
          if(paymentDaysOffsetNode->Attribute("id"))
          {
             paymentDaysOffsetIDRef_ = paymentDaysOffsetNode->Attribute("id");
             paymentDaysOffset_ = boost::shared_ptr<Offset>(new Offset(paymentDaysOffsetNode));
             paymentDaysOffset_->setID(paymentDaysOffsetIDRef_);
             IDManager::instance().setID(paymentDaysOffsetIDRef_,paymentDaysOffset_);
          }
          else if(paymentDaysOffsetNode->Attribute("href")) { paymentDaysOffsetIDRef_ = paymentDaysOffsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDaysOffset_ = boost::shared_ptr<Offset>(new Offset(paymentDaysOffsetNode));}
   }

   //paymentDatesAdjustmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDatesAdjustmentsNode = xmlNode->FirstChildElement("paymentDatesAdjustments");

   if(paymentDatesAdjustmentsNode){paymentDatesAdjustmentsIsNull_ = false;}
   else{paymentDatesAdjustmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesAdjustmentsNode , address : " << paymentDatesAdjustmentsNode << std::endl;
   #endif
   if(paymentDatesAdjustmentsNode)
   {
      if(paymentDatesAdjustmentsNode->Attribute("href") || paymentDatesAdjustmentsNode->Attribute("id"))
      {
          if(paymentDatesAdjustmentsNode->Attribute("id"))
          {
             paymentDatesAdjustmentsIDRef_ = paymentDatesAdjustmentsNode->Attribute("id");
             paymentDatesAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(paymentDatesAdjustmentsNode));
             paymentDatesAdjustments_->setID(paymentDatesAdjustmentsIDRef_);
             IDManager::instance().setID(paymentDatesAdjustmentsIDRef_,paymentDatesAdjustments_);
          }
          else if(paymentDatesAdjustmentsNode->Attribute("href")) { paymentDatesAdjustmentsIDRef_ = paymentDatesAdjustmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDatesAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(paymentDatesAdjustmentsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CalculationPeriodDatesReference> PaymentDates::getCalculationPeriodDatesReference()
{
   if(!this->calculationPeriodDatesReferenceIsNull_){
        if(calculationPeriodDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodDatesReference>(IDManager::instance().getID(calculationPeriodDatesReferenceIDRef_));
        }else{
             return this->calculationPeriodDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodDatesReference>();
   }
}
boost::shared_ptr<ResetDatesReference> PaymentDates::getResetDatesReference()
{
   if(!this->resetDatesReferenceIsNull_){
        if(resetDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<ResetDatesReference>(IDManager::instance().getID(resetDatesReferenceIDRef_));
        }else{
             return this->resetDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResetDatesReference>();
   }
}
boost::shared_ptr<ValuationDatesReference> PaymentDates::getValuationDatesReference()
{
   if(!this->valuationDatesReferenceIsNull_){
        if(valuationDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<ValuationDatesReference>(IDManager::instance().getID(valuationDatesReferenceIDRef_));
        }else{
             return this->valuationDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationDatesReference>();
   }
}
boost::shared_ptr<Frequency> PaymentDates::getPaymentFrequency()
{
   if(!this->paymentFrequencyIsNull_){
        if(paymentFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Frequency>(IDManager::instance().getID(paymentFrequencyIDRef_));
        }else{
             return this->paymentFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Frequency>();
   }
}
boost::shared_ptr<XsdTypeDate> PaymentDates::getFirstPaymentDate()
{
   if(!this->firstPaymentDateIsNull_){
        if(firstPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(firstPaymentDateIDRef_));
        }else{
             return this->firstPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> PaymentDates::getLastRegularPaymentDate()
{
   if(!this->lastRegularPaymentDateIsNull_){
        if(lastRegularPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(lastRegularPaymentDateIDRef_));
        }else{
             return this->lastRegularPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<PayRelativeToEnum> PaymentDates::getPayRelativeTo()
{
   if(!this->payRelativeToIsNull_){
        if(payRelativeToIDRef_ != ""){
             return boost::shared_static_cast<PayRelativeToEnum>(IDManager::instance().getID(payRelativeToIDRef_));
        }else{
             return this->payRelativeTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayRelativeToEnum>();
   }
}
boost::shared_ptr<Offset> PaymentDates::getPaymentDaysOffset()
{
   if(!this->paymentDaysOffsetIsNull_){
        if(paymentDaysOffsetIDRef_ != ""){
             return boost::shared_static_cast<Offset>(IDManager::instance().getID(paymentDaysOffsetIDRef_));
        }else{
             return this->paymentDaysOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Offset>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> PaymentDates::getPaymentDatesAdjustments()
{
   if(!this->paymentDatesAdjustmentsIsNull_){
        if(paymentDatesAdjustmentsIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayAdjustments>(IDManager::instance().getID(paymentDatesAdjustmentsIDRef_));
        }else{
             return this->paymentDatesAdjustments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayAdjustments>();
   }
}
}

