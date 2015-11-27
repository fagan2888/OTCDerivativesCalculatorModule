// FxDigitalOption.cpp 
#include "FxDigitalOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxDigitalOption::FxDigitalOption(TiXmlNode* xmlNode)
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
             americanExercise_ = boost::shared_ptr<FxDigitalAmericanExercise>(new FxDigitalAmericanExercise(americanExerciseNode));
             americanExercise_->setID(americanExerciseIDRef_);
             IDManager::instance().setID(americanExerciseIDRef_,americanExercise_);
          }
          else if(americanExerciseNode->Attribute("href")) { americanExerciseIDRef_ = americanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { americanExercise_ = boost::shared_ptr<FxDigitalAmericanExercise>(new FxDigitalAmericanExercise(americanExerciseNode));}
   }

   //touchNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* touchNode = xmlNode->FirstChildElement("touch");

   if(touchNode){touchIsNull_ = false;}
   else{touchIsNull_ = true;}

   if(touchNode)
   {
      for(touchNode; touchNode; touchNode = touchNode->NextSiblingElement("touch")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- touchNode , address : " << touchNode << std::endl;
          #endif
          if(touchNode->Attribute("href") || touchNode->Attribute("id"))
          {
              if(touchNode->Attribute("id"))
              {
                  touchIDRef_ = touchNode->Attribute("id");
                  touch_.push_back(boost::shared_ptr<FxTouch>(new FxTouch(touchNode)));
                  touch_.back()->setID(touchIDRef_);
                  IDManager::instance().setID(touchIDRef_, touch_.back());
              }
              else if(touchNode->Attribute("href")) { touchIDRef_ = touchNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { touch_.push_back(boost::shared_ptr<FxTouch>(new FxTouch(touchNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- touchNode , address : " << touchNode << std::endl;
       #endif
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

   //triggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerNode = xmlNode->FirstChildElement("trigger");

   if(triggerNode){triggerIsNull_ = false;}
   else{triggerIsNull_ = true;}

   if(triggerNode)
   {
      for(triggerNode; triggerNode; triggerNode = triggerNode->NextSiblingElement("trigger")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerNode , address : " << triggerNode << std::endl;
          #endif
          if(triggerNode->Attribute("href") || triggerNode->Attribute("id"))
          {
              if(triggerNode->Attribute("id"))
              {
                  triggerIDRef_ = triggerNode->Attribute("id");
                  trigger_.push_back(boost::shared_ptr<FxTrigger>(new FxTrigger(triggerNode)));
                  trigger_.back()->setID(triggerIDRef_);
                  IDManager::instance().setID(triggerIDRef_, trigger_.back());
              }
              else if(triggerNode->Attribute("href")) { triggerIDRef_ = triggerNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { trigger_.push_back(boost::shared_ptr<FxTrigger>(new FxTrigger(triggerNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerNode , address : " << triggerNode << std::endl;
       #endif
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

   //payoutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoutNode = xmlNode->FirstChildElement("payout");

   if(payoutNode){payoutIsNull_ = false;}
   else{payoutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoutNode , address : " << payoutNode << std::endl;
   #endif
   if(payoutNode)
   {
      if(payoutNode->Attribute("href") || payoutNode->Attribute("id"))
      {
          if(payoutNode->Attribute("id"))
          {
             payoutIDRef_ = payoutNode->Attribute("id");
             payout_ = boost::shared_ptr<FxOptionPayout>(new FxOptionPayout(payoutNode));
             payout_->setID(payoutIDRef_);
             IDManager::instance().setID(payoutIDRef_,payout_);
          }
          else if(payoutNode->Attribute("href")) { payoutIDRef_ = payoutNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payout_ = boost::shared_ptr<FxOptionPayout>(new FxOptionPayout(payoutNode));}
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> FxDigitalOption::getEffectiveDate()
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
boost::shared_ptr<Period> FxDigitalOption::getTenorPeriod()
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
boost::shared_ptr<FxDigitalAmericanExercise> FxDigitalOption::getAmericanExercise()
{
   if(!this->americanExerciseIsNull_){
        if(americanExerciseIDRef_ != ""){
             return boost::shared_static_cast<FxDigitalAmericanExercise>(IDManager::instance().getID(americanExerciseIDRef_));
        }else{
             return this->americanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxDigitalAmericanExercise>();
   }
}
std::vector<boost::shared_ptr<FxTouch>> FxDigitalOption::getTouch()
{
   if(!this->touchIsNull_){
        if(touchIDRef_ != ""){
             return this->touch_;
        }else{
             return this->touch_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxTouch>>();
   }
}
boost::shared_ptr<FxEuropeanExercise> FxDigitalOption::getEuropeanExercise()
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
std::vector<boost::shared_ptr<FxTrigger>> FxDigitalOption::getTrigger()
{
   if(!this->triggerIsNull_){
        if(triggerIDRef_ != ""){
             return this->trigger_;
        }else{
             return this->trigger_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxTrigger>>();
   }
}
boost::shared_ptr<ExerciseProcedure> FxDigitalOption::getExerciseProcedure()
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
boost::shared_ptr<FxOptionPayout> FxDigitalOption::getPayout()
{
   if(!this->payoutIsNull_){
        if(payoutIDRef_ != ""){
             return boost::shared_static_cast<FxOptionPayout>(IDManager::instance().getID(payoutIDRef_));
        }else{
             return this->payout_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxOptionPayout>();
   }
}
std::vector<boost::shared_ptr<FxOptionPremium>> FxDigitalOption::getPremium()
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
}

