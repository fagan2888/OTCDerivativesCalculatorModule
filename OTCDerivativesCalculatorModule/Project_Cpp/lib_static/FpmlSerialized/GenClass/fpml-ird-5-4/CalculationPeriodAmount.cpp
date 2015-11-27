// CalculationPeriodAmount.cpp 
#include "CalculationPeriodAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationPeriodAmount::CalculationPeriodAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationNode = xmlNode->FirstChildElement("calculation");

   if(calculationNode){calculationIsNull_ = false;}
   else{calculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationNode , address : " << calculationNode << std::endl;
   #endif
   if(calculationNode)
   {
      if(calculationNode->Attribute("href") || calculationNode->Attribute("id"))
      {
          if(calculationNode->Attribute("id"))
          {
             calculationIDRef_ = calculationNode->Attribute("id");
             calculation_ = boost::shared_ptr<Calculation>(new Calculation(calculationNode));
             calculation_->setID(calculationIDRef_);
             IDManager::instance().setID(calculationIDRef_,calculation_);
          }
          else if(calculationNode->Attribute("href")) { calculationIDRef_ = calculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculation_ = boost::shared_ptr<Calculation>(new Calculation(calculationNode));}
   }

   //knownAmountScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* knownAmountScheduleNode = xmlNode->FirstChildElement("knownAmountSchedule");

   if(knownAmountScheduleNode){knownAmountScheduleIsNull_ = false;}
   else{knownAmountScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- knownAmountScheduleNode , address : " << knownAmountScheduleNode << std::endl;
   #endif
   if(knownAmountScheduleNode)
   {
      if(knownAmountScheduleNode->Attribute("href") || knownAmountScheduleNode->Attribute("id"))
      {
          if(knownAmountScheduleNode->Attribute("id"))
          {
             knownAmountScheduleIDRef_ = knownAmountScheduleNode->Attribute("id");
             knownAmountSchedule_ = boost::shared_ptr<AmountSchedule>(new AmountSchedule(knownAmountScheduleNode));
             knownAmountSchedule_->setID(knownAmountScheduleIDRef_);
             IDManager::instance().setID(knownAmountScheduleIDRef_,knownAmountSchedule_);
          }
          else if(knownAmountScheduleNode->Attribute("href")) { knownAmountScheduleIDRef_ = knownAmountScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { knownAmountSchedule_ = boost::shared_ptr<AmountSchedule>(new AmountSchedule(knownAmountScheduleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Calculation> CalculationPeriodAmount::getCalculation()
{
   if(!this->calculationIsNull_){
        if(calculationIDRef_ != ""){
             return boost::shared_static_cast<Calculation>(IDManager::instance().getID(calculationIDRef_));
        }else{
             return this->calculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Calculation>();
   }
}
boost::shared_ptr<AmountSchedule> CalculationPeriodAmount::getKnownAmountSchedule()
{
   if(!this->knownAmountScheduleIsNull_){
        if(knownAmountScheduleIDRef_ != ""){
             return boost::shared_static_cast<AmountSchedule>(IDManager::instance().getID(knownAmountScheduleIDRef_));
        }else{
             return this->knownAmountSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AmountSchedule>();
   }
}
}

