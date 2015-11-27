// WeatherCalculationPeriod.cpp 
#include "WeatherCalculationPeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeatherCalculationPeriod::WeatherCalculationPeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationPeriodFirstDayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodFirstDayNode = xmlNode->FirstChildElement("calculationPeriodFirstDay");

   if(calculationPeriodFirstDayNode){calculationPeriodFirstDayIsNull_ = false;}
   else{calculationPeriodFirstDayIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodFirstDayNode , address : " << calculationPeriodFirstDayNode << std::endl;
   #endif
   if(calculationPeriodFirstDayNode)
   {
      if(calculationPeriodFirstDayNode->Attribute("href") || calculationPeriodFirstDayNode->Attribute("id"))
      {
          if(calculationPeriodFirstDayNode->Attribute("id"))
          {
             calculationPeriodFirstDayIDRef_ = calculationPeriodFirstDayNode->Attribute("id");
             calculationPeriodFirstDay_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(calculationPeriodFirstDayNode));
             calculationPeriodFirstDay_->setID(calculationPeriodFirstDayIDRef_);
             IDManager::instance().setID(calculationPeriodFirstDayIDRef_,calculationPeriodFirstDay_);
          }
          else if(calculationPeriodFirstDayNode->Attribute("href")) { calculationPeriodFirstDayIDRef_ = calculationPeriodFirstDayNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodFirstDay_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(calculationPeriodFirstDayNode));}
   }

   //calculationPeriodEndDayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodEndDayNode = xmlNode->FirstChildElement("calculationPeriodEndDay");

   if(calculationPeriodEndDayNode){calculationPeriodEndDayIsNull_ = false;}
   else{calculationPeriodEndDayIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodEndDayNode , address : " << calculationPeriodEndDayNode << std::endl;
   #endif
   if(calculationPeriodEndDayNode)
   {
      if(calculationPeriodEndDayNode->Attribute("href") || calculationPeriodEndDayNode->Attribute("id"))
      {
          if(calculationPeriodEndDayNode->Attribute("id"))
          {
             calculationPeriodEndDayIDRef_ = calculationPeriodEndDayNode->Attribute("id");
             calculationPeriodEndDay_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(calculationPeriodEndDayNode));
             calculationPeriodEndDay_->setID(calculationPeriodEndDayIDRef_);
             IDManager::instance().setID(calculationPeriodEndDayIDRef_,calculationPeriodEndDay_);
          }
          else if(calculationPeriodEndDayNode->Attribute("href")) { calculationPeriodEndDayIDRef_ = calculationPeriodEndDayNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodEndDay_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(calculationPeriodEndDayNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IdentifiedDate> WeatherCalculationPeriod::getCalculationPeriodFirstDay()
{
   if(!this->calculationPeriodFirstDayIsNull_){
        if(calculationPeriodFirstDayIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(calculationPeriodFirstDayIDRef_));
        }else{
             return this->calculationPeriodFirstDay_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<IdentifiedDate> WeatherCalculationPeriod::getCalculationPeriodEndDay()
{
   if(!this->calculationPeriodEndDayIsNull_){
        if(calculationPeriodEndDayIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(calculationPeriodEndDayIDRef_));
        }else{
             return this->calculationPeriodEndDay_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
}

