// DividendSwapOptionTransactionSupplement.cpp 
#include "DividendSwapOptionTransactionSupplement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendSwapOptionTransactionSupplement::DividendSwapOptionTransactionSupplement(TiXmlNode* xmlNode)
: OptionBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //equityPremiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityPremiumNode = xmlNode->FirstChildElement("equityPremium");

   if(equityPremiumNode){equityPremiumIsNull_ = false;}
   else{equityPremiumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityPremiumNode , address : " << equityPremiumNode << std::endl;
   #endif
   if(equityPremiumNode)
   {
      if(equityPremiumNode->Attribute("href") || equityPremiumNode->Attribute("id"))
      {
          if(equityPremiumNode->Attribute("id"))
          {
             equityPremiumIDRef_ = equityPremiumNode->Attribute("id");
             equityPremium_ = boost::shared_ptr<EquityPremium>(new EquityPremium(equityPremiumNode));
             equityPremium_->setID(equityPremiumIDRef_);
             IDManager::instance().setID(equityPremiumIDRef_,equityPremium_);
          }
          else if(equityPremiumNode->Attribute("href")) { equityPremiumIDRef_ = equityPremiumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityPremium_ = boost::shared_ptr<EquityPremium>(new EquityPremium(equityPremiumNode));}
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

   //dividendSwapTransactionSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendSwapTransactionSupplementNode = xmlNode->FirstChildElement("dividendSwapTransactionSupplement");

   if(dividendSwapTransactionSupplementNode){dividendSwapTransactionSupplementIsNull_ = false;}
   else{dividendSwapTransactionSupplementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendSwapTransactionSupplementNode , address : " << dividendSwapTransactionSupplementNode << std::endl;
   #endif
   if(dividendSwapTransactionSupplementNode)
   {
      if(dividendSwapTransactionSupplementNode->Attribute("href") || dividendSwapTransactionSupplementNode->Attribute("id"))
      {
          if(dividendSwapTransactionSupplementNode->Attribute("id"))
          {
             dividendSwapTransactionSupplementIDRef_ = dividendSwapTransactionSupplementNode->Attribute("id");
             dividendSwapTransactionSupplement_ = boost::shared_ptr<DividendSwapTransactionSupplement>(new DividendSwapTransactionSupplement(dividendSwapTransactionSupplementNode));
             dividendSwapTransactionSupplement_->setID(dividendSwapTransactionSupplementIDRef_);
             IDManager::instance().setID(dividendSwapTransactionSupplementIDRef_,dividendSwapTransactionSupplement_);
          }
          else if(dividendSwapTransactionSupplementNode->Attribute("href")) { dividendSwapTransactionSupplementIDRef_ = dividendSwapTransactionSupplementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendSwapTransactionSupplement_ = boost::shared_ptr<DividendSwapTransactionSupplement>(new DividendSwapTransactionSupplement(dividendSwapTransactionSupplementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EquityPremium> DividendSwapOptionTransactionSupplement::getEquityPremium()
{
   if(!this->equityPremiumIsNull_){
        if(equityPremiumIDRef_ != ""){
             return boost::shared_static_cast<EquityPremium>(IDManager::instance().getID(equityPremiumIDRef_));
        }else{
             return this->equityPremium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityPremium>();
   }
}
boost::shared_ptr<EquityExerciseValuationSettlement> DividendSwapOptionTransactionSupplement::getEquityExercise()
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
boost::shared_ptr<XsdTypeBoolean> DividendSwapOptionTransactionSupplement::getExchangeLookAlike()
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
boost::shared_ptr<MethodOfAdjustmentEnum> DividendSwapOptionTransactionSupplement::getMethodOfAdjustment()
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
boost::shared_ptr<PositiveDecimal> DividendSwapOptionTransactionSupplement::getOptionEntitlement()
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
boost::shared_ptr<PositiveDecimal> DividendSwapOptionTransactionSupplement::getMultiplier()
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
boost::shared_ptr<DividendSwapTransactionSupplement> DividendSwapOptionTransactionSupplement::getDividendSwapTransactionSupplement()
{
   if(!this->dividendSwapTransactionSupplementIsNull_){
        if(dividendSwapTransactionSupplementIDRef_ != ""){
             return boost::shared_static_cast<DividendSwapTransactionSupplement>(IDManager::instance().getID(dividendSwapTransactionSupplementIDRef_));
        }else{
             return this->dividendSwapTransactionSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendSwapTransactionSupplement>();
   }
}
}

