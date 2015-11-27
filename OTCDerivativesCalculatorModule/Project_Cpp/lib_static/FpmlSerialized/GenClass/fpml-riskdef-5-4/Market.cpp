// Market.cpp 
#include "Market.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Market::Market(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(nameNode));}
   }

   //benchmarkQuotesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* benchmarkQuotesNode = xmlNode->FirstChildElement("benchmarkQuotes");

   if(benchmarkQuotesNode){benchmarkQuotesIsNull_ = false;}
   else{benchmarkQuotesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- benchmarkQuotesNode , address : " << benchmarkQuotesNode << std::endl;
   #endif
   if(benchmarkQuotesNode)
   {
      if(benchmarkQuotesNode->Attribute("href") || benchmarkQuotesNode->Attribute("id"))
      {
          if(benchmarkQuotesNode->Attribute("id"))
          {
             benchmarkQuotesIDRef_ = benchmarkQuotesNode->Attribute("id");
             benchmarkQuotes_ = boost::shared_ptr<QuotedAssetSet>(new QuotedAssetSet(benchmarkQuotesNode));
             benchmarkQuotes_->setID(benchmarkQuotesIDRef_);
             IDManager::instance().setID(benchmarkQuotesIDRef_,benchmarkQuotes_);
          }
          else if(benchmarkQuotesNode->Attribute("href")) { benchmarkQuotesIDRef_ = benchmarkQuotesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { benchmarkQuotes_ = boost::shared_ptr<QuotedAssetSet>(new QuotedAssetSet(benchmarkQuotesNode));}
   }

   //pricingStructureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingStructureNode = xmlNode->FirstChildElement("pricingStructure");

   if(pricingStructureNode){pricingStructureIsNull_ = false;}
   else{pricingStructureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingStructureNode , address : " << pricingStructureNode << std::endl;
   #endif
   if(pricingStructureNode)
   {
      if(pricingStructureNode->Attribute("href") || pricingStructureNode->Attribute("id"))
      {
          if(pricingStructureNode->Attribute("id"))
          {
             pricingStructureIDRef_ = pricingStructureNode->Attribute("id");
             pricingStructure_ = boost::shared_ptr<PricingStructure>(new PricingStructure(pricingStructureNode));
             pricingStructure_->setID(pricingStructureIDRef_);
             IDManager::instance().setID(pricingStructureIDRef_,pricingStructure_);
          }
          else if(pricingStructureNode->Attribute("href")) { pricingStructureIDRef_ = pricingStructureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingStructure_ = boost::shared_ptr<PricingStructure>(new PricingStructure(pricingStructureNode));}
   }

   //creditCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditCurveNode = xmlNode->FirstChildElement("creditCurve");

   if(creditCurveNode){creditCurveIsNull_ = false;}
   else{creditCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditCurveNode , address : " << creditCurveNode << std::endl;
   #endif
   if(creditCurveNode)
   {
      if(creditCurveNode->Attribute("href") || creditCurveNode->Attribute("id"))
      {
          if(creditCurveNode->Attribute("id"))
          {
             creditCurveIDRef_ = creditCurveNode->Attribute("id");
             creditCurve_ = boost::shared_ptr<CreditCurve>(new CreditCurve(creditCurveNode));
             creditCurve_->setID(creditCurveIDRef_);
             IDManager::instance().setID(creditCurveIDRef_,creditCurve_);
          }
          else if(creditCurveNode->Attribute("href")) { creditCurveIDRef_ = creditCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditCurve_ = boost::shared_ptr<CreditCurve>(new CreditCurve(creditCurveNode));}
   }

   //fxCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxCurveNode = xmlNode->FirstChildElement("fxCurve");

   if(fxCurveNode){fxCurveIsNull_ = false;}
   else{fxCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxCurveNode , address : " << fxCurveNode << std::endl;
   #endif
   if(fxCurveNode)
   {
      if(fxCurveNode->Attribute("href") || fxCurveNode->Attribute("id"))
      {
          if(fxCurveNode->Attribute("id"))
          {
             fxCurveIDRef_ = fxCurveNode->Attribute("id");
             fxCurve_ = boost::shared_ptr<FxCurve>(new FxCurve(fxCurveNode));
             fxCurve_->setID(fxCurveIDRef_);
             IDManager::instance().setID(fxCurveIDRef_,fxCurve_);
          }
          else if(fxCurveNode->Attribute("href")) { fxCurveIDRef_ = fxCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxCurve_ = boost::shared_ptr<FxCurve>(new FxCurve(fxCurveNode));}
   }

   //volatilityRepresentationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volatilityRepresentationNode = xmlNode->FirstChildElement("volatilityRepresentation");

   if(volatilityRepresentationNode){volatilityRepresentationIsNull_ = false;}
   else{volatilityRepresentationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volatilityRepresentationNode , address : " << volatilityRepresentationNode << std::endl;
   #endif
   if(volatilityRepresentationNode)
   {
      if(volatilityRepresentationNode->Attribute("href") || volatilityRepresentationNode->Attribute("id"))
      {
          if(volatilityRepresentationNode->Attribute("id"))
          {
             volatilityRepresentationIDRef_ = volatilityRepresentationNode->Attribute("id");
             volatilityRepresentation_ = boost::shared_ptr<VolatilityRepresentation>(new VolatilityRepresentation(volatilityRepresentationNode));
             volatilityRepresentation_->setID(volatilityRepresentationIDRef_);
             IDManager::instance().setID(volatilityRepresentationIDRef_,volatilityRepresentation_);
          }
          else if(volatilityRepresentationNode->Attribute("href")) { volatilityRepresentationIDRef_ = volatilityRepresentationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { volatilityRepresentation_ = boost::shared_ptr<VolatilityRepresentation>(new VolatilityRepresentation(volatilityRepresentationNode));}
   }

   //yieldCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* yieldCurveNode = xmlNode->FirstChildElement("yieldCurve");

   if(yieldCurveNode){yieldCurveIsNull_ = false;}
   else{yieldCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- yieldCurveNode , address : " << yieldCurveNode << std::endl;
   #endif
   if(yieldCurveNode)
   {
      if(yieldCurveNode->Attribute("href") || yieldCurveNode->Attribute("id"))
      {
          if(yieldCurveNode->Attribute("id"))
          {
             yieldCurveIDRef_ = yieldCurveNode->Attribute("id");
             yieldCurve_ = boost::shared_ptr<YieldCurve>(new YieldCurve(yieldCurveNode));
             yieldCurve_->setID(yieldCurveIDRef_);
             IDManager::instance().setID(yieldCurveIDRef_,yieldCurve_);
          }
          else if(yieldCurveNode->Attribute("href")) { yieldCurveIDRef_ = yieldCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { yieldCurve_ = boost::shared_ptr<YieldCurve>(new YieldCurve(yieldCurveNode));}
   }

   //pricingStructureValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingStructureValuationNode = xmlNode->FirstChildElement("pricingStructureValuation");

   if(pricingStructureValuationNode){pricingStructureValuationIsNull_ = false;}
   else{pricingStructureValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingStructureValuationNode , address : " << pricingStructureValuationNode << std::endl;
   #endif
   if(pricingStructureValuationNode)
   {
      if(pricingStructureValuationNode->Attribute("href") || pricingStructureValuationNode->Attribute("id"))
      {
          if(pricingStructureValuationNode->Attribute("id"))
          {
             pricingStructureValuationIDRef_ = pricingStructureValuationNode->Attribute("id");
             pricingStructureValuation_ = boost::shared_ptr<PricingStructureValuation>(new PricingStructureValuation(pricingStructureValuationNode));
             pricingStructureValuation_->setID(pricingStructureValuationIDRef_);
             IDManager::instance().setID(pricingStructureValuationIDRef_,pricingStructureValuation_);
          }
          else if(pricingStructureValuationNode->Attribute("href")) { pricingStructureValuationIDRef_ = pricingStructureValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingStructureValuation_ = boost::shared_ptr<PricingStructureValuation>(new PricingStructureValuation(pricingStructureValuationNode));}
   }

   //creditCurveValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditCurveValuationNode = xmlNode->FirstChildElement("creditCurveValuation");

   if(creditCurveValuationNode){creditCurveValuationIsNull_ = false;}
   else{creditCurveValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditCurveValuationNode , address : " << creditCurveValuationNode << std::endl;
   #endif
   if(creditCurveValuationNode)
   {
      if(creditCurveValuationNode->Attribute("href") || creditCurveValuationNode->Attribute("id"))
      {
          if(creditCurveValuationNode->Attribute("id"))
          {
             creditCurveValuationIDRef_ = creditCurveValuationNode->Attribute("id");
             creditCurveValuation_ = boost::shared_ptr<CreditCurveValuation>(new CreditCurveValuation(creditCurveValuationNode));
             creditCurveValuation_->setID(creditCurveValuationIDRef_);
             IDManager::instance().setID(creditCurveValuationIDRef_,creditCurveValuation_);
          }
          else if(creditCurveValuationNode->Attribute("href")) { creditCurveValuationIDRef_ = creditCurveValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditCurveValuation_ = boost::shared_ptr<CreditCurveValuation>(new CreditCurveValuation(creditCurveValuationNode));}
   }

   //fxCurveValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxCurveValuationNode = xmlNode->FirstChildElement("fxCurveValuation");

   if(fxCurveValuationNode){fxCurveValuationIsNull_ = false;}
   else{fxCurveValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxCurveValuationNode , address : " << fxCurveValuationNode << std::endl;
   #endif
   if(fxCurveValuationNode)
   {
      if(fxCurveValuationNode->Attribute("href") || fxCurveValuationNode->Attribute("id"))
      {
          if(fxCurveValuationNode->Attribute("id"))
          {
             fxCurveValuationIDRef_ = fxCurveValuationNode->Attribute("id");
             fxCurveValuation_ = boost::shared_ptr<FxCurveValuation>(new FxCurveValuation(fxCurveValuationNode));
             fxCurveValuation_->setID(fxCurveValuationIDRef_);
             IDManager::instance().setID(fxCurveValuationIDRef_,fxCurveValuation_);
          }
          else if(fxCurveValuationNode->Attribute("href")) { fxCurveValuationIDRef_ = fxCurveValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxCurveValuation_ = boost::shared_ptr<FxCurveValuation>(new FxCurveValuation(fxCurveValuationNode));}
   }

   //volatilityMatrixValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volatilityMatrixValuationNode = xmlNode->FirstChildElement("volatilityMatrixValuation");

   if(volatilityMatrixValuationNode){volatilityMatrixValuationIsNull_ = false;}
   else{volatilityMatrixValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volatilityMatrixValuationNode , address : " << volatilityMatrixValuationNode << std::endl;
   #endif
   if(volatilityMatrixValuationNode)
   {
      if(volatilityMatrixValuationNode->Attribute("href") || volatilityMatrixValuationNode->Attribute("id"))
      {
          if(volatilityMatrixValuationNode->Attribute("id"))
          {
             volatilityMatrixValuationIDRef_ = volatilityMatrixValuationNode->Attribute("id");
             volatilityMatrixValuation_ = boost::shared_ptr<VolatilityMatrix>(new VolatilityMatrix(volatilityMatrixValuationNode));
             volatilityMatrixValuation_->setID(volatilityMatrixValuationIDRef_);
             IDManager::instance().setID(volatilityMatrixValuationIDRef_,volatilityMatrixValuation_);
          }
          else if(volatilityMatrixValuationNode->Attribute("href")) { volatilityMatrixValuationIDRef_ = volatilityMatrixValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { volatilityMatrixValuation_ = boost::shared_ptr<VolatilityMatrix>(new VolatilityMatrix(volatilityMatrixValuationNode));}
   }

   //yieldCurveValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* yieldCurveValuationNode = xmlNode->FirstChildElement("yieldCurveValuation");

   if(yieldCurveValuationNode){yieldCurveValuationIsNull_ = false;}
   else{yieldCurveValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- yieldCurveValuationNode , address : " << yieldCurveValuationNode << std::endl;
   #endif
   if(yieldCurveValuationNode)
   {
      if(yieldCurveValuationNode->Attribute("href") || yieldCurveValuationNode->Attribute("id"))
      {
          if(yieldCurveValuationNode->Attribute("id"))
          {
             yieldCurveValuationIDRef_ = yieldCurveValuationNode->Attribute("id");
             yieldCurveValuation_ = boost::shared_ptr<YieldCurveValuation>(new YieldCurveValuation(yieldCurveValuationNode));
             yieldCurveValuation_->setID(yieldCurveValuationIDRef_);
             IDManager::instance().setID(yieldCurveValuationIDRef_,yieldCurveValuation_);
          }
          else if(yieldCurveValuationNode->Attribute("href")) { yieldCurveValuationIDRef_ = yieldCurveValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { yieldCurveValuation_ = boost::shared_ptr<YieldCurveValuation>(new YieldCurveValuation(yieldCurveValuationNode));}
   }

   //benchmarkPricingMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* benchmarkPricingMethodNode = xmlNode->FirstChildElement("benchmarkPricingMethod");

   if(benchmarkPricingMethodNode){benchmarkPricingMethodIsNull_ = false;}
   else{benchmarkPricingMethodIsNull_ = true;}

   if(benchmarkPricingMethodNode)
   {
      for(benchmarkPricingMethodNode; benchmarkPricingMethodNode; benchmarkPricingMethodNode = benchmarkPricingMethodNode->NextSiblingElement("benchmarkPricingMethod")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- benchmarkPricingMethodNode , address : " << benchmarkPricingMethodNode << std::endl;
          #endif
          if(benchmarkPricingMethodNode->Attribute("href") || benchmarkPricingMethodNode->Attribute("id"))
          {
              if(benchmarkPricingMethodNode->Attribute("id"))
              {
                  benchmarkPricingMethodIDRef_ = benchmarkPricingMethodNode->Attribute("id");
                  benchmarkPricingMethod_.push_back(boost::shared_ptr<PricingMethod>(new PricingMethod(benchmarkPricingMethodNode)));
                  benchmarkPricingMethod_.back()->setID(benchmarkPricingMethodIDRef_);
                  IDManager::instance().setID(benchmarkPricingMethodIDRef_, benchmarkPricingMethod_.back());
              }
              else if(benchmarkPricingMethodNode->Attribute("href")) { benchmarkPricingMethodIDRef_ = benchmarkPricingMethodNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { benchmarkPricingMethod_.push_back(boost::shared_ptr<PricingMethod>(new PricingMethod(benchmarkPricingMethodNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- benchmarkPricingMethodNode , address : " << benchmarkPricingMethodNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> Market::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<QuotedAssetSet> Market::getBenchmarkQuotes()
{
   if(!this->benchmarkQuotesIsNull_){
        if(benchmarkQuotesIDRef_ != ""){
             return boost::shared_static_cast<QuotedAssetSet>(IDManager::instance().getID(benchmarkQuotesIDRef_));
        }else{
             return this->benchmarkQuotes_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedAssetSet>();
   }
}
boost::shared_ptr<PricingStructure> Market::getPricingStructure()
{
   if(!this->pricingStructureIsNull_){
        if(pricingStructureIDRef_ != ""){
             return boost::shared_static_cast<PricingStructure>(IDManager::instance().getID(pricingStructureIDRef_));
        }else{
             return this->pricingStructure_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructure>();
   }
}
boost::shared_ptr<CreditCurve> Market::getCreditCurve()
{
   if(!this->creditCurveIsNull_){
        if(creditCurveIDRef_ != ""){
             return boost::shared_static_cast<CreditCurve>(IDManager::instance().getID(creditCurveIDRef_));
        }else{
             return this->creditCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditCurve>();
   }
}
boost::shared_ptr<FxCurve> Market::getFxCurve()
{
   if(!this->fxCurveIsNull_){
        if(fxCurveIDRef_ != ""){
             return boost::shared_static_cast<FxCurve>(IDManager::instance().getID(fxCurveIDRef_));
        }else{
             return this->fxCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxCurve>();
   }
}
boost::shared_ptr<VolatilityRepresentation> Market::getVolatilityRepresentation()
{
   if(!this->volatilityRepresentationIsNull_){
        if(volatilityRepresentationIDRef_ != ""){
             return boost::shared_static_cast<VolatilityRepresentation>(IDManager::instance().getID(volatilityRepresentationIDRef_));
        }else{
             return this->volatilityRepresentation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VolatilityRepresentation>();
   }
}
boost::shared_ptr<YieldCurve> Market::getYieldCurve()
{
   if(!this->yieldCurveIsNull_){
        if(yieldCurveIDRef_ != ""){
             return boost::shared_static_cast<YieldCurve>(IDManager::instance().getID(yieldCurveIDRef_));
        }else{
             return this->yieldCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldCurve>();
   }
}
boost::shared_ptr<PricingStructureValuation> Market::getPricingStructureValuation()
{
   if(!this->pricingStructureValuationIsNull_){
        if(pricingStructureValuationIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureValuation>(IDManager::instance().getID(pricingStructureValuationIDRef_));
        }else{
             return this->pricingStructureValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureValuation>();
   }
}
boost::shared_ptr<CreditCurveValuation> Market::getCreditCurveValuation()
{
   if(!this->creditCurveValuationIsNull_){
        if(creditCurveValuationIDRef_ != ""){
             return boost::shared_static_cast<CreditCurveValuation>(IDManager::instance().getID(creditCurveValuationIDRef_));
        }else{
             return this->creditCurveValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditCurveValuation>();
   }
}
boost::shared_ptr<FxCurveValuation> Market::getFxCurveValuation()
{
   if(!this->fxCurveValuationIsNull_){
        if(fxCurveValuationIDRef_ != ""){
             return boost::shared_static_cast<FxCurveValuation>(IDManager::instance().getID(fxCurveValuationIDRef_));
        }else{
             return this->fxCurveValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxCurveValuation>();
   }
}
boost::shared_ptr<VolatilityMatrix> Market::getVolatilityMatrixValuation()
{
   if(!this->volatilityMatrixValuationIsNull_){
        if(volatilityMatrixValuationIDRef_ != ""){
             return boost::shared_static_cast<VolatilityMatrix>(IDManager::instance().getID(volatilityMatrixValuationIDRef_));
        }else{
             return this->volatilityMatrixValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VolatilityMatrix>();
   }
}
boost::shared_ptr<YieldCurveValuation> Market::getYieldCurveValuation()
{
   if(!this->yieldCurveValuationIsNull_){
        if(yieldCurveValuationIDRef_ != ""){
             return boost::shared_static_cast<YieldCurveValuation>(IDManager::instance().getID(yieldCurveValuationIDRef_));
        }else{
             return this->yieldCurveValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldCurveValuation>();
   }
}
std::vector<boost::shared_ptr<PricingMethod>> Market::getBenchmarkPricingMethod()
{
   if(!this->benchmarkPricingMethodIsNull_){
        if(benchmarkPricingMethodIDRef_ != ""){
             return this->benchmarkPricingMethod_;
        }else{
             return this->benchmarkPricingMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PricingMethod>>();
   }
}
}

