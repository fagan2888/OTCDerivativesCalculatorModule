// Swaption.cpp 
#include "Swaption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Swaption::Swaption(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //buyerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerPartyReferenceNode = xmlNode->FirstChildElement("buyerPartyReference");

   if(buyerPartyReferenceNode){buyerPartyReferenceIsNull_ = false;}
   else{buyerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerPartyReferenceNode , address : " << buyerPartyReferenceNode << std::endl;
   #endif
   if(buyerPartyReferenceNode)
   {
      if(buyerPartyReferenceNode->Attribute("href") || buyerPartyReferenceNode->Attribute("id"))
      {
          if(buyerPartyReferenceNode->Attribute("id"))
          {
             buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("id");
             buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));
             buyerPartyReference_->setID(buyerPartyReferenceIDRef_);
             IDManager::instance().setID(buyerPartyReferenceIDRef_,buyerPartyReference_);
          }
          else if(buyerPartyReferenceNode->Attribute("href")) { buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));}
   }

   //buyerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerAccountReferenceNode = xmlNode->FirstChildElement("buyerAccountReference");

   if(buyerAccountReferenceNode){buyerAccountReferenceIsNull_ = false;}
   else{buyerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerAccountReferenceNode , address : " << buyerAccountReferenceNode << std::endl;
   #endif
   if(buyerAccountReferenceNode)
   {
      if(buyerAccountReferenceNode->Attribute("href") || buyerAccountReferenceNode->Attribute("id"))
      {
          if(buyerAccountReferenceNode->Attribute("id"))
          {
             buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("id");
             buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));
             buyerAccountReference_->setID(buyerAccountReferenceIDRef_);
             IDManager::instance().setID(buyerAccountReferenceIDRef_,buyerAccountReference_);
          }
          else if(buyerAccountReferenceNode->Attribute("href")) { buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));}
   }

   //sellerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerPartyReferenceNode = xmlNode->FirstChildElement("sellerPartyReference");

   if(sellerPartyReferenceNode){sellerPartyReferenceIsNull_ = false;}
   else{sellerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerPartyReferenceNode , address : " << sellerPartyReferenceNode << std::endl;
   #endif
   if(sellerPartyReferenceNode)
   {
      if(sellerPartyReferenceNode->Attribute("href") || sellerPartyReferenceNode->Attribute("id"))
      {
          if(sellerPartyReferenceNode->Attribute("id"))
          {
             sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("id");
             sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));
             sellerPartyReference_->setID(sellerPartyReferenceIDRef_);
             IDManager::instance().setID(sellerPartyReferenceIDRef_,sellerPartyReference_);
          }
          else if(sellerPartyReferenceNode->Attribute("href")) { sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));}
   }

   //sellerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerAccountReferenceNode = xmlNode->FirstChildElement("sellerAccountReference");

   if(sellerAccountReferenceNode){sellerAccountReferenceIsNull_ = false;}
   else{sellerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerAccountReferenceNode , address : " << sellerAccountReferenceNode << std::endl;
   #endif
   if(sellerAccountReferenceNode)
   {
      if(sellerAccountReferenceNode->Attribute("href") || sellerAccountReferenceNode->Attribute("id"))
      {
          if(sellerAccountReferenceNode->Attribute("id"))
          {
             sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("id");
             sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));
             sellerAccountReference_->setID(sellerAccountReferenceIDRef_);
             IDManager::instance().setID(sellerAccountReferenceIDRef_,sellerAccountReference_);
          }
          else if(sellerAccountReferenceNode->Attribute("href")) { sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));}
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
                  premium_.push_back(boost::shared_ptr<Payment>(new Payment(premiumNode)));
                  premium_.back()->setID(premiumIDRef_);
                  IDManager::instance().setID(premiumIDRef_, premium_.back());
              }
              else if(premiumNode->Attribute("href")) { premiumIDRef_ = premiumNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { premium_.push_back(boost::shared_ptr<Payment>(new Payment(premiumNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
       #endif
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

   //physicalSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalSettlementNode = xmlNode->FirstChildElement("physicalSettlement");

   if(physicalSettlementNode){physicalSettlementIsNull_ = false;}
   else{physicalSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalSettlementNode , address : " << physicalSettlementNode << std::endl;
   #endif
   if(physicalSettlementNode)
   {
      if(physicalSettlementNode->Attribute("href") || physicalSettlementNode->Attribute("id"))
      {
          if(physicalSettlementNode->Attribute("id"))
          {
             physicalSettlementIDRef_ = physicalSettlementNode->Attribute("id");
             physicalSettlement_ = boost::shared_ptr<SwaptionPhysicalSettlement>(new SwaptionPhysicalSettlement(physicalSettlementNode));
             physicalSettlement_->setID(physicalSettlementIDRef_);
             IDManager::instance().setID(physicalSettlementIDRef_,physicalSettlement_);
          }
          else if(physicalSettlementNode->Attribute("href")) { physicalSettlementIDRef_ = physicalSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalSettlement_ = boost::shared_ptr<SwaptionPhysicalSettlement>(new SwaptionPhysicalSettlement(physicalSettlementNode));}
   }

   //swaptionStraddleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swaptionStraddleNode = xmlNode->FirstChildElement("swaptionStraddle");

   if(swaptionStraddleNode){swaptionStraddleIsNull_ = false;}
   else{swaptionStraddleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swaptionStraddleNode , address : " << swaptionStraddleNode << std::endl;
   #endif
   if(swaptionStraddleNode)
   {
      if(swaptionStraddleNode->Attribute("href") || swaptionStraddleNode->Attribute("id"))
      {
          if(swaptionStraddleNode->Attribute("id"))
          {
             swaptionStraddleIDRef_ = swaptionStraddleNode->Attribute("id");
             swaptionStraddle_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(swaptionStraddleNode));
             swaptionStraddle_->setID(swaptionStraddleIDRef_);
             IDManager::instance().setID(swaptionStraddleIDRef_,swaptionStraddle_);
          }
          else if(swaptionStraddleNode->Attribute("href")) { swaptionStraddleIDRef_ = swaptionStraddleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swaptionStraddle_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(swaptionStraddleNode));}
   }

   //swaptionAdjustedDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swaptionAdjustedDatesNode = xmlNode->FirstChildElement("swaptionAdjustedDates");

   if(swaptionAdjustedDatesNode){swaptionAdjustedDatesIsNull_ = false;}
   else{swaptionAdjustedDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swaptionAdjustedDatesNode , address : " << swaptionAdjustedDatesNode << std::endl;
   #endif
   if(swaptionAdjustedDatesNode)
   {
      if(swaptionAdjustedDatesNode->Attribute("href") || swaptionAdjustedDatesNode->Attribute("id"))
      {
          if(swaptionAdjustedDatesNode->Attribute("id"))
          {
             swaptionAdjustedDatesIDRef_ = swaptionAdjustedDatesNode->Attribute("id");
             swaptionAdjustedDates_ = boost::shared_ptr<SwaptionAdjustedDates>(new SwaptionAdjustedDates(swaptionAdjustedDatesNode));
             swaptionAdjustedDates_->setID(swaptionAdjustedDatesIDRef_);
             IDManager::instance().setID(swaptionAdjustedDatesIDRef_,swaptionAdjustedDates_);
          }
          else if(swaptionAdjustedDatesNode->Attribute("href")) { swaptionAdjustedDatesIDRef_ = swaptionAdjustedDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swaptionAdjustedDates_ = boost::shared_ptr<SwaptionAdjustedDates>(new SwaptionAdjustedDates(swaptionAdjustedDatesNode));}
   }

   //swapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapNode = xmlNode->FirstChildElement("swap");

   if(swapNode){swapIsNull_ = false;}
   else{swapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapNode , address : " << swapNode << std::endl;
   #endif
   if(swapNode)
   {
      if(swapNode->Attribute("href") || swapNode->Attribute("id"))
      {
          if(swapNode->Attribute("id"))
          {
             swapIDRef_ = swapNode->Attribute("id");
             swap_ = boost::shared_ptr<Swap>(new Swap(swapNode));
             swap_->setID(swapIDRef_);
             IDManager::instance().setID(swapIDRef_,swap_);
          }
          else if(swapNode->Attribute("href")) { swapIDRef_ = swapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swap_ = boost::shared_ptr<Swap>(new Swap(swapNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> Swaption::getBuyerPartyReference()
{
   if(!this->buyerPartyReferenceIsNull_){
        if(buyerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(buyerPartyReferenceIDRef_));
        }else{
             return this->buyerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> Swaption::getBuyerAccountReference()
{
   if(!this->buyerAccountReferenceIsNull_){
        if(buyerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(buyerAccountReferenceIDRef_));
        }else{
             return this->buyerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> Swaption::getSellerPartyReference()
{
   if(!this->sellerPartyReferenceIsNull_){
        if(sellerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(sellerPartyReferenceIDRef_));
        }else{
             return this->sellerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> Swaption::getSellerAccountReference()
{
   if(!this->sellerAccountReferenceIsNull_){
        if(sellerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(sellerAccountReferenceIDRef_));
        }else{
             return this->sellerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
std::vector<boost::shared_ptr<Payment>> Swaption::getPremium()
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
      return std::vector<boost::shared_ptr<Payment>>();
   }
}
boost::shared_ptr<Exercise> Swaption::getExercise()
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
boost::shared_ptr<AmericanExercise> Swaption::getAmericanExercise()
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
boost::shared_ptr<BermudaExercise> Swaption::getBermudaExercise()
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
boost::shared_ptr<EuropeanExercise> Swaption::getEuropeanExercise()
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
boost::shared_ptr<ExerciseProcedure> Swaption::getExerciseProcedure()
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
boost::shared_ptr<CalculationAgent> Swaption::getCalculationAgent()
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
boost::shared_ptr<CashSettlement> Swaption::getCashSettlement()
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
boost::shared_ptr<SwaptionPhysicalSettlement> Swaption::getPhysicalSettlement()
{
   if(!this->physicalSettlementIsNull_){
        if(physicalSettlementIDRef_ != ""){
             return boost::shared_static_cast<SwaptionPhysicalSettlement>(IDManager::instance().getID(physicalSettlementIDRef_));
        }else{
             return this->physicalSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SwaptionPhysicalSettlement>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Swaption::getSwaptionStraddle()
{
   if(!this->swaptionStraddleIsNull_){
        if(swaptionStraddleIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(swaptionStraddleIDRef_));
        }else{
             return this->swaptionStraddle_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<SwaptionAdjustedDates> Swaption::getSwaptionAdjustedDates()
{
   if(!this->swaptionAdjustedDatesIsNull_){
        if(swaptionAdjustedDatesIDRef_ != ""){
             return boost::shared_static_cast<SwaptionAdjustedDates>(IDManager::instance().getID(swaptionAdjustedDatesIDRef_));
        }else{
             return this->swaptionAdjustedDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SwaptionAdjustedDates>();
   }
}
boost::shared_ptr<Swap> Swaption::getSwap()
{
   if(!this->swapIsNull_){
        if(swapIDRef_ != ""){
             return boost::shared_static_cast<Swap>(IDManager::instance().getID(swapIDRef_));
        }else{
             return this->swap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Swap>();
   }
}
}

