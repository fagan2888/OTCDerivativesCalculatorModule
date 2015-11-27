// FutureValueAmount.cpp 
#include "FutureValueAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FutureValueAmount::FutureValueAmount(TiXmlNode* xmlNode)
: NonNegativeMoney(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //valueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueDateNode = xmlNode->FirstChildElement("valueDate");

   if(valueDateNode){valueDateIsNull_ = false;}
   else{valueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueDateNode , address : " << valueDateNode << std::endl;
   #endif
   if(valueDateNode)
   {
      if(valueDateNode->Attribute("href") || valueDateNode->Attribute("id"))
      {
          if(valueDateNode->Attribute("id"))
          {
             valueDateIDRef_ = valueDateNode->Attribute("id");
             valueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valueDateNode));
             valueDate_->setID(valueDateIDRef_);
             IDManager::instance().setID(valueDateIDRef_,valueDate_);
          }
          else if(valueDateNode->Attribute("href")) { valueDateIDRef_ = valueDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valueDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypePositiveInteger> FutureValueAmount::getCalculationPeriodNumberOfDays()
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
boost::shared_ptr<XsdTypeDate> FutureValueAmount::getValueDate()
{
   if(!this->valueDateIsNull_){
        if(valueDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(valueDateIDRef_));
        }else{
             return this->valueDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

