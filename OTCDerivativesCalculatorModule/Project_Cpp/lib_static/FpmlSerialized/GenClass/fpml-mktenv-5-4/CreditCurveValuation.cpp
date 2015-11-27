// CreditCurveValuation.cpp 
#include "CreditCurveValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditCurveValuation::CreditCurveValuation(TiXmlNode* xmlNode)
: PricingStructureValuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //inputsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inputsNode = xmlNode->FirstChildElement("inputs");

   if(inputsNode){inputsIsNull_ = false;}
   else{inputsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inputsNode , address : " << inputsNode << std::endl;
   #endif
   if(inputsNode)
   {
      if(inputsNode->Attribute("href") || inputsNode->Attribute("id"))
      {
          if(inputsNode->Attribute("id"))
          {
             inputsIDRef_ = inputsNode->Attribute("id");
             inputs_ = boost::shared_ptr<QuotedAssetSet>(new QuotedAssetSet(inputsNode));
             inputs_->setID(inputsIDRef_);
             IDManager::instance().setID(inputsIDRef_,inputs_);
          }
          else if(inputsNode->Attribute("href")) { inputsIDRef_ = inputsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { inputs_ = boost::shared_ptr<QuotedAssetSet>(new QuotedAssetSet(inputsNode));}
   }

   //defaultProbabilityCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* defaultProbabilityCurveNode = xmlNode->FirstChildElement("defaultProbabilityCurve");

   if(defaultProbabilityCurveNode){defaultProbabilityCurveIsNull_ = false;}
   else{defaultProbabilityCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- defaultProbabilityCurveNode , address : " << defaultProbabilityCurveNode << std::endl;
   #endif
   if(defaultProbabilityCurveNode)
   {
      if(defaultProbabilityCurveNode->Attribute("href") || defaultProbabilityCurveNode->Attribute("id"))
      {
          if(defaultProbabilityCurveNode->Attribute("id"))
          {
             defaultProbabilityCurveIDRef_ = defaultProbabilityCurveNode->Attribute("id");
             defaultProbabilityCurve_ = boost::shared_ptr<DefaultProbabilityCurve>(new DefaultProbabilityCurve(defaultProbabilityCurveNode));
             defaultProbabilityCurve_->setID(defaultProbabilityCurveIDRef_);
             IDManager::instance().setID(defaultProbabilityCurveIDRef_,defaultProbabilityCurve_);
          }
          else if(defaultProbabilityCurveNode->Attribute("href")) { defaultProbabilityCurveIDRef_ = defaultProbabilityCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { defaultProbabilityCurve_ = boost::shared_ptr<DefaultProbabilityCurve>(new DefaultProbabilityCurve(defaultProbabilityCurveNode));}
   }

   //recoveryRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* recoveryRateNode = xmlNode->FirstChildElement("recoveryRate");

   if(recoveryRateNode){recoveryRateIsNull_ = false;}
   else{recoveryRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- recoveryRateNode , address : " << recoveryRateNode << std::endl;
   #endif
   if(recoveryRateNode)
   {
      if(recoveryRateNode->Attribute("href") || recoveryRateNode->Attribute("id"))
      {
          if(recoveryRateNode->Attribute("id"))
          {
             recoveryRateIDRef_ = recoveryRateNode->Attribute("id");
             recoveryRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(recoveryRateNode));
             recoveryRate_->setID(recoveryRateIDRef_);
             IDManager::instance().setID(recoveryRateIDRef_,recoveryRate_);
          }
          else if(recoveryRateNode->Attribute("href")) { recoveryRateIDRef_ = recoveryRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { recoveryRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(recoveryRateNode));}
   }

   //recoveryRateCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* recoveryRateCurveNode = xmlNode->FirstChildElement("recoveryRateCurve");

   if(recoveryRateCurveNode){recoveryRateCurveIsNull_ = false;}
   else{recoveryRateCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- recoveryRateCurveNode , address : " << recoveryRateCurveNode << std::endl;
   #endif
   if(recoveryRateCurveNode)
   {
      if(recoveryRateCurveNode->Attribute("href") || recoveryRateCurveNode->Attribute("id"))
      {
          if(recoveryRateCurveNode->Attribute("id"))
          {
             recoveryRateCurveIDRef_ = recoveryRateCurveNode->Attribute("id");
             recoveryRateCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(recoveryRateCurveNode));
             recoveryRateCurve_->setID(recoveryRateCurveIDRef_);
             IDManager::instance().setID(recoveryRateCurveIDRef_,recoveryRateCurve_);
          }
          else if(recoveryRateCurveNode->Attribute("href")) { recoveryRateCurveIDRef_ = recoveryRateCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { recoveryRateCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(recoveryRateCurveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuotedAssetSet> CreditCurveValuation::getInputs()
{
   if(!this->inputsIsNull_){
        if(inputsIDRef_ != ""){
             return boost::shared_static_cast<QuotedAssetSet>(IDManager::instance().getID(inputsIDRef_));
        }else{
             return this->inputs_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedAssetSet>();
   }
}
boost::shared_ptr<DefaultProbabilityCurve> CreditCurveValuation::getDefaultProbabilityCurve()
{
   if(!this->defaultProbabilityCurveIsNull_){
        if(defaultProbabilityCurveIDRef_ != ""){
             return boost::shared_static_cast<DefaultProbabilityCurve>(IDManager::instance().getID(defaultProbabilityCurveIDRef_));
        }else{
             return this->defaultProbabilityCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DefaultProbabilityCurve>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CreditCurveValuation::getRecoveryRate()
{
   if(!this->recoveryRateIsNull_){
        if(recoveryRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(recoveryRateIDRef_));
        }else{
             return this->recoveryRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<TermCurve> CreditCurveValuation::getRecoveryRateCurve()
{
   if(!this->recoveryRateCurveIsNull_){
        if(recoveryRateCurveIDRef_ != ""){
             return boost::shared_static_cast<TermCurve>(IDManager::instance().getID(recoveryRateCurveIDRef_));
        }else{
             return this->recoveryRateCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermCurve>();
   }
}
}

