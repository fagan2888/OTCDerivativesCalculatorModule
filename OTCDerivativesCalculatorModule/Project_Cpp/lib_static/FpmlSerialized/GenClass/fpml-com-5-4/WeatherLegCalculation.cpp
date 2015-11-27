// WeatherLegCalculation.cpp 
#include "WeatherLegCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeatherLegCalculation::WeatherLegCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementLevelNode = xmlNode->FirstChildElement("settlementLevel");

   if(settlementLevelNode){settlementLevelIsNull_ = false;}
   else{settlementLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementLevelNode , address : " << settlementLevelNode << std::endl;
   #endif
   if(settlementLevelNode)
   {
      if(settlementLevelNode->Attribute("href") || settlementLevelNode->Attribute("id"))
      {
          if(settlementLevelNode->Attribute("id"))
          {
             settlementLevelIDRef_ = settlementLevelNode->Attribute("id");
             settlementLevel_ = boost::shared_ptr<WeatherSettlementLevelEnum>(new WeatherSettlementLevelEnum(settlementLevelNode));
             settlementLevel_->setID(settlementLevelIDRef_);
             IDManager::instance().setID(settlementLevelIDRef_,settlementLevel_);
          }
          else if(settlementLevelNode->Attribute("href")) { settlementLevelIDRef_ = settlementLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementLevel_ = boost::shared_ptr<WeatherSettlementLevelEnum>(new WeatherSettlementLevelEnum(settlementLevelNode));}
   }

   //referenceLevelEqualsZeroNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceLevelEqualsZeroNode = xmlNode->FirstChildElement("referenceLevelEqualsZero");

   if(referenceLevelEqualsZeroNode){referenceLevelEqualsZeroIsNull_ = false;}
   else{referenceLevelEqualsZeroIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceLevelEqualsZeroNode , address : " << referenceLevelEqualsZeroNode << std::endl;
   #endif
   if(referenceLevelEqualsZeroNode)
   {
      if(referenceLevelEqualsZeroNode->Attribute("href") || referenceLevelEqualsZeroNode->Attribute("id"))
      {
          if(referenceLevelEqualsZeroNode->Attribute("id"))
          {
             referenceLevelEqualsZeroIDRef_ = referenceLevelEqualsZeroNode->Attribute("id");
             referenceLevelEqualsZero_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(referenceLevelEqualsZeroNode));
             referenceLevelEqualsZero_->setID(referenceLevelEqualsZeroIDRef_);
             IDManager::instance().setID(referenceLevelEqualsZeroIDRef_,referenceLevelEqualsZero_);
          }
          else if(referenceLevelEqualsZeroNode->Attribute("href")) { referenceLevelEqualsZeroIDRef_ = referenceLevelEqualsZeroNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceLevelEqualsZero_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(referenceLevelEqualsZeroNode));}
   }

   //calculationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationDateNode = xmlNode->FirstChildElement("calculationDate");

   if(calculationDateNode){calculationDateIsNull_ = false;}
   else{calculationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationDateNode , address : " << calculationDateNode << std::endl;
   #endif
   if(calculationDateNode)
   {
      if(calculationDateNode->Attribute("href") || calculationDateNode->Attribute("id"))
      {
          if(calculationDateNode->Attribute("id"))
          {
             calculationDateIDRef_ = calculationDateNode->Attribute("id");
             calculationDate_ = boost::shared_ptr<Period>(new Period(calculationDateNode));
             calculationDate_->setID(calculationDateIDRef_);
             IDManager::instance().setID(calculationDateIDRef_,calculationDate_);
          }
          else if(calculationDateNode->Attribute("href")) { calculationDateIDRef_ = calculationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationDate_ = boost::shared_ptr<Period>(new Period(calculationDateNode));}
   }

   //businessDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDaysNode = xmlNode->FirstChildElement("businessDays");

   if(businessDaysNode){businessDaysIsNull_ = false;}
   else{businessDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDaysNode , address : " << businessDaysNode << std::endl;
   #endif
   if(businessDaysNode)
   {
      if(businessDaysNode->Attribute("href") || businessDaysNode->Attribute("id"))
      {
          if(businessDaysNode->Attribute("id"))
          {
             businessDaysIDRef_ = businessDaysNode->Attribute("id");
             businessDays_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessDaysNode));
             businessDays_->setID(businessDaysIDRef_);
             IDManager::instance().setID(businessDaysIDRef_,businessDays_);
          }
          else if(businessDaysNode->Attribute("href")) { businessDaysIDRef_ = businessDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDays_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessDaysNode));}
   }

   //dataCorrectionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dataCorrectionNode = xmlNode->FirstChildElement("dataCorrection");

   if(dataCorrectionNode){dataCorrectionIsNull_ = false;}
   else{dataCorrectionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dataCorrectionNode , address : " << dataCorrectionNode << std::endl;
   #endif
   if(dataCorrectionNode)
   {
      if(dataCorrectionNode->Attribute("href") || dataCorrectionNode->Attribute("id"))
      {
          if(dataCorrectionNode->Attribute("id"))
          {
             dataCorrectionIDRef_ = dataCorrectionNode->Attribute("id");
             dataCorrection_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(dataCorrectionNode));
             dataCorrection_->setID(dataCorrectionIDRef_);
             IDManager::instance().setID(dataCorrectionIDRef_,dataCorrection_);
          }
          else if(dataCorrectionNode->Attribute("href")) { dataCorrectionIDRef_ = dataCorrectionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dataCorrection_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(dataCorrectionNode));}
   }

   //correctionPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correctionPeriodNode = xmlNode->FirstChildElement("correctionPeriod");

   if(correctionPeriodNode){correctionPeriodIsNull_ = false;}
   else{correctionPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correctionPeriodNode , address : " << correctionPeriodNode << std::endl;
   #endif
   if(correctionPeriodNode)
   {
      if(correctionPeriodNode->Attribute("href") || correctionPeriodNode->Attribute("id"))
      {
          if(correctionPeriodNode->Attribute("id"))
          {
             correctionPeriodIDRef_ = correctionPeriodNode->Attribute("id");
             correctionPeriod_ = boost::shared_ptr<Period>(new Period(correctionPeriodNode));
             correctionPeriod_->setID(correctionPeriodIDRef_);
             IDManager::instance().setID(correctionPeriodIDRef_,correctionPeriod_);
          }
          else if(correctionPeriodNode->Attribute("href")) { correctionPeriodIDRef_ = correctionPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correctionPeriod_ = boost::shared_ptr<Period>(new Period(correctionPeriodNode));}
   }

   //maximumPaymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumPaymentAmountNode = xmlNode->FirstChildElement("maximumPaymentAmount");

   if(maximumPaymentAmountNode){maximumPaymentAmountIsNull_ = false;}
   else{maximumPaymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumPaymentAmountNode , address : " << maximumPaymentAmountNode << std::endl;
   #endif
   if(maximumPaymentAmountNode)
   {
      if(maximumPaymentAmountNode->Attribute("href") || maximumPaymentAmountNode->Attribute("id"))
      {
          if(maximumPaymentAmountNode->Attribute("id"))
          {
             maximumPaymentAmountIDRef_ = maximumPaymentAmountNode->Attribute("id");
             maximumPaymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(maximumPaymentAmountNode));
             maximumPaymentAmount_->setID(maximumPaymentAmountIDRef_);
             IDManager::instance().setID(maximumPaymentAmountIDRef_,maximumPaymentAmount_);
          }
          else if(maximumPaymentAmountNode->Attribute("href")) { maximumPaymentAmountIDRef_ = maximumPaymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumPaymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(maximumPaymentAmountNode));}
   }

   //maximumTransactionPaymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumTransactionPaymentAmountNode = xmlNode->FirstChildElement("maximumTransactionPaymentAmount");

   if(maximumTransactionPaymentAmountNode){maximumTransactionPaymentAmountIsNull_ = false;}
   else{maximumTransactionPaymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumTransactionPaymentAmountNode , address : " << maximumTransactionPaymentAmountNode << std::endl;
   #endif
   if(maximumTransactionPaymentAmountNode)
   {
      if(maximumTransactionPaymentAmountNode->Attribute("href") || maximumTransactionPaymentAmountNode->Attribute("id"))
      {
          if(maximumTransactionPaymentAmountNode->Attribute("id"))
          {
             maximumTransactionPaymentAmountIDRef_ = maximumTransactionPaymentAmountNode->Attribute("id");
             maximumTransactionPaymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(maximumTransactionPaymentAmountNode));
             maximumTransactionPaymentAmount_->setID(maximumTransactionPaymentAmountIDRef_);
             IDManager::instance().setID(maximumTransactionPaymentAmountIDRef_,maximumTransactionPaymentAmount_);
          }
          else if(maximumTransactionPaymentAmountNode->Attribute("href")) { maximumTransactionPaymentAmountIDRef_ = maximumTransactionPaymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumTransactionPaymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(maximumTransactionPaymentAmountNode));}
   }

   //roundingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* roundingNode = xmlNode->FirstChildElement("rounding");

   if(roundingNode){roundingIsNull_ = false;}
   else{roundingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- roundingNode , address : " << roundingNode << std::endl;
   #endif
   if(roundingNode)
   {
      if(roundingNode->Attribute("href") || roundingNode->Attribute("id"))
      {
          if(roundingNode->Attribute("id"))
          {
             roundingIDRef_ = roundingNode->Attribute("id");
             rounding_ = boost::shared_ptr<Rounding>(new Rounding(roundingNode));
             rounding_->setID(roundingIDRef_);
             IDManager::instance().setID(roundingIDRef_,rounding_);
          }
          else if(roundingNode->Attribute("href")) { roundingIDRef_ = roundingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rounding_ = boost::shared_ptr<Rounding>(new Rounding(roundingNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<WeatherSettlementLevelEnum> WeatherLegCalculation::getSettlementLevel()
{
   if(!this->settlementLevelIsNull_){
        if(settlementLevelIDRef_ != ""){
             return boost::shared_static_cast<WeatherSettlementLevelEnum>(IDManager::instance().getID(settlementLevelIDRef_));
        }else{
             return this->settlementLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherSettlementLevelEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> WeatherLegCalculation::getReferenceLevelEqualsZero()
{
   if(!this->referenceLevelEqualsZeroIsNull_){
        if(referenceLevelEqualsZeroIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(referenceLevelEqualsZeroIDRef_));
        }else{
             return this->referenceLevelEqualsZero_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Period> WeatherLegCalculation::getCalculationDate()
{
   if(!this->calculationDateIsNull_){
        if(calculationDateIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(calculationDateIDRef_));
        }else{
             return this->calculationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<BusinessCenter> WeatherLegCalculation::getBusinessDays()
{
   if(!this->businessDaysIsNull_){
        if(businessDaysIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(businessDaysIDRef_));
        }else{
             return this->businessDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
boost::shared_ptr<XsdTypeBoolean> WeatherLegCalculation::getDataCorrection()
{
   if(!this->dataCorrectionIsNull_){
        if(dataCorrectionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(dataCorrectionIDRef_));
        }else{
             return this->dataCorrection_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Period> WeatherLegCalculation::getCorrectionPeriod()
{
   if(!this->correctionPeriodIsNull_){
        if(correctionPeriodIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(correctionPeriodIDRef_));
        }else{
             return this->correctionPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<NonNegativeMoney> WeatherLegCalculation::getMaximumPaymentAmount()
{
   if(!this->maximumPaymentAmountIsNull_){
        if(maximumPaymentAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(maximumPaymentAmountIDRef_));
        }else{
             return this->maximumPaymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<NonNegativeMoney> WeatherLegCalculation::getMaximumTransactionPaymentAmount()
{
   if(!this->maximumTransactionPaymentAmountIsNull_){
        if(maximumTransactionPaymentAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(maximumTransactionPaymentAmountIDRef_));
        }else{
             return this->maximumTransactionPaymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<Rounding> WeatherLegCalculation::getRounding()
{
   if(!this->roundingIsNull_){
        if(roundingIDRef_ != ""){
             return boost::shared_static_cast<Rounding>(IDManager::instance().getID(roundingIDRef_));
        }else{
             return this->rounding_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Rounding>();
   }
}
}

