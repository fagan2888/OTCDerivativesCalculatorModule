// OptionExercise.cpp 
#include "OptionExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionExercise::OptionExercise(TiXmlNode* xmlNode)
: AbstractEvent(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //optionSellerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionSellerNode = xmlNode->FirstChildElement("optionSeller");

   if(optionSellerNode){optionSellerIsNull_ = false;}
   else{optionSellerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionSellerNode , address : " << optionSellerNode << std::endl;
   #endif
   if(optionSellerNode)
   {
      if(optionSellerNode->Attribute("href") || optionSellerNode->Attribute("id"))
      {
          if(optionSellerNode->Attribute("id"))
          {
             optionSellerIDRef_ = optionSellerNode->Attribute("id");
             optionSeller_ = boost::shared_ptr<PartyReference>(new PartyReference(optionSellerNode));
             optionSeller_->setID(optionSellerIDRef_);
             IDManager::instance().setID(optionSellerIDRef_,optionSeller_);
          }
          else if(optionSellerNode->Attribute("href")) { optionSellerIDRef_ = optionSellerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionSeller_ = boost::shared_ptr<PartyReference>(new PartyReference(optionSellerNode));}
   }

   //optionBuyerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionBuyerNode = xmlNode->FirstChildElement("optionBuyer");

   if(optionBuyerNode){optionBuyerIsNull_ = false;}
   else{optionBuyerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionBuyerNode , address : " << optionBuyerNode << std::endl;
   #endif
   if(optionBuyerNode)
   {
      if(optionBuyerNode->Attribute("href") || optionBuyerNode->Attribute("id"))
      {
          if(optionBuyerNode->Attribute("id"))
          {
             optionBuyerIDRef_ = optionBuyerNode->Attribute("id");
             optionBuyer_ = boost::shared_ptr<PartyReference>(new PartyReference(optionBuyerNode));
             optionBuyer_->setID(optionBuyerIDRef_);
             IDManager::instance().setID(optionBuyerIDRef_,optionBuyer_);
          }
          else if(optionBuyerNode->Attribute("href")) { optionBuyerIDRef_ = optionBuyerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionBuyer_ = boost::shared_ptr<PartyReference>(new PartyReference(optionBuyerNode));}
   }

   //originalTradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originalTradeNode = xmlNode->FirstChildElement("originalTrade");

   if(originalTradeNode){originalTradeIsNull_ = false;}
   else{originalTradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originalTradeNode , address : " << originalTradeNode << std::endl;
   #endif
   if(originalTradeNode)
   {
      if(originalTradeNode->Attribute("href") || originalTradeNode->Attribute("id"))
      {
          if(originalTradeNode->Attribute("id"))
          {
             originalTradeIDRef_ = originalTradeNode->Attribute("id");
             originalTrade_ = boost::shared_ptr<Trade>(new Trade(originalTradeNode));
             originalTrade_->setID(originalTradeIDRef_);
             IDManager::instance().setID(originalTradeIDRef_,originalTrade_);
          }
          else if(originalTradeNode->Attribute("href")) { originalTradeIDRef_ = originalTradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originalTrade_ = boost::shared_ptr<Trade>(new Trade(originalTradeNode));}
   }

   //tradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierNode = xmlNode->FirstChildElement("tradeIdentifier");

   if(tradeIdentifierNode){tradeIdentifierIsNull_ = false;}
   else{tradeIdentifierIsNull_ = true;}

   if(tradeIdentifierNode)
   {
      for(tradeIdentifierNode; tradeIdentifierNode; tradeIdentifierNode = tradeIdentifierNode->NextSiblingElement("tradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
          #endif
          if(tradeIdentifierNode->Attribute("href") || tradeIdentifierNode->Attribute("id"))
          {
              if(tradeIdentifierNode->Attribute("id"))
              {
                  tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("id");
                  tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));
                  tradeIdentifier_.back()->setID(tradeIdentifierIDRef_);
                  IDManager::instance().setID(tradeIdentifierIDRef_, tradeIdentifier_.back());
              }
              else if(tradeIdentifierNode->Attribute("href")) { tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
       #endif
   }

   //exerciseDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseDateNode = xmlNode->FirstChildElement("exerciseDate");

   if(exerciseDateNode){exerciseDateIsNull_ = false;}
   else{exerciseDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseDateNode , address : " << exerciseDateNode << std::endl;
   #endif
   if(exerciseDateNode)
   {
      if(exerciseDateNode->Attribute("href") || exerciseDateNode->Attribute("id"))
      {
          if(exerciseDateNode->Attribute("id"))
          {
             exerciseDateIDRef_ = exerciseDateNode->Attribute("id");
             exerciseDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(exerciseDateNode));
             exerciseDate_->setID(exerciseDateIDRef_);
             IDManager::instance().setID(exerciseDateIDRef_,exerciseDate_);
          }
          else if(exerciseDateNode->Attribute("href")) { exerciseDateIDRef_ = exerciseDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(exerciseDateNode));}
   }

   //exerciseTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseTimeNode = xmlNode->FirstChildElement("exerciseTime");

   if(exerciseTimeNode){exerciseTimeIsNull_ = false;}
   else{exerciseTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseTimeNode , address : " << exerciseTimeNode << std::endl;
   #endif
   if(exerciseTimeNode)
   {
      if(exerciseTimeNode->Attribute("href") || exerciseTimeNode->Attribute("id"))
      {
          if(exerciseTimeNode->Attribute("id"))
          {
             exerciseTimeIDRef_ = exerciseTimeNode->Attribute("id");
             exerciseTime_ = boost::shared_ptr<XsdTypeTime>(new XsdTypeTime(exerciseTimeNode));
             exerciseTime_->setID(exerciseTimeIDRef_);
             IDManager::instance().setID(exerciseTimeIDRef_,exerciseTime_);
          }
          else if(exerciseTimeNode->Attribute("href")) { exerciseTimeIDRef_ = exerciseTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseTime_ = boost::shared_ptr<XsdTypeTime>(new XsdTypeTime(exerciseTimeNode));}
   }

   //expiryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiryNode = xmlNode->FirstChildElement("expiry");

   if(expiryNode){expiryIsNull_ = false;}
   else{expiryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiryNode , address : " << expiryNode << std::endl;
   #endif
   if(expiryNode)
   {
      if(expiryNode->Attribute("href") || expiryNode->Attribute("id"))
      {
          if(expiryNode->Attribute("id"))
          {
             expiryIDRef_ = expiryNode->Attribute("id");
             expiry_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(expiryNode));
             expiry_->setID(expiryIDRef_);
             IDManager::instance().setID(expiryIDRef_,expiry_);
          }
          else if(expiryNode->Attribute("href")) { expiryIDRef_ = expiryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiry_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(expiryNode));}
   }

   //fullExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fullExerciseNode = xmlNode->FirstChildElement("fullExercise");

   if(fullExerciseNode){fullExerciseIsNull_ = false;}
   else{fullExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fullExerciseNode , address : " << fullExerciseNode << std::endl;
   #endif
   if(fullExerciseNode)
   {
      if(fullExerciseNode->Attribute("href") || fullExerciseNode->Attribute("id"))
      {
          if(fullExerciseNode->Attribute("id"))
          {
             fullExerciseIDRef_ = fullExerciseNode->Attribute("id");
             fullExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullExerciseNode));
             fullExercise_->setID(fullExerciseIDRef_);
             IDManager::instance().setID(fullExerciseIDRef_,fullExercise_);
          }
          else if(fullExerciseNode->Attribute("href")) { fullExerciseIDRef_ = fullExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fullExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullExerciseNode));}
   }

   //exerciseInNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseInNotionalAmountNode = xmlNode->FirstChildElement("exerciseInNotionalAmount");

   if(exerciseInNotionalAmountNode){exerciseInNotionalAmountIsNull_ = false;}
   else{exerciseInNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseInNotionalAmountNode , address : " << exerciseInNotionalAmountNode << std::endl;
   #endif
   if(exerciseInNotionalAmountNode)
   {
      if(exerciseInNotionalAmountNode->Attribute("href") || exerciseInNotionalAmountNode->Attribute("id"))
      {
          if(exerciseInNotionalAmountNode->Attribute("id"))
          {
             exerciseInNotionalAmountIDRef_ = exerciseInNotionalAmountNode->Attribute("id");
             exerciseInNotionalAmount_ = boost::shared_ptr<Money>(new Money(exerciseInNotionalAmountNode));
             exerciseInNotionalAmount_->setID(exerciseInNotionalAmountIDRef_);
             IDManager::instance().setID(exerciseInNotionalAmountIDRef_,exerciseInNotionalAmount_);
          }
          else if(exerciseInNotionalAmountNode->Attribute("href")) { exerciseInNotionalAmountIDRef_ = exerciseInNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseInNotionalAmount_ = boost::shared_ptr<Money>(new Money(exerciseInNotionalAmountNode));}
   }

   //outstandingNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* outstandingNotionalAmountNode = xmlNode->FirstChildElement("outstandingNotionalAmount");

   if(outstandingNotionalAmountNode){outstandingNotionalAmountIsNull_ = false;}
   else{outstandingNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- outstandingNotionalAmountNode , address : " << outstandingNotionalAmountNode << std::endl;
   #endif
   if(outstandingNotionalAmountNode)
   {
      if(outstandingNotionalAmountNode->Attribute("href") || outstandingNotionalAmountNode->Attribute("id"))
      {
          if(outstandingNotionalAmountNode->Attribute("id"))
          {
             outstandingNotionalAmountIDRef_ = outstandingNotionalAmountNode->Attribute("id");
             outstandingNotionalAmount_ = boost::shared_ptr<Money>(new Money(outstandingNotionalAmountNode));
             outstandingNotionalAmount_->setID(outstandingNotionalAmountIDRef_);
             IDManager::instance().setID(outstandingNotionalAmountIDRef_,outstandingNotionalAmount_);
          }
          else if(outstandingNotionalAmountNode->Attribute("href")) { outstandingNotionalAmountIDRef_ = outstandingNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { outstandingNotionalAmount_ = boost::shared_ptr<Money>(new Money(outstandingNotionalAmountNode));}
   }

   //exerciseInNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseInNumberOfOptionsNode = xmlNode->FirstChildElement("exerciseInNumberOfOptions");

   if(exerciseInNumberOfOptionsNode){exerciseInNumberOfOptionsIsNull_ = false;}
   else{exerciseInNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseInNumberOfOptionsNode , address : " << exerciseInNumberOfOptionsNode << std::endl;
   #endif
   if(exerciseInNumberOfOptionsNode)
   {
      if(exerciseInNumberOfOptionsNode->Attribute("href") || exerciseInNumberOfOptionsNode->Attribute("id"))
      {
          if(exerciseInNumberOfOptionsNode->Attribute("id"))
          {
             exerciseInNumberOfOptionsIDRef_ = exerciseInNumberOfOptionsNode->Attribute("id");
             exerciseInNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(exerciseInNumberOfOptionsNode));
             exerciseInNumberOfOptions_->setID(exerciseInNumberOfOptionsIDRef_);
             IDManager::instance().setID(exerciseInNumberOfOptionsIDRef_,exerciseInNumberOfOptions_);
          }
          else if(exerciseInNumberOfOptionsNode->Attribute("href")) { exerciseInNumberOfOptionsIDRef_ = exerciseInNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseInNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(exerciseInNumberOfOptionsNode));}
   }

   //outstandingNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* outstandingNumberOfOptionsNode = xmlNode->FirstChildElement("outstandingNumberOfOptions");

   if(outstandingNumberOfOptionsNode){outstandingNumberOfOptionsIsNull_ = false;}
   else{outstandingNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- outstandingNumberOfOptionsNode , address : " << outstandingNumberOfOptionsNode << std::endl;
   #endif
   if(outstandingNumberOfOptionsNode)
   {
      if(outstandingNumberOfOptionsNode->Attribute("href") || outstandingNumberOfOptionsNode->Attribute("id"))
      {
          if(outstandingNumberOfOptionsNode->Attribute("id"))
          {
             outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode->Attribute("id");
             outstandingNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfOptionsNode));
             outstandingNumberOfOptions_->setID(outstandingNumberOfOptionsIDRef_);
             IDManager::instance().setID(outstandingNumberOfOptionsIDRef_,outstandingNumberOfOptions_);
          }
          else if(outstandingNumberOfOptionsNode->Attribute("href")) { outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { outstandingNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfOptionsNode));}
   }

   //exerciseInNumberOfUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseInNumberOfUnitsNode = xmlNode->FirstChildElement("exerciseInNumberOfUnits");

   if(exerciseInNumberOfUnitsNode){exerciseInNumberOfUnitsIsNull_ = false;}
   else{exerciseInNumberOfUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseInNumberOfUnitsNode , address : " << exerciseInNumberOfUnitsNode << std::endl;
   #endif
   if(exerciseInNumberOfUnitsNode)
   {
      if(exerciseInNumberOfUnitsNode->Attribute("href") || exerciseInNumberOfUnitsNode->Attribute("id"))
      {
          if(exerciseInNumberOfUnitsNode->Attribute("id"))
          {
             exerciseInNumberOfUnitsIDRef_ = exerciseInNumberOfUnitsNode->Attribute("id");
             exerciseInNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(exerciseInNumberOfUnitsNode));
             exerciseInNumberOfUnits_->setID(exerciseInNumberOfUnitsIDRef_);
             IDManager::instance().setID(exerciseInNumberOfUnitsIDRef_,exerciseInNumberOfUnits_);
          }
          else if(exerciseInNumberOfUnitsNode->Attribute("href")) { exerciseInNumberOfUnitsIDRef_ = exerciseInNumberOfUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseInNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(exerciseInNumberOfUnitsNode));}
   }

   //outstandingNumberOfUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* outstandingNumberOfUnitsNode = xmlNode->FirstChildElement("outstandingNumberOfUnits");

   if(outstandingNumberOfUnitsNode){outstandingNumberOfUnitsIsNull_ = false;}
   else{outstandingNumberOfUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- outstandingNumberOfUnitsNode , address : " << outstandingNumberOfUnitsNode << std::endl;
   #endif
   if(outstandingNumberOfUnitsNode)
   {
      if(outstandingNumberOfUnitsNode->Attribute("href") || outstandingNumberOfUnitsNode->Attribute("id"))
      {
          if(outstandingNumberOfUnitsNode->Attribute("id"))
          {
             outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode->Attribute("id");
             outstandingNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfUnitsNode));
             outstandingNumberOfUnits_->setID(outstandingNumberOfUnitsIDRef_);
             IDManager::instance().setID(outstandingNumberOfUnitsIDRef_,outstandingNumberOfUnits_);
          }
          else if(outstandingNumberOfUnitsNode->Attribute("href")) { outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { outstandingNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfUnitsNode));}
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
             cashSettlement_ = boost::shared_ptr<SimplePayment>(new SimplePayment(cashSettlementNode));
             cashSettlement_->setID(cashSettlementIDRef_);
             IDManager::instance().setID(cashSettlementIDRef_,cashSettlement_);
          }
          else if(cashSettlementNode->Attribute("href")) { cashSettlementIDRef_ = cashSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlement_ = boost::shared_ptr<SimplePayment>(new SimplePayment(cashSettlementNode));}
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
             physicalSettlement_ = boost::shared_ptr<PhysicalSettlement>(new PhysicalSettlement(physicalSettlementNode));
             physicalSettlement_->setID(physicalSettlementIDRef_);
             IDManager::instance().setID(physicalSettlementIDRef_,physicalSettlement_);
          }
          else if(physicalSettlementNode->Attribute("href")) { physicalSettlementIDRef_ = physicalSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalSettlement_ = boost::shared_ptr<PhysicalSettlement>(new PhysicalSettlement(physicalSettlementNode));}
   }

   //paymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentNode = xmlNode->FirstChildElement("payment");

   if(paymentNode){paymentIsNull_ = false;}
   else{paymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
   #endif
   if(paymentNode)
   {
      if(paymentNode->Attribute("href") || paymentNode->Attribute("id"))
      {
          if(paymentNode->Attribute("id"))
          {
             paymentIDRef_ = paymentNode->Attribute("id");
             payment_ = boost::shared_ptr<NonNegativePayment>(new NonNegativePayment(paymentNode));
             payment_->setID(paymentIDRef_);
             IDManager::instance().setID(paymentIDRef_,payment_);
          }
          else if(paymentNode->Attribute("href")) { paymentIDRef_ = paymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payment_ = boost::shared_ptr<NonNegativePayment>(new NonNegativePayment(paymentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> OptionExercise::getOptionSeller()
{
   if(!this->optionSellerIsNull_){
        if(optionSellerIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(optionSellerIDRef_));
        }else{
             return this->optionSeller_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> OptionExercise::getOptionBuyer()
{
   if(!this->optionBuyerIsNull_){
        if(optionBuyerIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(optionBuyerIDRef_));
        }else{
             return this->optionBuyer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<Trade> OptionExercise::getOriginalTrade()
{
   if(!this->originalTradeIsNull_){
        if(originalTradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(originalTradeIDRef_));
        }else{
             return this->originalTrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> OptionExercise::getTradeIdentifier()
{
   if(!this->tradeIdentifierIsNull_){
        if(tradeIdentifierIDRef_ != ""){
             return this->tradeIdentifier_;
        }else{
             return this->tradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
boost::shared_ptr<XsdTypeDate> OptionExercise::getExerciseDate()
{
   if(!this->exerciseDateIsNull_){
        if(exerciseDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(exerciseDateIDRef_));
        }else{
             return this->exerciseDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeTime> OptionExercise::getExerciseTime()
{
   if(!this->exerciseTimeIsNull_){
        if(exerciseTimeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeTime>(IDManager::instance().getID(exerciseTimeIDRef_));
        }else{
             return this->exerciseTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeTime>();
   }
}
boost::shared_ptr<XsdTypeBoolean> OptionExercise::getExpiry()
{
   if(!this->expiryIsNull_){
        if(expiryIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(expiryIDRef_));
        }else{
             return this->expiry_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> OptionExercise::getFullExercise()
{
   if(!this->fullExerciseIsNull_){
        if(fullExerciseIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(fullExerciseIDRef_));
        }else{
             return this->fullExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Money> OptionExercise::getExerciseInNotionalAmount()
{
   if(!this->exerciseInNotionalAmountIsNull_){
        if(exerciseInNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(exerciseInNotionalAmountIDRef_));
        }else{
             return this->exerciseInNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<Money> OptionExercise::getOutstandingNotionalAmount()
{
   if(!this->outstandingNotionalAmountIsNull_){
        if(outstandingNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(outstandingNotionalAmountIDRef_));
        }else{
             return this->outstandingNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<XsdTypeDecimal> OptionExercise::getExerciseInNumberOfOptions()
{
   if(!this->exerciseInNumberOfOptionsIsNull_){
        if(exerciseInNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(exerciseInNumberOfOptionsIDRef_));
        }else{
             return this->exerciseInNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> OptionExercise::getOutstandingNumberOfOptions()
{
   if(!this->outstandingNumberOfOptionsIsNull_){
        if(outstandingNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(outstandingNumberOfOptionsIDRef_));
        }else{
             return this->outstandingNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> OptionExercise::getExerciseInNumberOfUnits()
{
   if(!this->exerciseInNumberOfUnitsIsNull_){
        if(exerciseInNumberOfUnitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(exerciseInNumberOfUnitsIDRef_));
        }else{
             return this->exerciseInNumberOfUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> OptionExercise::getOutstandingNumberOfUnits()
{
   if(!this->outstandingNumberOfUnitsIsNull_){
        if(outstandingNumberOfUnitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(outstandingNumberOfUnitsIDRef_));
        }else{
             return this->outstandingNumberOfUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<SettlementTypeEnum> OptionExercise::getSettlementType()
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
boost::shared_ptr<SimplePayment> OptionExercise::getCashSettlement()
{
   if(!this->cashSettlementIsNull_){
        if(cashSettlementIDRef_ != ""){
             return boost::shared_static_cast<SimplePayment>(IDManager::instance().getID(cashSettlementIDRef_));
        }else{
             return this->cashSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimplePayment>();
   }
}
boost::shared_ptr<PhysicalSettlement> OptionExercise::getPhysicalSettlement()
{
   if(!this->physicalSettlementIsNull_){
        if(physicalSettlementIDRef_ != ""){
             return boost::shared_static_cast<PhysicalSettlement>(IDManager::instance().getID(physicalSettlementIDRef_));
        }else{
             return this->physicalSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PhysicalSettlement>();
   }
}
boost::shared_ptr<NonNegativePayment> OptionExercise::getPayment()
{
   if(!this->paymentIsNull_){
        if(paymentIDRef_ != ""){
             return boost::shared_static_cast<NonNegativePayment>(IDManager::instance().getID(paymentIDRef_));
        }else{
             return this->payment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativePayment>();
   }
}
}

