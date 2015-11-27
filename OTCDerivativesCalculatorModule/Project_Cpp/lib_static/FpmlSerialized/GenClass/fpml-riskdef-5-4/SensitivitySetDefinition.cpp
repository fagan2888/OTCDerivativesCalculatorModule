// SensitivitySetDefinition.cpp 
#include "SensitivitySetDefinition.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SensitivitySetDefinition::SensitivitySetDefinition(TiXmlNode* xmlNode)
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

   //sensitivityCharacteristicsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sensitivityCharacteristicsNode = xmlNode->FirstChildElement("sensitivityCharacteristics");

   if(sensitivityCharacteristicsNode){sensitivityCharacteristicsIsNull_ = false;}
   else{sensitivityCharacteristicsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sensitivityCharacteristicsNode , address : " << sensitivityCharacteristicsNode << std::endl;
   #endif
   if(sensitivityCharacteristicsNode)
   {
      if(sensitivityCharacteristicsNode->Attribute("href") || sensitivityCharacteristicsNode->Attribute("id"))
      {
          if(sensitivityCharacteristicsNode->Attribute("id"))
          {
             sensitivityCharacteristicsIDRef_ = sensitivityCharacteristicsNode->Attribute("id");
             sensitivityCharacteristics_ = boost::shared_ptr<QuotationCharacteristics>(new QuotationCharacteristics(sensitivityCharacteristicsNode));
             sensitivityCharacteristics_->setID(sensitivityCharacteristicsIDRef_);
             IDManager::instance().setID(sensitivityCharacteristicsIDRef_,sensitivityCharacteristics_);
          }
          else if(sensitivityCharacteristicsNode->Attribute("href")) { sensitivityCharacteristicsIDRef_ = sensitivityCharacteristicsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sensitivityCharacteristics_ = boost::shared_ptr<QuotationCharacteristics>(new QuotationCharacteristics(sensitivityCharacteristicsNode));}
   }

   //valuationScenarioReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationScenarioReferenceNode = xmlNode->FirstChildElement("valuationScenarioReference");

   if(valuationScenarioReferenceNode){valuationScenarioReferenceIsNull_ = false;}
   else{valuationScenarioReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationScenarioReferenceNode , address : " << valuationScenarioReferenceNode << std::endl;
   #endif
   if(valuationScenarioReferenceNode)
   {
      if(valuationScenarioReferenceNode->Attribute("href") || valuationScenarioReferenceNode->Attribute("id"))
      {
          if(valuationScenarioReferenceNode->Attribute("id"))
          {
             valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode->Attribute("id");
             valuationScenarioReference_ = boost::shared_ptr<ValuationScenarioReference>(new ValuationScenarioReference(valuationScenarioReferenceNode));
             valuationScenarioReference_->setID(valuationScenarioReferenceIDRef_);
             IDManager::instance().setID(valuationScenarioReferenceIDRef_,valuationScenarioReference_);
          }
          else if(valuationScenarioReferenceNode->Attribute("href")) { valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationScenarioReference_ = boost::shared_ptr<ValuationScenarioReference>(new ValuationScenarioReference(valuationScenarioReferenceNode));}
   }

   //pricingInputTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingInputTypeNode = xmlNode->FirstChildElement("pricingInputType");

   if(pricingInputTypeNode){pricingInputTypeIsNull_ = false;}
   else{pricingInputTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingInputTypeNode , address : " << pricingInputTypeNode << std::endl;
   #endif
   if(pricingInputTypeNode)
   {
      if(pricingInputTypeNode->Attribute("href") || pricingInputTypeNode->Attribute("id"))
      {
          if(pricingInputTypeNode->Attribute("id"))
          {
             pricingInputTypeIDRef_ = pricingInputTypeNode->Attribute("id");
             pricingInputType_ = boost::shared_ptr<PricingInputType>(new PricingInputType(pricingInputTypeNode));
             pricingInputType_->setID(pricingInputTypeIDRef_);
             IDManager::instance().setID(pricingInputTypeIDRef_,pricingInputType_);
          }
          else if(pricingInputTypeNode->Attribute("href")) { pricingInputTypeIDRef_ = pricingInputTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingInputType_ = boost::shared_ptr<PricingInputType>(new PricingInputType(pricingInputTypeNode));}
   }

   //pricingInputReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingInputReferenceNode = xmlNode->FirstChildElement("pricingInputReference");

   if(pricingInputReferenceNode){pricingInputReferenceIsNull_ = false;}
   else{pricingInputReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingInputReferenceNode , address : " << pricingInputReferenceNode << std::endl;
   #endif
   if(pricingInputReferenceNode)
   {
      if(pricingInputReferenceNode->Attribute("href") || pricingInputReferenceNode->Attribute("id"))
      {
          if(pricingInputReferenceNode->Attribute("id"))
          {
             pricingInputReferenceIDRef_ = pricingInputReferenceNode->Attribute("id");
             pricingInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(pricingInputReferenceNode));
             pricingInputReference_->setID(pricingInputReferenceIDRef_);
             IDManager::instance().setID(pricingInputReferenceIDRef_,pricingInputReference_);
          }
          else if(pricingInputReferenceNode->Attribute("href")) { pricingInputReferenceIDRef_ = pricingInputReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(pricingInputReferenceNode));}
   }

   //scaleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* scaleNode = xmlNode->FirstChildElement("scale");

   if(scaleNode){scaleIsNull_ = false;}
   else{scaleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scaleNode , address : " << scaleNode << std::endl;
   #endif
   if(scaleNode)
   {
      if(scaleNode->Attribute("href") || scaleNode->Attribute("id"))
      {
          if(scaleNode->Attribute("id"))
          {
             scaleIDRef_ = scaleNode->Attribute("id");
             scale_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(scaleNode));
             scale_->setID(scaleIDRef_);
             IDManager::instance().setID(scaleIDRef_,scale_);
          }
          else if(scaleNode->Attribute("href")) { scaleIDRef_ = scaleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { scale_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(scaleNode));}
   }

   //sensitivityDefinitionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sensitivityDefinitionNode = xmlNode->FirstChildElement("sensitivityDefinition");

   if(sensitivityDefinitionNode){sensitivityDefinitionIsNull_ = false;}
   else{sensitivityDefinitionIsNull_ = true;}

   if(sensitivityDefinitionNode)
   {
      for(sensitivityDefinitionNode; sensitivityDefinitionNode; sensitivityDefinitionNode = sensitivityDefinitionNode->NextSiblingElement("sensitivityDefinition")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sensitivityDefinitionNode , address : " << sensitivityDefinitionNode << std::endl;
          #endif
          if(sensitivityDefinitionNode->Attribute("href") || sensitivityDefinitionNode->Attribute("id"))
          {
              if(sensitivityDefinitionNode->Attribute("id"))
              {
                  sensitivityDefinitionIDRef_ = sensitivityDefinitionNode->Attribute("id");
                  sensitivityDefinition_.push_back(boost::shared_ptr<SensitivityDefinition>(new SensitivityDefinition(sensitivityDefinitionNode)));
                  sensitivityDefinition_.back()->setID(sensitivityDefinitionIDRef_);
                  IDManager::instance().setID(sensitivityDefinitionIDRef_, sensitivityDefinition_.back());
              }
              else if(sensitivityDefinitionNode->Attribute("href")) { sensitivityDefinitionIDRef_ = sensitivityDefinitionNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { sensitivityDefinition_.push_back(boost::shared_ptr<SensitivityDefinition>(new SensitivityDefinition(sensitivityDefinitionNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sensitivityDefinitionNode , address : " << sensitivityDefinitionNode << std::endl;
       #endif
   }

   //calculationProcedureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationProcedureNode = xmlNode->FirstChildElement("calculationProcedure");

   if(calculationProcedureNode){calculationProcedureIsNull_ = false;}
   else{calculationProcedureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationProcedureNode , address : " << calculationProcedureNode << std::endl;
   #endif
   if(calculationProcedureNode)
   {
      if(calculationProcedureNode->Attribute("href") || calculationProcedureNode->Attribute("id"))
      {
          if(calculationProcedureNode->Attribute("id"))
          {
             calculationProcedureIDRef_ = calculationProcedureNode->Attribute("id");
             calculationProcedure_ = boost::shared_ptr<DerivativeCalculationProcedure>(new DerivativeCalculationProcedure(calculationProcedureNode));
             calculationProcedure_->setID(calculationProcedureIDRef_);
             IDManager::instance().setID(calculationProcedureIDRef_,calculationProcedure_);
          }
          else if(calculationProcedureNode->Attribute("href")) { calculationProcedureIDRef_ = calculationProcedureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationProcedure_ = boost::shared_ptr<DerivativeCalculationProcedure>(new DerivativeCalculationProcedure(calculationProcedureNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> SensitivitySetDefinition::getName()
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
boost::shared_ptr<QuotationCharacteristics> SensitivitySetDefinition::getSensitivityCharacteristics()
{
   if(!this->sensitivityCharacteristicsIsNull_){
        if(sensitivityCharacteristicsIDRef_ != ""){
             return boost::shared_static_cast<QuotationCharacteristics>(IDManager::instance().getID(sensitivityCharacteristicsIDRef_));
        }else{
             return this->sensitivityCharacteristics_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationCharacteristics>();
   }
}
boost::shared_ptr<ValuationScenarioReference> SensitivitySetDefinition::getValuationScenarioReference()
{
   if(!this->valuationScenarioReferenceIsNull_){
        if(valuationScenarioReferenceIDRef_ != ""){
             return boost::shared_static_cast<ValuationScenarioReference>(IDManager::instance().getID(valuationScenarioReferenceIDRef_));
        }else{
             return this->valuationScenarioReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationScenarioReference>();
   }
}
boost::shared_ptr<PricingInputType> SensitivitySetDefinition::getPricingInputType()
{
   if(!this->pricingInputTypeIsNull_){
        if(pricingInputTypeIDRef_ != ""){
             return boost::shared_static_cast<PricingInputType>(IDManager::instance().getID(pricingInputTypeIDRef_));
        }else{
             return this->pricingInputType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingInputType>();
   }
}
boost::shared_ptr<PricingStructureReference> SensitivitySetDefinition::getPricingInputReference()
{
   if(!this->pricingInputReferenceIsNull_){
        if(pricingInputReferenceIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(pricingInputReferenceIDRef_));
        }else{
             return this->pricingInputReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> SensitivitySetDefinition::getScale()
{
   if(!this->scaleIsNull_){
        if(scaleIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(scaleIDRef_));
        }else{
             return this->scale_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
std::vector<boost::shared_ptr<SensitivityDefinition>> SensitivitySetDefinition::getSensitivityDefinition()
{
   if(!this->sensitivityDefinitionIsNull_){
        if(sensitivityDefinitionIDRef_ != ""){
             return this->sensitivityDefinition_;
        }else{
             return this->sensitivityDefinition_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SensitivityDefinition>>();
   }
}
boost::shared_ptr<DerivativeCalculationProcedure> SensitivitySetDefinition::getCalculationProcedure()
{
   if(!this->calculationProcedureIsNull_){
        if(calculationProcedureIDRef_ != ""){
             return boost::shared_static_cast<DerivativeCalculationProcedure>(IDManager::instance().getID(calculationProcedureIDRef_));
        }else{
             return this->calculationProcedure_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DerivativeCalculationProcedure>();
   }
}
}

