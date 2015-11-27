// OptionalEarlyTermination.cpp 
#include "OptionalEarlyTermination.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionalEarlyTermination::OptionalEarlyTermination(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //singlePartyOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* singlePartyOptionNode = xmlNode->FirstChildElement("singlePartyOption");

   if(singlePartyOptionNode){singlePartyOptionIsNull_ = false;}
   else{singlePartyOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- singlePartyOptionNode , address : " << singlePartyOptionNode << std::endl;
   #endif
   if(singlePartyOptionNode)
   {
      if(singlePartyOptionNode->Attribute("href") || singlePartyOptionNode->Attribute("id"))
      {
          if(singlePartyOptionNode->Attribute("id"))
          {
             singlePartyOptionIDRef_ = singlePartyOptionNode->Attribute("id");
             singlePartyOption_ = boost::shared_ptr<SinglePartyOption>(new SinglePartyOption(singlePartyOptionNode));
             singlePartyOption_->setID(singlePartyOptionIDRef_);
             IDManager::instance().setID(singlePartyOptionIDRef_,singlePartyOption_);
          }
          else if(singlePartyOptionNode->Attribute("href")) { singlePartyOptionIDRef_ = singlePartyOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { singlePartyOption_ = boost::shared_ptr<SinglePartyOption>(new SinglePartyOption(singlePartyOptionNode));}
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

   //exerciseNoticeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseNoticeNode = xmlNode->FirstChildElement("exerciseNotice");

   if(exerciseNoticeNode){exerciseNoticeIsNull_ = false;}
   else{exerciseNoticeIsNull_ = true;}

   if(exerciseNoticeNode)
   {
      for(exerciseNoticeNode; exerciseNoticeNode; exerciseNoticeNode = exerciseNoticeNode->NextSiblingElement("exerciseNotice")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNoticeNode , address : " << exerciseNoticeNode << std::endl;
          #endif
          if(exerciseNoticeNode->Attribute("href") || exerciseNoticeNode->Attribute("id"))
          {
              if(exerciseNoticeNode->Attribute("id"))
              {
                  exerciseNoticeIDRef_ = exerciseNoticeNode->Attribute("id");
                  exerciseNotice_.push_back(boost::shared_ptr<ExerciseNotice>(new ExerciseNotice(exerciseNoticeNode)));
                  exerciseNotice_.back()->setID(exerciseNoticeIDRef_);
                  IDManager::instance().setID(exerciseNoticeIDRef_, exerciseNotice_.back());
              }
              else if(exerciseNoticeNode->Attribute("href")) { exerciseNoticeIDRef_ = exerciseNoticeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { exerciseNotice_.push_back(boost::shared_ptr<ExerciseNotice>(new ExerciseNotice(exerciseNoticeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNoticeNode , address : " << exerciseNoticeNode << std::endl;
       #endif
   }

   //followUpConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* followUpConfirmationNode = xmlNode->FirstChildElement("followUpConfirmation");

   if(followUpConfirmationNode){followUpConfirmationIsNull_ = false;}
   else{followUpConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- followUpConfirmationNode , address : " << followUpConfirmationNode << std::endl;
   #endif
   if(followUpConfirmationNode)
   {
      if(followUpConfirmationNode->Attribute("href") || followUpConfirmationNode->Attribute("id"))
      {
          if(followUpConfirmationNode->Attribute("id"))
          {
             followUpConfirmationIDRef_ = followUpConfirmationNode->Attribute("id");
             followUpConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(followUpConfirmationNode));
             followUpConfirmation_->setID(followUpConfirmationIDRef_);
             IDManager::instance().setID(followUpConfirmationIDRef_,followUpConfirmation_);
          }
          else if(followUpConfirmationNode->Attribute("href")) { followUpConfirmationIDRef_ = followUpConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { followUpConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(followUpConfirmationNode));}
   }

   //calculationAgentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentNode = xmlNode->FirstChildElement("calculationAgent");

   if(calculationAgentNode){calculationAgentIsNull_ = false;}
   else{calculationAgentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentNode , address : " << calculationAgentNode << std::endl;
   #endif
   if(calculationAgentNode)
   {
      if(calculationAgentNode->Attribute("href") || calculationAgentNode->Attribute("id"))
      {
          if(calculationAgentNode->Attribute("id"))
          {
             calculationAgentIDRef_ = calculationAgentNode->Attribute("id");
             calculationAgent_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentNode));
             calculationAgent_->setID(calculationAgentIDRef_);
             IDManager::instance().setID(calculationAgentIDRef_,calculationAgent_);
          }
          else if(calculationAgentNode->Attribute("href")) { calculationAgentIDRef_ = calculationAgentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAgent_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentNode));}
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
             cashSettlement_ = boost::shared_ptr<CashSettlement>(new CashSettlement(cashSettlementNode));
             cashSettlement_->setID(cashSettlementIDRef_);
             IDManager::instance().setID(cashSettlementIDRef_,cashSettlement_);
          }
          else if(cashSettlementNode->Attribute("href")) { cashSettlementIDRef_ = cashSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlement_ = boost::shared_ptr<CashSettlement>(new CashSettlement(cashSettlementNode));}
   }

   //optionalEarlyTerminationAdjustedDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionalEarlyTerminationAdjustedDatesNode = xmlNode->FirstChildElement("optionalEarlyTerminationAdjustedDates");

   if(optionalEarlyTerminationAdjustedDatesNode){optionalEarlyTerminationAdjustedDatesIsNull_ = false;}
   else{optionalEarlyTerminationAdjustedDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionalEarlyTerminationAdjustedDatesNode , address : " << optionalEarlyTerminationAdjustedDatesNode << std::endl;
   #endif
   if(optionalEarlyTerminationAdjustedDatesNode)
   {
      if(optionalEarlyTerminationAdjustedDatesNode->Attribute("href") || optionalEarlyTerminationAdjustedDatesNode->Attribute("id"))
      {
          if(optionalEarlyTerminationAdjustedDatesNode->Attribute("id"))
          {
             optionalEarlyTerminationAdjustedDatesIDRef_ = optionalEarlyTerminationAdjustedDatesNode->Attribute("id");
             optionalEarlyTerminationAdjustedDates_ = boost::shared_ptr<OptionalEarlyTerminationAdjustedDates>(new OptionalEarlyTerminationAdjustedDates(optionalEarlyTerminationAdjustedDatesNode));
             optionalEarlyTerminationAdjustedDates_->setID(optionalEarlyTerminationAdjustedDatesIDRef_);
             IDManager::instance().setID(optionalEarlyTerminationAdjustedDatesIDRef_,optionalEarlyTerminationAdjustedDates_);
          }
          else if(optionalEarlyTerminationAdjustedDatesNode->Attribute("href")) { optionalEarlyTerminationAdjustedDatesIDRef_ = optionalEarlyTerminationAdjustedDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionalEarlyTerminationAdjustedDates_ = boost::shared_ptr<OptionalEarlyTerminationAdjustedDates>(new OptionalEarlyTerminationAdjustedDates(optionalEarlyTerminationAdjustedDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SinglePartyOption> OptionalEarlyTermination::getSinglePartyOption()
{
   if(!this->singlePartyOptionIsNull_){
        if(singlePartyOptionIDRef_ != ""){
             return boost::shared_static_cast<SinglePartyOption>(IDManager::instance().getID(singlePartyOptionIDRef_));
        }else{
             return this->singlePartyOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SinglePartyOption>();
   }
}
boost::shared_ptr<Exercise> OptionalEarlyTermination::getExercise()
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
boost::shared_ptr<AmericanExercise> OptionalEarlyTermination::getAmericanExercise()
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
boost::shared_ptr<BermudaExercise> OptionalEarlyTermination::getBermudaExercise()
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
boost::shared_ptr<EuropeanExercise> OptionalEarlyTermination::getEuropeanExercise()
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
std::vector<boost::shared_ptr<ExerciseNotice>> OptionalEarlyTermination::getExerciseNotice()
{
   if(!this->exerciseNoticeIsNull_){
        if(exerciseNoticeIDRef_ != ""){
             return this->exerciseNotice_;
        }else{
             return this->exerciseNotice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExerciseNotice>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> OptionalEarlyTermination::getFollowUpConfirmation()
{
   if(!this->followUpConfirmationIsNull_){
        if(followUpConfirmationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(followUpConfirmationIDRef_));
        }else{
             return this->followUpConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CalculationAgent> OptionalEarlyTermination::getCalculationAgent()
{
   if(!this->calculationAgentIsNull_){
        if(calculationAgentIDRef_ != ""){
             return boost::shared_static_cast<CalculationAgent>(IDManager::instance().getID(calculationAgentIDRef_));
        }else{
             return this->calculationAgent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAgent>();
   }
}
boost::shared_ptr<CashSettlement> OptionalEarlyTermination::getCashSettlement()
{
   if(!this->cashSettlementIsNull_){
        if(cashSettlementIDRef_ != ""){
             return boost::shared_static_cast<CashSettlement>(IDManager::instance().getID(cashSettlementIDRef_));
        }else{
             return this->cashSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashSettlement>();
   }
}
boost::shared_ptr<OptionalEarlyTerminationAdjustedDates> OptionalEarlyTermination::getOptionalEarlyTerminationAdjustedDates()
{
   if(!this->optionalEarlyTerminationAdjustedDatesIsNull_){
        if(optionalEarlyTerminationAdjustedDatesIDRef_ != ""){
             return boost::shared_static_cast<OptionalEarlyTerminationAdjustedDates>(IDManager::instance().getID(optionalEarlyTerminationAdjustedDatesIDRef_));
        }else{
             return this->optionalEarlyTerminationAdjustedDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionalEarlyTerminationAdjustedDates>();
   }
}
}

