// FxOption.cpp 
#include "FxOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxOption::FxOption(TiXmlNode* xmlNode)
: Option(xmlNode)
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
             effectiveDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(effectiveDateNode));}
   }

   //tenorPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorPeriodNode = xmlNode->FirstChildElement("tenorPeriod");

   if(tenorPeriodNode){tenorPeriodIsNull_ = false;}
   else{tenorPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorPeriodNode , address : " << tenorPeriodNode << std::endl;
   #endif
   if(tenorPeriodNode)
   {
      if(tenorPeriodNode->Attribute("href") || tenorPeriodNode->Attribute("id"))
      {
          if(tenorPeriodNode->Attribute("id"))
          {
             tenorPeriodIDRef_ = tenorPeriodNode->Attribute("id");
             tenorPeriod_ = boost::shared_ptr<Period>(new Period(tenorPeriodNode));
             tenorPeriod_->setID(tenorPeriodIDRef_);
             IDManager::instance().setID(tenorPeriodIDRef_,tenorPeriod_);
          }
          else if(tenorPeriodNode->Attribute("href")) { tenorPeriodIDRef_ = tenorPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenorPeriod_ = boost::shared_ptr<Period>(new Period(tenorPeriodNode));}
   }

   //americanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* americanExerciseNode = xmlNode->FirstChildElement("americanExercise");

   if(americanExerciseNode){americanExerciseIsNull_ = false;}
   else{americanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- americanExerciseNode , address : " << americanExerciseNode << std::endl;
   #endif
   if(americanExerciseNode)
   {
      if(americanExerciseNode->Attribute("href") || americanExerciseNode->Attribute("id"))
      {
          if(americanExerciseNode->Attribute("id"))
          {
             americanExerciseIDRef_ = americanExerciseNode->Attribute("id");
             americanExercise_ = boost::shared_ptr<FxAmericanExercise>(new FxAmericanExercise(americanExerciseNode));
             americanExercise_->setID(americanExerciseIDRef_);
             IDManager::instance().setID(americanExerciseIDRef_,americanExercise_);
          }
          else if(americanExerciseNode->Attribute("href")) { americanExerciseIDRef_ = americanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { americanExercise_ = boost::shared_ptr<FxAmericanExercise>(new FxAmericanExercise(americanExerciseNode));}
   }

   //europeanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* europeanExerciseNode = xmlNode->FirstChildElement("europeanExercise");

   if(europeanExerciseNode){europeanExerciseIsNull_ = false;}
   else{europeanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- europeanExerciseNode , address : " << europeanExerciseNode << std::endl;
   #endif
   if(europeanExerciseNode)
   {
      if(europeanExerciseNode->Attribute("href") || europeanExerciseNode->Attribute("id"))
      {
          if(europeanExerciseNode->Attribute("id"))
          {
             europeanExerciseIDRef_ = europeanExerciseNode->Attribute("id");
             europeanExercise_ = boost::shared_ptr<FxEuropeanExercise>(new FxEuropeanExercise(europeanExerciseNode));
             europeanExercise_->setID(europeanExerciseIDRef_);
             IDManager::instance().setID(europeanExerciseIDRef_,europeanExercise_);
          }
          else if(europeanExerciseNode->Attribute("href")) { europeanExerciseIDRef_ = europeanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { europeanExercise_ = boost::shared_ptr<FxEuropeanExercise>(new FxEuropeanExercise(europeanExerciseNode));}
   }

   //exerciseProcedureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseProcedureNode = xmlNode->FirstChildElement("exerciseProcedure");

   if(exerciseProcedureNode){exerciseProcedureIsNull_ = false;}
   else{exerciseProcedureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseProcedureNode , address : " << exerciseProcedureNode << std::endl;
   #endif
   if(exerciseProcedureNode)
   {
      if(exerciseProcedureNode->Attribute("href") || exerciseProcedureNode->Attribute("id"))
      {
          if(exerciseProcedureNode->Attribute("id"))
          {
             exerciseProcedureIDRef_ = exerciseProcedureNode->Attribute("id");
             exerciseProcedure_ = boost::shared_ptr<ExerciseProcedure>(new ExerciseProcedure(exerciseProcedureNode));
             exerciseProcedure_->setID(exerciseProcedureIDRef_);
             IDManager::instance().setID(exerciseProcedureIDRef_,exerciseProcedure_);
          }
          else if(exerciseProcedureNode->Attribute("href")) { exerciseProcedureIDRef_ = exerciseProcedureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseProcedure_ = boost::shared_ptr<ExerciseProcedure>(new ExerciseProcedure(exerciseProcedureNode));}
   }

   //putCurrencyAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* putCurrencyAmountNode = xmlNode->FirstChildElement("putCurrencyAmount");

   if(putCurrencyAmountNode){putCurrencyAmountIsNull_ = false;}
   else{putCurrencyAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- putCurrencyAmountNode , address : " << putCurrencyAmountNode << std::endl;
   #endif
   if(putCurrencyAmountNode)
   {
      if(putCurrencyAmountNode->Attribute("href") || putCurrencyAmountNode->Attribute("id"))
      {
          if(putCurrencyAmountNode->Attribute("id"))
          {
             putCurrencyAmountIDRef_ = putCurrencyAmountNode->Attribute("id");
             putCurrencyAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(putCurrencyAmountNode));
             putCurrencyAmount_->setID(putCurrencyAmountIDRef_);
             IDManager::instance().setID(putCurrencyAmountIDRef_,putCurrencyAmount_);
          }
          else if(putCurrencyAmountNode->Attribute("href")) { putCurrencyAmountIDRef_ = putCurrencyAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { putCurrencyAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(putCurrencyAmountNode));}
   }

   //callCurrencyAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* callCurrencyAmountNode = xmlNode->FirstChildElement("callCurrencyAmount");

   if(callCurrencyAmountNode){callCurrencyAmountIsNull_ = false;}
   else{callCurrencyAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- callCurrencyAmountNode , address : " << callCurrencyAmountNode << std::endl;
   #endif
   if(callCurrencyAmountNode)
   {
      if(callCurrencyAmountNode->Attribute("href") || callCurrencyAmountNode->Attribute("id"))
      {
          if(callCurrencyAmountNode->Attribute("id"))
          {
             callCurrencyAmountIDRef_ = callCurrencyAmountNode->Attribute("id");
             callCurrencyAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(callCurrencyAmountNode));
             callCurrencyAmount_->setID(callCurrencyAmountIDRef_);
             IDManager::instance().setID(callCurrencyAmountIDRef_,callCurrencyAmount_);
          }
          else if(callCurrencyAmountNode->Attribute("href")) { callCurrencyAmountIDRef_ = callCurrencyAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { callCurrencyAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(callCurrencyAmountNode));}
   }

   //soldAsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* soldAsNode = xmlNode->FirstChildElement("soldAs");

   if(soldAsNode){soldAsIsNull_ = false;}
   else{soldAsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- soldAsNode , address : " << soldAsNode << std::endl;
   #endif
   if(soldAsNode)
   {
      if(soldAsNode->Attribute("href") || soldAsNode->Attribute("id"))
      {
          if(soldAsNode->Attribute("id"))
          {
             soldAsIDRef_ = soldAsNode->Attribute("id");
             soldAs_ = boost::shared_ptr<PutCallEnum>(new PutCallEnum(soldAsNode));
             soldAs_->setID(soldAsIDRef_);
             IDManager::instance().setID(soldAsIDRef_,soldAs_);
          }
          else if(soldAsNode->Attribute("href")) { soldAsIDRef_ = soldAsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { soldAs_ = boost::shared_ptr<PutCallEnum>(new PutCallEnum(soldAsNode));}
   }

   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
   #endif
   if(strikeNode)
   {
      if(strikeNode->Attribute("href") || strikeNode->Attribute("id"))
      {
          if(strikeNode->Attribute("id"))
          {
             strikeIDRef_ = strikeNode->Attribute("id");
             strike_ = boost::shared_ptr<FxStrikePrice>(new FxStrikePrice(strikeNode));
             strike_->setID(strikeIDRef_);
             IDManager::instance().setID(strikeIDRef_,strike_);
          }
          else if(strikeNode->Attribute("href")) { strikeIDRef_ = strikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strike_ = boost::shared_ptr<FxStrikePrice>(new FxStrikePrice(strikeNode));}
   }

   //spotRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spotRateNode = xmlNode->FirstChildElement("spotRate");

   if(spotRateNode){spotRateIsNull_ = false;}
   else{spotRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spotRateNode , address : " << spotRateNode << std::endl;
   #endif
   if(spotRateNode)
   {
      if(spotRateNode->Attribute("href") || spotRateNode->Attribute("id"))
      {
          if(spotRateNode->Attribute("id"))
          {
             spotRateIDRef_ = spotRateNode->Attribute("id");
             spotRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(spotRateNode));
             spotRate_->setID(spotRateIDRef_);
             IDManager::instance().setID(spotRateIDRef_,spotRate_);
          }
          else if(spotRateNode->Attribute("href")) { spotRateIDRef_ = spotRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spotRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(spotRateNode));}
   }

   //featuresNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* featuresNode = xmlNode->FirstChildElement("features");

   if(featuresNode){featuresIsNull_ = false;}
   else{featuresIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- featuresNode , address : " << featuresNode << std::endl;
   #endif
   if(featuresNode)
   {
      if(featuresNode->Attribute("href") || featuresNode->Attribute("id"))
      {
          if(featuresNode->Attribute("id"))
          {
             featuresIDRef_ = featuresNode->Attribute("id");
             features_ = boost::shared_ptr<FxOptionFeatures>(new FxOptionFeatures(featuresNode));
             features_->setID(featuresIDRef_);
             IDManager::instance().setID(featuresIDRef_,features_);
          }
          else if(featuresNode->Attribute("href")) { featuresIDRef_ = featuresNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { features_ = boost::shared_ptr<FxOptionFeatures>(new FxOptionFeatures(featuresNode));}
   }

   //premiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumNode = xmlNode->FirstChildElement("premium");

   if(premiumNode){premiumIsNull_ = false;}
   else{premiumIsNull_ = true;}

   if(premiumNode)
   {
      for(premiumNode; premiumNode; premiumNode = premiumNode->NextSiblingElement("premium")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
          #endif
          if(premiumNode->Attribute("href") || premiumNode->Attribute("id"))
          {
              if(premiumNode->Attribute("id"))
              {
                  premiumIDRef_ = premiumNode->Attribute("id");
                  premium_.push_back(boost::shared_ptr<FxOptionPremium>(new FxOptionPremium(premiumNode)));
                  premium_.back()->setID(premiumIDRef_);
                  IDManager::instance().setID(premiumIDRef_, premium_.back());
              }
              else if(premiumNode->Attribute("href")) { premiumIDRef_ = premiumNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { premium_.push_back(boost::shared_ptr<FxOptionPremium>(new FxOptionPremium(premiumNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
       #endif
   }

   //cashSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementNode = xmlNode->FirstChildElement("cashSettlement");

   if(cashSettlementNode){cashSettlementIsNull_ = false;}
   else{cashSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementNode , address : " << cashSettlementNode << std::endl;
   #endif
   if(cashSettlementNode)
   {
      if(cashSettlementNode->Attribute("href") || cashSettlementNode->Attribute("id"))
      {
          if(cashSettlementNode->Attribute("id"))
          {
             cashSettlementIDRef_ = cashSettlementNode->Attribute("id");
             cashSettlement_ = boost::shared_ptr<FxCashSettlement>(new FxCashSettlement(cashSettlementNode));
             cashSettlement_->setID(cashSettlementIDRef_);
             IDManager::instance().setID(cashSettlementIDRef_,cashSettlement_);
          }
          else if(cashSettlementNode->Attribute("href")) { cashSettlementIDRef_ = cashSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlement_ = boost::shared_ptr<FxCashSettlement>(new FxCashSettlement(cashSettlementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> FxOption::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<Period> FxOption::getTenorPeriod()
{
   if(!this->tenorPeriodIsNull_){
        if(tenorPeriodIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(tenorPeriodIDRef_));
        }else{
             return this->tenorPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<FxAmericanExercise> FxOption::getAmericanExercise()
{
   if(!this->americanExerciseIsNull_){
        if(americanExerciseIDRef_ != ""){
             return boost::shared_static_cast<FxAmericanExercise>(IDManager::instance().getID(americanExerciseIDRef_));
        }else{
             return this->americanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxAmericanExercise>();
   }
}
boost::shared_ptr<FxEuropeanExercise> FxOption::getEuropeanExercise()
{
   if(!this->europeanExerciseIsNull_){
        if(europeanExerciseIDRef_ != ""){
             return boost::shared_static_cast<FxEuropeanExercise>(IDManager::instance().getID(europeanExerciseIDRef_));
        }else{
             return this->europeanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxEuropeanExercise>();
   }
}
boost::shared_ptr<ExerciseProcedure> FxOption::getExerciseProcedure()
{
   if(!this->exerciseProcedureIsNull_){
        if(exerciseProcedureIDRef_ != ""){
             return boost::shared_static_cast<ExerciseProcedure>(IDManager::instance().getID(exerciseProcedureIDRef_));
        }else{
             return this->exerciseProcedure_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExerciseProcedure>();
   }
}
boost::shared_ptr<NonNegativeMoney> FxOption::getPutCurrencyAmount()
{
   if(!this->putCurrencyAmountIsNull_){
        if(putCurrencyAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(putCurrencyAmountIDRef_));
        }else{
             return this->putCurrencyAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<NonNegativeMoney> FxOption::getCallCurrencyAmount()
{
   if(!this->callCurrencyAmountIsNull_){
        if(callCurrencyAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(callCurrencyAmountIDRef_));
        }else{
             return this->callCurrencyAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<PutCallEnum> FxOption::getSoldAs()
{
   if(!this->soldAsIsNull_){
        if(soldAsIDRef_ != ""){
             return boost::shared_static_cast<PutCallEnum>(IDManager::instance().getID(soldAsIDRef_));
        }else{
             return this->soldAs_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PutCallEnum>();
   }
}
boost::shared_ptr<FxStrikePrice> FxOption::getStrike()
{
   if(!this->strikeIsNull_){
        if(strikeIDRef_ != ""){
             return boost::shared_static_cast<FxStrikePrice>(IDManager::instance().getID(strikeIDRef_));
        }else{
             return this->strike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxStrikePrice>();
   }
}
boost::shared_ptr<PositiveDecimal> FxOption::getSpotRate()
{
   if(!this->spotRateIsNull_){
        if(spotRateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(spotRateIDRef_));
        }else{
             return this->spotRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<FxOptionFeatures> FxOption::getFeatures()
{
   if(!this->featuresIsNull_){
        if(featuresIDRef_ != ""){
             return boost::shared_static_cast<FxOptionFeatures>(IDManager::instance().getID(featuresIDRef_));
        }else{
             return this->features_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxOptionFeatures>();
   }
}
std::vector<boost::shared_ptr<FxOptionPremium>> FxOption::getPremium()
{
   if(!this->premiumIsNull_){
        if(premiumIDRef_ != ""){
             return this->premium_;
        }else{
             return this->premium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxOptionPremium>>();
   }
}
boost::shared_ptr<FxCashSettlement> FxOption::getCashSettlement()
{
   if(!this->cashSettlementIsNull_){
        if(cashSettlementIDRef_ != ""){
             return boost::shared_static_cast<FxCashSettlement>(IDManager::instance().getID(cashSettlementIDRef_));
        }else{
             return this->cashSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxCashSettlement>();
   }
}
}

