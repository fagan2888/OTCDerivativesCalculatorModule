// RelatedPerson.cpp 
#include "RelatedPerson.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RelatedPerson::RelatedPerson(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //personReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* personReferenceNode = xmlNode->FirstChildElement("personReference");

   if(personReferenceNode){personReferenceIsNull_ = false;}
   else{personReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- personReferenceNode , address : " << personReferenceNode << std::endl;
   #endif
   if(personReferenceNode)
   {
      if(personReferenceNode->Attribute("href") || personReferenceNode->Attribute("id"))
      {
          if(personReferenceNode->Attribute("id"))
          {
             personReferenceIDRef_ = personReferenceNode->Attribute("id");
             personReference_ = boost::shared_ptr<PersonReference>(new PersonReference(personReferenceNode));
             personReference_->setID(personReferenceIDRef_);
             IDManager::instance().setID(personReferenceIDRef_,personReference_);
          }
          else if(personReferenceNode->Attribute("href")) { personReferenceIDRef_ = personReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { personReference_ = boost::shared_ptr<PersonReference>(new PersonReference(personReferenceNode));}
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
             role_ = boost::shared_ptr<PersonRole>(new PersonRole(roleNode));
             role_->setID(roleIDRef_);
             IDManager::instance().setID(roleIDRef_,role_);
          }
          else if(roleNode->Attribute("href")) { roleIDRef_ = roleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { role_ = boost::shared_ptr<PersonRole>(new PersonRole(roleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PersonReference> RelatedPerson::getPersonReference()
{
   if(!this->personReferenceIsNull_){
        if(personReferenceIDRef_ != ""){
             return boost::shared_static_cast<PersonReference>(IDManager::instance().getID(personReferenceIDRef_));
        }else{
             return this->personReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PersonReference>();
   }
}
boost::shared_ptr<PersonRole> RelatedPerson::getRole()
{
   if(!this->roleIsNull_){
        if(roleIDRef_ != ""){
             return boost::shared_static_cast<PersonRole>(IDManager::instance().getID(roleIDRef_));
        }else{
             return this->role_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PersonRole>();
   }
}
}

