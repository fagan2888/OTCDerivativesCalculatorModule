// PricingParameterDerivative.cpp 
#include "PricingParameterDerivative.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingParameterDerivative::PricingParameterDerivative(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* descriptionNode = xmlNode->FirstChildElement("description");

   if(descriptionNode){descriptionIsNull_ = false;}
   else{descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- descriptionNode , address : " << descriptionNode << std::endl;
   #endif
   if(descriptionNode)
   {
      if(descriptionNode->Attribute("href") || descriptionNode->Attribute("id"))
      {
          if(descriptionNode->Attribute("id"))
          {
             descriptionIDRef_ = descriptionNode->Attribute("id");
             description_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(descriptionNode));
             description_->setID(descriptionIDRef_);
             IDManager::instance().setID(descriptionIDRef_,description_);
          }
          else if(descriptionNode->Attribute("href")) { descriptionIDRef_ = descriptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { description_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(descriptionNode));}
   }

   //parameterReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parameterReferenceNode = xmlNode->FirstChildElement("parameterReference");

   if(parameterReferenceNode){parameterReferenceIsNull_ = false;}
   else{parameterReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parameterReferenceNode , address : " << parameterReferenceNode << std::endl;
   #endif
   if(parameterReferenceNode)
   {
      if(parameterReferenceNode->Attribute("href") || parameterReferenceNode->Attribute("id"))
      {
          if(parameterReferenceNode->Attribute("id"))
          {
             parameterReferenceIDRef_ = parameterReferenceNode->Attribute("id");
             parameterReference_ = boost::shared_ptr<AssetOrTermPointOrPricingStructureReference>(new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode));
             parameterReference_->setID(parameterReferenceIDRef_);
             IDManager::instance().setID(parameterReferenceIDRef_,parameterReference_);
          }
          else if(parameterReferenceNode->Attribute("href")) { parameterReferenceIDRef_ = parameterReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parameterReference_ = boost::shared_ptr<AssetOrTermPointOrPricingStructureReference>(new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode));}
   }

   //inputDateReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inputDateReferenceNode = xmlNode->FirstChildElement("inputDateReference");

   if(inputDateReferenceNode){inputDateReferenceIsNull_ = false;}
   else{inputDateReferenceIsNull_ = true;}

   if(inputDateReferenceNode)
   {
      for(inputDateReferenceNode; inputDateReferenceNode; inputDateReferenceNode = inputDateReferenceNode->NextSiblingElement("inputDateReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inputDateReferenceNode , address : " << inputDateReferenceNode << std::endl;
          #endif
          if(inputDateReferenceNode->Attribute("href") || inputDateReferenceNode->Attribute("id"))
          {
              if(inputDateReferenceNode->Attribute("id"))
              {
                  inputDateReferenceIDRef_ = inputDateReferenceNode->Attribute("id");
                  inputDateReference_.push_back(boost::shared_ptr<ValuationReference>(new ValuationReference(inputDateReferenceNode)));
                  inputDateReference_.back()->setID(inputDateReferenceIDRef_);
                  IDManager::instance().setID(inputDateReferenceIDRef_, inputDateReference_.back());
              }
              else if(inputDateReferenceNode->Attribute("href")) { inputDateReferenceIDRef_ = inputDateReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { inputDateReference_.push_back(boost::shared_ptr<ValuationReference>(new ValuationReference(inputDateReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inputDateReferenceNode , address : " << inputDateReferenceNode << std::endl;
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
boost::shared_ptr<XsdTypeString> PricingParameterDerivative::getDescription()
{
   if(!this->descriptionIsNull_){
        if(descriptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(descriptionIDRef_));
        }else{
             return this->description_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<AssetOrTermPointOrPricingStructureReference> PricingParameterDerivative::getParameterReference()
{
   if(!this->parameterReferenceIsNull_){
        if(parameterReferenceIDRef_ != ""){
             return boost::shared_static_cast<AssetOrTermPointOrPricingStructureReference>(IDManager::instance().getID(parameterReferenceIDRef_));
        }else{
             return this->parameterReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetOrTermPointOrPricingStructureReference>();
   }
}
std::vector<boost::shared_ptr<ValuationReference>> PricingParameterDerivative::getInputDateReference()
{
   if(!this->inputDateReferenceIsNull_){
        if(inputDateReferenceIDRef_ != ""){
             return this->inputDateReference_;
        }else{
             return this->inputDateReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ValuationReference>>();
   }
}
boost::shared_ptr<DerivativeCalculationProcedure> PricingParameterDerivative::getCalculationProcedure()
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

