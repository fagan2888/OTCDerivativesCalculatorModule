// PartyRelationship.cpp 
#include "PartyRelationship.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PartyRelationship::PartyRelationship(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyReferenceNode = xmlNode->FirstChildElement("partyReference");

   if(partyReferenceNode){partyReferenceIsNull_ = false;}
   else{partyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyReferenceNode , address : " << partyReferenceNode << std::endl;
   #endif
   if(partyReferenceNode)
   {
      if(partyReferenceNode->Attribute("href") || partyReferenceNode->Attribute("id"))
      {
          if(partyReferenceNode->Attribute("id"))
          {
             partyReferenceIDRef_ = partyReferenceNode->Attribute("id");
             partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));
             partyReference_->setID(partyReferenceIDRef_);
             IDManager::instance().setID(partyReferenceIDRef_,partyReference_);
          }
          else if(partyReferenceNode->Attribute("href")) { partyReferenceIDRef_ = partyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));}
   }

   //accountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountReferenceNode = xmlNode->FirstChildElement("accountReference");

   if(accountReferenceNode){accountReferenceIsNull_ = false;}
   else{accountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountReferenceNode , address : " << accountReferenceNode << std::endl;
   #endif
   if(accountReferenceNode)
   {
      if(accountReferenceNode->Attribute("href") || accountReferenceNode->Attribute("id"))
      {
          if(accountReferenceNode->Attribute("id"))
          {
             accountReferenceIDRef_ = accountReferenceNode->Attribute("id");
             accountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(accountReferenceNode));
             accountReference_->setID(accountReferenceIDRef_);
             IDManager::instance().setID(accountReferenceIDRef_,accountReference_);
          }
          else if(accountReferenceNode->Attribute("href")) { accountReferenceIDRef_ = accountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(accountReferenceNode));}
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
             role_ = boost::shared_ptr<PartyRole>(new PartyRole(roleNode));
             role_->setID(roleIDRef_);
             IDManager::instance().setID(roleIDRef_,role_);
          }
          else if(roleNode->Attribute("href")) { roleIDRef_ = roleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { role_ = boost::shared_ptr<PartyRole>(new PartyRole(roleNode));}
   }

   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
      if(typeNode->Attribute("href") || typeNode->Attribute("id"))
      {
          if(typeNode->Attribute("id"))
          {
             typeIDRef_ = typeNode->Attribute("id");
             type_ = boost::shared_ptr<PartyRoleType>(new PartyRoleType(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<PartyRoleType>(new PartyRoleType(typeNode));}
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));}
   }

   //terminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* terminationDateNode = xmlNode->FirstChildElement("terminationDate");

   if(terminationDateNode){terminationDateIsNull_ = false;}
   else{terminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- terminationDateNode , address : " << terminationDateNode << std::endl;
   #endif
   if(terminationDateNode)
   {
      if(terminationDateNode->Attribute("href") || terminationDateNode->Attribute("id"))
      {
          if(terminationDateNode->Attribute("id"))
          {
             terminationDateIDRef_ = terminationDateNode->Attribute("id");
             terminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(terminationDateNode));
             terminationDate_->setID(terminationDateIDRef_);
             IDManager::instance().setID(terminationDateIDRef_,terminationDate_);
          }
          else if(terminationDateNode->Attribute("href")) { terminationDateIDRef_ = terminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { terminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(terminationDateNode));}
   }

   //documentationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* documentationNode = xmlNode->FirstChildElement("documentation");

   if(documentationNode){documentationIsNull_ = false;}
   else{documentationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- documentationNode , address : " << documentationNode << std::endl;
   #endif
   if(documentationNode)
   {
      if(documentationNode->Attribute("href") || documentationNode->Attribute("id"))
      {
          if(documentationNode->Attribute("id"))
          {
             documentationIDRef_ = documentationNode->Attribute("id");
             documentation_ = boost::shared_ptr<PartyRelationshipDocumentation>(new PartyRelationshipDocumentation(documentationNode));
             documentation_->setID(documentationIDRef_);
             IDManager::instance().setID(documentationIDRef_,documentation_);
          }
          else if(documentationNode->Attribute("href")) { documentationIDRef_ = documentationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { documentation_ = boost::shared_ptr<PartyRelationshipDocumentation>(new PartyRelationshipDocumentation(documentationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> PartyRelationship::getPartyReference()
{
   if(!this->partyReferenceIsNull_){
        if(partyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(partyReferenceIDRef_));
        }else{
             return this->partyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> PartyRelationship::getAccountReference()
{
   if(!this->accountReferenceIsNull_){
        if(accountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(accountReferenceIDRef_));
        }else{
             return this->accountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyRole> PartyRelationship::getRole()
{
   if(!this->roleIsNull_){
        if(roleIDRef_ != ""){
             return boost::shared_static_cast<PartyRole>(IDManager::instance().getID(roleIDRef_));
        }else{
             return this->role_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyRole>();
   }
}
boost::shared_ptr<PartyRoleType> PartyRelationship::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<PartyRoleType>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyRoleType>();
   }
}
boost::shared_ptr<XsdTypeDate> PartyRelationship::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> PartyRelationship::getTerminationDate()
{
   if(!this->terminationDateIsNull_){
        if(terminationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(terminationDateIDRef_));
        }else{
             return this->terminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<PartyRelationshipDocumentation> PartyRelationship::getDocumentation()
{
   if(!this->documentationIsNull_){
        if(documentationIDRef_ != ""){
             return boost::shared_static_cast<PartyRelationshipDocumentation>(IDManager::instance().getID(documentationIDRef_));
        }else{
             return this->documentation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyRelationshipDocumentation>();
   }
}
}

