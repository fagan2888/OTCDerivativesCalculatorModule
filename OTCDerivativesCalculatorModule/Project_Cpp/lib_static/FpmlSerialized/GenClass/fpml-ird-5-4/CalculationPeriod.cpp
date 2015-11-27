// CalculationPeriod.cpp 
#include "CalculationPeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationPeriod::CalculationPeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unadjustedStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedStartDateNode = xmlNode->FirstChildElement("unadjustedStartDate");

   if(unadjustedStartDateNode){unadjustedStartDateIsNull_ = false;}
   else{unadjustedStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedStartDateNode , address : " << unadjustedStartDateNode << std::endl;
   #endif
   if(unadjustedStartDateNode)
   {
      if(unadjustedStartDateNode->Attribute("href") || unadjustedStartDateNode->Attribute("id"))
      {
          if(unadjustedStartDateNode->Attribute("id"))
          {
             unadjustedStartDateIDRef_ = unadjustedStartDateNode->Attribute("id");
             unadjustedStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedStartDateNode));
             unadjustedStartDate_->setID(unadjustedStartDateIDRef_);
             IDManager::instance().setID(unadjustedStartDateIDRef_,unadjustedStartDate_);
          }
          else if(unadjustedStartDateNode->Attribute("href")) { unadjustedStartDateIDRef_ = unadjustedStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedStartDateNode));}
   }

   //unadjustedEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedEndDateNode = xmlNode->FirstChildElement("unadjustedEndDate");

   if(unadjustedEndDateNode){unadjustedEndDateIsNull_ = false;}
   else{unadjustedEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedEndDateNode , address : " << unadjustedEndDateNode << std::endl;
   #endif
   if(unadjustedEndDateNode)
   {
      if(unadjustedEndDateNode->Attribute("href") || unadjustedEndDateNode->Attribute("id"))
      {
          if(unadjustedEndDateNode->Attribute("id"))
          {
             unadjustedEndDateIDRef_ = unadjustedEndDateNode->Attribute("id");
             unadjustedEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedEndDateNode));
             unadjustedEndDate_->setID(unadjustedEndDateIDRef_);
             IDManager::instance().setID(unadjustedEndDateIDRef_,unadjustedEndDate_);
          }
          else if(unadjustedEndDateNode->Attribute("href")) { unadjustedEndDateIDRef_ = unadjustedEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedEndDateNode));}
   }

   //adjustedStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedStartDateNode = xmlNode->FirstChildElement("adjustedStartDate");

   if(adjustedStartDateNode){adjustedStartDateIsNull_ = false;}
   else{adjustedStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedStartDateNode , address : " << adjustedStartDateNode << std::endl;
   #endif
   if(adjustedStartDateNode)
   {
      if(adjustedStartDateNode->Attribute("href") || adjustedStartDateNode->Attribute("id"))
      {
          if(adjustedStartDateNode->Attribute("id"))
          {
             adjustedStartDateIDRef_ = adjustedStartDateNode->Attribute("id");
             adjustedStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedStartDateNode));
             adjustedStartDate_->setID(adjustedStartDateIDRef_);
             IDManager::instance().setID(adjustedStartDateIDRef_,adjustedStartDate_);
          }
          else if(adjustedStartDateNode->Attribute("href")) { adjustedStartDateIDRef_ = adjustedStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedStartDateNode));}
   }

   //adjustedEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedEndDateNode = xmlNode->FirstChildElement("adjustedEndDate");

   if(adjustedEndDateNode){adjustedEndDateIsNull_ = false;}
   else{adjustedEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedEndDateNode , address : " << adjustedEndDateNode << std::endl;
   #endif
   if(adjustedEndDateNode)
   {
      if(adjustedEndDateNode->Attribute("href") || adjustedEndDateNode->Attribute("id"))
      {
          if(adjustedEndDateNode->Attribute("id"))
          {
             adjustedEndDateIDRef_ = adjustedEndDateNode->Attribute("id");
             adjustedEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedEndDateNode));
             adjustedEndDate_->setID(adjustedEndDateIDRef_);
             IDManager::instance().setID(adjustedEndDateIDRef_,adjustedEndDate_);
          }
          else if(adjustedEndDateNode->Attribute("href")) { adjustedEndDateIDRef_ = adjustedEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedEndDateNode));}
   }

   //calculationPeriodNumberOfDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodNumberOfDaysNode = xmlNode->FirstChildElement("calculationPeriodNumberOfDays");

   if(calculationPeriodNumberOfDaysNode){calculationPeriodNumberOfDaysIsNull_ = false;}
   else{calculationPeriodNumberOfDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodNumberOfDaysNode , address : " << calculationPeriodNumberOfDaysNode << std::endl;
   #endif
   if(calculationPeriodNumberOfDaysNode)
   {
      if(calculationPeriodNumberOfDaysNode->Attribute("href") || calculationPeriodNumberOfDaysNode->Attribute("id"))
      {
          if(calculationPeriodNumberOfDaysNode->Attribute("id"))
          {
             calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode->Attribute("id");
             calculationPeriodNumberOfDays_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode));
             calculationPeriodNumberOfDays_->setID(calculationPeriodNumberOfDaysIDRef_);
             IDManager::instance().setID(calculationPeriodNumberOfDaysIDRef_,calculationPeriodNumberOfDays_);
          }
          else if(calculationPeriodNumberOfDaysNode->Attribute("href")) { calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodNumberOfDays_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode));}
   }

   //notionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAmountNode = xmlNode->FirstChildElement("notionalAmount");

   if(notionalAmountNode){notionalAmountIsNull_ = false;}
   else{notionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAmountNode , address : " << notionalAmountNode << std::endl;
   #endif
   if(notionalAmountNode)
   {
      if(notionalAmountNode->Attribute("href") || notionalAmountNode->Attribute("id"))
      {
          if(notionalAmountNode->Attribute("id"))
          {
             notionalAmountIDRef_ = notionalAmountNode->Attribute("id");
             notionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalAmountNode));
             notionalAmount_->setID(notionalAmountIDRef_);
             IDManager::instance().setID(notionalAmountIDRef_,notionalAmount_);
          }
          else if(notionalAmountNode->Attribute("href")) { notionalAmountIDRef_ = notionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalAmountNode));}
   }

   //fxLinkedNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxLinkedNotionalAmountNode = xmlNode->FirstChildElement("fxLinkedNotionalAmount");

   if(fxLinkedNotionalAmountNode){fxLinkedNotionalAmountIsNull_ = false;}
   else{fxLinkedNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxLinkedNotionalAmountNode , address : " << fxLinkedNotionalAmountNode << std::endl;
   #endif
   if(fxLinkedNotionalAmountNode)
   {
      if(fxLinkedNotionalAmountNode->Attribute("href") || fxLinkedNotionalAmountNode->Attribute("id"))
      {
          if(fxLinkedNotionalAmountNode->Attribute("id"))
          {
             fxLinkedNotionalAmountIDRef_ = fxLinkedNotionalAmountNode->Attribute("id");
             fxLinkedNotionalAmount_ = boost::shared_ptr<FxLinkedNotionalAmount>(new FxLinkedNotionalAmount(fxLinkedNotionalAmountNode));
             fxLinkedNotionalAmount_->setID(fxLinkedNotionalAmountIDRef_);
             IDManager::instance().setID(fxLinkedNotionalAmountIDRef_,fxLinkedNotionalAmount_);
          }
          else if(fxLinkedNotionalAmountNode->Attribute("href")) { fxLinkedNotionalAmountIDRef_ = fxLinkedNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxLinkedNotionalAmount_ = boost::shared_ptr<FxLinkedNotionalAmount>(new FxLinkedNotionalAmount(fxLinkedNotionalAmountNode));}
   }

   //floatingRateDefinitionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateDefinitionNode = xmlNode->FirstChildElement("floatingRateDefinition");

   if(floatingRateDefinitionNode){floatingRateDefinitionIsNull_ = false;}
   else{floatingRateDefinitionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateDefinitionNode , address : " << floatingRateDefinitionNode << std::endl;
   #endif
   if(floatingRateDefinitionNode)
   {
      if(floatingRateDefinitionNode->Attribute("href") || floatingRateDefinitionNode->Attribute("id"))
      {
          if(floatingRateDefinitionNode->Attribute("id"))
          {
             floatingRateDefinitionIDRef_ = floatingRateDefinitionNode->Attribute("id");
             floatingRateDefinition_ = boost::shared_ptr<FloatingRateDefinition>(new FloatingRateDefinition(floatingRateDefinitionNode));
             floatingRateDefinition_->setID(floatingRateDefinitionIDRef_);
             IDManager::instance().setID(floatingRateDefinitionIDRef_,floatingRateDefinition_);
          }
          else if(floatingRateDefinitionNode->Attribute("href")) { floatingRateDefinitionIDRef_ = floatingRateDefinitionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateDefinition_ = boost::shared_ptr<FloatingRateDefinition>(new FloatingRateDefinition(floatingRateDefinitionNode));}
   }

   //fixedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateNode = xmlNode->FirstChildElement("fixedRate");

   if(fixedRateNode){fixedRateIsNull_ = false;}
   else{fixedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateNode , address : " << fixedRateNode << std::endl;
   #endif
   if(fixedRateNode)
   {
      if(fixedRateNode->Attribute("href") || fixedRateNode->Attribute("id"))
      {
          if(fixedRateNode->Attribute("id"))
          {
             fixedRateIDRef_ = fixedRateNode->Attribute("id");
             fixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedRateNode));
             fixedRate_->setID(fixedRateIDRef_);
             IDManager::instance().setID(fixedRateIDRef_,fixedRate_);
          }
          else if(fixedRateNode->Attribute("href")) { fixedRateIDRef_ = fixedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedRateNode));}
   }

   //dayCountYearFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountYearFractionNode = xmlNode->FirstChildElement("dayCountYearFraction");

   if(dayCountYearFractionNode){dayCountYearFractionIsNull_ = false;}
   else{dayCountYearFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountYearFractionNode , address : " << dayCountYearFractionNode << std::endl;
   #endif
   if(dayCountYearFractionNode)
   {
      if(dayCountYearFractionNode->Attribute("href") || dayCountYearFractionNode->Attribute("id"))
      {
          if(dayCountYearFractionNode->Attribute("id"))
          {
             dayCountYearFractionIDRef_ = dayCountYearFractionNode->Attribute("id");
             dayCountYearFraction_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(dayCountYearFractionNode));
             dayCountYearFraction_->setID(dayCountYearFractionIDRef_);
             IDManager::instance().setID(dayCountYearFractionIDRef_,dayCountYearFraction_);
          }
          else if(dayCountYearFractionNode->Attribute("href")) { dayCountYearFractionIDRef_ = dayCountYearFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCountYearFraction_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(dayCountYearFractionNode));}
   }

   //forecastAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forecastAmountNode = xmlNode->FirstChildElement("forecastAmount");

   if(forecastAmountNode){forecastAmountIsNull_ = false;}
   else{forecastAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forecastAmountNode , address : " << forecastAmountNode << std::endl;
   #endif
   if(forecastAmountNode)
   {
      if(forecastAmountNode->Attribute("href") || forecastAmountNode->Attribute("id"))
      {
          if(forecastAmountNode->Attribute("id"))
          {
             forecastAmountIDRef_ = forecastAmountNode->Attribute("id");
             forecastAmount_ = boost::shared_ptr<Money>(new Money(forecastAmountNode));
             forecastAmount_->setID(forecastAmountIDRef_);
             IDManager::instance().setID(forecastAmountIDRef_,forecastAmount_);
          }
          else if(forecastAmountNode->Attribute("href")) { forecastAmountIDRef_ = forecastAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forecastAmount_ = boost::shared_ptr<Money>(new Money(forecastAmountNode));}
   }

   //forecastRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forecastRateNode = xmlNode->FirstChildElement("forecastRate");

   if(forecastRateNode){forecastRateIsNull_ = false;}
   else{forecastRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forecastRateNode , address : " << forecastRateNode << std::endl;
   #endif
   if(forecastRateNode)
   {
      if(forecastRateNode->Attribute("href") || forecastRateNode->Attribute("id"))
      {
          if(forecastRateNode->Attribute("id"))
          {
             forecastRateIDRef_ = forecastRateNode->Attribute("id");
             forecastRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(forecastRateNode));
             forecastRate_->setID(forecastRateIDRef_);
             IDManager::instance().setID(forecastRateIDRef_,forecastRate_);
          }
          else if(forecastRateNode->Attribute("href")) { forecastRateIDRef_ = forecastRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forecastRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(forecastRateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> CalculationPeriod::getUnadjustedStartDate()
{
   if(!this->unadjustedStartDateIsNull_){
        if(unadjustedStartDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(unadjustedStartDateIDRef_));
        }else{
             return this->unadjustedStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CalculationPeriod::getUnadjustedEndDate()
{
   if(!this->unadjustedEndDateIsNull_){
        if(unadjustedEndDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(unadjustedEndDateIDRef_));
        }else{
             return this->unadjustedEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CalculationPeriod::getAdjustedStartDate()
{
   if(!this->adjustedStartDateIsNull_){
        if(adjustedStartDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedStartDateIDRef_));
        }else{
             return this->adjustedStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CalculationPeriod::getAdjustedEndDate()
{
   if(!this->adjustedEndDateIsNull_){
        if(adjustedEndDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedEndDateIDRef_));
        }else{
             return this->adjustedEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> CalculationPeriod::getCalculationPeriodNumberOfDays()
{
   if(!this->calculationPeriodNumberOfDaysIsNull_){
        if(calculationPeriodNumberOfDaysIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(calculationPeriodNumberOfDaysIDRef_));
        }else{
             return this->calculationPeriodNumberOfDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CalculationPeriod::getNotionalAmount()
{
   if(!this->notionalAmountIsNull_){
        if(notionalAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(notionalAmountIDRef_));
        }else{
             return this->notionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<FxLinkedNotionalAmount> CalculationPeriod::getFxLinkedNotionalAmount()
{
   if(!this->fxLinkedNotionalAmountIsNull_){
        if(fxLinkedNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<FxLinkedNotionalAmount>(IDManager::instance().getID(fxLinkedNotionalAmountIDRef_));
        }else{
             return this->fxLinkedNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxLinkedNotionalAmount>();
   }
}
boost::shared_ptr<FloatingRateDefinition> CalculationPeriod::getFloatingRateDefinition()
{
   if(!this->floatingRateDefinitionIsNull_){
        if(floatingRateDefinitionIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateDefinition>(IDManager::instance().getID(floatingRateDefinitionIDRef_));
        }else{
             return this->floatingRateDefinition_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateDefinition>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CalculationPeriod::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        if(fixedRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(fixedRateIDRef_));
        }else{
             return this->fixedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CalculationPeriod::getDayCountYearFraction()
{
   if(!this->dayCountYearFractionIsNull_){
        if(dayCountYearFractionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(dayCountYearFractionIDRef_));
        }else{
             return this->dayCountYearFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Money> CalculationPeriod::getForecastAmount()
{
   if(!this->forecastAmountIsNull_){
        if(forecastAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(forecastAmountIDRef_));
        }else{
             return this->forecastAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CalculationPeriod::getForecastRate()
{
   if(!this->forecastRateIsNull_){
        if(forecastRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(forecastRateIDRef_));
        }else{
             return this->forecastRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

