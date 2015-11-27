// CalculatedAmount.cpp 
#include "CalculatedAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculatedAmount::CalculatedAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationDatesNode = xmlNode->FirstChildElement("calculationDates");

   if(calculationDatesNode){calculationDatesIsNull_ = false;}
   else{calculationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationDatesNode , address : " << calculationDatesNode << std::endl;
   #endif
   if(calculationDatesNode)
   {
      if(calculationDatesNode->Attribute("href") || calculationDatesNode->Attribute("id"))
      {
          if(calculationDatesNode->Attribute("id"))
          {
             calculationDatesIDRef_ = calculationDatesNode->Attribute("id");
             calculationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(calculationDatesNode));
             calculationDates_->setID(calculationDatesIDRef_);
             IDManager::instance().setID(calculationDatesIDRef_,calculationDates_);
          }
          else if(calculationDatesNode->Attribute("href")) { calculationDatesIDRef_ = calculationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(calculationDatesNode));}
   }

   //observationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationStartDateNode = xmlNode->FirstChildElement("observationStartDate");

   if(observationStartDateNode){observationStartDateIsNull_ = false;}
   else{observationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationStartDateNode , address : " << observationStartDateNode << std::endl;
   #endif
   if(observationStartDateNode)
   {
      if(observationStartDateNode->Attribute("href") || observationStartDateNode->Attribute("id"))
      {
          if(observationStartDateNode->Attribute("id"))
          {
             observationStartDateIDRef_ = observationStartDateNode->Attribute("id");
             observationStartDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(observationStartDateNode));
             observationStartDate_->setID(observationStartDateIDRef_);
             IDManager::instance().setID(observationStartDateIDRef_,observationStartDate_);
          }
          else if(observationStartDateNode->Attribute("href")) { observationStartDateIDRef_ = observationStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observationStartDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(observationStartDateNode));}
   }

   //optionsExchangeDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionsExchangeDividendsNode = xmlNode->FirstChildElement("optionsExchangeDividends");

   if(optionsExchangeDividendsNode){optionsExchangeDividendsIsNull_ = false;}
   else{optionsExchangeDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionsExchangeDividendsNode , address : " << optionsExchangeDividendsNode << std::endl;
   #endif
   if(optionsExchangeDividendsNode)
   {
      if(optionsExchangeDividendsNode->Attribute("href") || optionsExchangeDividendsNode->Attribute("id"))
      {
          if(optionsExchangeDividendsNode->Attribute("id"))
          {
             optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode->Attribute("id");
             optionsExchangeDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionsExchangeDividendsNode));
             optionsExchangeDividends_->setID(optionsExchangeDividendsIDRef_);
             IDManager::instance().setID(optionsExchangeDividendsIDRef_,optionsExchangeDividends_);
          }
          else if(optionsExchangeDividendsNode->Attribute("href")) { optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionsExchangeDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionsExchangeDividendsNode));}
   }

   //additionalDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalDividendsNode = xmlNode->FirstChildElement("additionalDividends");

   if(additionalDividendsNode){additionalDividendsIsNull_ = false;}
   else{additionalDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalDividendsNode , address : " << additionalDividendsNode << std::endl;
   #endif
   if(additionalDividendsNode)
   {
      if(additionalDividendsNode->Attribute("href") || additionalDividendsNode->Attribute("id"))
      {
          if(additionalDividendsNode->Attribute("id"))
          {
             additionalDividendsIDRef_ = additionalDividendsNode->Attribute("id");
             additionalDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(additionalDividendsNode));
             additionalDividends_->setID(additionalDividendsIDRef_);
             IDManager::instance().setID(additionalDividendsIDRef_,additionalDividends_);
          }
          else if(additionalDividendsNode->Attribute("href")) { additionalDividendsIDRef_ = additionalDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(additionalDividendsNode));}
   }

   //allDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allDividendsNode = xmlNode->FirstChildElement("allDividends");

   if(allDividendsNode){allDividendsIsNull_ = false;}
   else{allDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allDividendsNode , address : " << allDividendsNode << std::endl;
   #endif
   if(allDividendsNode)
   {
      if(allDividendsNode->Attribute("href") || allDividendsNode->Attribute("id"))
      {
          if(allDividendsNode->Attribute("id"))
          {
             allDividendsIDRef_ = allDividendsNode->Attribute("id");
             allDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(allDividendsNode));
             allDividends_->setID(allDividendsIDRef_);
             IDManager::instance().setID(allDividendsIDRef_,allDividends_);
          }
          else if(allDividendsNode->Attribute("href")) { allDividendsIDRef_ = allDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(allDividendsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableRelativeOrPeriodicDates> CalculatedAmount::getCalculationDates()
{
   if(!this->calculationDatesIsNull_){
        if(calculationDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableRelativeOrPeriodicDates>(IDManager::instance().getID(calculationDatesIDRef_));
        }else{
             return this->calculationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableRelativeOrPeriodicDates>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> CalculatedAmount::getObservationStartDate()
{
   if(!this->observationStartDateIsNull_){
        if(observationStartDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(observationStartDateIDRef_));
        }else{
             return this->observationStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CalculatedAmount::getOptionsExchangeDividends()
{
   if(!this->optionsExchangeDividendsIsNull_){
        if(optionsExchangeDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(optionsExchangeDividendsIDRef_));
        }else{
             return this->optionsExchangeDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CalculatedAmount::getAdditionalDividends()
{
   if(!this->additionalDividendsIsNull_){
        if(additionalDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(additionalDividendsIDRef_));
        }else{
             return this->additionalDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CalculatedAmount::getAllDividends()
{
   if(!this->allDividendsIsNull_){
        if(allDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(allDividendsIDRef_));
        }else{
             return this->allDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

