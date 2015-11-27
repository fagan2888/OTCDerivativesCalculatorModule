// LegAmount.cpp 
#include "LegAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

LegAmount::LegAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
      if(currencyNode->Attribute("href") || currencyNode->Attribute("id"))
      {
          if(currencyNode->Attribute("id"))
          {
             currencyIDRef_ = currencyNode->Attribute("id");
             currency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(currencyNode));}
   }

   //determinationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determinationMethodNode = xmlNode->FirstChildElement("determinationMethod");

   if(determinationMethodNode){determinationMethodIsNull_ = false;}
   else{determinationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determinationMethodNode , address : " << determinationMethodNode << std::endl;
   #endif
   if(determinationMethodNode)
   {
      if(determinationMethodNode->Attribute("href") || determinationMethodNode->Attribute("id"))
      {
          if(determinationMethodNode->Attribute("id"))
          {
             determinationMethodIDRef_ = determinationMethodNode->Attribute("id");
             determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));
             determinationMethod_->setID(determinationMethodIDRef_);
             IDManager::instance().setID(determinationMethodIDRef_,determinationMethod_);
          }
          else if(determinationMethodNode->Attribute("href")) { determinationMethodIDRef_ = determinationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));}
   }

   //currencyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyReferenceNode = xmlNode->FirstChildElement("currencyReference");

   if(currencyReferenceNode){currencyReferenceIsNull_ = false;}
   else{currencyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyReferenceNode , address : " << currencyReferenceNode << std::endl;
   #endif
   if(currencyReferenceNode)
   {
      if(currencyReferenceNode->Attribute("href") || currencyReferenceNode->Attribute("id"))
      {
          if(currencyReferenceNode->Attribute("id"))
          {
             currencyReferenceIDRef_ = currencyReferenceNode->Attribute("id");
             currencyReference_ = boost::shared_ptr<IdentifiedCurrencyReference>(new IdentifiedCurrencyReference(currencyReferenceNode));
             currencyReference_->setID(currencyReferenceIDRef_);
             IDManager::instance().setID(currencyReferenceIDRef_,currencyReference_);
          }
          else if(currencyReferenceNode->Attribute("href")) { currencyReferenceIDRef_ = currencyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currencyReference_ = boost::shared_ptr<IdentifiedCurrencyReference>(new IdentifiedCurrencyReference(currencyReferenceNode));}
   }

   //referenceAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceAmountNode = xmlNode->FirstChildElement("referenceAmount");

   if(referenceAmountNode){referenceAmountIsNull_ = false;}
   else{referenceAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceAmountNode , address : " << referenceAmountNode << std::endl;
   #endif
   if(referenceAmountNode)
   {
      if(referenceAmountNode->Attribute("href") || referenceAmountNode->Attribute("id"))
      {
          if(referenceAmountNode->Attribute("id"))
          {
             referenceAmountIDRef_ = referenceAmountNode->Attribute("id");
             referenceAmount_ = boost::shared_ptr<ReferenceAmount>(new ReferenceAmount(referenceAmountNode));
             referenceAmount_->setID(referenceAmountIDRef_);
             IDManager::instance().setID(referenceAmountIDRef_,referenceAmount_);
          }
          else if(referenceAmountNode->Attribute("href")) { referenceAmountIDRef_ = referenceAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceAmount_ = boost::shared_ptr<ReferenceAmount>(new ReferenceAmount(referenceAmountNode));}
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
             formula_ = boost::shared_ptr<Formula>(new Formula(formulaNode));
             formula_->setID(formulaIDRef_);
             IDManager::instance().setID(formulaIDRef_,formula_);
          }
          else if(formulaNode->Attribute("href")) { formulaIDRef_ = formulaNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { formula_ = boost::shared_ptr<Formula>(new Formula(formulaNode));}
   }

   //encodedDescriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* encodedDescriptionNode = xmlNode->FirstChildElement("encodedDescription");

   if(encodedDescriptionNode){encodedDescriptionIsNull_ = false;}
   else{encodedDescriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- encodedDescriptionNode , address : " << encodedDescriptionNode << std::endl;
   #endif
   if(encodedDescriptionNode)
   {
      if(encodedDescriptionNode->Attribute("href") || encodedDescriptionNode->Attribute("id"))
      {
          if(encodedDescriptionNode->Attribute("id"))
          {
             encodedDescriptionIDRef_ = encodedDescriptionNode->Attribute("id");
             encodedDescription_ = boost::shared_ptr<XsdTypeBase64Binary>(new XsdTypeBase64Binary(encodedDescriptionNode));
             encodedDescription_->setID(encodedDescriptionIDRef_);
             IDManager::instance().setID(encodedDescriptionIDRef_,encodedDescription_);
          }
          else if(encodedDescriptionNode->Attribute("href")) { encodedDescriptionIDRef_ = encodedDescriptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { encodedDescription_ = boost::shared_ptr<XsdTypeBase64Binary>(new XsdTypeBase64Binary(encodedDescriptionNode));}
   }

   //calculationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationDatesNode = xmlNode->FirstChildElement("calculationDates");

   if(calculationDatesNode){calculationDatesIsNull_ = false;}
   else{calculationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationDatesNode , address : " << calculationDatesNode << std::endl;
   #endif
   if(calculationDatesNode)
   {
      if(calculationDatesNode->Attribute("href") || calculationDatesNode->Attribute("id"))
      {
          if(calculationDatesNode->Attribute("id"))
          {
             calculationDatesIDRef_ = calculationDatesNode->Attribute("id");
             calculationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(calculationDatesNode));
             calculationDates_->setID(calculationDatesIDRef_);
             IDManager::instance().setID(calculationDatesIDRef_,calculationDates_);
          }
          else if(calculationDatesNode->Attribute("href")) { calculationDatesIDRef_ = calculationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(calculationDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IdentifiedCurrency> LegAmount::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedCurrency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedCurrency>();
   }
}
boost::shared_ptr<DeterminationMethod> LegAmount::getDeterminationMethod()
{
   if(!this->determinationMethodIsNull_){
        if(determinationMethodIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(determinationMethodIDRef_));
        }else{
             return this->determinationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
boost::shared_ptr<IdentifiedCurrencyReference> LegAmount::getCurrencyReference()
{
   if(!this->currencyReferenceIsNull_){
        if(currencyReferenceIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedCurrencyReference>(IDManager::instance().getID(currencyReferenceIDRef_));
        }else{
             return this->currencyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedCurrencyReference>();
   }
}
boost::shared_ptr<ReferenceAmount> LegAmount::getReferenceAmount()
{
   if(!this->referenceAmountIsNull_){
        if(referenceAmountIDRef_ != ""){
             return boost::shared_static_cast<ReferenceAmount>(IDManager::instance().getID(referenceAmountIDRef_));
        }else{
             return this->referenceAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceAmount>();
   }
}
boost::shared_ptr<Formula> LegAmount::getFormula()
{
   if(!this->formulaIsNull_){
        if(formulaIDRef_ != ""){
             return boost::shared_static_cast<Formula>(IDManager::instance().getID(formulaIDRef_));
        }else{
             return this->formula_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Formula>();
   }
}
boost::shared_ptr<XsdTypeBase64Binary> LegAmount::getEncodedDescription()
{
   if(!this->encodedDescriptionIsNull_){
        if(encodedDescriptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBase64Binary>(IDManager::instance().getID(encodedDescriptionIDRef_));
        }else{
             return this->encodedDescription_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBase64Binary>();
   }
}
boost::shared_ptr<AdjustableRelativeOrPeriodicDates> LegAmount::getCalculationDates()
{
   if(!this->calculationDatesIsNull_){
        if(calculationDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableRelativeOrPeriodicDates>(IDManager::instance().getID(calculationDatesIDRef_));
        }else{
             return this->calculationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableRelativeOrPeriodicDates>();
   }
}
}

