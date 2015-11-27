// EquityOption.cpp 
#include "EquityOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityOption::EquityOption(TiXmlNode* xmlNode)
: EquityDerivativeLongFormBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
   #endif
   if(strikeNode)
   {
      if(strikeNode->Attribute("href") || strikeNode->Attribute("id"))
      {
          if(strikeNode->Attribute("id"))
          {
             strikeIDRef_ = strikeNode->Attribute("id");
             strike_ = boost::shared_ptr<EquityStrike>(new EquityStrike(strikeNode));
             strike_->setID(strikeIDRef_);
             IDManager::instance().setID(strikeIDRef_,strike_);
          }
          else if(strikeNode->Attribute("href")) { strikeIDRef_ = strikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strike_ = boost::shared_ptr<EquityStrike>(new EquityStrike(strikeNode));}
   }

   //spotPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spotPriceNode = xmlNode->FirstChildElement("spotPrice");

   if(spotPriceNode){spotPriceIsNull_ = false;}
   else{spotPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spotPriceNode , address : " << spotPriceNode << std::endl;
   #endif
   if(spotPriceNode)
   {
      if(spotPriceNode->Attribute("href") || spotPriceNode->Attribute("id"))
      {
          if(spotPriceNode->Attribute("id"))
          {
             spotPriceIDRef_ = spotPriceNode->Attribute("id");
             spotPrice_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(spotPriceNode));
             spotPrice_->setID(spotPriceIDRef_);
             IDManager::instance().setID(spotPriceIDRef_,spotPrice_);
          }
          else if(spotPriceNode->Attribute("href")) { spotPriceIDRef_ = spotPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spotPrice_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(spotPriceNode));}
   }

   //numberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberOfOptionsNode = xmlNode->FirstChildElement("numberOfOptions");

   if(numberOfOptionsNode){numberOfOptionsIsNull_ = false;}
   else{numberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberOfOptionsNode , address : " << numberOfOptionsNode << std::endl;
   #endif
   if(numberOfOptionsNode)
   {
      if(numberOfOptionsNode->Attribute("href") || numberOfOptionsNode->Attribute("id"))
      {
          if(numberOfOptionsNode->Attribute("id"))
          {
             numberOfOptionsIDRef_ = numberOfOptionsNode->Attribute("id");
             numberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(numberOfOptionsNode));
             numberOfOptions_->setID(numberOfOptionsIDRef_);
             IDManager::instance().setID(numberOfOptionsIDRef_,numberOfOptions_);
          }
          else if(numberOfOptionsNode->Attribute("href")) { numberOfOptionsIDRef_ = numberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(numberOfOptionsNode));}
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EquityStrike> EquityOption::getStrike()
{
   if(!this->strikeIsNull_){
        if(strikeIDRef_ != ""){
             return boost::shared_static_cast<EquityStrike>(IDManager::instance().getID(strikeIDRef_));
        }else{
             return this->strike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityStrike>();
   }
}
boost::shared_ptr<NonNegativeDecimal> EquityOption::getSpotPrice()
{
   if(!this->spotPriceIsNull_){
        if(spotPriceIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(spotPriceIDRef_));
        }else{
             return this->spotPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> EquityOption::getNumberOfOptions()
{
   if(!this->numberOfOptionsIsNull_){
        if(numberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(numberOfOptionsIDRef_));
        }else{
             return this->numberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<PositiveDecimal> EquityOption::getOptionEntitlement()
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
boost::shared_ptr<EquityPremium> EquityOption::getEquityPremium()
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
}

