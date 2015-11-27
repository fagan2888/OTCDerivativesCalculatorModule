// EquityExerciseValuationSettlement.cpp 
#include "EquityExerciseValuationSettlement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityExerciseValuationSettlement::EquityExerciseValuationSettlement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //equityEuropeanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityEuropeanExerciseNode = xmlNode->FirstChildElement("equityEuropeanExercise");

   if(equityEuropeanExerciseNode){equityEuropeanExerciseIsNull_ = false;}
   else{equityEuropeanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityEuropeanExerciseNode , address : " << equityEuropeanExerciseNode << std::endl;
   #endif
   if(equityEuropeanExerciseNode)
   {
      if(equityEuropeanExerciseNode->Attribute("href") || equityEuropeanExerciseNode->Attribute("id"))
      {
          if(equityEuropeanExerciseNode->Attribute("id"))
          {
             equityEuropeanExerciseIDRef_ = equityEuropeanExerciseNode->Attribute("id");
             equityEuropeanExercise_ = boost::shared_ptr<EquityEuropeanExercise>(new EquityEuropeanExercise(equityEuropeanExerciseNode));
             equityEuropeanExercise_->setID(equityEuropeanExerciseIDRef_);
             IDManager::instance().setID(equityEuropeanExerciseIDRef_,equityEuropeanExercise_);
          }
          else if(equityEuropeanExerciseNode->Attribute("href")) { equityEuropeanExerciseIDRef_ = equityEuropeanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityEuropeanExercise_ = boost::shared_ptr<EquityEuropeanExercise>(new EquityEuropeanExercise(equityEuropeanExerciseNode));}
   }

   //equityAmericanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityAmericanExerciseNode = xmlNode->FirstChildElement("equityAmericanExercise");

   if(equityAmericanExerciseNode){equityAmericanExerciseIsNull_ = false;}
   else{equityAmericanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityAmericanExerciseNode , address : " << equityAmericanExerciseNode << std::endl;
   #endif
   if(equityAmericanExerciseNode)
   {
      if(equityAmericanExerciseNode->Attribute("href") || equityAmericanExerciseNode->Attribute("id"))
      {
          if(equityAmericanExerciseNode->Attribute("id"))
          {
             equityAmericanExerciseIDRef_ = equityAmericanExerciseNode->Attribute("id");
             equityAmericanExercise_ = boost::shared_ptr<EquityAmericanExercise>(new EquityAmericanExercise(equityAmericanExerciseNode));
             equityAmericanExercise_->setID(equityAmericanExerciseIDRef_);
             IDManager::instance().setID(equityAmericanExerciseIDRef_,equityAmericanExercise_);
          }
          else if(equityAmericanExerciseNode->Attribute("href")) { equityAmericanExerciseIDRef_ = equityAmericanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityAmericanExercise_ = boost::shared_ptr<EquityAmericanExercise>(new EquityAmericanExercise(equityAmericanExerciseNode));}
   }

   //equityBermudaExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityBermudaExerciseNode = xmlNode->FirstChildElement("equityBermudaExercise");

   if(equityBermudaExerciseNode){equityBermudaExerciseIsNull_ = false;}
   else{equityBermudaExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityBermudaExerciseNode , address : " << equityBermudaExerciseNode << std::endl;
   #endif
   if(equityBermudaExerciseNode)
   {
      if(equityBermudaExerciseNode->Attribute("href") || equityBermudaExerciseNode->Attribute("id"))
      {
          if(equityBermudaExerciseNode->Attribute("id"))
          {
             equityBermudaExerciseIDRef_ = equityBermudaExerciseNode->Attribute("id");
             equityBermudaExercise_ = boost::shared_ptr<EquityBermudaExercise>(new EquityBermudaExercise(equityBermudaExerciseNode));
             equityBermudaExercise_->setID(equityBermudaExerciseIDRef_);
             IDManager::instance().setID(equityBermudaExerciseIDRef_,equityBermudaExercise_);
          }
          else if(equityBermudaExerciseNode->Attribute("href")) { equityBermudaExerciseIDRef_ = equityBermudaExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityBermudaExercise_ = boost::shared_ptr<EquityBermudaExercise>(new EquityBermudaExercise(equityBermudaExerciseNode));}
   }

   //automaticExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* automaticExerciseNode = xmlNode->FirstChildElement("automaticExercise");

   if(automaticExerciseNode){automaticExerciseIsNull_ = false;}
   else{automaticExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- automaticExerciseNode , address : " << automaticExerciseNode << std::endl;
   #endif
   if(automaticExerciseNode)
   {
      if(automaticExerciseNode->Attribute("href") || automaticExerciseNode->Attribute("id"))
      {
          if(automaticExerciseNode->Attribute("id"))
          {
             automaticExerciseIDRef_ = automaticExerciseNode->Attribute("id");
             automaticExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(automaticExerciseNode));
             automaticExercise_->setID(automaticExerciseIDRef_);
             IDManager::instance().setID(automaticExerciseIDRef_,automaticExercise_);
          }
          else if(automaticExerciseNode->Attribute("href")) { automaticExerciseIDRef_ = automaticExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { automaticExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(automaticExerciseNode));}
   }

   //makeWholeProvisionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* makeWholeProvisionsNode = xmlNode->FirstChildElement("makeWholeProvisions");

   if(makeWholeProvisionsNode){makeWholeProvisionsIsNull_ = false;}
   else{makeWholeProvisionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- makeWholeProvisionsNode , address : " << makeWholeProvisionsNode << std::endl;
   #endif
   if(makeWholeProvisionsNode)
   {
      if(makeWholeProvisionsNode->Attribute("href") || makeWholeProvisionsNode->Attribute("id"))
      {
          if(makeWholeProvisionsNode->Attribute("id"))
          {
             makeWholeProvisionsIDRef_ = makeWholeProvisionsNode->Attribute("id");
             makeWholeProvisions_ = boost::shared_ptr<MakeWholeProvisions>(new MakeWholeProvisions(makeWholeProvisionsNode));
             makeWholeProvisions_->setID(makeWholeProvisionsIDRef_);
             IDManager::instance().setID(makeWholeProvisionsIDRef_,makeWholeProvisions_);
          }
          else if(makeWholeProvisionsNode->Attribute("href")) { makeWholeProvisionsIDRef_ = makeWholeProvisionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { makeWholeProvisions_ = boost::shared_ptr<MakeWholeProvisions>(new MakeWholeProvisions(makeWholeProvisionsNode));}
   }

   //prePaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* prePaymentNode = xmlNode->FirstChildElement("prePayment");

   if(prePaymentNode){prePaymentIsNull_ = false;}
   else{prePaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- prePaymentNode , address : " << prePaymentNode << std::endl;
   #endif
   if(prePaymentNode)
   {
      if(prePaymentNode->Attribute("href") || prePaymentNode->Attribute("id"))
      {
          if(prePaymentNode->Attribute("id"))
          {
             prePaymentIDRef_ = prePaymentNode->Attribute("id");
             prePayment_ = boost::shared_ptr<PrePayment>(new PrePayment(prePaymentNode));
             prePayment_->setID(prePaymentIDRef_);
             IDManager::instance().setID(prePaymentIDRef_,prePayment_);
          }
          else if(prePaymentNode->Attribute("href")) { prePaymentIDRef_ = prePaymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { prePayment_ = boost::shared_ptr<PrePayment>(new PrePayment(prePaymentNode));}
   }

   //equityValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityValuationNode = xmlNode->FirstChildElement("equityValuation");

   if(equityValuationNode){equityValuationIsNull_ = false;}
   else{equityValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityValuationNode , address : " << equityValuationNode << std::endl;
   #endif
   if(equityValuationNode)
   {
      if(equityValuationNode->Attribute("href") || equityValuationNode->Attribute("id"))
      {
          if(equityValuationNode->Attribute("id"))
          {
             equityValuationIDRef_ = equityValuationNode->Attribute("id");
             equityValuation_ = boost::shared_ptr<EquityValuation>(new EquityValuation(equityValuationNode));
             equityValuation_->setID(equityValuationIDRef_);
             IDManager::instance().setID(equityValuationIDRef_,equityValuation_);
          }
          else if(equityValuationNode->Attribute("href")) { equityValuationIDRef_ = equityValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityValuation_ = boost::shared_ptr<EquityValuation>(new EquityValuation(equityValuationNode));}
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

   //settlementPriceSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPriceSourceNode = xmlNode->FirstChildElement("settlementPriceSource");

   if(settlementPriceSourceNode){settlementPriceSourceIsNull_ = false;}
   else{settlementPriceSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPriceSourceNode , address : " << settlementPriceSourceNode << std::endl;
   #endif
   if(settlementPriceSourceNode)
   {
      if(settlementPriceSourceNode->Attribute("href") || settlementPriceSourceNode->Attribute("id"))
      {
          if(settlementPriceSourceNode->Attribute("id"))
          {
             settlementPriceSourceIDRef_ = settlementPriceSourceNode->Attribute("id");
             settlementPriceSource_ = boost::shared_ptr<SettlementPriceSource>(new SettlementPriceSource(settlementPriceSourceNode));
             settlementPriceSource_->setID(settlementPriceSourceIDRef_);
             IDManager::instance().setID(settlementPriceSourceIDRef_,settlementPriceSource_);
          }
          else if(settlementPriceSourceNode->Attribute("href")) { settlementPriceSourceIDRef_ = settlementPriceSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementPriceSource_ = boost::shared_ptr<SettlementPriceSource>(new SettlementPriceSource(settlementPriceSourceNode));}
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

   //settlementMethodElectionDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementMethodElectionDateNode = xmlNode->FirstChildElement("settlementMethodElectionDate");

   if(settlementMethodElectionDateNode){settlementMethodElectionDateIsNull_ = false;}
   else{settlementMethodElectionDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementMethodElectionDateNode , address : " << settlementMethodElectionDateNode << std::endl;
   #endif
   if(settlementMethodElectionDateNode)
   {
      if(settlementMethodElectionDateNode->Attribute("href") || settlementMethodElectionDateNode->Attribute("id"))
      {
          if(settlementMethodElectionDateNode->Attribute("id"))
          {
             settlementMethodElectionDateIDRef_ = settlementMethodElectionDateNode->Attribute("id");
             settlementMethodElectionDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(settlementMethodElectionDateNode));
             settlementMethodElectionDate_->setID(settlementMethodElectionDateIDRef_);
             IDManager::instance().setID(settlementMethodElectionDateIDRef_,settlementMethodElectionDate_);
          }
          else if(settlementMethodElectionDateNode->Attribute("href")) { settlementMethodElectionDateIDRef_ = settlementMethodElectionDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementMethodElectionDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(settlementMethodElectionDateNode));}
   }

   //settlementMethodElectingPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementMethodElectingPartyReferenceNode = xmlNode->FirstChildElement("settlementMethodElectingPartyReference");

   if(settlementMethodElectingPartyReferenceNode){settlementMethodElectingPartyReferenceIsNull_ = false;}
   else{settlementMethodElectingPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementMethodElectingPartyReferenceNode , address : " << settlementMethodElectingPartyReferenceNode << std::endl;
   #endif
   if(settlementMethodElectingPartyReferenceNode)
   {
      if(settlementMethodElectingPartyReferenceNode->Attribute("href") || settlementMethodElectingPartyReferenceNode->Attribute("id"))
      {
          if(settlementMethodElectingPartyReferenceNode->Attribute("id"))
          {
             settlementMethodElectingPartyReferenceIDRef_ = settlementMethodElectingPartyReferenceNode->Attribute("id");
             settlementMethodElectingPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(settlementMethodElectingPartyReferenceNode));
             settlementMethodElectingPartyReference_->setID(settlementMethodElectingPartyReferenceIDRef_);
             IDManager::instance().setID(settlementMethodElectingPartyReferenceIDRef_,settlementMethodElectingPartyReference_);
          }
          else if(settlementMethodElectingPartyReferenceNode->Attribute("href")) { settlementMethodElectingPartyReferenceIDRef_ = settlementMethodElectingPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementMethodElectingPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(settlementMethodElectingPartyReferenceNode));}
   }

   //settlementPriceDefaultElectionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPriceDefaultElectionNode = xmlNode->FirstChildElement("settlementPriceDefaultElection");

   if(settlementPriceDefaultElectionNode){settlementPriceDefaultElectionIsNull_ = false;}
   else{settlementPriceDefaultElectionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPriceDefaultElectionNode , address : " << settlementPriceDefaultElectionNode << std::endl;
   #endif
   if(settlementPriceDefaultElectionNode)
   {
      if(settlementPriceDefaultElectionNode->Attribute("href") || settlementPriceDefaultElectionNode->Attribute("id"))
      {
          if(settlementPriceDefaultElectionNode->Attribute("id"))
          {
             settlementPriceDefaultElectionIDRef_ = settlementPriceDefaultElectionNode->Attribute("id");
             settlementPriceDefaultElection_ = boost::shared_ptr<SettlementPriceDefaultElection>(new SettlementPriceDefaultElection(settlementPriceDefaultElectionNode));
             settlementPriceDefaultElection_->setID(settlementPriceDefaultElectionIDRef_);
             IDManager::instance().setID(settlementPriceDefaultElectionIDRef_,settlementPriceDefaultElection_);
          }
          else if(settlementPriceDefaultElectionNode->Attribute("href")) { settlementPriceDefaultElectionIDRef_ = settlementPriceDefaultElectionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementPriceDefaultElection_ = boost::shared_ptr<SettlementPriceDefaultElection>(new SettlementPriceDefaultElection(settlementPriceDefaultElectionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EquityEuropeanExercise> EquityExerciseValuationSettlement::getEquityEuropeanExercise()
{
   if(!this->equityEuropeanExerciseIsNull_){
        if(equityEuropeanExerciseIDRef_ != ""){
             return boost::shared_static_cast<EquityEuropeanExercise>(IDManager::instance().getID(equityEuropeanExerciseIDRef_));
        }else{
             return this->equityEuropeanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityEuropeanExercise>();
   }
}
boost::shared_ptr<EquityAmericanExercise> EquityExerciseValuationSettlement::getEquityAmericanExercise()
{
   if(!this->equityAmericanExerciseIsNull_){
        if(equityAmericanExerciseIDRef_ != ""){
             return boost::shared_static_cast<EquityAmericanExercise>(IDManager::instance().getID(equityAmericanExerciseIDRef_));
        }else{
             return this->equityAmericanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityAmericanExercise>();
   }
}
boost::shared_ptr<EquityBermudaExercise> EquityExerciseValuationSettlement::getEquityBermudaExercise()
{
   if(!this->equityBermudaExerciseIsNull_){
        if(equityBermudaExerciseIDRef_ != ""){
             return boost::shared_static_cast<EquityBermudaExercise>(IDManager::instance().getID(equityBermudaExerciseIDRef_));
        }else{
             return this->equityBermudaExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityBermudaExercise>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquityExerciseValuationSettlement::getAutomaticExercise()
{
   if(!this->automaticExerciseIsNull_){
        if(automaticExerciseIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(automaticExerciseIDRef_));
        }else{
             return this->automaticExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<MakeWholeProvisions> EquityExerciseValuationSettlement::getMakeWholeProvisions()
{
   if(!this->makeWholeProvisionsIsNull_){
        if(makeWholeProvisionsIDRef_ != ""){
             return boost::shared_static_cast<MakeWholeProvisions>(IDManager::instance().getID(makeWholeProvisionsIDRef_));
        }else{
             return this->makeWholeProvisions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MakeWholeProvisions>();
   }
}
boost::shared_ptr<PrePayment> EquityExerciseValuationSettlement::getPrePayment()
{
   if(!this->prePaymentIsNull_){
        if(prePaymentIDRef_ != ""){
             return boost::shared_static_cast<PrePayment>(IDManager::instance().getID(prePaymentIDRef_));
        }else{
             return this->prePayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrePayment>();
   }
}
boost::shared_ptr<EquityValuation> EquityExerciseValuationSettlement::getEquityValuation()
{
   if(!this->equityValuationIsNull_){
        if(equityValuationIDRef_ != ""){
             return boost::shared_static_cast<EquityValuation>(IDManager::instance().getID(equityValuationIDRef_));
        }else{
             return this->equityValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityValuation>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> EquityExerciseValuationSettlement::getSettlementDate()
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
boost::shared_ptr<Currency> EquityExerciseValuationSettlement::getSettlementCurrency()
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
boost::shared_ptr<SettlementPriceSource> EquityExerciseValuationSettlement::getSettlementPriceSource()
{
   if(!this->settlementPriceSourceIsNull_){
        if(settlementPriceSourceIDRef_ != ""){
             return boost::shared_static_cast<SettlementPriceSource>(IDManager::instance().getID(settlementPriceSourceIDRef_));
        }else{
             return this->settlementPriceSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementPriceSource>();
   }
}
boost::shared_ptr<SettlementTypeEnum> EquityExerciseValuationSettlement::getSettlementType()
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
boost::shared_ptr<AdjustableOrRelativeDate> EquityExerciseValuationSettlement::getSettlementMethodElectionDate()
{
   if(!this->settlementMethodElectionDateIsNull_){
        if(settlementMethodElectionDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(settlementMethodElectionDateIDRef_));
        }else{
             return this->settlementMethodElectionDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<PartyReference> EquityExerciseValuationSettlement::getSettlementMethodElectingPartyReference()
{
   if(!this->settlementMethodElectingPartyReferenceIsNull_){
        if(settlementMethodElectingPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(settlementMethodElectingPartyReferenceIDRef_));
        }else{
             return this->settlementMethodElectingPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<SettlementPriceDefaultElection> EquityExerciseValuationSettlement::getSettlementPriceDefaultElection()
{
   if(!this->settlementPriceDefaultElectionIsNull_){
        if(settlementPriceDefaultElectionIDRef_ != ""){
             return boost::shared_static_cast<SettlementPriceDefaultElection>(IDManager::instance().getID(settlementPriceDefaultElectionIDRef_));
        }else{
             return this->settlementPriceDefaultElection_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementPriceDefaultElection>();
   }
}
}

