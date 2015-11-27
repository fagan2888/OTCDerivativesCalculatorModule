// PeriodicDates.cpp 
#include "PeriodicDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PeriodicDates::PeriodicDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationStartDateNode = xmlNode->FirstChildElement("calculationStartDate");

   if(calculationStartDateNode){calculationStartDateIsNull_ = false;}
   else{calculationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationStartDateNode , address : " << calculationStartDateNode << std::endl;
   #endif
   if(calculationStartDateNode)
   {
      if(calculationStartDateNode->Attribute("href") || calculationStartDateNode->Attribute("id"))
      {
          if(calculationStartDateNode->Attribute("id"))
          {
             calculationStartDateIDRef_ = calculationStartDateNode->Attribute("id");
             calculationStartDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(calculationStartDateNode));
             calculationStartDate_->setID(calculationStartDateIDRef_);
             IDManager::instance().setID(calculationStartDateIDRef_,calculationStartDate_);
          }
          else if(calculationStartDateNode->Attribute("href")) { calculationStartDateIDRef_ = calculationStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationStartDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(calculationStartDateNode));}
   }

   //calculationEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationEndDateNode = xmlNode->FirstChildElement("calculationEndDate");

   if(calculationEndDateNode){calculationEndDateIsNull_ = false;}
   else{calculationEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationEndDateNode , address : " << calculationEndDateNode << std::endl;
   #endif
   if(calculationEndDateNode)
   {
      if(calculationEndDateNode->Attribute("href") || calculationEndDateNode->Attribute("id"))
      {
          if(calculationEndDateNode->Attribute("id"))
          {
             calculationEndDateIDRef_ = calculationEndDateNode->Attribute("id");
             calculationEndDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(calculationEndDateNode));
             calculationEndDate_->setID(calculationEndDateIDRef_);
             IDManager::instance().setID(calculationEndDateIDRef_,calculationEndDate_);
          }
          else if(calculationEndDateNode->Attribute("href")) { calculationEndDateIDRef_ = calculationEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationEndDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(calculationEndDateNode));}
   }

   //calculationPeriodFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodFrequencyNode = xmlNode->FirstChildElement("calculationPeriodFrequency");

   if(calculationPeriodFrequencyNode){calculationPeriodFrequencyIsNull_ = false;}
   else{calculationPeriodFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodFrequencyNode , address : " << calculationPeriodFrequencyNode << std::endl;
   #endif
   if(calculationPeriodFrequencyNode)
   {
      if(calculationPeriodFrequencyNode->Attribute("href") || calculationPeriodFrequencyNode->Attribute("id"))
      {
          if(calculationPeriodFrequencyNode->Attribute("id"))
          {
             calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode->Attribute("id");
             calculationPeriodFrequency_ = boost::shared_ptr<CalculationPeriodFrequency>(new CalculationPeriodFrequency(calculationPeriodFrequencyNode));
             calculationPeriodFrequency_->setID(calculationPeriodFrequencyIDRef_);
             IDManager::instance().setID(calculationPeriodFrequencyIDRef_,calculationPeriodFrequency_);
          }
          else if(calculationPeriodFrequencyNode->Attribute("href")) { calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodFrequency_ = boost::shared_ptr<CalculationPeriodFrequency>(new CalculationPeriodFrequency(calculationPeriodFrequencyNode));}
   }

   //calculationPeriodDatesAdjustmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodDatesAdjustmentsNode = xmlNode->FirstChildElement("calculationPeriodDatesAdjustments");

   if(calculationPeriodDatesAdjustmentsNode){calculationPeriodDatesAdjustmentsIsNull_ = false;}
   else{calculationPeriodDatesAdjustmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesAdjustmentsNode , address : " << calculationPeriodDatesAdjustmentsNode << std::endl;
   #endif
   if(calculationPeriodDatesAdjustmentsNode)
   {
      if(calculationPeriodDatesAdjustmentsNode->Attribute("href") || calculationPeriodDatesAdjustmentsNode->Attribute("id"))
      {
          if(calculationPeriodDatesAdjustmentsNode->Attribute("id"))
          {
             calculationPeriodDatesAdjustmentsIDRef_ = calculationPeriodDatesAdjustmentsNode->Attribute("id");
             calculationPeriodDatesAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode));
             calculationPeriodDatesAdjustments_->setID(calculationPeriodDatesAdjustmentsIDRef_);
             IDManager::instance().setID(calculationPeriodDatesAdjustmentsIDRef_,calculationPeriodDatesAdjustments_);
          }
          else if(calculationPeriodDatesAdjustmentsNode->Attribute("href")) { calculationPeriodDatesAdjustmentsIDRef_ = calculationPeriodDatesAdjustmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodDatesAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> PeriodicDates::getCalculationStartDate()
{
   if(!this->calculationStartDateIsNull_){
        if(calculationStartDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(calculationStartDateIDRef_));
        }else{
             return this->calculationStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> PeriodicDates::getCalculationEndDate()
{
   if(!this->calculationEndDateIsNull_){
        if(calculationEndDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(calculationEndDateIDRef_));
        }else{
             return this->calculationEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<CalculationPeriodFrequency> PeriodicDates::getCalculationPeriodFrequency()
{
   if(!this->calculationPeriodFrequencyIsNull_){
        if(calculationPeriodFrequencyIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodFrequency>(IDManager::instance().getID(calculationPeriodFrequencyIDRef_));
        }else{
             return this->calculationPeriodFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodFrequency>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> PeriodicDates::getCalculationPeriodDatesAdjustments()
{
   if(!this->calculationPeriodDatesAdjustmentsIsNull_){
        if(calculationPeriodDatesAdjustmentsIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayAdjustments>(IDManager::instance().getID(calculationPeriodDatesAdjustmentsIDRef_));
        }else{
             return this->calculationPeriodDatesAdjustments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayAdjustments>();
   }
}
}

