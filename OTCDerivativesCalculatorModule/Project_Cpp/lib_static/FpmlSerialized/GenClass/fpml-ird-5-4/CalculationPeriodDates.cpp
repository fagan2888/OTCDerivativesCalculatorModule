// CalculationPeriodDates.cpp 
#include "CalculationPeriodDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationPeriodDates::CalculationPeriodDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(effectiveDateNode));}
   }

   //relativeEffectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeEffectiveDateNode = xmlNode->FirstChildElement("relativeEffectiveDate");

   if(relativeEffectiveDateNode){relativeEffectiveDateIsNull_ = false;}
   else{relativeEffectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeEffectiveDateNode , address : " << relativeEffectiveDateNode << std::endl;
   #endif
   if(relativeEffectiveDateNode)
   {
      if(relativeEffectiveDateNode->Attribute("href") || relativeEffectiveDateNode->Attribute("id"))
      {
          if(relativeEffectiveDateNode->Attribute("id"))
          {
             relativeEffectiveDateIDRef_ = relativeEffectiveDateNode->Attribute("id");
             relativeEffectiveDate_ = boost::shared_ptr<AdjustedRelativeDateOffset>(new AdjustedRelativeDateOffset(relativeEffectiveDateNode));
             relativeEffectiveDate_->setID(relativeEffectiveDateIDRef_);
             IDManager::instance().setID(relativeEffectiveDateIDRef_,relativeEffectiveDate_);
          }
          else if(relativeEffectiveDateNode->Attribute("href")) { relativeEffectiveDateIDRef_ = relativeEffectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeEffectiveDate_ = boost::shared_ptr<AdjustedRelativeDateOffset>(new AdjustedRelativeDateOffset(relativeEffectiveDateNode));}
   }

   //terminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* terminationDateNode = xmlNode->FirstChildElement("terminationDate");

   if(terminationDateNode){terminationDateIsNull_ = false;}
   else{terminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- terminationDateNode , address : " << terminationDateNode << std::endl;
   #endif
   if(terminationDateNode)
   {
      if(terminationDateNode->Attribute("href") || terminationDateNode->Attribute("id"))
      {
          if(terminationDateNode->Attribute("id"))
          {
             terminationDateIDRef_ = terminationDateNode->Attribute("id");
             terminationDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(terminationDateNode));
             terminationDate_->setID(terminationDateIDRef_);
             IDManager::instance().setID(terminationDateIDRef_,terminationDate_);
          }
          else if(terminationDateNode->Attribute("href")) { terminationDateIDRef_ = terminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { terminationDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(terminationDateNode));}
   }

   //relativeTerminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeTerminationDateNode = xmlNode->FirstChildElement("relativeTerminationDate");

   if(relativeTerminationDateNode){relativeTerminationDateIsNull_ = false;}
   else{relativeTerminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeTerminationDateNode , address : " << relativeTerminationDateNode << std::endl;
   #endif
   if(relativeTerminationDateNode)
   {
      if(relativeTerminationDateNode->Attribute("href") || relativeTerminationDateNode->Attribute("id"))
      {
          if(relativeTerminationDateNode->Attribute("id"))
          {
             relativeTerminationDateIDRef_ = relativeTerminationDateNode->Attribute("id");
             relativeTerminationDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeTerminationDateNode));
             relativeTerminationDate_->setID(relativeTerminationDateIDRef_);
             IDManager::instance().setID(relativeTerminationDateIDRef_,relativeTerminationDate_);
          }
          else if(relativeTerminationDateNode->Attribute("href")) { relativeTerminationDateIDRef_ = relativeTerminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeTerminationDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeTerminationDateNode));}
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
             firstPeriodStartDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(firstPeriodStartDateNode));
             firstPeriodStartDate_->setID(firstPeriodStartDateIDRef_);
             IDManager::instance().setID(firstPeriodStartDateIDRef_,firstPeriodStartDate_);
          }
          else if(firstPeriodStartDateNode->Attribute("href")) { firstPeriodStartDateIDRef_ = firstPeriodStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstPeriodStartDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(firstPeriodStartDateNode));}
   }

   //firstRegularPeriodStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstRegularPeriodStartDateNode = xmlNode->FirstChildElement("firstRegularPeriodStartDate");

   if(firstRegularPeriodStartDateNode){firstRegularPeriodStartDateIsNull_ = false;}
   else{firstRegularPeriodStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstRegularPeriodStartDateNode , address : " << firstRegularPeriodStartDateNode << std::endl;
   #endif
   if(firstRegularPeriodStartDateNode)
   {
      if(firstRegularPeriodStartDateNode->Attribute("href") || firstRegularPeriodStartDateNode->Attribute("id"))
      {
          if(firstRegularPeriodStartDateNode->Attribute("id"))
          {
             firstRegularPeriodStartDateIDRef_ = firstRegularPeriodStartDateNode->Attribute("id");
             firstRegularPeriodStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstRegularPeriodStartDateNode));
             firstRegularPeriodStartDate_->setID(firstRegularPeriodStartDateIDRef_);
             IDManager::instance().setID(firstRegularPeriodStartDateIDRef_,firstRegularPeriodStartDate_);
          }
          else if(firstRegularPeriodStartDateNode->Attribute("href")) { firstRegularPeriodStartDateIDRef_ = firstRegularPeriodStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstRegularPeriodStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstRegularPeriodStartDateNode));}
   }

   //firstCompoundingPeriodEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstCompoundingPeriodEndDateNode = xmlNode->FirstChildElement("firstCompoundingPeriodEndDate");

   if(firstCompoundingPeriodEndDateNode){firstCompoundingPeriodEndDateIsNull_ = false;}
   else{firstCompoundingPeriodEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstCompoundingPeriodEndDateNode , address : " << firstCompoundingPeriodEndDateNode << std::endl;
   #endif
   if(firstCompoundingPeriodEndDateNode)
   {
      if(firstCompoundingPeriodEndDateNode->Attribute("href") || firstCompoundingPeriodEndDateNode->Attribute("id"))
      {
          if(firstCompoundingPeriodEndDateNode->Attribute("id"))
          {
             firstCompoundingPeriodEndDateIDRef_ = firstCompoundingPeriodEndDateNode->Attribute("id");
             firstCompoundingPeriodEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstCompoundingPeriodEndDateNode));
             firstCompoundingPeriodEndDate_->setID(firstCompoundingPeriodEndDateIDRef_);
             IDManager::instance().setID(firstCompoundingPeriodEndDateIDRef_,firstCompoundingPeriodEndDate_);
          }
          else if(firstCompoundingPeriodEndDateNode->Attribute("href")) { firstCompoundingPeriodEndDateIDRef_ = firstCompoundingPeriodEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstCompoundingPeriodEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstCompoundingPeriodEndDateNode));}
   }

   //lastRegularPeriodEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lastRegularPeriodEndDateNode = xmlNode->FirstChildElement("lastRegularPeriodEndDate");

   if(lastRegularPeriodEndDateNode){lastRegularPeriodEndDateIsNull_ = false;}
   else{lastRegularPeriodEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lastRegularPeriodEndDateNode , address : " << lastRegularPeriodEndDateNode << std::endl;
   #endif
   if(lastRegularPeriodEndDateNode)
   {
      if(lastRegularPeriodEndDateNode->Attribute("href") || lastRegularPeriodEndDateNode->Attribute("id"))
      {
          if(lastRegularPeriodEndDateNode->Attribute("id"))
          {
             lastRegularPeriodEndDateIDRef_ = lastRegularPeriodEndDateNode->Attribute("id");
             lastRegularPeriodEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastRegularPeriodEndDateNode));
             lastRegularPeriodEndDate_->setID(lastRegularPeriodEndDateIDRef_);
             IDManager::instance().setID(lastRegularPeriodEndDateIDRef_,lastRegularPeriodEndDate_);
          }
          else if(lastRegularPeriodEndDateNode->Attribute("href")) { lastRegularPeriodEndDateIDRef_ = lastRegularPeriodEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lastRegularPeriodEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastRegularPeriodEndDateNode));}
   }

   //stubPeriodTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stubPeriodTypeNode = xmlNode->FirstChildElement("stubPeriodType");

   if(stubPeriodTypeNode){stubPeriodTypeIsNull_ = false;}
   else{stubPeriodTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stubPeriodTypeNode , address : " << stubPeriodTypeNode << std::endl;
   #endif
   if(stubPeriodTypeNode)
   {
      if(stubPeriodTypeNode->Attribute("href") || stubPeriodTypeNode->Attribute("id"))
      {
          if(stubPeriodTypeNode->Attribute("id"))
          {
             stubPeriodTypeIDRef_ = stubPeriodTypeNode->Attribute("id");
             stubPeriodType_ = boost::shared_ptr<StubPeriodTypeEnum>(new StubPeriodTypeEnum(stubPeriodTypeNode));
             stubPeriodType_->setID(stubPeriodTypeIDRef_);
             IDManager::instance().setID(stubPeriodTypeIDRef_,stubPeriodType_);
          }
          else if(stubPeriodTypeNode->Attribute("href")) { stubPeriodTypeIDRef_ = stubPeriodTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stubPeriodType_ = boost::shared_ptr<StubPeriodTypeEnum>(new StubPeriodTypeEnum(stubPeriodTypeNode));}
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDate> CalculationPeriodDates::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<AdjustedRelativeDateOffset> CalculationPeriodDates::getRelativeEffectiveDate()
{
   if(!this->relativeEffectiveDateIsNull_){
        if(relativeEffectiveDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustedRelativeDateOffset>(IDManager::instance().getID(relativeEffectiveDateIDRef_));
        }else{
             return this->relativeEffectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustedRelativeDateOffset>();
   }
}
boost::shared_ptr<AdjustableDate> CalculationPeriodDates::getTerminationDate()
{
   if(!this->terminationDateIsNull_){
        if(terminationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(terminationDateIDRef_));
        }else{
             return this->terminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<RelativeDateOffset> CalculationPeriodDates::getRelativeTerminationDate()
{
   if(!this->relativeTerminationDateIsNull_){
        if(relativeTerminationDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(relativeTerminationDateIDRef_));
        }else{
             return this->relativeTerminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> CalculationPeriodDates::getCalculationPeriodDatesAdjustments()
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
boost::shared_ptr<AdjustableDate> CalculationPeriodDates::getFirstPeriodStartDate()
{
   if(!this->firstPeriodStartDateIsNull_){
        if(firstPeriodStartDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(firstPeriodStartDateIDRef_));
        }else{
             return this->firstPeriodStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CalculationPeriodDates::getFirstRegularPeriodStartDate()
{
   if(!this->firstRegularPeriodStartDateIsNull_){
        if(firstRegularPeriodStartDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(firstRegularPeriodStartDateIDRef_));
        }else{
             return this->firstRegularPeriodStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CalculationPeriodDates::getFirstCompoundingPeriodEndDate()
{
   if(!this->firstCompoundingPeriodEndDateIsNull_){
        if(firstCompoundingPeriodEndDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(firstCompoundingPeriodEndDateIDRef_));
        }else{
             return this->firstCompoundingPeriodEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CalculationPeriodDates::getLastRegularPeriodEndDate()
{
   if(!this->lastRegularPeriodEndDateIsNull_){
        if(lastRegularPeriodEndDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(lastRegularPeriodEndDateIDRef_));
        }else{
             return this->lastRegularPeriodEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<StubPeriodTypeEnum> CalculationPeriodDates::getStubPeriodType()
{
   if(!this->stubPeriodTypeIsNull_){
        if(stubPeriodTypeIDRef_ != ""){
             return boost::shared_static_cast<StubPeriodTypeEnum>(IDManager::instance().getID(stubPeriodTypeIDRef_));
        }else{
             return this->stubPeriodType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StubPeriodTypeEnum>();
   }
}
boost::shared_ptr<CalculationPeriodFrequency> CalculationPeriodDates::getCalculationPeriodFrequency()
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
}

