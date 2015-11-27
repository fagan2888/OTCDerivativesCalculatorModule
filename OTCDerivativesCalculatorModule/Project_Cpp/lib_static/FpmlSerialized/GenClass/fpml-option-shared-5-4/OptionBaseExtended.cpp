// OptionBaseExtended.cpp 
#include "OptionBaseExtended.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionBaseExtended::OptionBaseExtended(TiXmlNode* xmlNode)
: OptionBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //premiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumNode = xmlNode->FirstChildElement("premium");

   if(premiumNode){premiumIsNull_ = false;}
   else{premiumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
   #endif
   if(premiumNode)
   {
      if(premiumNode->Attribute("href") || premiumNode->Attribute("id"))
      {
          if(premiumNode->Attribute("id"))
          {
             premiumIDRef_ = premiumNode->Attribute("id");
             premium_ = boost::shared_ptr<Premium>(new Premium(premiumNode));
             premium_->setID(premiumIDRef_);
             IDManager::instance().setID(premiumIDRef_,premium_);
          }
          else if(premiumNode->Attribute("href")) { premiumIDRef_ = premiumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { premium_ = boost::shared_ptr<Premium>(new Premium(premiumNode));}
   }

   //exerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseNode = xmlNode->FirstChildElement("exercise");

   if(exerciseNode){exerciseIsNull_ = false;}
   else{exerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNode , address : " << exerciseNode << std::endl;
   #endif
   if(exerciseNode)
   {
      if(exerciseNode->Attribute("href") || exerciseNode->Attribute("id"))
      {
          if(exerciseNode->Attribute("id"))
          {
             exerciseIDRef_ = exerciseNode->Attribute("id");
             exercise_ = boost::shared_ptr<Exercise>(new Exercise(exerciseNode));
             exercise_->setID(exerciseIDRef_);
             IDManager::instance().setID(exerciseIDRef_,exercise_);
          }
          else if(exerciseNode->Attribute("href")) { exerciseIDRef_ = exerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exercise_ = boost::shared_ptr<Exercise>(new Exercise(exerciseNode));}
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
             americanExercise_ = boost::shared_ptr<AmericanExercise>(new AmericanExercise(americanExerciseNode));
             americanExercise_->setID(americanExerciseIDRef_);
             IDManager::instance().setID(americanExerciseIDRef_,americanExercise_);
          }
          else if(americanExerciseNode->Attribute("href")) { americanExerciseIDRef_ = americanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { americanExercise_ = boost::shared_ptr<AmericanExercise>(new AmericanExercise(americanExerciseNode));}
   }

   //bermudaExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bermudaExerciseNode = xmlNode->FirstChildElement("bermudaExercise");

   if(bermudaExerciseNode){bermudaExerciseIsNull_ = false;}
   else{bermudaExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bermudaExerciseNode , address : " << bermudaExerciseNode << std::endl;
   #endif
   if(bermudaExerciseNode)
   {
      if(bermudaExerciseNode->Attribute("href") || bermudaExerciseNode->Attribute("id"))
      {
          if(bermudaExerciseNode->Attribute("id"))
          {
             bermudaExerciseIDRef_ = bermudaExerciseNode->Attribute("id");
             bermudaExercise_ = boost::shared_ptr<BermudaExercise>(new BermudaExercise(bermudaExerciseNode));
             bermudaExercise_->setID(bermudaExerciseIDRef_);
             IDManager::instance().setID(bermudaExerciseIDRef_,bermudaExercise_);
          }
          else if(bermudaExerciseNode->Attribute("href")) { bermudaExerciseIDRef_ = bermudaExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bermudaExercise_ = boost::shared_ptr<BermudaExercise>(new BermudaExercise(bermudaExerciseNode));}
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
             europeanExercise_ = boost::shared_ptr<EuropeanExercise>(new EuropeanExercise(europeanExerciseNode));
             europeanExercise_->setID(europeanExerciseIDRef_);
             IDManager::instance().setID(europeanExerciseIDRef_,europeanExercise_);
          }
          else if(europeanExerciseNode->Attribute("href")) { europeanExerciseIDRef_ = europeanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { europeanExercise_ = boost::shared_ptr<EuropeanExercise>(new EuropeanExercise(europeanExerciseNode));}
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

   //featureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* featureNode = xmlNode->FirstChildElement("feature");

   if(featureNode){featureIsNull_ = false;}
   else{featureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- featureNode , address : " << featureNode << std::endl;
   #endif
   if(featureNode)
   {
      if(featureNode->Attribute("href") || featureNode->Attribute("id"))
      {
          if(featureNode->Attribute("id"))
          {
             featureIDRef_ = featureNode->Attribute("id");
             feature_ = boost::shared_ptr<OptionFeature>(new OptionFeature(featureNode));
             feature_->setID(featureIDRef_);
             IDManager::instance().setID(featureIDRef_,feature_);
          }
          else if(featureNode->Attribute("href")) { featureIDRef_ = featureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feature_ = boost::shared_ptr<OptionFeature>(new OptionFeature(featureNode));}
   }

   //notionalReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalReferenceNode = xmlNode->FirstChildElement("notionalReference");

   if(notionalReferenceNode){notionalReferenceIsNull_ = false;}
   else{notionalReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalReferenceNode , address : " << notionalReferenceNode << std::endl;
   #endif
   if(notionalReferenceNode)
   {
      if(notionalReferenceNode->Attribute("href") || notionalReferenceNode->Attribute("id"))
      {
          if(notionalReferenceNode->Attribute("id"))
          {
             notionalReferenceIDRef_ = notionalReferenceNode->Attribute("id");
             notionalReference_ = boost::shared_ptr<NotionalAmountReference>(new NotionalAmountReference(notionalReferenceNode));
             notionalReference_->setID(notionalReferenceIDRef_);
             IDManager::instance().setID(notionalReferenceIDRef_,notionalReference_);
          }
          else if(notionalReferenceNode->Attribute("href")) { notionalReferenceIDRef_ = notionalReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalReference_ = boost::shared_ptr<NotionalAmountReference>(new NotionalAmountReference(notionalReferenceNode));}
   }

   //notionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAmountNode = xmlNode->FirstChildElement("notionalAmount");

   if(notionalAmountNode){notionalAmountIsNull_ = false;}
   else{notionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAmountNode , address : " << notionalAmountNode << std::endl;
   #endif
   if(notionalAmountNode)
   {
      if(notionalAmountNode->Attribute("href") || notionalAmountNode->Attribute("id"))
      {
          if(notionalAmountNode->Attribute("id"))
          {
             notionalAmountIDRef_ = notionalAmountNode->Attribute("id");
             notionalAmount_ = boost::shared_ptr<Money>(new Money(notionalAmountNode));
             notionalAmount_->setID(notionalAmountIDRef_);
             IDManager::instance().setID(notionalAmountIDRef_,notionalAmount_);
          }
          else if(notionalAmountNode->Attribute("href")) { notionalAmountIDRef_ = notionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAmount_ = boost::shared_ptr<Money>(new Money(notionalAmountNode));}
   }

   //optionEntitlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionEntitlementNode = xmlNode->FirstChildElement("optionEntitlement");

   if(optionEntitlementNode){optionEntitlementIsNull_ = false;}
   else{optionEntitlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionEntitlementNode , address : " << optionEntitlementNode << std::endl;
   #endif
   if(optionEntitlementNode)
   {
      if(optionEntitlementNode->Attribute("href") || optionEntitlementNode->Attribute("id"))
      {
          if(optionEntitlementNode->Attribute("id"))
          {
             optionEntitlementIDRef_ = optionEntitlementNode->Attribute("id");
             optionEntitlement_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(optionEntitlementNode));
             optionEntitlement_->setID(optionEntitlementIDRef_);
             IDManager::instance().setID(optionEntitlementIDRef_,optionEntitlement_);
          }
          else if(optionEntitlementNode->Attribute("href")) { optionEntitlementIDRef_ = optionEntitlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionEntitlement_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(optionEntitlementNode));}
   }

   //entitlementCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entitlementCurrencyNode = xmlNode->FirstChildElement("entitlementCurrency");

   if(entitlementCurrencyNode){entitlementCurrencyIsNull_ = false;}
   else{entitlementCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entitlementCurrencyNode , address : " << entitlementCurrencyNode << std::endl;
   #endif
   if(entitlementCurrencyNode)
   {
      if(entitlementCurrencyNode->Attribute("href") || entitlementCurrencyNode->Attribute("id"))
      {
          if(entitlementCurrencyNode->Attribute("id"))
          {
             entitlementCurrencyIDRef_ = entitlementCurrencyNode->Attribute("id");
             entitlementCurrency_ = boost::shared_ptr<Currency>(new Currency(entitlementCurrencyNode));
             entitlementCurrency_->setID(entitlementCurrencyIDRef_);
             IDManager::instance().setID(entitlementCurrencyIDRef_,entitlementCurrency_);
          }
          else if(entitlementCurrencyNode->Attribute("href")) { entitlementCurrencyIDRef_ = entitlementCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { entitlementCurrency_ = boost::shared_ptr<Currency>(new Currency(entitlementCurrencyNode));}
   }

   //numberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberOfOptionsNode = xmlNode->FirstChildElement("numberOfOptions");

   if(numberOfOptionsNode){numberOfOptionsIsNull_ = false;}
   else{numberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberOfOptionsNode , address : " << numberOfOptionsNode << std::endl;
   #endif
   if(numberOfOptionsNode)
   {
      if(numberOfOptionsNode->Attribute("href") || numberOfOptionsNode->Attribute("id"))
      {
          if(numberOfOptionsNode->Attribute("id"))
          {
             numberOfOptionsIDRef_ = numberOfOptionsNode->Attribute("id");
             numberOfOptions_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(numberOfOptionsNode));
             numberOfOptions_->setID(numberOfOptionsIDRef_);
             IDManager::instance().setID(numberOfOptionsIDRef_,numberOfOptions_);
          }
          else if(numberOfOptionsNode->Attribute("href")) { numberOfOptionsIDRef_ = numberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberOfOptions_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(numberOfOptionsNode));}
   }

   //settlementTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementTypeNode = xmlNode->FirstChildElement("settlementType");

   if(settlementTypeNode){settlementTypeIsNull_ = false;}
   else{settlementTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementTypeNode , address : " << settlementTypeNode << std::endl;
   #endif
   if(settlementTypeNode)
   {
      if(settlementTypeNode->Attribute("href") || settlementTypeNode->Attribute("id"))
      {
          if(settlementTypeNode->Attribute("id"))
          {
             settlementTypeIDRef_ = settlementTypeNode->Attribute("id");
             settlementType_ = boost::shared_ptr<SettlementTypeEnum>(new SettlementTypeEnum(settlementTypeNode));
             settlementType_->setID(settlementTypeIDRef_);
             IDManager::instance().setID(settlementTypeIDRef_,settlementType_);
          }
          else if(settlementTypeNode->Attribute("href")) { settlementTypeIDRef_ = settlementTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementType_ = boost::shared_ptr<SettlementTypeEnum>(new SettlementTypeEnum(settlementTypeNode));}
   }

   //settlementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementDateNode = xmlNode->FirstChildElement("settlementDate");

   if(settlementDateNode){settlementDateIsNull_ = false;}
   else{settlementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementDateNode , address : " << settlementDateNode << std::endl;
   #endif
   if(settlementDateNode)
   {
      if(settlementDateNode->Attribute("href") || settlementDateNode->Attribute("id"))
      {
          if(settlementDateNode->Attribute("id"))
          {
             settlementDateIDRef_ = settlementDateNode->Attribute("id");
             settlementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(settlementDateNode));
             settlementDate_->setID(settlementDateIDRef_);
             IDManager::instance().setID(settlementDateIDRef_,settlementDate_);
          }
          else if(settlementDateNode->Attribute("href")) { settlementDateIDRef_ = settlementDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(settlementDateNode));}
   }

   //settlementAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementAmountNode = xmlNode->FirstChildElement("settlementAmount");

   if(settlementAmountNode){settlementAmountIsNull_ = false;}
   else{settlementAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementAmountNode , address : " << settlementAmountNode << std::endl;
   #endif
   if(settlementAmountNode)
   {
      if(settlementAmountNode->Attribute("href") || settlementAmountNode->Attribute("id"))
      {
          if(settlementAmountNode->Attribute("id"))
          {
             settlementAmountIDRef_ = settlementAmountNode->Attribute("id");
             settlementAmount_ = boost::shared_ptr<Money>(new Money(settlementAmountNode));
             settlementAmount_->setID(settlementAmountIDRef_);
             IDManager::instance().setID(settlementAmountIDRef_,settlementAmount_);
          }
          else if(settlementAmountNode->Attribute("href")) { settlementAmountIDRef_ = settlementAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementAmount_ = boost::shared_ptr<Money>(new Money(settlementAmountNode));}
   }

   //settlementCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementCurrencyNode = xmlNode->FirstChildElement("settlementCurrency");

   if(settlementCurrencyNode){settlementCurrencyIsNull_ = false;}
   else{settlementCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementCurrencyNode , address : " << settlementCurrencyNode << std::endl;
   #endif
   if(settlementCurrencyNode)
   {
      if(settlementCurrencyNode->Attribute("href") || settlementCurrencyNode->Attribute("id"))
      {
          if(settlementCurrencyNode->Attribute("id"))
          {
             settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("id");
             settlementCurrency_ = boost::shared_ptr<Currency>(new Currency(settlementCurrencyNode));
             settlementCurrency_->setID(settlementCurrencyIDRef_);
             IDManager::instance().setID(settlementCurrencyIDRef_,settlementCurrency_);
          }
          else if(settlementCurrencyNode->Attribute("href")) { settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementCurrency_ = boost::shared_ptr<Currency>(new Currency(settlementCurrencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Premium> OptionBaseExtended::getPremium()
{
   if(!this->premiumIsNull_){
        if(premiumIDRef_ != ""){
             return boost::shared_static_cast<Premium>(IDManager::instance().getID(premiumIDRef_));
        }else{
             return this->premium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Premium>();
   }
}
boost::shared_ptr<Exercise> OptionBaseExtended::getExercise()
{
   if(!this->exerciseIsNull_){
        if(exerciseIDRef_ != ""){
             return boost::shared_static_cast<Exercise>(IDManager::instance().getID(exerciseIDRef_));
        }else{
             return this->exercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Exercise>();
   }
}
boost::shared_ptr<AmericanExercise> OptionBaseExtended::getAmericanExercise()
{
   if(!this->americanExerciseIsNull_){
        if(americanExerciseIDRef_ != ""){
             return boost::shared_static_cast<AmericanExercise>(IDManager::instance().getID(americanExerciseIDRef_));
        }else{
             return this->americanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AmericanExercise>();
   }
}
boost::shared_ptr<BermudaExercise> OptionBaseExtended::getBermudaExercise()
{
   if(!this->bermudaExerciseIsNull_){
        if(bermudaExerciseIDRef_ != ""){
             return boost::shared_static_cast<BermudaExercise>(IDManager::instance().getID(bermudaExerciseIDRef_));
        }else{
             return this->bermudaExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BermudaExercise>();
   }
}
boost::shared_ptr<EuropeanExercise> OptionBaseExtended::getEuropeanExercise()
{
   if(!this->europeanExerciseIsNull_){
        if(europeanExerciseIDRef_ != ""){
             return boost::shared_static_cast<EuropeanExercise>(IDManager::instance().getID(europeanExerciseIDRef_));
        }else{
             return this->europeanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EuropeanExercise>();
   }
}
boost::shared_ptr<ExerciseProcedure> OptionBaseExtended::getExerciseProcedure()
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
boost::shared_ptr<OptionFeature> OptionBaseExtended::getFeature()
{
   if(!this->featureIsNull_){
        if(featureIDRef_ != ""){
             return boost::shared_static_cast<OptionFeature>(IDManager::instance().getID(featureIDRef_));
        }else{
             return this->feature_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionFeature>();
   }
}
boost::shared_ptr<NotionalAmountReference> OptionBaseExtended::getNotionalReference()
{
   if(!this->notionalReferenceIsNull_){
        if(notionalReferenceIDRef_ != ""){
             return boost::shared_static_cast<NotionalAmountReference>(IDManager::instance().getID(notionalReferenceIDRef_));
        }else{
             return this->notionalReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotionalAmountReference>();
   }
}
boost::shared_ptr<Money> OptionBaseExtended::getNotionalAmount()
{
   if(!this->notionalAmountIsNull_){
        if(notionalAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(notionalAmountIDRef_));
        }else{
             return this->notionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<PositiveDecimal> OptionBaseExtended::getOptionEntitlement()
{
   if(!this->optionEntitlementIsNull_){
        if(optionEntitlementIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(optionEntitlementIDRef_));
        }else{
             return this->optionEntitlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<Currency> OptionBaseExtended::getEntitlementCurrency()
{
   if(!this->entitlementCurrencyIsNull_){
        if(entitlementCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(entitlementCurrencyIDRef_));
        }else{
             return this->entitlementCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<PositiveDecimal> OptionBaseExtended::getNumberOfOptions()
{
   if(!this->numberOfOptionsIsNull_){
        if(numberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(numberOfOptionsIDRef_));
        }else{
             return this->numberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<SettlementTypeEnum> OptionBaseExtended::getSettlementType()
{
   if(!this->settlementTypeIsNull_){
        if(settlementTypeIDRef_ != ""){
             return boost::shared_static_cast<SettlementTypeEnum>(IDManager::instance().getID(settlementTypeIDRef_));
        }else{
             return this->settlementType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementTypeEnum>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> OptionBaseExtended::getSettlementDate()
{
   if(!this->settlementDateIsNull_){
        if(settlementDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(settlementDateIDRef_));
        }else{
             return this->settlementDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<Money> OptionBaseExtended::getSettlementAmount()
{
   if(!this->settlementAmountIsNull_){
        if(settlementAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(settlementAmountIDRef_));
        }else{
             return this->settlementAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<Currency> OptionBaseExtended::getSettlementCurrency()
{
   if(!this->settlementCurrencyIsNull_){
        if(settlementCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(settlementCurrencyIDRef_));
        }else{
             return this->settlementCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
}

