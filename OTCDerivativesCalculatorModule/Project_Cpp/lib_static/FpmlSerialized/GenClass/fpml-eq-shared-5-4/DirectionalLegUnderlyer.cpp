// DirectionalLegUnderlyer.cpp 
#include "DirectionalLegUnderlyer.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DirectionalLegUnderlyer::DirectionalLegUnderlyer(TiXmlNode* xmlNode)
: DirectionalLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Underlyer> DirectionalLegUnderlyer::getUnderlyer()
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
boost::shared_ptr<SettlementTypeEnum> DirectionalLegUnderlyer::getSettlementType()
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
boost::shared_ptr<AdjustableOrRelativeDate> DirectionalLegUnderlyer::getSettlementDate()
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
boost::shared_ptr<Money> DirectionalLegUnderlyer::getSettlementAmount()
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
boost::shared_ptr<Currency> DirectionalLegUnderlyer::getSettlementCurrency()
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
boost::shared_ptr<FxFeature> DirectionalLegUnderlyer::getFxFeature()
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
}

