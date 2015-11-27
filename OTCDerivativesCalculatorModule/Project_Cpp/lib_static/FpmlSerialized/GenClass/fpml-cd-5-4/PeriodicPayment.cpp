// PeriodicPayment.cpp 
#include "PeriodicPayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PeriodicPayment::PeriodicPayment(TiXmlNode* xmlNode)
: PaymentBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
             paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));
             paymentFrequency_->setID(paymentFrequencyIDRef_);
             IDManager::instance().setID(paymentFrequencyIDRef_,paymentFrequency_);
          }
          else if(paymentFrequencyNode->Attribute("href")) { paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));}
   }

   //firstPeriodStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstPeriodStartDateNode = xmlNode->FirstChildElement("firstPeriodStartDate");

   if(firstPeriodStartDateNode){firstPeriodStartDateIsNull_ = false;}
   else{firstPeriodStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstPeriodStartDateNode , address : " << firstPeriodStartDateNode << std::endl;
   #endif
   if(firstPeriodStartDateNode)
   {
      if(firstPeriodStartDateNode->Attribute("href") || firstPeriodStartDateNode->Attribute("id"))
      {
          if(firstPeriodStartDateNode->Attribute("id"))
          {
             firstPeriodStartDateIDRef_ = firstPeriodStartDateNode->Attribute("id");
             firstPeriodStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstPeriodStartDateNode));
             firstPeriodStartDate_->setID(firstPeriodStartDateIDRef_);
             IDManager::instance().setID(firstPeriodStartDateIDRef_,firstPeriodStartDate_);
          }
          else if(firstPeriodStartDateNode->Attribute("href")) { firstPeriodStartDateIDRef_ = firstPeriodStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstPeriodStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstPeriodStartDateNode));}
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

   //rollConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rollConventionNode = xmlNode->FirstChildElement("rollConvention");

   if(rollConventionNode){rollConventionIsNull_ = false;}
   else{rollConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rollConventionNode , address : " << rollConventionNode << std::endl;
   #endif
   if(rollConventionNode)
   {
      if(rollConventionNode->Attribute("href") || rollConventionNode->Attribute("id"))
      {
          if(rollConventionNode->Attribute("id"))
          {
             rollConventionIDRef_ = rollConventionNode->Attribute("id");
             rollConvention_ = boost::shared_ptr<RollConventionEnum>(new RollConventionEnum(rollConventionNode));
             rollConvention_->setID(rollConventionIDRef_);
             IDManager::instance().setID(rollConventionIDRef_,rollConvention_);
          }
          else if(rollConventionNode->Attribute("href")) { rollConventionIDRef_ = rollConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rollConvention_ = boost::shared_ptr<RollConventionEnum>(new RollConventionEnum(rollConventionNode));}
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

   //fixedAmountCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedAmountCalculationNode = xmlNode->FirstChildElement("fixedAmountCalculation");

   if(fixedAmountCalculationNode){fixedAmountCalculationIsNull_ = false;}
   else{fixedAmountCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedAmountCalculationNode , address : " << fixedAmountCalculationNode << std::endl;
   #endif
   if(fixedAmountCalculationNode)
   {
      if(fixedAmountCalculationNode->Attribute("href") || fixedAmountCalculationNode->Attribute("id"))
      {
          if(fixedAmountCalculationNode->Attribute("id"))
          {
             fixedAmountCalculationIDRef_ = fixedAmountCalculationNode->Attribute("id");
             fixedAmountCalculation_ = boost::shared_ptr<FixedAmountCalculation>(new FixedAmountCalculation(fixedAmountCalculationNode));
             fixedAmountCalculation_->setID(fixedAmountCalculationIDRef_);
             IDManager::instance().setID(fixedAmountCalculationIDRef_,fixedAmountCalculation_);
          }
          else if(fixedAmountCalculationNode->Attribute("href")) { fixedAmountCalculationIDRef_ = fixedAmountCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedAmountCalculation_ = boost::shared_ptr<FixedAmountCalculation>(new FixedAmountCalculation(fixedAmountCalculationNode));}
   }

   //adjustedPaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedPaymentDatesNode = xmlNode->FirstChildElement("adjustedPaymentDates");

   if(adjustedPaymentDatesNode){adjustedPaymentDatesIsNull_ = false;}
   else{adjustedPaymentDatesIsNull_ = true;}

   if(adjustedPaymentDatesNode)
   {
      for(adjustedPaymentDatesNode; adjustedPaymentDatesNode; adjustedPaymentDatesNode = adjustedPaymentDatesNode->NextSiblingElement("adjustedPaymentDates")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedPaymentDatesNode , address : " << adjustedPaymentDatesNode << std::endl;
          #endif
          if(adjustedPaymentDatesNode->Attribute("href") || adjustedPaymentDatesNode->Attribute("id"))
          {
              if(adjustedPaymentDatesNode->Attribute("id"))
              {
                  adjustedPaymentDatesIDRef_ = adjustedPaymentDatesNode->Attribute("id");
                  adjustedPaymentDates_.push_back(boost::shared_ptr<AdjustedPaymentDates>(new AdjustedPaymentDates(adjustedPaymentDatesNode)));
                  adjustedPaymentDates_.back()->setID(adjustedPaymentDatesIDRef_);
                  IDManager::instance().setID(adjustedPaymentDatesIDRef_, adjustedPaymentDates_.back());
              }
              else if(adjustedPaymentDatesNode->Attribute("href")) { adjustedPaymentDatesIDRef_ = adjustedPaymentDatesNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { adjustedPaymentDates_.push_back(boost::shared_ptr<AdjustedPaymentDates>(new AdjustedPaymentDates(adjustedPaymentDatesNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedPaymentDatesNode , address : " << adjustedPaymentDatesNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Period> PeriodicPayment::getPaymentFrequency()
{
   if(!this->paymentFrequencyIsNull_){
        if(paymentFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(paymentFrequencyIDRef_));
        }else{
             return this->paymentFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<XsdTypeDate> PeriodicPayment::getFirstPeriodStartDate()
{
   if(!this->firstPeriodStartDateIsNull_){
        if(firstPeriodStartDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(firstPeriodStartDateIDRef_));
        }else{
             return this->firstPeriodStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> PeriodicPayment::getFirstPaymentDate()
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
boost::shared_ptr<XsdTypeDate> PeriodicPayment::getLastRegularPaymentDate()
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
boost::shared_ptr<RollConventionEnum> PeriodicPayment::getRollConvention()
{
   if(!this->rollConventionIsNull_){
        if(rollConventionIDRef_ != ""){
             return boost::shared_static_cast<RollConventionEnum>(IDManager::instance().getID(rollConventionIDRef_));
        }else{
             return this->rollConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RollConventionEnum>();
   }
}
boost::shared_ptr<Money> PeriodicPayment::getFixedAmount()
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
boost::shared_ptr<FixedAmountCalculation> PeriodicPayment::getFixedAmountCalculation()
{
   if(!this->fixedAmountCalculationIsNull_){
        if(fixedAmountCalculationIDRef_ != ""){
             return boost::shared_static_cast<FixedAmountCalculation>(IDManager::instance().getID(fixedAmountCalculationIDRef_));
        }else{
             return this->fixedAmountCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedAmountCalculation>();
   }
}
std::vector<boost::shared_ptr<AdjustedPaymentDates>> PeriodicPayment::getAdjustedPaymentDates()
{
   if(!this->adjustedPaymentDatesIsNull_){
        if(adjustedPaymentDatesIDRef_ != ""){
             return this->adjustedPaymentDates_;
        }else{
             return this->adjustedPaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AdjustedPaymentDates>>();
   }
}
}

