// ReferencePair.cpp 
#include "ReferencePair.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferencePair::ReferencePair(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceEntityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceEntityNode = xmlNode->FirstChildElement("referenceEntity");

   if(referenceEntityNode){referenceEntityIsNull_ = false;}
   else{referenceEntityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceEntityNode , address : " << referenceEntityNode << std::endl;
   #endif
   if(referenceEntityNode)
   {
      if(referenceEntityNode->Attribute("href") || referenceEntityNode->Attribute("id"))
      {
          if(referenceEntityNode->Attribute("id"))
          {
             referenceEntityIDRef_ = referenceEntityNode->Attribute("id");
             referenceEntity_ = boost::shared_ptr<LegalEntity>(new LegalEntity(referenceEntityNode));
             referenceEntity_->setID(referenceEntityIDRef_);
             IDManager::instance().setID(referenceEntityIDRef_,referenceEntity_);
          }
          else if(referenceEntityNode->Attribute("href")) { referenceEntityIDRef_ = referenceEntityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceEntity_ = boost::shared_ptr<LegalEntity>(new LegalEntity(referenceEntityNode));}
   }

   //referenceObligationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceObligationNode = xmlNode->FirstChildElement("referenceObligation");

   if(referenceObligationNode){referenceObligationIsNull_ = false;}
   else{referenceObligationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceObligationNode , address : " << referenceObligationNode << std::endl;
   #endif
   if(referenceObligationNode)
   {
      if(referenceObligationNode->Attribute("href") || referenceObligationNode->Attribute("id"))
      {
          if(referenceObligationNode->Attribute("id"))
          {
             referenceObligationIDRef_ = referenceObligationNode->Attribute("id");
             referenceObligation_ = boost::shared_ptr<ReferenceObligation>(new ReferenceObligation(referenceObligationNode));
             referenceObligation_->setID(referenceObligationIDRef_);
             IDManager::instance().setID(referenceObligationIDRef_,referenceObligation_);
          }
          else if(referenceObligationNode->Attribute("href")) { referenceObligationIDRef_ = referenceObligationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceObligation_ = boost::shared_ptr<ReferenceObligation>(new ReferenceObligation(referenceObligationNode));}
   }

   //noReferenceObligationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* noReferenceObligationNode = xmlNode->FirstChildElement("noReferenceObligation");

   if(noReferenceObligationNode){noReferenceObligationIsNull_ = false;}
   else{noReferenceObligationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- noReferenceObligationNode , address : " << noReferenceObligationNode << std::endl;
   #endif
   if(noReferenceObligationNode)
   {
      if(noReferenceObligationNode->Attribute("href") || noReferenceObligationNode->Attribute("id"))
      {
          if(noReferenceObligationNode->Attribute("id"))
          {
             noReferenceObligationIDRef_ = noReferenceObligationNode->Attribute("id");
             noReferenceObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(noReferenceObligationNode));
             noReferenceObligation_->setID(noReferenceObligationIDRef_);
             IDManager::instance().setID(noReferenceObligationIDRef_,noReferenceObligation_);
          }
          else if(noReferenceObligationNode->Attribute("href")) { noReferenceObligationIDRef_ = noReferenceObligationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { noReferenceObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(noReferenceObligationNode));}
   }

   //entityTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entityTypeNode = xmlNode->FirstChildElement("entityType");

   if(entityTypeNode){entityTypeIsNull_ = false;}
   else{entityTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entityTypeNode , address : " << entityTypeNode << std::endl;
   #endif
   if(entityTypeNode)
   {
      if(entityTypeNode->Attribute("href") || entityTypeNode->Attribute("id"))
      {
          if(entityTypeNode->Attribute("id"))
          {
             entityTypeIDRef_ = entityTypeNode->Attribute("id");
             entityType_ = boost::shared_ptr<EntityType>(new EntityType(entityTypeNode));
             entityType_->setID(entityTypeIDRef_);
             IDManager::instance().setID(entityTypeIDRef_,entityType_);
          }
          else if(entityTypeNode->Attribute("href")) { entityTypeIDRef_ = entityTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { entityType_ = boost::shared_ptr<EntityType>(new EntityType(entityTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LegalEntity> ReferencePair::getReferenceEntity()
{
   if(!this->referenceEntityIsNull_){
        if(referenceEntityIDRef_ != ""){
             return boost::shared_static_cast<LegalEntity>(IDManager::instance().getID(referenceEntityIDRef_));
        }else{
             return this->referenceEntity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntity>();
   }
}
boost::shared_ptr<ReferenceObligation> ReferencePair::getReferenceObligation()
{
   if(!this->referenceObligationIsNull_){
        if(referenceObligationIDRef_ != ""){
             return boost::shared_static_cast<ReferenceObligation>(IDManager::instance().getID(referenceObligationIDRef_));
        }else{
             return this->referenceObligation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceObligation>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReferencePair::getNoReferenceObligation()
{
   if(!this->noReferenceObligationIsNull_){
        if(noReferenceObligationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(noReferenceObligationIDRef_));
        }else{
             return this->noReferenceObligation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<EntityType> ReferencePair::getEntityType()
{
   if(!this->entityTypeIsNull_){
        if(entityTypeIDRef_ != ""){
             return boost::shared_static_cast<EntityType>(IDManager::instance().getID(entityTypeIDRef_));
        }else{
             return this->entityType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EntityType>();
   }
}
}

