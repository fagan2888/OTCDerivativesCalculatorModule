// FixedAmountCalculation.cpp 
#include "FixedAmountCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedAmountCalculation::FixedAmountCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAmountNode = xmlNode->FirstChildElement("calculationAmount");

   if(calculationAmountNode){calculationAmountIsNull_ = false;}
   else{calculationAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAmountNode , address : " << calculationAmountNode << std::endl;
   #endif
   if(calculationAmountNode)
   {
      if(calculationAmountNode->Attribute("href") || calculationAmountNode->Attribute("id"))
      {
          if(calculationAmountNode->Attribute("id"))
          {
             calculationAmountIDRef_ = calculationAmountNode->Attribute("id");
             calculationAmount_ = boost::shared_ptr<CalculationAmount>(new CalculationAmount(calculationAmountNode));
             calculationAmount_->setID(calculationAmountIDRef_);
             IDManager::instance().setID(calculationAmountIDRef_,calculationAmount_);
          }
          else if(calculationAmountNode->Attribute("href")) { calculationAmountIDRef_ = calculationAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAmount_ = boost::shared_ptr<CalculationAmount>(new CalculationAmount(calculationAmountNode));}
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
             fixedRate_ = boost::shared_ptr<FixedRate>(new FixedRate(fixedRateNode));
             fixedRate_->setID(fixedRateIDRef_);
             IDManager::instance().setID(fixedRateIDRef_,fixedRate_);
          }
          else if(fixedRateNode->Attribute("href")) { fixedRateIDRef_ = fixedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedRate_ = boost::shared_ptr<FixedRate>(new FixedRate(fixedRateNode));}
   }

   //dayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountFractionNode = xmlNode->FirstChildElement("dayCountFraction");

   if(dayCountFractionNode){dayCountFractionIsNull_ = false;}
   else{dayCountFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
   #endif
   if(dayCountFractionNode)
   {
      if(dayCountFractionNode->Attribute("href") || dayCountFractionNode->Attribute("id"))
      {
          if(dayCountFractionNode->Attribute("id"))
          {
             dayCountFractionIDRef_ = dayCountFractionNode->Attribute("id");
             dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));
             dayCountFraction_->setID(dayCountFractionIDRef_);
             IDManager::instance().setID(dayCountFractionIDRef_,dayCountFraction_);
          }
          else if(dayCountFractionNode->Attribute("href")) { dayCountFractionIDRef_ = dayCountFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CalculationAmount> FixedAmountCalculation::getCalculationAmount()
{
   if(!this->calculationAmountIsNull_){
        if(calculationAmountIDRef_ != ""){
             return boost::shared_static_cast<CalculationAmount>(IDManager::instance().getID(calculationAmountIDRef_));
        }else{
             return this->calculationAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAmount>();
   }
}
boost::shared_ptr<FixedRate> FixedAmountCalculation::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        if(fixedRateIDRef_ != ""){
             return boost::shared_static_cast<FixedRate>(IDManager::instance().getID(fixedRateIDRef_));
        }else{
             return this->fixedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedRate>();
   }
}
boost::shared_ptr<DayCountFraction> FixedAmountCalculation::getDayCountFraction()
{
   if(!this->dayCountFractionIsNull_){
        if(dayCountFractionIDRef_ != ""){
             return boost::shared_static_cast<DayCountFraction>(IDManager::instance().getID(dayCountFractionIDRef_));
        }else{
             return this->dayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayCountFraction>();
   }
}
}

