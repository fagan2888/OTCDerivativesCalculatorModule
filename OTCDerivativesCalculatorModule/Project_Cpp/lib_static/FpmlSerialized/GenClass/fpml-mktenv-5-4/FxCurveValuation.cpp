// FxCurveValuation.cpp 
#include "FxCurveValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxCurveValuation::FxCurveValuation(TiXmlNode* xmlNode)
: PricingStructureValuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementCurrencyYieldCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementCurrencyYieldCurveNode = xmlNode->FirstChildElement("settlementCurrencyYieldCurve");

   if(settlementCurrencyYieldCurveNode){settlementCurrencyYieldCurveIsNull_ = false;}
   else{settlementCurrencyYieldCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementCurrencyYieldCurveNode , address : " << settlementCurrencyYieldCurveNode << std::endl;
   #endif
   if(settlementCurrencyYieldCurveNode)
   {
      if(settlementCurrencyYieldCurveNode->Attribute("href") || settlementCurrencyYieldCurveNode->Attribute("id"))
      {
          if(settlementCurrencyYieldCurveNode->Attribute("id"))
          {
             settlementCurrencyYieldCurveIDRef_ = settlementCurrencyYieldCurveNode->Attribute("id");
             settlementCurrencyYieldCurve_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(settlementCurrencyYieldCurveNode));
             settlementCurrencyYieldCurve_->setID(settlementCurrencyYieldCurveIDRef_);
             IDManager::instance().setID(settlementCurrencyYieldCurveIDRef_,settlementCurrencyYieldCurve_);
          }
          else if(settlementCurrencyYieldCurveNode->Attribute("href")) { settlementCurrencyYieldCurveIDRef_ = settlementCurrencyYieldCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementCurrencyYieldCurve_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(settlementCurrencyYieldCurveNode));}
   }

   //forecastCurrencyYieldCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forecastCurrencyYieldCurveNode = xmlNode->FirstChildElement("forecastCurrencyYieldCurve");

   if(forecastCurrencyYieldCurveNode){forecastCurrencyYieldCurveIsNull_ = false;}
   else{forecastCurrencyYieldCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forecastCurrencyYieldCurveNode , address : " << forecastCurrencyYieldCurveNode << std::endl;
   #endif
   if(forecastCurrencyYieldCurveNode)
   {
      if(forecastCurrencyYieldCurveNode->Attribute("href") || forecastCurrencyYieldCurveNode->Attribute("id"))
      {
          if(forecastCurrencyYieldCurveNode->Attribute("id"))
          {
             forecastCurrencyYieldCurveIDRef_ = forecastCurrencyYieldCurveNode->Attribute("id");
             forecastCurrencyYieldCurve_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(forecastCurrencyYieldCurveNode));
             forecastCurrencyYieldCurve_->setID(forecastCurrencyYieldCurveIDRef_);
             IDManager::instance().setID(forecastCurrencyYieldCurveIDRef_,forecastCurrencyYieldCurve_);
          }
          else if(forecastCurrencyYieldCurveNode->Attribute("href")) { forecastCurrencyYieldCurveIDRef_ = forecastCurrencyYieldCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forecastCurrencyYieldCurve_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(forecastCurrencyYieldCurveNode));}
   }

   //spotRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spotRateNode = xmlNode->FirstChildElement("spotRate");

   if(spotRateNode){spotRateIsNull_ = false;}
   else{spotRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spotRateNode , address : " << spotRateNode << std::endl;
   #endif
   if(spotRateNode)
   {
      if(spotRateNode->Attribute("href") || spotRateNode->Attribute("id"))
      {
          if(spotRateNode->Attribute("id"))
          {
             spotRateIDRef_ = spotRateNode->Attribute("id");
             spotRate_ = boost::shared_ptr<FxRateSet>(new FxRateSet(spotRateNode));
             spotRate_->setID(spotRateIDRef_);
             IDManager::instance().setID(spotRateIDRef_,spotRate_);
          }
          else if(spotRateNode->Attribute("href")) { spotRateIDRef_ = spotRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spotRate_ = boost::shared_ptr<FxRateSet>(new FxRateSet(spotRateNode));}
   }

   //fxForwardCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxForwardCurveNode = xmlNode->FirstChildElement("fxForwardCurve");

   if(fxForwardCurveNode){fxForwardCurveIsNull_ = false;}
   else{fxForwardCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxForwardCurveNode , address : " << fxForwardCurveNode << std::endl;
   #endif
   if(fxForwardCurveNode)
   {
      if(fxForwardCurveNode->Attribute("href") || fxForwardCurveNode->Attribute("id"))
      {
          if(fxForwardCurveNode->Attribute("id"))
          {
             fxForwardCurveIDRef_ = fxForwardCurveNode->Attribute("id");
             fxForwardCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(fxForwardCurveNode));
             fxForwardCurve_->setID(fxForwardCurveIDRef_);
             IDManager::instance().setID(fxForwardCurveIDRef_,fxForwardCurve_);
          }
          else if(fxForwardCurveNode->Attribute("href")) { fxForwardCurveIDRef_ = fxForwardCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxForwardCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(fxForwardCurveNode));}
   }

   //fxForwardPointsCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxForwardPointsCurveNode = xmlNode->FirstChildElement("fxForwardPointsCurve");

   if(fxForwardPointsCurveNode){fxForwardPointsCurveIsNull_ = false;}
   else{fxForwardPointsCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxForwardPointsCurveNode , address : " << fxForwardPointsCurveNode << std::endl;
   #endif
   if(fxForwardPointsCurveNode)
   {
      if(fxForwardPointsCurveNode->Attribute("href") || fxForwardPointsCurveNode->Attribute("id"))
      {
          if(fxForwardPointsCurveNode->Attribute("id"))
          {
             fxForwardPointsCurveIDRef_ = fxForwardPointsCurveNode->Attribute("id");
             fxForwardPointsCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(fxForwardPointsCurveNode));
             fxForwardPointsCurve_->setID(fxForwardPointsCurveIDRef_);
             IDManager::instance().setID(fxForwardPointsCurveIDRef_,fxForwardPointsCurve_);
          }
          else if(fxForwardPointsCurveNode->Attribute("href")) { fxForwardPointsCurveIDRef_ = fxForwardPointsCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxForwardPointsCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(fxForwardPointsCurveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PricingStructureReference> FxCurveValuation::getSettlementCurrencyYieldCurve()
{
   if(!this->settlementCurrencyYieldCurveIsNull_){
        if(settlementCurrencyYieldCurveIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(settlementCurrencyYieldCurveIDRef_));
        }else{
             return this->settlementCurrencyYieldCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
boost::shared_ptr<PricingStructureReference> FxCurveValuation::getForecastCurrencyYieldCurve()
{
   if(!this->forecastCurrencyYieldCurveIsNull_){
        if(forecastCurrencyYieldCurveIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(forecastCurrencyYieldCurveIDRef_));
        }else{
             return this->forecastCurrencyYieldCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
boost::shared_ptr<FxRateSet> FxCurveValuation::getSpotRate()
{
   if(!this->spotRateIsNull_){
        if(spotRateIDRef_ != ""){
             return boost::shared_static_cast<FxRateSet>(IDManager::instance().getID(spotRateIDRef_));
        }else{
             return this->spotRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxRateSet>();
   }
}
boost::shared_ptr<TermCurve> FxCurveValuation::getFxForwardCurve()
{
   if(!this->fxForwardCurveIsNull_){
        if(fxForwardCurveIDRef_ != ""){
             return boost::shared_static_cast<TermCurve>(IDManager::instance().getID(fxForwardCurveIDRef_));
        }else{
             return this->fxForwardCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermCurve>();
   }
}
boost::shared_ptr<TermCurve> FxCurveValuation::getFxForwardPointsCurve()
{
   if(!this->fxForwardPointsCurveIsNull_){
        if(fxForwardPointsCurveIDRef_ != ""){
             return boost::shared_static_cast<TermCurve>(IDManager::instance().getID(fxForwardPointsCurveIDRef_));
        }else{
             return this->fxForwardPointsCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermCurve>();
   }
}
}

