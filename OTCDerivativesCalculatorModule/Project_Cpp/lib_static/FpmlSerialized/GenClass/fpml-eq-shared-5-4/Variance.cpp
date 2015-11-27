// Variance.cpp 
#include "Variance.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Variance::Variance(TiXmlNode* xmlNode)
: CalculationFromObservation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //varianceAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceAmountNode = xmlNode->FirstChildElement("varianceAmount");

   if(varianceAmountNode){varianceAmountIsNull_ = false;}
   else{varianceAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceAmountNode , address : " << varianceAmountNode << std::endl;
   #endif
   if(varianceAmountNode)
   {
      if(varianceAmountNode->Attribute("href") || varianceAmountNode->Attribute("id"))
      {
          if(varianceAmountNode->Attribute("id"))
          {
             varianceAmountIDRef_ = varianceAmountNode->Attribute("id");
             varianceAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(varianceAmountNode));
             varianceAmount_->setID(varianceAmountIDRef_);
             IDManager::instance().setID(varianceAmountIDRef_,varianceAmount_);
          }
          else if(varianceAmountNode->Attribute("href")) { varianceAmountIDRef_ = varianceAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varianceAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(varianceAmountNode));}
   }

   //volatilityStrikePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volatilityStrikePriceNode = xmlNode->FirstChildElement("volatilityStrikePrice");

   if(volatilityStrikePriceNode){volatilityStrikePriceIsNull_ = false;}
   else{volatilityStrikePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volatilityStrikePriceNode , address : " << volatilityStrikePriceNode << std::endl;
   #endif
   if(volatilityStrikePriceNode)
   {
      if(volatilityStrikePriceNode->Attribute("href") || volatilityStrikePriceNode->Attribute("id"))
      {
          if(volatilityStrikePriceNode->Attribute("id"))
          {
             volatilityStrikePriceIDRef_ = volatilityStrikePriceNode->Attribute("id");
             volatilityStrikePrice_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(volatilityStrikePriceNode));
             volatilityStrikePrice_->setID(volatilityStrikePriceIDRef_);
             IDManager::instance().setID(volatilityStrikePriceIDRef_,volatilityStrikePrice_);
          }
          else if(volatilityStrikePriceNode->Attribute("href")) { volatilityStrikePriceIDRef_ = volatilityStrikePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { volatilityStrikePrice_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(volatilityStrikePriceNode));}
   }

   //varianceStrikePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceStrikePriceNode = xmlNode->FirstChildElement("varianceStrikePrice");

   if(varianceStrikePriceNode){varianceStrikePriceIsNull_ = false;}
   else{varianceStrikePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceStrikePriceNode , address : " << varianceStrikePriceNode << std::endl;
   #endif
   if(varianceStrikePriceNode)
   {
      if(varianceStrikePriceNode->Attribute("href") || varianceStrikePriceNode->Attribute("id"))
      {
          if(varianceStrikePriceNode->Attribute("id"))
          {
             varianceStrikePriceIDRef_ = varianceStrikePriceNode->Attribute("id");
             varianceStrikePrice_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(varianceStrikePriceNode));
             varianceStrikePrice_->setID(varianceStrikePriceIDRef_);
             IDManager::instance().setID(varianceStrikePriceIDRef_,varianceStrikePrice_);
          }
          else if(varianceStrikePriceNode->Attribute("href")) { varianceStrikePriceIDRef_ = varianceStrikePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varianceStrikePrice_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(varianceStrikePriceNode));}
   }

   //varianceCapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceCapNode = xmlNode->FirstChildElement("varianceCap");

   if(varianceCapNode){varianceCapIsNull_ = false;}
   else{varianceCapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceCapNode , address : " << varianceCapNode << std::endl;
   #endif
   if(varianceCapNode)
   {
      if(varianceCapNode->Attribute("href") || varianceCapNode->Attribute("id"))
      {
          if(varianceCapNode->Attribute("id"))
          {
             varianceCapIDRef_ = varianceCapNode->Attribute("id");
             varianceCap_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(varianceCapNode));
             varianceCap_->setID(varianceCapIDRef_);
             IDManager::instance().setID(varianceCapIDRef_,varianceCap_);
          }
          else if(varianceCapNode->Attribute("href")) { varianceCapIDRef_ = varianceCapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varianceCap_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(varianceCapNode));}
   }

   //unadjustedVarianceCapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedVarianceCapNode = xmlNode->FirstChildElement("unadjustedVarianceCap");

   if(unadjustedVarianceCapNode){unadjustedVarianceCapIsNull_ = false;}
   else{unadjustedVarianceCapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedVarianceCapNode , address : " << unadjustedVarianceCapNode << std::endl;
   #endif
   if(unadjustedVarianceCapNode)
   {
      if(unadjustedVarianceCapNode->Attribute("href") || unadjustedVarianceCapNode->Attribute("id"))
      {
          if(unadjustedVarianceCapNode->Attribute("id"))
          {
             unadjustedVarianceCapIDRef_ = unadjustedVarianceCapNode->Attribute("id");
             unadjustedVarianceCap_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(unadjustedVarianceCapNode));
             unadjustedVarianceCap_->setID(unadjustedVarianceCapIDRef_);
             IDManager::instance().setID(unadjustedVarianceCapIDRef_,unadjustedVarianceCap_);
          }
          else if(unadjustedVarianceCapNode->Attribute("href")) { unadjustedVarianceCapIDRef_ = unadjustedVarianceCapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedVarianceCap_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(unadjustedVarianceCapNode));}
   }

   //boundedVarianceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* boundedVarianceNode = xmlNode->FirstChildElement("boundedVariance");

   if(boundedVarianceNode){boundedVarianceIsNull_ = false;}
   else{boundedVarianceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- boundedVarianceNode , address : " << boundedVarianceNode << std::endl;
   #endif
   if(boundedVarianceNode)
   {
      if(boundedVarianceNode->Attribute("href") || boundedVarianceNode->Attribute("id"))
      {
          if(boundedVarianceNode->Attribute("id"))
          {
             boundedVarianceIDRef_ = boundedVarianceNode->Attribute("id");
             boundedVariance_ = boost::shared_ptr<BoundedVariance>(new BoundedVariance(boundedVarianceNode));
             boundedVariance_->setID(boundedVarianceIDRef_);
             IDManager::instance().setID(boundedVarianceIDRef_,boundedVariance_);
          }
          else if(boundedVarianceNode->Attribute("href")) { boundedVarianceIDRef_ = boundedVarianceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { boundedVariance_ = boost::shared_ptr<BoundedVariance>(new BoundedVariance(boundedVarianceNode));}
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
             exchangeTradedContractNearest_ = boost::shared_ptr<ExchangeTradedContract>(new ExchangeTradedContract(exchangeTradedContractNearestNode));
             exchangeTradedContractNearest_->setID(exchangeTradedContractNearestIDRef_);
             IDManager::instance().setID(exchangeTradedContractNearestIDRef_,exchangeTradedContractNearest_);
          }
          else if(exchangeTradedContractNearestNode->Attribute("href")) { exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeTradedContractNearest_ = boost::shared_ptr<ExchangeTradedContract>(new ExchangeTradedContract(exchangeTradedContractNearestNode));}
   }

   //vegaNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vegaNotionalAmountNode = xmlNode->FirstChildElement("vegaNotionalAmount");

   if(vegaNotionalAmountNode){vegaNotionalAmountIsNull_ = false;}
   else{vegaNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vegaNotionalAmountNode , address : " << vegaNotionalAmountNode << std::endl;
   #endif
   if(vegaNotionalAmountNode)
   {
      if(vegaNotionalAmountNode->Attribute("href") || vegaNotionalAmountNode->Attribute("id"))
      {
          if(vegaNotionalAmountNode->Attribute("id"))
          {
             vegaNotionalAmountIDRef_ = vegaNotionalAmountNode->Attribute("id");
             vegaNotionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(vegaNotionalAmountNode));
             vegaNotionalAmount_->setID(vegaNotionalAmountIDRef_);
             IDManager::instance().setID(vegaNotionalAmountIDRef_,vegaNotionalAmount_);
          }
          else if(vegaNotionalAmountNode->Attribute("href")) { vegaNotionalAmountIDRef_ = vegaNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { vegaNotionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(vegaNotionalAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> Variance::getVarianceAmount()
{
   if(!this->varianceAmountIsNull_){
        if(varianceAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(varianceAmountIDRef_));
        }else{
             return this->varianceAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<NonNegativeDecimal> Variance::getVolatilityStrikePrice()
{
   if(!this->volatilityStrikePriceIsNull_){
        if(volatilityStrikePriceIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(volatilityStrikePriceIDRef_));
        }else{
             return this->volatilityStrikePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> Variance::getVarianceStrikePrice()
{
   if(!this->varianceStrikePriceIsNull_){
        if(varianceStrikePriceIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(varianceStrikePriceIDRef_));
        }else{
             return this->varianceStrikePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Variance::getVarianceCap()
{
   if(!this->varianceCapIsNull_){
        if(varianceCapIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(varianceCapIDRef_));
        }else{
             return this->varianceCap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<PositiveDecimal> Variance::getUnadjustedVarianceCap()
{
   if(!this->unadjustedVarianceCapIsNull_){
        if(unadjustedVarianceCapIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(unadjustedVarianceCapIDRef_));
        }else{
             return this->unadjustedVarianceCap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<BoundedVariance> Variance::getBoundedVariance()
{
   if(!this->boundedVarianceIsNull_){
        if(boundedVarianceIDRef_ != ""){
             return boost::shared_static_cast<BoundedVariance>(IDManager::instance().getID(boundedVarianceIDRef_));
        }else{
             return this->boundedVariance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BoundedVariance>();
   }
}
boost::shared_ptr<ExchangeTradedContract> Variance::getExchangeTradedContractNearest()
{
   if(!this->exchangeTradedContractNearestIsNull_){
        if(exchangeTradedContractNearestIDRef_ != ""){
             return boost::shared_static_cast<ExchangeTradedContract>(IDManager::instance().getID(exchangeTradedContractNearestIDRef_));
        }else{
             return this->exchangeTradedContractNearest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExchangeTradedContract>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Variance::getVegaNotionalAmount()
{
   if(!this->vegaNotionalAmountIsNull_){
        if(vegaNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(vegaNotionalAmountIDRef_));
        }else{
             return this->vegaNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

