// ServiceAdvisory.cpp 
#include "ServiceAdvisory.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ServiceAdvisory::ServiceAdvisory(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //categoryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* categoryNode = xmlNode->FirstChildElement("category");

   if(categoryNode){categoryIsNull_ = false;}
   else{categoryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- categoryNode , address : " << categoryNode << std::endl;
   #endif
   if(categoryNode)
   {
      if(categoryNode->Attribute("href") || categoryNode->Attribute("id"))
      {
          if(categoryNode->Attribute("id"))
          {
             categoryIDRef_ = categoryNode->Attribute("id");
             category_ = boost::shared_ptr<ServiceAdvisoryCategory>(new ServiceAdvisoryCategory(categoryNode));
             category_->setID(categoryIDRef_);
             IDManager::instance().setID(categoryIDRef_,category_);
          }
          else if(categoryNode->Attribute("href")) { categoryIDRef_ = categoryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { category_ = boost::shared_ptr<ServiceAdvisoryCategory>(new ServiceAdvisoryCategory(categoryNode));}
   }

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

   //effectiveFromNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveFromNode = xmlNode->FirstChildElement("effectiveFrom");

   if(effectiveFromNode){effectiveFromIsNull_ = false;}
   else{effectiveFromIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveFromNode , address : " << effectiveFromNode << std::endl;
   #endif
   if(effectiveFromNode)
   {
      if(effectiveFromNode->Attribute("href") || effectiveFromNode->Attribute("id"))
      {
          if(effectiveFromNode->Attribute("id"))
          {
             effectiveFromIDRef_ = effectiveFromNode->Attribute("id");
             effectiveFrom_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(effectiveFromNode));
             effectiveFrom_->setID(effectiveFromIDRef_);
             IDManager::instance().setID(effectiveFromIDRef_,effectiveFrom_);
          }
          else if(effectiveFromNode->Attribute("href")) { effectiveFromIDRef_ = effectiveFromNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveFrom_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(effectiveFromNode));}
   }

   //effectiveToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveToNode = xmlNode->FirstChildElement("effectiveTo");

   if(effectiveToNode){effectiveToIsNull_ = false;}
   else{effectiveToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveToNode , address : " << effectiveToNode << std::endl;
   #endif
   if(effectiveToNode)
   {
      if(effectiveToNode->Attribute("href") || effectiveToNode->Attribute("id"))
      {
          if(effectiveToNode->Attribute("id"))
          {
             effectiveToIDRef_ = effectiveToNode->Attribute("id");
             effectiveTo_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(effectiveToNode));
             effectiveTo_->setID(effectiveToIDRef_);
             IDManager::instance().setID(effectiveToIDRef_,effectiveTo_);
          }
          else if(effectiveToNode->Attribute("href")) { effectiveToIDRef_ = effectiveToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveTo_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(effectiveToNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ServiceAdvisoryCategory> ServiceAdvisory::getCategory()
{
   if(!this->categoryIsNull_){
        if(categoryIDRef_ != ""){
             return boost::shared_static_cast<ServiceAdvisoryCategory>(IDManager::instance().getID(categoryIDRef_));
        }else{
             return this->category_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ServiceAdvisoryCategory>();
   }
}
boost::shared_ptr<XsdTypeString> ServiceAdvisory::getDescription()
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
boost::shared_ptr<XsdTypeDateTime> ServiceAdvisory::getEffectiveFrom()
{
   if(!this->effectiveFromIsNull_){
        if(effectiveFromIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(effectiveFromIDRef_));
        }else{
             return this->effectiveFrom_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> ServiceAdvisory::getEffectiveTo()
{
   if(!this->effectiveToIsNull_){
        if(effectiveToIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(effectiveToIDRef_));
        }else{
             return this->effectiveTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
}

