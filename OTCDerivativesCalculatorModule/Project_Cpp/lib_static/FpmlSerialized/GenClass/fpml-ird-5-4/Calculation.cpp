// Calculation.cpp 
#include "Calculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Calculation::Calculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalScheduleNode = xmlNode->FirstChildElement("notionalSchedule");

   if(notionalScheduleNode){notionalScheduleIsNull_ = false;}
   else{notionalScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalScheduleNode , address : " << notionalScheduleNode << std::endl;
   #endif
   if(notionalScheduleNode)
   {
      if(notionalScheduleNode->Attribute("href") || notionalScheduleNode->Attribute("id"))
      {
          if(notionalScheduleNode->Attribute("id"))
          {
             notionalScheduleIDRef_ = notionalScheduleNode->Attribute("id");
             notionalSchedule_ = boost::shared_ptr<Notional>(new Notional(notionalScheduleNode));
             notionalSchedule_->setID(notionalScheduleIDRef_);
             IDManager::instance().setID(notionalScheduleIDRef_,notionalSchedule_);
          }
          else if(notionalScheduleNode->Attribute("href")) { notionalScheduleIDRef_ = notionalScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalSchedule_ = boost::shared_ptr<Notional>(new Notional(notionalScheduleNode));}
   }

   //fxLinkedNotionalScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxLinkedNotionalScheduleNode = xmlNode->FirstChildElement("fxLinkedNotionalSchedule");

   if(fxLinkedNotionalScheduleNode){fxLinkedNotionalScheduleIsNull_ = false;}
   else{fxLinkedNotionalScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxLinkedNotionalScheduleNode , address : " << fxLinkedNotionalScheduleNode << std::endl;
   #endif
   if(fxLinkedNotionalScheduleNode)
   {
      if(fxLinkedNotionalScheduleNode->Attribute("href") || fxLinkedNotionalScheduleNode->Attribute("id"))
      {
          if(fxLinkedNotionalScheduleNode->Attribute("id"))
          {
             fxLinkedNotionalScheduleIDRef_ = fxLinkedNotionalScheduleNode->Attribute("id");
             fxLinkedNotionalSchedule_ = boost::shared_ptr<FxLinkedNotionalSchedule>(new FxLinkedNotionalSchedule(fxLinkedNotionalScheduleNode));
             fxLinkedNotionalSchedule_->setID(fxLinkedNotionalScheduleIDRef_);
             IDManager::instance().setID(fxLinkedNotionalScheduleIDRef_,fxLinkedNotionalSchedule_);
          }
          else if(fxLinkedNotionalScheduleNode->Attribute("href")) { fxLinkedNotionalScheduleIDRef_ = fxLinkedNotionalScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxLinkedNotionalSchedule_ = boost::shared_ptr<FxLinkedNotionalSchedule>(new FxLinkedNotionalSchedule(fxLinkedNotionalScheduleNode));}
   }

   //fixedRateScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateScheduleNode = xmlNode->FirstChildElement("fixedRateSchedule");

   if(fixedRateScheduleNode){fixedRateScheduleIsNull_ = false;}
   else{fixedRateScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateScheduleNode , address : " << fixedRateScheduleNode << std::endl;
   #endif
   if(fixedRateScheduleNode)
   {
      if(fixedRateScheduleNode->Attribute("href") || fixedRateScheduleNode->Attribute("id"))
      {
          if(fixedRateScheduleNode->Attribute("id"))
          {
             fixedRateScheduleIDRef_ = fixedRateScheduleNode->Attribute("id");
             fixedRateSchedule_ = boost::shared_ptr<Schedule>(new Schedule(fixedRateScheduleNode));
             fixedRateSchedule_->setID(fixedRateScheduleIDRef_);
             IDManager::instance().setID(fixedRateScheduleIDRef_,fixedRateSchedule_);
          }
          else if(fixedRateScheduleNode->Attribute("href")) { fixedRateScheduleIDRef_ = fixedRateScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedRateSchedule_ = boost::shared_ptr<Schedule>(new Schedule(fixedRateScheduleNode));}
   }

   //futureValueNotionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* futureValueNotionalNode = xmlNode->FirstChildElement("futureValueNotional");

   if(futureValueNotionalNode){futureValueNotionalIsNull_ = false;}
   else{futureValueNotionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- futureValueNotionalNode , address : " << futureValueNotionalNode << std::endl;
   #endif
   if(futureValueNotionalNode)
   {
      if(futureValueNotionalNode->Attribute("href") || futureValueNotionalNode->Attribute("id"))
      {
          if(futureValueNotionalNode->Attribute("id"))
          {
             futureValueNotionalIDRef_ = futureValueNotionalNode->Attribute("id");
             futureValueNotional_ = boost::shared_ptr<FutureValueAmount>(new FutureValueAmount(futureValueNotionalNode));
             futureValueNotional_->setID(futureValueNotionalIDRef_);
             IDManager::instance().setID(futureValueNotionalIDRef_,futureValueNotional_);
          }
          else if(futureValueNotionalNode->Attribute("href")) { futureValueNotionalIDRef_ = futureValueNotionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { futureValueNotional_ = boost::shared_ptr<FutureValueAmount>(new FutureValueAmount(futureValueNotionalNode));}
   }

   //rateCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateCalculationNode = xmlNode->FirstChildElement("rateCalculation");

   if(rateCalculationNode){rateCalculationIsNull_ = false;}
   else{rateCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateCalculationNode , address : " << rateCalculationNode << std::endl;
   #endif
   if(rateCalculationNode)
   {
      if(rateCalculationNode->Attribute("href") || rateCalculationNode->Attribute("id"))
      {
          if(rateCalculationNode->Attribute("id"))
          {
             rateCalculationIDRef_ = rateCalculationNode->Attribute("id");
             rateCalculation_ = boost::shared_ptr<Rate>(new Rate(rateCalculationNode));
             rateCalculation_->setID(rateCalculationIDRef_);
             IDManager::instance().setID(rateCalculationIDRef_,rateCalculation_);
          }
          else if(rateCalculationNode->Attribute("href")) { rateCalculationIDRef_ = rateCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateCalculation_ = boost::shared_ptr<Rate>(new Rate(rateCalculationNode));}
   }

   //floatingRateCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateCalculationNode = xmlNode->FirstChildElement("floatingRateCalculation");

   if(floatingRateCalculationNode){floatingRateCalculationIsNull_ = false;}
   else{floatingRateCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateCalculationNode , address : " << floatingRateCalculationNode << std::endl;
   #endif
   if(floatingRateCalculationNode)
   {
      if(floatingRateCalculationNode->Attribute("href") || floatingRateCalculationNode->Attribute("id"))
      {
          if(floatingRateCalculationNode->Attribute("id"))
          {
             floatingRateCalculationIDRef_ = floatingRateCalculationNode->Attribute("id");
             floatingRateCalculation_ = boost::shared_ptr<FloatingRateCalculation>(new FloatingRateCalculation(floatingRateCalculationNode));
             floatingRateCalculation_->setID(floatingRateCalculationIDRef_);
             IDManager::instance().setID(floatingRateCalculationIDRef_,floatingRateCalculation_);
          }
          else if(floatingRateCalculationNode->Attribute("href")) { floatingRateCalculationIDRef_ = floatingRateCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateCalculation_ = boost::shared_ptr<FloatingRateCalculation>(new FloatingRateCalculation(floatingRateCalculationNode));}
   }

   //inflationRateCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inflationRateCalculationNode = xmlNode->FirstChildElement("inflationRateCalculation");

   if(inflationRateCalculationNode){inflationRateCalculationIsNull_ = false;}
   else{inflationRateCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inflationRateCalculationNode , address : " << inflationRateCalculationNode << std::endl;
   #endif
   if(inflationRateCalculationNode)
   {
      if(inflationRateCalculationNode->Attribute("href") || inflationRateCalculationNode->Attribute("id"))
      {
          if(inflationRateCalculationNode->Attribute("id"))
          {
             inflationRateCalculationIDRef_ = inflationRateCalculationNode->Attribute("id");
             inflationRateCalculation_ = boost::shared_ptr<InflationRateCalculation>(new InflationRateCalculation(inflationRateCalculationNode));
             inflationRateCalculation_->setID(inflationRateCalculationIDRef_);
             IDManager::instance().setID(inflationRateCalculationIDRef_,inflationRateCalculation_);
          }
          else if(inflationRateCalculationNode->Attribute("href")) { inflationRateCalculationIDRef_ = inflationRateCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { inflationRateCalculation_ = boost::shared_ptr<InflationRateCalculation>(new InflationRateCalculation(inflationRateCalculationNode));}
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

   //discountingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountingNode = xmlNode->FirstChildElement("discounting");

   if(discountingNode){discountingIsNull_ = false;}
   else{discountingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountingNode , address : " << discountingNode << std::endl;
   #endif
   if(discountingNode)
   {
      if(discountingNode->Attribute("href") || discountingNode->Attribute("id"))
      {
          if(discountingNode->Attribute("id"))
          {
             discountingIDRef_ = discountingNode->Attribute("id");
             discounting_ = boost::shared_ptr<Discounting>(new Discounting(discountingNode));
             discounting_->setID(discountingIDRef_);
             IDManager::instance().setID(discountingIDRef_,discounting_);
          }
          else if(discountingNode->Attribute("href")) { discountingIDRef_ = discountingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discounting_ = boost::shared_ptr<Discounting>(new Discounting(discountingNode));}
   }

   //compoundingMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingMethodNode = xmlNode->FirstChildElement("compoundingMethod");

   if(compoundingMethodNode){compoundingMethodIsNull_ = false;}
   else{compoundingMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingMethodNode , address : " << compoundingMethodNode << std::endl;
   #endif
   if(compoundingMethodNode)
   {
      if(compoundingMethodNode->Attribute("href") || compoundingMethodNode->Attribute("id"))
      {
          if(compoundingMethodNode->Attribute("id"))
          {
             compoundingMethodIDRef_ = compoundingMethodNode->Attribute("id");
             compoundingMethod_ = boost::shared_ptr<CompoundingMethodEnum>(new CompoundingMethodEnum(compoundingMethodNode));
             compoundingMethod_->setID(compoundingMethodIDRef_);
             IDManager::instance().setID(compoundingMethodIDRef_,compoundingMethod_);
          }
          else if(compoundingMethodNode->Attribute("href")) { compoundingMethodIDRef_ = compoundingMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compoundingMethod_ = boost::shared_ptr<CompoundingMethodEnum>(new CompoundingMethodEnum(compoundingMethodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Notional> Calculation::getNotionalSchedule()
{
   if(!this->notionalScheduleIsNull_){
        if(notionalScheduleIDRef_ != ""){
             return boost::shared_static_cast<Notional>(IDManager::instance().getID(notionalScheduleIDRef_));
        }else{
             return this->notionalSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Notional>();
   }
}
boost::shared_ptr<FxLinkedNotionalSchedule> Calculation::getFxLinkedNotionalSchedule()
{
   if(!this->fxLinkedNotionalScheduleIsNull_){
        if(fxLinkedNotionalScheduleIDRef_ != ""){
             return boost::shared_static_cast<FxLinkedNotionalSchedule>(IDManager::instance().getID(fxLinkedNotionalScheduleIDRef_));
        }else{
             return this->fxLinkedNotionalSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxLinkedNotionalSchedule>();
   }
}
boost::shared_ptr<Schedule> Calculation::getFixedRateSchedule()
{
   if(!this->fixedRateScheduleIsNull_){
        if(fixedRateScheduleIDRef_ != ""){
             return boost::shared_static_cast<Schedule>(IDManager::instance().getID(fixedRateScheduleIDRef_));
        }else{
             return this->fixedRateSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Schedule>();
   }
}
boost::shared_ptr<FutureValueAmount> Calculation::getFutureValueNotional()
{
   if(!this->futureValueNotionalIsNull_){
        if(futureValueNotionalIDRef_ != ""){
             return boost::shared_static_cast<FutureValueAmount>(IDManager::instance().getID(futureValueNotionalIDRef_));
        }else{
             return this->futureValueNotional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FutureValueAmount>();
   }
}
boost::shared_ptr<Rate> Calculation::getRateCalculation()
{
   if(!this->rateCalculationIsNull_){
        if(rateCalculationIDRef_ != ""){
             return boost::shared_static_cast<Rate>(IDManager::instance().getID(rateCalculationIDRef_));
        }else{
             return this->rateCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Rate>();
   }
}
boost::shared_ptr<FloatingRateCalculation> Calculation::getFloatingRateCalculation()
{
   if(!this->floatingRateCalculationIsNull_){
        if(floatingRateCalculationIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateCalculation>(IDManager::instance().getID(floatingRateCalculationIDRef_));
        }else{
             return this->floatingRateCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateCalculation>();
   }
}
boost::shared_ptr<InflationRateCalculation> Calculation::getInflationRateCalculation()
{
   if(!this->inflationRateCalculationIsNull_){
        if(inflationRateCalculationIDRef_ != ""){
             return boost::shared_static_cast<InflationRateCalculation>(IDManager::instance().getID(inflationRateCalculationIDRef_));
        }else{
             return this->inflationRateCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InflationRateCalculation>();
   }
}
boost::shared_ptr<DayCountFraction> Calculation::getDayCountFraction()
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
boost::shared_ptr<Discounting> Calculation::getDiscounting()
{
   if(!this->discountingIsNull_){
        if(discountingIDRef_ != ""){
             return boost::shared_static_cast<Discounting>(IDManager::instance().getID(discountingIDRef_));
        }else{
             return this->discounting_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Discounting>();
   }
}
boost::shared_ptr<CompoundingMethodEnum> Calculation::getCompoundingMethod()
{
   if(!this->compoundingMethodIsNull_){
        if(compoundingMethodIDRef_ != ""){
             return boost::shared_static_cast<CompoundingMethodEnum>(IDManager::instance().getID(compoundingMethodIDRef_));
        }else{
             return this->compoundingMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompoundingMethodEnum>();
   }
}
}

