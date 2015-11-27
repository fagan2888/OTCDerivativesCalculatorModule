// EquityOptionTransactionSupplement.cpp 
#include "EquityOptionTransactionSupplement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityOptionTransactionSupplement::EquityOptionTransactionSupplement(TiXmlNode* xmlNode)
: EquityDerivativeShortFormBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //exchangeLookAlikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeLookAlikeNode = xmlNode->FirstChildElement("exchangeLookAlike");

   if(exchangeLookAlikeNode){exchangeLookAlikeIsNull_ = false;}
   else{exchangeLookAlikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeLookAlikeNode , address : " << exchangeLookAlikeNode << std::endl;
   #endif
   if(exchangeLookAlikeNode)
   {
      if(exchangeLookAlikeNode->Attribute("href") || exchangeLookAlikeNode->Attribute("id"))
      {
          if(exchangeLookAlikeNode->Attribute("id"))
          {
             exchangeLookAlikeIDRef_ = exchangeLookAlikeNode->Attribute("id");
             exchangeLookAlike_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(exchangeLookAlikeNode));
             exchangeLookAlike_->setID(exchangeLookAlikeIDRef_);
             IDManager::instance().setID(exchangeLookAlikeIDRef_,exchangeLookAlike_);
          }
          else if(exchangeLookAlikeNode->Attribute("href")) { exchangeLookAlikeIDRef_ = exchangeLookAlikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeLookAlike_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(exchangeLookAlikeNode));}
   }

   //exchangeTradedContractNearestNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeTradedContractNearestNode = xmlNode->FirstChildElement("exchangeTradedContractNearest");

   if(exchangeTradedContractNearestNode){exchangeTradedContractNearestIsNull_ = false;}
   else{exchangeTradedContractNearestIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeTradedContractNearestNode , address : " << exchangeTradedContractNearestNode << std::endl;
   #endif
   if(exchangeTradedContractNearestNode)
   {
      if(exchangeTradedContractNearestNode->Attribute("href") || exchangeTradedContractNearestNode->Attribute("id"))
      {
          if(exchangeTradedContractNearestNode->Attribute("id"))
          {
             exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode->Attribute("id");
             exchangeTradedContractNearest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(exchangeTradedContractNearestNode));
             exchangeTradedContractNearest_->setID(exchangeTradedContractNearestIDRef_);
             IDManager::instance().setID(exchangeTradedContractNearestIDRef_,exchangeTradedContractNearest_);
          }
          else if(exchangeTradedContractNearestNode->Attribute("href")) { exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeTradedContractNearest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(exchangeTradedContractNearestNode));}
   }

   //multipleExchangeIndexAnnexFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleExchangeIndexAnnexFallbackNode = xmlNode->FirstChildElement("multipleExchangeIndexAnnexFallback");

   if(multipleExchangeIndexAnnexFallbackNode){multipleExchangeIndexAnnexFallbackIsNull_ = false;}
   else{multipleExchangeIndexAnnexFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleExchangeIndexAnnexFallbackNode , address : " << multipleExchangeIndexAnnexFallbackNode << std::endl;
   #endif
   if(multipleExchangeIndexAnnexFallbackNode)
   {
      if(multipleExchangeIndexAnnexFallbackNode->Attribute("href") || multipleExchangeIndexAnnexFallbackNode->Attribute("id"))
      {
          if(multipleExchangeIndexAnnexFallbackNode->Attribute("id"))
          {
             multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode->Attribute("id");
             multipleExchangeIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode));
             multipleExchangeIndexAnnexFallback_->setID(multipleExchangeIndexAnnexFallbackIDRef_);
             IDManager::instance().setID(multipleExchangeIndexAnnexFallbackIDRef_,multipleExchangeIndexAnnexFallback_);
          }
          else if(multipleExchangeIndexAnnexFallbackNode->Attribute("href")) { multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleExchangeIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode));}
   }

   //componentSecurityIndexAnnexFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* componentSecurityIndexAnnexFallbackNode = xmlNode->FirstChildElement("componentSecurityIndexAnnexFallback");

   if(componentSecurityIndexAnnexFallbackNode){componentSecurityIndexAnnexFallbackIsNull_ = false;}
   else{componentSecurityIndexAnnexFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- componentSecurityIndexAnnexFallbackNode , address : " << componentSecurityIndexAnnexFallbackNode << std::endl;
   #endif
   if(componentSecurityIndexAnnexFallbackNode)
   {
      if(componentSecurityIndexAnnexFallbackNode->Attribute("href") || componentSecurityIndexAnnexFallbackNode->Attribute("id"))
      {
          if(componentSecurityIndexAnnexFallbackNode->Attribute("id"))
          {
             componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode->Attribute("id");
             componentSecurityIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode));
             componentSecurityIndexAnnexFallback_->setID(componentSecurityIndexAnnexFallbackIDRef_);
             IDManager::instance().setID(componentSecurityIndexAnnexFallbackIDRef_,componentSecurityIndexAnnexFallback_);
          }
          else if(componentSecurityIndexAnnexFallbackNode->Attribute("href")) { componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { componentSecurityIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode));}
   }

   //methodOfAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* methodOfAdjustmentNode = xmlNode->FirstChildElement("methodOfAdjustment");

   if(methodOfAdjustmentNode){methodOfAdjustmentIsNull_ = false;}
   else{methodOfAdjustmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- methodOfAdjustmentNode , address : " << methodOfAdjustmentNode << std::endl;
   #endif
   if(methodOfAdjustmentNode)
   {
      if(methodOfAdjustmentNode->Attribute("href") || methodOfAdjustmentNode->Attribute("id"))
      {
          if(methodOfAdjustmentNode->Attribute("id"))
          {
             methodOfAdjustmentIDRef_ = methodOfAdjustmentNode->Attribute("id");
             methodOfAdjustment_ = boost::shared_ptr<MethodOfAdjustmentEnum>(new MethodOfAdjustmentEnum(methodOfAdjustmentNode));
             methodOfAdjustment_->setID(methodOfAdjustmentIDRef_);
             IDManager::instance().setID(methodOfAdjustmentIDRef_,methodOfAdjustment_);
          }
          else if(methodOfAdjustmentNode->Attribute("href")) { methodOfAdjustmentIDRef_ = methodOfAdjustmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { methodOfAdjustment_ = boost::shared_ptr<MethodOfAdjustmentEnum>(new MethodOfAdjustmentEnum(methodOfAdjustmentNode));}
   }

   //localJurisdictionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* localJurisdictionNode = xmlNode->FirstChildElement("localJurisdiction");

   if(localJurisdictionNode){localJurisdictionIsNull_ = false;}
   else{localJurisdictionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- localJurisdictionNode , address : " << localJurisdictionNode << std::endl;
   #endif
   if(localJurisdictionNode)
   {
      if(localJurisdictionNode->Attribute("href") || localJurisdictionNode->Attribute("id"))
      {
          if(localJurisdictionNode->Attribute("id"))
          {
             localJurisdictionIDRef_ = localJurisdictionNode->Attribute("id");
             localJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(localJurisdictionNode));
             localJurisdiction_->setID(localJurisdictionIDRef_);
             IDManager::instance().setID(localJurisdictionIDRef_,localJurisdiction_);
          }
          else if(localJurisdictionNode->Attribute("href")) { localJurisdictionIDRef_ = localJurisdictionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { localJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(localJurisdictionNode));}
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

   //multiplierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multiplierNode = xmlNode->FirstChildElement("multiplier");

   if(multiplierNode){multiplierIsNull_ = false;}
   else{multiplierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multiplierNode , address : " << multiplierNode << std::endl;
   #endif
   if(multiplierNode)
   {
      if(multiplierNode->Attribute("href") || multiplierNode->Attribute("id"))
      {
          if(multiplierNode->Attribute("id"))
          {
             multiplierIDRef_ = multiplierNode->Attribute("id");
             multiplier_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(multiplierNode));
             multiplier_->setID(multiplierIDRef_);
             IDManager::instance().setID(multiplierIDRef_,multiplier_);
          }
          else if(multiplierNode->Attribute("href")) { multiplierIDRef_ = multiplierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multiplier_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(multiplierNode));}
   }

   //extraordinaryEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extraordinaryEventsNode = xmlNode->FirstChildElement("extraordinaryEvents");

   if(extraordinaryEventsNode){extraordinaryEventsIsNull_ = false;}
   else{extraordinaryEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extraordinaryEventsNode , address : " << extraordinaryEventsNode << std::endl;
   #endif
   if(extraordinaryEventsNode)
   {
      if(extraordinaryEventsNode->Attribute("href") || extraordinaryEventsNode->Attribute("id"))
      {
          if(extraordinaryEventsNode->Attribute("id"))
          {
             extraordinaryEventsIDRef_ = extraordinaryEventsNode->Attribute("id");
             extraordinaryEvents_ = boost::shared_ptr<ExtraordinaryEvents>(new ExtraordinaryEvents(extraordinaryEventsNode));
             extraordinaryEvents_->setID(extraordinaryEventsIDRef_);
             IDManager::instance().setID(extraordinaryEventsIDRef_,extraordinaryEvents_);
          }
          else if(extraordinaryEventsNode->Attribute("href")) { extraordinaryEventsIDRef_ = extraordinaryEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { extraordinaryEvents_ = boost::shared_ptr<ExtraordinaryEvents>(new ExtraordinaryEvents(extraordinaryEventsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> EquityOptionTransactionSupplement::getExchangeLookAlike()
{
   if(!this->exchangeLookAlikeIsNull_){
        if(exchangeLookAlikeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(exchangeLookAlikeIDRef_));
        }else{
             return this->exchangeLookAlike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquityOptionTransactionSupplement::getExchangeTradedContractNearest()
{
   if(!this->exchangeTradedContractNearestIsNull_){
        if(exchangeTradedContractNearestIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(exchangeTradedContractNearestIDRef_));
        }else{
             return this->exchangeTradedContractNearest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquityOptionTransactionSupplement::getMultipleExchangeIndexAnnexFallback()
{
   if(!this->multipleExchangeIndexAnnexFallbackIsNull_){
        if(multipleExchangeIndexAnnexFallbackIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(multipleExchangeIndexAnnexFallbackIDRef_));
        }else{
             return this->multipleExchangeIndexAnnexFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquityOptionTransactionSupplement::getComponentSecurityIndexAnnexFallback()
{
   if(!this->componentSecurityIndexAnnexFallbackIsNull_){
        if(componentSecurityIndexAnnexFallbackIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(componentSecurityIndexAnnexFallbackIDRef_));
        }else{
             return this->componentSecurityIndexAnnexFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<MethodOfAdjustmentEnum> EquityOptionTransactionSupplement::getMethodOfAdjustment()
{
   if(!this->methodOfAdjustmentIsNull_){
        if(methodOfAdjustmentIDRef_ != ""){
             return boost::shared_static_cast<MethodOfAdjustmentEnum>(IDManager::instance().getID(methodOfAdjustmentIDRef_));
        }else{
             return this->methodOfAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MethodOfAdjustmentEnum>();
   }
}
boost::shared_ptr<CountryCode> EquityOptionTransactionSupplement::getLocalJurisdiction()
{
   if(!this->localJurisdictionIsNull_){
        if(localJurisdictionIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(localJurisdictionIDRef_));
        }else{
             return this->localJurisdiction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
boost::shared_ptr<PositiveDecimal> EquityOptionTransactionSupplement::getOptionEntitlement()
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
boost::shared_ptr<PositiveDecimal> EquityOptionTransactionSupplement::getMultiplier()
{
   if(!this->multiplierIsNull_){
        if(multiplierIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(multiplierIDRef_));
        }else{
             return this->multiplier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<ExtraordinaryEvents> EquityOptionTransactionSupplement::getExtraordinaryEvents()
{
   if(!this->extraordinaryEventsIsNull_){
        if(extraordinaryEventsIDRef_ != ""){
             return boost::shared_static_cast<ExtraordinaryEvents>(IDManager::instance().getID(extraordinaryEventsIDRef_));
        }else{
             return this->extraordinaryEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExtraordinaryEvents>();
   }
}
}

