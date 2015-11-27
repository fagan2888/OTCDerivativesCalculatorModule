// Formula.cpp 
#include "Formula.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Formula::Formula(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //formulaDescriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* formulaDescriptionNode = xmlNode->FirstChildElement("formulaDescription");

   if(formulaDescriptionNode){formulaDescriptionIsNull_ = false;}
   else{formulaDescriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- formulaDescriptionNode , address : " << formulaDescriptionNode << std::endl;
   #endif
   if(formulaDescriptionNode)
   {
      if(formulaDescriptionNode->Attribute("href") || formulaDescriptionNode->Attribute("id"))
      {
          if(formulaDescriptionNode->Attribute("id"))
          {
             formulaDescriptionIDRef_ = formulaDescriptionNode->Attribute("id");
             formulaDescription_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(formulaDescriptionNode));
             formulaDescription_->setID(formulaDescriptionIDRef_);
             IDManager::instance().setID(formulaDescriptionIDRef_,formulaDescription_);
          }
          else if(formulaDescriptionNode->Attribute("href")) { formulaDescriptionIDRef_ = formulaDescriptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { formulaDescription_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(formulaDescriptionNode));}
   }

   //mathNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mathNode = xmlNode->FirstChildElement("math");

   if(mathNode){mathIsNull_ = false;}
   else{mathIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mathNode , address : " << mathNode << std::endl;
   #endif
   if(mathNode)
   {
      if(mathNode->Attribute("href") || mathNode->Attribute("id"))
      {
          if(mathNode->Attribute("id"))
          {
             mathIDRef_ = mathNode->Attribute("id");
             math_ = boost::shared_ptr<Math>(new Math(mathNode));
             math_->setID(mathIDRef_);
             IDManager::instance().setID(mathIDRef_,math_);
          }
          else if(mathNode->Attribute("href")) { mathIDRef_ = mathNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { math_ = boost::shared_ptr<Math>(new Math(mathNode));}
   }

   //formulaComponentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* formulaComponentNode = xmlNode->FirstChildElement("formulaComponent");

   if(formulaComponentNode){formulaComponentIsNull_ = false;}
   else{formulaComponentIsNull_ = true;}

   if(formulaComponentNode)
   {
      for(formulaComponentNode; formulaComponentNode; formulaComponentNode = formulaComponentNode->NextSiblingElement("formulaComponent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- formulaComponentNode , address : " << formulaComponentNode << std::endl;
          #endif
          if(formulaComponentNode->Attribute("href") || formulaComponentNode->Attribute("id"))
          {
              if(formulaComponentNode->Attribute("id"))
              {
                  formulaComponentIDRef_ = formulaComponentNode->Attribute("id");
                  formulaComponent_.push_back(boost::shared_ptr<FormulaComponent>(new FormulaComponent(formulaComponentNode)));
                  formulaComponent_.back()->setID(formulaComponentIDRef_);
                  IDManager::instance().setID(formulaComponentIDRef_, formulaComponent_.back());
              }
              else if(formulaComponentNode->Attribute("href")) { formulaComponentIDRef_ = formulaComponentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { formulaComponent_.push_back(boost::shared_ptr<FormulaComponent>(new FormulaComponent(formulaComponentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- formulaComponentNode , address : " << formulaComponentNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> Formula::getFormulaDescription()
{
   if(!this->formulaDescriptionIsNull_){
        if(formulaDescriptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(formulaDescriptionIDRef_));
        }else{
             return this->formulaDescription_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<Math> Formula::getMath()
{
   if(!this->mathIsNull_){
        if(mathIDRef_ != ""){
             return boost::shared_static_cast<Math>(IDManager::instance().getID(mathIDRef_));
        }else{
             return this->math_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Math>();
   }
}
std::vector<boost::shared_ptr<FormulaComponent>> Formula::getFormulaComponent()
{
   if(!this->formulaComponentIsNull_){
        if(formulaComponentIDRef_ != ""){
             return this->formulaComponent_;
        }else{
             return this->formulaComponent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FormulaComponent>>();
   }
}
}

