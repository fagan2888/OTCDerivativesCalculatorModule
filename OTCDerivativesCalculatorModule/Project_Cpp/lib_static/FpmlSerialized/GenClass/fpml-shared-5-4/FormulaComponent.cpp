// FormulaComponent.cpp 
#include "FormulaComponent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FormulaComponent::FormulaComponent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //componentDescriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* componentDescriptionNode = xmlNode->FirstChildElement("componentDescription");

   if(componentDescriptionNode){componentDescriptionIsNull_ = false;}
   else{componentDescriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- componentDescriptionNode , address : " << componentDescriptionNode << std::endl;
   #endif
   if(componentDescriptionNode)
   {
      if(componentDescriptionNode->Attribute("href") || componentDescriptionNode->Attribute("id"))
      {
          if(componentDescriptionNode->Attribute("id"))
          {
             componentDescriptionIDRef_ = componentDescriptionNode->Attribute("id");
             componentDescription_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(componentDescriptionNode));
             componentDescription_->setID(componentDescriptionIDRef_);
             IDManager::instance().setID(componentDescriptionIDRef_,componentDescription_);
          }
          else if(componentDescriptionNode->Attribute("href")) { componentDescriptionIDRef_ = componentDescriptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { componentDescription_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(componentDescriptionNode));}
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> FormulaComponent::getComponentDescription()
{
   if(!this->componentDescriptionIsNull_){
        if(componentDescriptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(componentDescriptionIDRef_));
        }else{
             return this->componentDescription_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<Formula> FormulaComponent::getFormula()
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
}

