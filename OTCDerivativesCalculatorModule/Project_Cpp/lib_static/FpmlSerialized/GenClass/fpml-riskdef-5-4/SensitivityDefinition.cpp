// SensitivityDefinition.cpp 
#include "SensitivityDefinition.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SensitivityDefinition::SensitivityDefinition(TiXmlNode* xmlNode)
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

   //partialDerivativeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partialDerivativeNode = xmlNode->FirstChildElement("partialDerivative");

   if(partialDerivativeNode){partialDerivativeIsNull_ = false;}
   else{partialDerivativeIsNull_ = true;}

   if(partialDerivativeNode)
   {
      for(partialDerivativeNode; partialDerivativeNode; partialDerivativeNode = partialDerivativeNode->NextSiblingElement("partialDerivative")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialDerivativeNode , address : " << partialDerivativeNode << std::endl;
          #endif
          if(partialDerivativeNode->Attribute("href") || partialDerivativeNode->Attribute("id"))
          {
              if(partialDerivativeNode->Attribute("id"))
              {
                  partialDerivativeIDRef_ = partialDerivativeNode->Attribute("id");
                  partialDerivative_.push_back(boost::shared_ptr<PricingParameterDerivative>(new PricingParameterDerivative(partialDerivativeNode)));
                  partialDerivative_.back()->setID(partialDerivativeIDRef_);
                  IDManager::instance().setID(partialDerivativeIDRef_, partialDerivative_.back());
              }
              else if(partialDerivativeNode->Attribute("href")) { partialDerivativeIDRef_ = partialDerivativeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partialDerivative_.push_back(boost::shared_ptr<PricingParameterDerivative>(new PricingParameterDerivative(partialDerivativeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialDerivativeNode , address : " << partialDerivativeNode << std::endl;
       #endif
   }

   //formulaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* formulaNode = xmlNode->FirstChildElement("formula");

   if(formulaNode){formulaIsNull_ = false;}
   else{formulaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- formulaNode , address : " << formulaNode << std::endl;
   #endif
   if(formulaNode)
   {
      if(formulaNode->Attribute("href") || formulaNode->Attribute("id"))
      {
          if(formulaNode->Attribute("id"))
          {
             formulaIDRef_ = formulaNode->Attribute("id");
             formula_ = boost::shared_ptr<DerivativeFormula>(new DerivativeFormula(formulaNode));
             formula_->setID(formulaIDRef_);
             IDManager::instance().setID(formulaIDRef_,formula_);
          }
          else if(formulaNode->Attribute("href")) { formulaIDRef_ = formulaNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { formula_ = boost::shared_ptr<DerivativeFormula>(new DerivativeFormula(formulaNode));}
   }

   //termNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* termNode = xmlNode->FirstChildElement("term");

   if(termNode){termIsNull_ = false;}
   else{termIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- termNode , address : " << termNode << std::endl;
   #endif
   if(termNode)
   {
      if(termNode->Attribute("href") || termNode->Attribute("id"))
      {
          if(termNode->Attribute("id"))
          {
             termIDRef_ = termNode->Attribute("id");
             term_ = boost::shared_ptr<TimeDimension>(new TimeDimension(termNode));
             term_->setID(termIDRef_);
             IDManager::instance().setID(termIDRef_,term_);
          }
          else if(termNode->Attribute("href")) { termIDRef_ = termNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { term_ = boost::shared_ptr<TimeDimension>(new TimeDimension(termNode));}
   }

   //coordinateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coordinateNode = xmlNode->FirstChildElement("coordinate");

   if(coordinateNode){coordinateIsNull_ = false;}
   else{coordinateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coordinateNode , address : " << coordinateNode << std::endl;
   #endif
   if(coordinateNode)
   {
      if(coordinateNode->Attribute("href") || coordinateNode->Attribute("id"))
      {
          if(coordinateNode->Attribute("id"))
          {
             coordinateIDRef_ = coordinateNode->Attribute("id");
             coordinate_ = boost::shared_ptr<PricingDataPointCoordinate>(new PricingDataPointCoordinate(coordinateNode));
             coordinate_->setID(coordinateIDRef_);
             IDManager::instance().setID(coordinateIDRef_,coordinate_);
          }
          else if(coordinateNode->Attribute("href")) { coordinateIDRef_ = coordinateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coordinate_ = boost::shared_ptr<PricingDataPointCoordinate>(new PricingDataPointCoordinate(coordinateNode));}
   }

   //coordinateReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coordinateReferenceNode = xmlNode->FirstChildElement("coordinateReference");

   if(coordinateReferenceNode){coordinateReferenceIsNull_ = false;}
   else{coordinateReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coordinateReferenceNode , address : " << coordinateReferenceNode << std::endl;
   #endif
   if(coordinateReferenceNode)
   {
      if(coordinateReferenceNode->Attribute("href") || coordinateReferenceNode->Attribute("id"))
      {
          if(coordinateReferenceNode->Attribute("id"))
          {
             coordinateReferenceIDRef_ = coordinateReferenceNode->Attribute("id");
             coordinateReference_ = boost::shared_ptr<PricingDataPointCoordinateReference>(new PricingDataPointCoordinateReference(coordinateReferenceNode));
             coordinateReference_->setID(coordinateReferenceIDRef_);
             IDManager::instance().setID(coordinateReferenceIDRef_,coordinateReference_);
          }
          else if(coordinateReferenceNode->Attribute("href")) { coordinateReferenceIDRef_ = coordinateReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coordinateReference_ = boost::shared_ptr<PricingDataPointCoordinateReference>(new PricingDataPointCoordinateReference(coordinateReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> SensitivityDefinition::getName()
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
boost::shared_ptr<ValuationScenarioReference> SensitivityDefinition::getValuationScenarioReference()
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
std::vector<boost::shared_ptr<PricingParameterDerivative>> SensitivityDefinition::getPartialDerivative()
{
   if(!this->partialDerivativeIsNull_){
        if(partialDerivativeIDRef_ != ""){
             return this->partialDerivative_;
        }else{
             return this->partialDerivative_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PricingParameterDerivative>>();
   }
}
boost::shared_ptr<DerivativeFormula> SensitivityDefinition::getFormula()
{
   if(!this->formulaIsNull_){
        if(formulaIDRef_ != ""){
             return boost::shared_static_cast<DerivativeFormula>(IDManager::instance().getID(formulaIDRef_));
        }else{
             return this->formula_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DerivativeFormula>();
   }
}
boost::shared_ptr<TimeDimension> SensitivityDefinition::getTerm()
{
   if(!this->termIsNull_){
        if(termIDRef_ != ""){
             return boost::shared_static_cast<TimeDimension>(IDManager::instance().getID(termIDRef_));
        }else{
             return this->term_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeDimension>();
   }
}
boost::shared_ptr<PricingDataPointCoordinate> SensitivityDefinition::getCoordinate()
{
   if(!this->coordinateIsNull_){
        if(coordinateIDRef_ != ""){
             return boost::shared_static_cast<PricingDataPointCoordinate>(IDManager::instance().getID(coordinateIDRef_));
        }else{
             return this->coordinate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingDataPointCoordinate>();
   }
}
boost::shared_ptr<PricingDataPointCoordinateReference> SensitivityDefinition::getCoordinateReference()
{
   if(!this->coordinateReferenceIsNull_){
        if(coordinateReferenceIDRef_ != ""){
             return boost::shared_static_cast<PricingDataPointCoordinateReference>(IDManager::instance().getID(coordinateReferenceIDRef_));
        }else{
             return this->coordinateReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingDataPointCoordinateReference>();
   }
}
}

