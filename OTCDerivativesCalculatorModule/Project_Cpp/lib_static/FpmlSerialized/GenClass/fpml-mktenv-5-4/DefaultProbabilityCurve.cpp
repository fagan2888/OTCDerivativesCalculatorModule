// DefaultProbabilityCurve.cpp 
#include "DefaultProbabilityCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DefaultProbabilityCurve::DefaultProbabilityCurve(TiXmlNode* xmlNode)
: PricingStructureValuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //baseYieldCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseYieldCurveNode = xmlNode->FirstChildElement("baseYieldCurve");

   if(baseYieldCurveNode){baseYieldCurveIsNull_ = false;}
   else{baseYieldCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseYieldCurveNode , address : " << baseYieldCurveNode << std::endl;
   #endif
   if(baseYieldCurveNode)
   {
      if(baseYieldCurveNode->Attribute("href") || baseYieldCurveNode->Attribute("id"))
      {
          if(baseYieldCurveNode->Attribute("id"))
          {
             baseYieldCurveIDRef_ = baseYieldCurveNode->Attribute("id");
             baseYieldCurve_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(baseYieldCurveNode));
             baseYieldCurve_->setID(baseYieldCurveIDRef_);
             IDManager::instance().setID(baseYieldCurveIDRef_,baseYieldCurve_);
          }
          else if(baseYieldCurveNode->Attribute("href")) { baseYieldCurveIDRef_ = baseYieldCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseYieldCurve_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(baseYieldCurveNode));}
   }

   //defaultProbabilitiesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* defaultProbabilitiesNode = xmlNode->FirstChildElement("defaultProbabilities");

   if(defaultProbabilitiesNode){defaultProbabilitiesIsNull_ = false;}
   else{defaultProbabilitiesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- defaultProbabilitiesNode , address : " << defaultProbabilitiesNode << std::endl;
   #endif
   if(defaultProbabilitiesNode)
   {
      if(defaultProbabilitiesNode->Attribute("href") || defaultProbabilitiesNode->Attribute("id"))
      {
          if(defaultProbabilitiesNode->Attribute("id"))
          {
             defaultProbabilitiesIDRef_ = defaultProbabilitiesNode->Attribute("id");
             defaultProbabilities_ = boost::shared_ptr<TermCurve>(new TermCurve(defaultProbabilitiesNode));
             defaultProbabilities_->setID(defaultProbabilitiesIDRef_);
             IDManager::instance().setID(defaultProbabilitiesIDRef_,defaultProbabilities_);
          }
          else if(defaultProbabilitiesNode->Attribute("href")) { defaultProbabilitiesIDRef_ = defaultProbabilitiesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { defaultProbabilities_ = boost::shared_ptr<TermCurve>(new TermCurve(defaultProbabilitiesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PricingStructureReference> DefaultProbabilityCurve::getBaseYieldCurve()
{
   if(!this->baseYieldCurveIsNull_){
        if(baseYieldCurveIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(baseYieldCurveIDRef_));
        }else{
             return this->baseYieldCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
boost::shared_ptr<TermCurve> DefaultProbabilityCurve::getDefaultProbabilities()
{
   if(!this->defaultProbabilitiesIsNull_){
        if(defaultProbabilitiesIDRef_ != ""){
             return boost::shared_static_cast<TermCurve>(IDManager::instance().getID(defaultProbabilitiesIDRef_));
        }else{
             return this->defaultProbabilities_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermCurve>();
   }
}
}

