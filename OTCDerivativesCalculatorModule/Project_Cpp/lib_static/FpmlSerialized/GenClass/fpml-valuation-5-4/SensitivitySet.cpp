// SensitivitySet.cpp 
#include "SensitivitySet.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SensitivitySet::SensitivitySet(TiXmlNode* xmlNode)
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

   //definitionReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* definitionReferenceNode = xmlNode->FirstChildElement("definitionReference");

   if(definitionReferenceNode){definitionReferenceIsNull_ = false;}
   else{definitionReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- definitionReferenceNode , address : " << definitionReferenceNode << std::endl;
   #endif
   if(definitionReferenceNode)
   {
      if(definitionReferenceNode->Attribute("href") || definitionReferenceNode->Attribute("id"))
      {
          if(definitionReferenceNode->Attribute("id"))
          {
             definitionReferenceIDRef_ = definitionReferenceNode->Attribute("id");
             definitionReference_ = boost::shared_ptr<SensitivitySetDefinitionReference>(new SensitivitySetDefinitionReference(definitionReferenceNode));
             definitionReference_->setID(definitionReferenceIDRef_);
             IDManager::instance().setID(definitionReferenceIDRef_,definitionReference_);
          }
          else if(definitionReferenceNode->Attribute("href")) { definitionReferenceIDRef_ = definitionReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { definitionReference_ = boost::shared_ptr<SensitivitySetDefinitionReference>(new SensitivitySetDefinitionReference(definitionReferenceNode));}
   }

   //sensitivityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sensitivityNode = xmlNode->FirstChildElement("sensitivity");

   if(sensitivityNode){sensitivityIsNull_ = false;}
   else{sensitivityIsNull_ = true;}

   if(sensitivityNode)
   {
      for(sensitivityNode; sensitivityNode; sensitivityNode = sensitivityNode->NextSiblingElement("sensitivity")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sensitivityNode , address : " << sensitivityNode << std::endl;
          #endif
          if(sensitivityNode->Attribute("href") || sensitivityNode->Attribute("id"))
          {
              if(sensitivityNode->Attribute("id"))
              {
                  sensitivityIDRef_ = sensitivityNode->Attribute("id");
                  sensitivity_.push_back(boost::shared_ptr<Sensitivity>(new Sensitivity(sensitivityNode)));
                  sensitivity_.back()->setID(sensitivityIDRef_);
                  IDManager::instance().setID(sensitivityIDRef_, sensitivity_.back());
              }
              else if(sensitivityNode->Attribute("href")) { sensitivityIDRef_ = sensitivityNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { sensitivity_.push_back(boost::shared_ptr<Sensitivity>(new Sensitivity(sensitivityNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sensitivityNode , address : " << sensitivityNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> SensitivitySet::getName()
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
boost::shared_ptr<SensitivitySetDefinitionReference> SensitivitySet::getDefinitionReference()
{
   if(!this->definitionReferenceIsNull_){
        if(definitionReferenceIDRef_ != ""){
             return boost::shared_static_cast<SensitivitySetDefinitionReference>(IDManager::instance().getID(definitionReferenceIDRef_));
        }else{
             return this->definitionReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SensitivitySetDefinitionReference>();
   }
}
std::vector<boost::shared_ptr<Sensitivity>> SensitivitySet::getSensitivity()
{
   if(!this->sensitivityIsNull_){
        if(sensitivityIDRef_ != ""){
             return this->sensitivity_;
        }else{
             return this->sensitivity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Sensitivity>>();
   }
}
}

