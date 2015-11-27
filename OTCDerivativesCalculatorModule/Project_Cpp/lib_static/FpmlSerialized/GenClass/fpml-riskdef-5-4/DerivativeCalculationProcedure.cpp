// DerivativeCalculationProcedure.cpp 
#include "DerivativeCalculationProcedure.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DerivativeCalculationProcedure::DerivativeCalculationProcedure(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //methodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* methodNode = xmlNode->FirstChildElement("method");

   if(methodNode){methodIsNull_ = false;}
   else{methodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- methodNode , address : " << methodNode << std::endl;
   #endif
   if(methodNode)
   {
      if(methodNode->Attribute("href") || methodNode->Attribute("id"))
      {
          if(methodNode->Attribute("id"))
          {
             methodIDRef_ = methodNode->Attribute("id");
             method_ = boost::shared_ptr<DerivativeCalculationMethod>(new DerivativeCalculationMethod(methodNode));
             method_->setID(methodIDRef_);
             IDManager::instance().setID(methodIDRef_,method_);
          }
          else if(methodNode->Attribute("href")) { methodIDRef_ = methodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { method_ = boost::shared_ptr<DerivativeCalculationMethod>(new DerivativeCalculationMethod(methodNode));}
   }

   //perturbationAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* perturbationAmountNode = xmlNode->FirstChildElement("perturbationAmount");

   if(perturbationAmountNode){perturbationAmountIsNull_ = false;}
   else{perturbationAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- perturbationAmountNode , address : " << perturbationAmountNode << std::endl;
   #endif
   if(perturbationAmountNode)
   {
      if(perturbationAmountNode->Attribute("href") || perturbationAmountNode->Attribute("id"))
      {
          if(perturbationAmountNode->Attribute("id"))
          {
             perturbationAmountIDRef_ = perturbationAmountNode->Attribute("id");
             perturbationAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(perturbationAmountNode));
             perturbationAmount_->setID(perturbationAmountIDRef_);
             IDManager::instance().setID(perturbationAmountIDRef_,perturbationAmount_);
          }
          else if(perturbationAmountNode->Attribute("href")) { perturbationAmountIDRef_ = perturbationAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { perturbationAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(perturbationAmountNode));}
   }

   //averagedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagedNode = xmlNode->FirstChildElement("averaged");

   if(averagedNode){averagedIsNull_ = false;}
   else{averagedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagedNode , address : " << averagedNode << std::endl;
   #endif
   if(averagedNode)
   {
      if(averagedNode->Attribute("href") || averagedNode->Attribute("id"))
      {
          if(averagedNode->Attribute("id"))
          {
             averagedIDRef_ = averagedNode->Attribute("id");
             averaged_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(averagedNode));
             averaged_->setID(averagedIDRef_);
             IDManager::instance().setID(averagedIDRef_,averaged_);
          }
          else if(averagedNode->Attribute("href")) { averagedIDRef_ = averagedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averaged_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(averagedNode));}
   }

   //perturbationTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* perturbationTypeNode = xmlNode->FirstChildElement("perturbationType");

   if(perturbationTypeNode){perturbationTypeIsNull_ = false;}
   else{perturbationTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- perturbationTypeNode , address : " << perturbationTypeNode << std::endl;
   #endif
   if(perturbationTypeNode)
   {
      if(perturbationTypeNode->Attribute("href") || perturbationTypeNode->Attribute("id"))
      {
          if(perturbationTypeNode->Attribute("id"))
          {
             perturbationTypeIDRef_ = perturbationTypeNode->Attribute("id");
             perturbationType_ = boost::shared_ptr<PerturbationType>(new PerturbationType(perturbationTypeNode));
             perturbationType_->setID(perturbationTypeIDRef_);
             IDManager::instance().setID(perturbationTypeIDRef_,perturbationType_);
          }
          else if(perturbationTypeNode->Attribute("href")) { perturbationTypeIDRef_ = perturbationTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { perturbationType_ = boost::shared_ptr<PerturbationType>(new PerturbationType(perturbationTypeNode));}
   }

   //derivativeFormulaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* derivativeFormulaNode = xmlNode->FirstChildElement("derivativeFormula");

   if(derivativeFormulaNode){derivativeFormulaIsNull_ = false;}
   else{derivativeFormulaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- derivativeFormulaNode , address : " << derivativeFormulaNode << std::endl;
   #endif
   if(derivativeFormulaNode)
   {
      if(derivativeFormulaNode->Attribute("href") || derivativeFormulaNode->Attribute("id"))
      {
          if(derivativeFormulaNode->Attribute("id"))
          {
             derivativeFormulaIDRef_ = derivativeFormulaNode->Attribute("id");
             derivativeFormula_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(derivativeFormulaNode));
             derivativeFormula_->setID(derivativeFormulaIDRef_);
             IDManager::instance().setID(derivativeFormulaIDRef_,derivativeFormula_);
          }
          else if(derivativeFormulaNode->Attribute("href")) { derivativeFormulaIDRef_ = derivativeFormulaNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { derivativeFormula_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(derivativeFormulaNode));}
   }

   //replacementMarketInputNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* replacementMarketInputNode = xmlNode->FirstChildElement("replacementMarketInput");

   if(replacementMarketInputNode){replacementMarketInputIsNull_ = false;}
   else{replacementMarketInputIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- replacementMarketInputNode , address : " << replacementMarketInputNode << std::endl;
   #endif
   if(replacementMarketInputNode)
   {
      if(replacementMarketInputNode->Attribute("href") || replacementMarketInputNode->Attribute("id"))
      {
          if(replacementMarketInputNode->Attribute("id"))
          {
             replacementMarketInputIDRef_ = replacementMarketInputNode->Attribute("id");
             replacementMarketInput_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(replacementMarketInputNode));
             replacementMarketInput_->setID(replacementMarketInputIDRef_);
             IDManager::instance().setID(replacementMarketInputIDRef_,replacementMarketInput_);
          }
          else if(replacementMarketInputNode->Attribute("href")) { replacementMarketInputIDRef_ = replacementMarketInputNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { replacementMarketInput_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(replacementMarketInputNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DerivativeCalculationMethod> DerivativeCalculationProcedure::getMethod()
{
   if(!this->methodIsNull_){
        if(methodIDRef_ != ""){
             return boost::shared_static_cast<DerivativeCalculationMethod>(IDManager::instance().getID(methodIDRef_));
        }else{
             return this->method_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DerivativeCalculationMethod>();
   }
}
boost::shared_ptr<XsdTypeDecimal> DerivativeCalculationProcedure::getPerturbationAmount()
{
   if(!this->perturbationAmountIsNull_){
        if(perturbationAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(perturbationAmountIDRef_));
        }else{
             return this->perturbationAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DerivativeCalculationProcedure::getAveraged()
{
   if(!this->averagedIsNull_){
        if(averagedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(averagedIDRef_));
        }else{
             return this->averaged_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<PerturbationType> DerivativeCalculationProcedure::getPerturbationType()
{
   if(!this->perturbationTypeIsNull_){
        if(perturbationTypeIDRef_ != ""){
             return boost::shared_static_cast<PerturbationType>(IDManager::instance().getID(perturbationTypeIDRef_));
        }else{
             return this->perturbationType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PerturbationType>();
   }
}
boost::shared_ptr<XsdTypeString> DerivativeCalculationProcedure::getDerivativeFormula()
{
   if(!this->derivativeFormulaIsNull_){
        if(derivativeFormulaIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(derivativeFormulaIDRef_));
        }else{
             return this->derivativeFormula_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<PricingStructureReference> DerivativeCalculationProcedure::getReplacementMarketInput()
{
   if(!this->replacementMarketInputIsNull_){
        if(replacementMarketInputIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(replacementMarketInputIDRef_));
        }else{
             return this->replacementMarketInput_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
}

