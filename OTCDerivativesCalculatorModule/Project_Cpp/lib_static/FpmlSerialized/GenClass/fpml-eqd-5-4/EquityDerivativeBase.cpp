// EquityDerivativeBase.cpp 
#include "EquityDerivativeBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityDerivativeBase::EquityDerivativeBase(TiXmlNode* xmlNode)
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

   //optionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionTypeNode = xmlNode->FirstChildElement("optionType");

   if(optionTypeNode){optionTypeIsNull_ = false;}
   else{optionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionTypeNode , address : " << optionTypeNode << std::endl;
   #endif
   if(optionTypeNode)
   {
      if(optionTypeNode->Attribute("href") || optionTypeNode->Attribute("id"))
      {
          if(optionTypeNode->Attribute("id"))
          {
             optionTypeIDRef_ = optionTypeNode->Attribute("id");
             optionType_ = boost::shared_ptr<EquityOptionTypeEnum>(new EquityOptionTypeEnum(optionTypeNode));
             optionType_->setID(optionTypeIDRef_);
             IDManager::instance().setID(optionTypeIDRef_,optionType_);
          }
          else if(optionTypeNode->Attribute("href")) { optionTypeIDRef_ = optionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionType_ = boost::shared_ptr<EquityOptionTypeEnum>(new EquityOptionTypeEnum(optionTypeNode));}
   }

   //equityEffectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityEffectiveDateNode = xmlNode->FirstChildElement("equityEffectiveDate");

   if(equityEffectiveDateNode){equityEffectiveDateIsNull_ = false;}
   else{equityEffectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityEffectiveDateNode , address : " << equityEffectiveDateNode << std::endl;
   #endif
   if(equityEffectiveDateNode)
   {
      if(equityEffectiveDateNode->Attribute("href") || equityEffectiveDateNode->Attribute("id"))
      {
          if(equityEffectiveDateNode->Attribute("id"))
          {
             equityEffectiveDateIDRef_ = equityEffectiveDateNode->Attribute("id");
             equityEffectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(equityEffectiveDateNode));
             equityEffectiveDate_->setID(equityEffectiveDateIDRef_);
             IDManager::instance().setID(equityEffectiveDateIDRef_,equityEffectiveDate_);
          }
          else if(equityEffectiveDateNode->Attribute("href")) { equityEffectiveDateIDRef_ = equityEffectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityEffectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(equityEffectiveDateNode));}
   }

   //underlyerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyerNode = xmlNode->FirstChildElement("underlyer");

   if(underlyerNode){underlyerIsNull_ = false;}
   else{underlyerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyerNode , address : " << underlyerNode << std::endl;
   #endif
   if(underlyerNode)
   {
      if(underlyerNode->Attribute("href") || underlyerNode->Attribute("id"))
      {
          if(underlyerNode->Attribute("id"))
          {
             underlyerIDRef_ = underlyerNode->Attribute("id");
             underlyer_ = boost::shared_ptr<Underlyer>(new Underlyer(underlyerNode));
             underlyer_->setID(underlyerIDRef_);
             IDManager::instance().setID(underlyerIDRef_,underlyer_);
          }
          else if(underlyerNode->Attribute("href")) { underlyerIDRef_ = underlyerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyer_ = boost::shared_ptr<Underlyer>(new Underlyer(underlyerNode));}
   }

   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
      if(notionalNode->Attribute("href") || notionalNode->Attribute("id"))
      {
          if(notionalNode->Attribute("id"))
          {
             notionalIDRef_ = notionalNode->Attribute("id");
             notional_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(notionalNode));
             notional_->setID(notionalIDRef_);
             IDManager::instance().setID(notionalIDRef_,notional_);
          }
          else if(notionalNode->Attribute("href")) { notionalIDRef_ = notionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notional_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(notionalNode));}
   }

   //equityExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityExerciseNode = xmlNode->FirstChildElement("equityExercise");

   if(equityExerciseNode){equityExerciseIsNull_ = false;}
   else{equityExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityExerciseNode , address : " << equityExerciseNode << std::endl;
   #endif
   if(equityExerciseNode)
   {
      if(equityExerciseNode->Attribute("href") || equityExerciseNode->Attribute("id"))
      {
          if(equityExerciseNode->Attribute("id"))
          {
             equityExerciseIDRef_ = equityExerciseNode->Attribute("id");
             equityExercise_ = boost::shared_ptr<EquityExerciseValuationSettlement>(new EquityExerciseValuationSettlement(equityExerciseNode));
             equityExercise_->setID(equityExerciseIDRef_);
             IDManager::instance().setID(equityExerciseIDRef_,equityExercise_);
          }
          else if(equityExerciseNode->Attribute("href")) { equityExerciseIDRef_ = equityExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityExercise_ = boost::shared_ptr<EquityExerciseValuationSettlement>(new EquityExerciseValuationSettlement(equityExerciseNode));}
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
             feature_ = boost::shared_ptr<OptionFeatures>(new OptionFeatures(featureNode));
             feature_->setID(featureIDRef_);
             IDManager::instance().setID(featureIDRef_,feature_);
          }
          else if(featureNode->Attribute("href")) { featureIDRef_ = featureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feature_ = boost::shared_ptr<OptionFeatures>(new OptionFeatures(featureNode));}
   }

   //fxFeatureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxFeatureNode = xmlNode->FirstChildElement("fxFeature");

   if(fxFeatureNode){fxFeatureIsNull_ = false;}
   else{fxFeatureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxFeatureNode , address : " << fxFeatureNode << std::endl;
   #endif
   if(fxFeatureNode)
   {
      if(fxFeatureNode->Attribute("href") || fxFeatureNode->Attribute("id"))
      {
          if(fxFeatureNode->Attribute("id"))
          {
             fxFeatureIDRef_ = fxFeatureNode->Attribute("id");
             fxFeature_ = boost::shared_ptr<FxFeature>(new FxFeature(fxFeatureNode));
             fxFeature_->setID(fxFeatureIDRef_);
             IDManager::instance().setID(fxFeatureIDRef_,fxFeature_);
          }
          else if(fxFeatureNode->Attribute("href")) { fxFeatureIDRef_ = fxFeatureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxFeature_ = boost::shared_ptr<FxFeature>(new FxFeature(fxFeatureNode));}
   }

   //strategyFeatureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strategyFeatureNode = xmlNode->FirstChildElement("strategyFeature");

   if(strategyFeatureNode){strategyFeatureIsNull_ = false;}
   else{strategyFeatureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strategyFeatureNode , address : " << strategyFeatureNode << std::endl;
   #endif
   if(strategyFeatureNode)
   {
      if(strategyFeatureNode->Attribute("href") || strategyFeatureNode->Attribute("id"))
      {
          if(strategyFeatureNode->Attribute("id"))
          {
             strategyFeatureIDRef_ = strategyFeatureNode->Attribute("id");
             strategyFeature_ = boost::shared_ptr<StrategyFeature>(new StrategyFeature(strategyFeatureNode));
             strategyFeature_->setID(strategyFeatureIDRef_);
             IDManager::instance().setID(strategyFeatureIDRef_,strategyFeature_);
          }
          else if(strategyFeatureNode->Attribute("href")) { strategyFeatureIDRef_ = strategyFeatureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strategyFeature_ = boost::shared_ptr<StrategyFeature>(new StrategyFeature(strategyFeatureNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> EquityDerivativeBase::getBuyerPartyReference()
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
boost::shared_ptr<AccountReference> EquityDerivativeBase::getBuyerAccountReference()
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
boost::shared_ptr<PartyReference> EquityDerivativeBase::getSellerPartyReference()
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
boost::shared_ptr<AccountReference> EquityDerivativeBase::getSellerAccountReference()
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
boost::shared_ptr<EquityOptionTypeEnum> EquityDerivativeBase::getOptionType()
{
   if(!this->optionTypeIsNull_){
        if(optionTypeIDRef_ != ""){
             return boost::shared_static_cast<EquityOptionTypeEnum>(IDManager::instance().getID(optionTypeIDRef_));
        }else{
             return this->optionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityOptionTypeEnum>();
   }
}
boost::shared_ptr<XsdTypeDate> EquityDerivativeBase::getEquityEffectiveDate()
{
   if(!this->equityEffectiveDateIsNull_){
        if(equityEffectiveDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(equityEffectiveDateIDRef_));
        }else{
             return this->equityEffectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<Underlyer> EquityDerivativeBase::getUnderlyer()
{
   if(!this->underlyerIsNull_){
        if(underlyerIDRef_ != ""){
             return boost::shared_static_cast<Underlyer>(IDManager::instance().getID(underlyerIDRef_));
        }else{
             return this->underlyer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Underlyer>();
   }
}
boost::shared_ptr<NonNegativeMoney> EquityDerivativeBase::getNotional()
{
   if(!this->notionalIsNull_){
        if(notionalIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(notionalIDRef_));
        }else{
             return this->notional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<EquityExerciseValuationSettlement> EquityDerivativeBase::getEquityExercise()
{
   if(!this->equityExerciseIsNull_){
        if(equityExerciseIDRef_ != ""){
             return boost::shared_static_cast<EquityExerciseValuationSettlement>(IDManager::instance().getID(equityExerciseIDRef_));
        }else{
             return this->equityExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityExerciseValuationSettlement>();
   }
}
boost::shared_ptr<OptionFeatures> EquityDerivativeBase::getFeature()
{
   if(!this->featureIsNull_){
        if(featureIDRef_ != ""){
             return boost::shared_static_cast<OptionFeatures>(IDManager::instance().getID(featureIDRef_));
        }else{
             return this->feature_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionFeatures>();
   }
}
boost::shared_ptr<FxFeature> EquityDerivativeBase::getFxFeature()
{
   if(!this->fxFeatureIsNull_){
        if(fxFeatureIDRef_ != ""){
             return boost::shared_static_cast<FxFeature>(IDManager::instance().getID(fxFeatureIDRef_));
        }else{
             return this->fxFeature_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxFeature>();
   }
}
boost::shared_ptr<StrategyFeature> EquityDerivativeBase::getStrategyFeature()
{
   if(!this->strategyFeatureIsNull_){
        if(strategyFeatureIDRef_ != ""){
             return boost::shared_static_cast<StrategyFeature>(IDManager::instance().getID(strategyFeatureIDRef_));
        }else{
             return this->strategyFeature_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StrategyFeature>();
   }
}
}

