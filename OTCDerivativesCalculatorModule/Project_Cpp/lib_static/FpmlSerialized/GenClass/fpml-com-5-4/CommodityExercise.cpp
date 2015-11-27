// CommodityExercise.cpp 
#include "CommodityExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityExercise::CommodityExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
             americanExercise_ = boost::shared_ptr<CommodityAmericanExercise>(new CommodityAmericanExercise(americanExerciseNode));
             americanExercise_->setID(americanExerciseIDRef_);
             IDManager::instance().setID(americanExerciseIDRef_,americanExercise_);
          }
          else if(americanExerciseNode->Attribute("href")) { americanExerciseIDRef_ = americanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { americanExercise_ = boost::shared_ptr<CommodityAmericanExercise>(new CommodityAmericanExercise(americanExerciseNode));}
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
             europeanExercise_ = boost::shared_ptr<CommodityEuropeanExercise>(new CommodityEuropeanExercise(europeanExerciseNode));
             europeanExercise_->setID(europeanExerciseIDRef_);
             IDManager::instance().setID(europeanExerciseIDRef_,europeanExercise_);
          }
          else if(europeanExerciseNode->Attribute("href")) { europeanExerciseIDRef_ = europeanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { europeanExercise_ = boost::shared_ptr<CommodityEuropeanExercise>(new CommodityEuropeanExercise(europeanExerciseNode));}
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

   //writtenConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* writtenConfirmationNode = xmlNode->FirstChildElement("writtenConfirmation");

   if(writtenConfirmationNode){writtenConfirmationIsNull_ = false;}
   else{writtenConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- writtenConfirmationNode , address : " << writtenConfirmationNode << std::endl;
   #endif
   if(writtenConfirmationNode)
   {
      if(writtenConfirmationNode->Attribute("href") || writtenConfirmationNode->Attribute("id"))
      {
          if(writtenConfirmationNode->Attribute("id"))
          {
             writtenConfirmationIDRef_ = writtenConfirmationNode->Attribute("id");
             writtenConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writtenConfirmationNode));
             writtenConfirmation_->setID(writtenConfirmationIDRef_);
             IDManager::instance().setID(writtenConfirmationIDRef_,writtenConfirmation_);
          }
          else if(writtenConfirmationNode->Attribute("href")) { writtenConfirmationIDRef_ = writtenConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { writtenConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writtenConfirmationNode));}
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
             settlementCurrency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(settlementCurrencyNode));
             settlementCurrency_->setID(settlementCurrencyIDRef_);
             IDManager::instance().setID(settlementCurrencyIDRef_,settlementCurrency_);
          }
          else if(settlementCurrencyNode->Attribute("href")) { settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementCurrency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(settlementCurrencyNode));}
   }

   //fxNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxNode = xmlNode->FirstChildElement("fx");

   if(fxNode){fxIsNull_ = false;}
   else{fxIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxNode , address : " << fxNode << std::endl;
   #endif
   if(fxNode)
   {
      if(fxNode->Attribute("href") || fxNode->Attribute("id"))
      {
          if(fxNode->Attribute("id"))
          {
             fxIDRef_ = fxNode->Attribute("id");
             fx_ = boost::shared_ptr<CommodityFx>(new CommodityFx(fxNode));
             fx_->setID(fxIDRef_);
             IDManager::instance().setID(fxIDRef_,fx_);
          }
          else if(fxNode->Attribute("href")) { fxIDRef_ = fxNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fx_ = boost::shared_ptr<CommodityFx>(new CommodityFx(fxNode));}
   }

   //conversionFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* conversionFactorNode = xmlNode->FirstChildElement("conversionFactor");

   if(conversionFactorNode){conversionFactorIsNull_ = false;}
   else{conversionFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- conversionFactorNode , address : " << conversionFactorNode << std::endl;
   #endif
   if(conversionFactorNode)
   {
      if(conversionFactorNode->Attribute("href") || conversionFactorNode->Attribute("id"))
      {
          if(conversionFactorNode->Attribute("id"))
          {
             conversionFactorIDRef_ = conversionFactorNode->Attribute("id");
             conversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(conversionFactorNode));
             conversionFactor_->setID(conversionFactorIDRef_);
             IDManager::instance().setID(conversionFactorIDRef_,conversionFactor_);
          }
          else if(conversionFactorNode->Attribute("href")) { conversionFactorIDRef_ = conversionFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { conversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(conversionFactorNode));}
   }

   //relativePaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativePaymentDatesNode = xmlNode->FirstChildElement("relativePaymentDates");

   if(relativePaymentDatesNode){relativePaymentDatesIsNull_ = false;}
   else{relativePaymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativePaymentDatesNode , address : " << relativePaymentDatesNode << std::endl;
   #endif
   if(relativePaymentDatesNode)
   {
      if(relativePaymentDatesNode->Attribute("href") || relativePaymentDatesNode->Attribute("id"))
      {
          if(relativePaymentDatesNode->Attribute("id"))
          {
             relativePaymentDatesIDRef_ = relativePaymentDatesNode->Attribute("id");
             relativePaymentDates_ = boost::shared_ptr<CommodityRelativePaymentDates>(new CommodityRelativePaymentDates(relativePaymentDatesNode));
             relativePaymentDates_->setID(relativePaymentDatesIDRef_);
             IDManager::instance().setID(relativePaymentDatesIDRef_,relativePaymentDates_);
          }
          else if(relativePaymentDatesNode->Attribute("href")) { relativePaymentDatesIDRef_ = relativePaymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativePaymentDates_ = boost::shared_ptr<CommodityRelativePaymentDates>(new CommodityRelativePaymentDates(relativePaymentDatesNode));}
   }

   //paymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDatesNode = xmlNode->FirstChildElement("paymentDates");

   if(paymentDatesNode){paymentDatesIsNull_ = false;}
   else{paymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesNode , address : " << paymentDatesNode << std::endl;
   #endif
   if(paymentDatesNode)
   {
      if(paymentDatesNode->Attribute("href") || paymentDatesNode->Attribute("id"))
      {
          if(paymentDatesNode->Attribute("id"))
          {
             paymentDatesIDRef_ = paymentDatesNode->Attribute("id");
             paymentDates_ = boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>(new AdjustableDatesOrRelativeDateOffset(paymentDatesNode));
             paymentDates_->setID(paymentDatesIDRef_);
             IDManager::instance().setID(paymentDatesIDRef_,paymentDates_);
          }
          else if(paymentDatesNode->Attribute("href")) { paymentDatesIDRef_ = paymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDates_ = boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>(new AdjustableDatesOrRelativeDateOffset(paymentDatesNode));}
   }

   //masterAgreementPaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterAgreementPaymentDatesNode = xmlNode->FirstChildElement("masterAgreementPaymentDates");

   if(masterAgreementPaymentDatesNode){masterAgreementPaymentDatesIsNull_ = false;}
   else{masterAgreementPaymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterAgreementPaymentDatesNode , address : " << masterAgreementPaymentDatesNode << std::endl;
   #endif
   if(masterAgreementPaymentDatesNode)
   {
      if(masterAgreementPaymentDatesNode->Attribute("href") || masterAgreementPaymentDatesNode->Attribute("id"))
      {
          if(masterAgreementPaymentDatesNode->Attribute("id"))
          {
             masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode->Attribute("id");
             masterAgreementPaymentDates_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(masterAgreementPaymentDatesNode));
             masterAgreementPaymentDates_->setID(masterAgreementPaymentDatesIDRef_);
             IDManager::instance().setID(masterAgreementPaymentDatesIDRef_,masterAgreementPaymentDates_);
          }
          else if(masterAgreementPaymentDatesNode->Attribute("href")) { masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterAgreementPaymentDates_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(masterAgreementPaymentDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityAmericanExercise> CommodityExercise::getAmericanExercise()
{
   if(!this->americanExerciseIsNull_){
        if(americanExerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityAmericanExercise>(IDManager::instance().getID(americanExerciseIDRef_));
        }else{
             return this->americanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityAmericanExercise>();
   }
}
boost::shared_ptr<CommodityEuropeanExercise> CommodityExercise::getEuropeanExercise()
{
   if(!this->europeanExerciseIsNull_){
        if(europeanExerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityEuropeanExercise>(IDManager::instance().getID(europeanExerciseIDRef_));
        }else{
             return this->europeanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityEuropeanExercise>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommodityExercise::getAutomaticExercise()
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
boost::shared_ptr<XsdTypeBoolean> CommodityExercise::getWrittenConfirmation()
{
   if(!this->writtenConfirmationIsNull_){
        if(writtenConfirmationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(writtenConfirmationIDRef_));
        }else{
             return this->writtenConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<IdentifiedCurrency> CommodityExercise::getSettlementCurrency()
{
   if(!this->settlementCurrencyIsNull_){
        if(settlementCurrencyIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedCurrency>(IDManager::instance().getID(settlementCurrencyIDRef_));
        }else{
             return this->settlementCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedCurrency>();
   }
}
boost::shared_ptr<CommodityFx> CommodityExercise::getFx()
{
   if(!this->fxIsNull_){
        if(fxIDRef_ != ""){
             return boost::shared_static_cast<CommodityFx>(IDManager::instance().getID(fxIDRef_));
        }else{
             return this->fx_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityFx>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CommodityExercise::getConversionFactor()
{
   if(!this->conversionFactorIsNull_){
        if(conversionFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(conversionFactorIDRef_));
        }else{
             return this->conversionFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<CommodityRelativePaymentDates> CommodityExercise::getRelativePaymentDates()
{
   if(!this->relativePaymentDatesIsNull_){
        if(relativePaymentDatesIDRef_ != ""){
             return boost::shared_static_cast<CommodityRelativePaymentDates>(IDManager::instance().getID(relativePaymentDatesIDRef_));
        }else{
             return this->relativePaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityRelativePaymentDates>();
   }
}
boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> CommodityExercise::getPaymentDates()
{
   if(!this->paymentDatesIsNull_){
        if(paymentDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDatesOrRelativeDateOffset>(IDManager::instance().getID(paymentDatesIDRef_));
        }else{
             return this->paymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommodityExercise::getMasterAgreementPaymentDates()
{
   if(!this->masterAgreementPaymentDatesIsNull_){
        if(masterAgreementPaymentDatesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(masterAgreementPaymentDatesIDRef_));
        }else{
             return this->masterAgreementPaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

