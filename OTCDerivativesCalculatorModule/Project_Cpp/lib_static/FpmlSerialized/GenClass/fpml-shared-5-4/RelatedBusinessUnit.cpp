// RelatedBusinessUnit.cpp 
#include "RelatedBusinessUnit.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RelatedBusinessUnit::RelatedBusinessUnit(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessUnitReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessUnitReferenceNode = xmlNode->FirstChildElement("businessUnitReference");

   if(businessUnitReferenceNode){businessUnitReferenceIsNull_ = false;}
   else{businessUnitReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessUnitReferenceNode , address : " << businessUnitReferenceNode << std::endl;
   #endif
   if(businessUnitReferenceNode)
   {
      if(businessUnitReferenceNode->Attribute("href") || businessUnitReferenceNode->Attribute("id"))
      {
          if(businessUnitReferenceNode->Attribute("id"))
          {
             businessUnitReferenceIDRef_ = businessUnitReferenceNode->Attribute("id");
             businessUnitReference_ = boost::shared_ptr<BusinessUnitReference>(new BusinessUnitReference(businessUnitReferenceNode));
             businessUnitReference_->setID(businessUnitReferenceIDRef_);
             IDManager::instance().setID(businessUnitReferenceIDRef_,businessUnitReference_);
          }
          else if(businessUnitReferenceNode->Attribute("href")) { businessUnitReferenceIDRef_ = businessUnitReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessUnitReference_ = boost::shared_ptr<BusinessUnitReference>(new BusinessUnitReference(businessUnitReferenceNode));}
   }

   //roleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* roleNode = xmlNode->FirstChildElement("role");

   if(roleNode){roleIsNull_ = false;}
   else{roleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- roleNode , address : " << roleNode << std::endl;
   #endif
   if(roleNode)
   {
      if(roleNode->Attribute("href") || roleNode->Attribute("id"))
      {
          if(roleNode->Attribute("id"))
          {
             roleIDRef_ = roleNode->Attribute("id");
             role_ = boost::shared_ptr<BusinessUnitRole>(new BusinessUnitRole(roleNode));
             role_->setID(roleIDRef_);
             IDManager::instance().setID(roleIDRef_,role_);
          }
          else if(roleNode->Attribute("href")) { roleIDRef_ = roleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { role_ = boost::shared_ptr<BusinessUnitRole>(new BusinessUnitRole(roleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BusinessUnitReference> RelatedBusinessUnit::getBusinessUnitReference()
{
   if(!this->businessUnitReferenceIsNull_){
        if(businessUnitReferenceIDRef_ != ""){
             return boost::shared_static_cast<BusinessUnitReference>(IDManager::instance().getID(businessUnitReferenceIDRef_));
        }else{
             return this->businessUnitReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessUnitReference>();
   }
}
boost::shared_ptr<BusinessUnitRole> RelatedBusinessUnit::getRole()
{
   if(!this->roleIsNull_){
        if(roleIDRef_ != ""){
             return boost::shared_static_cast<BusinessUnitRole>(IDManager::instance().getID(roleIDRef_));
        }else{
             return this->role_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessUnitRole>();
   }
}
}

