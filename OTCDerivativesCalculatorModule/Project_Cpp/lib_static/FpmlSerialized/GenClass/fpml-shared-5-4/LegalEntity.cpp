// LegalEntity.cpp 
#include "LegalEntity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

LegalEntity::LegalEntity(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //entityNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entityNameNode = xmlNode->FirstChildElement("entityName");

   if(entityNameNode){entityNameIsNull_ = false;}
   else{entityNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entityNameNode , address : " << entityNameNode << std::endl;
   #endif
   if(entityNameNode)
   {
      if(entityNameNode->Attribute("href") || entityNameNode->Attribute("id"))
      {
          if(entityNameNode->Attribute("id"))
          {
             entityNameIDRef_ = entityNameNode->Attribute("id");
             entityName_ = boost::shared_ptr<EntityName>(new EntityName(entityNameNode));
             entityName_->setID(entityNameIDRef_);
             IDManager::instance().setID(entityNameIDRef_,entityName_);
          }
          else if(entityNameNode->Attribute("href")) { entityNameIDRef_ = entityNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { entityName_ = boost::shared_ptr<EntityName>(new EntityName(entityNameNode));}
   }

   //entityIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entityIdNode = xmlNode->FirstChildElement("entityId");

   if(entityIdNode){entityIdIsNull_ = false;}
   else{entityIdIsNull_ = true;}

   if(entityIdNode)
   {
      for(entityIdNode; entityIdNode; entityIdNode = entityIdNode->NextSiblingElement("entityId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entityIdNode , address : " << entityIdNode << std::endl;
          #endif
          if(entityIdNode->Attribute("href") || entityIdNode->Attribute("id"))
          {
              if(entityIdNode->Attribute("id"))
              {
                  entityIdIDRef_ = entityIdNode->Attribute("id");
                  entityId_.push_back(boost::shared_ptr<EntityId>(new EntityId(entityIdNode)));
                  entityId_.back()->setID(entityIdIDRef_);
                  IDManager::instance().setID(entityIdIDRef_, entityId_.back());
              }
              else if(entityIdNode->Attribute("href")) { entityIdIDRef_ = entityIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { entityId_.push_back(boost::shared_ptr<EntityId>(new EntityId(entityIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entityIdNode , address : " << entityIdNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EntityName> LegalEntity::getEntityName()
{
   if(!this->entityNameIsNull_){
        if(entityNameIDRef_ != ""){
             return boost::shared_static_cast<EntityName>(IDManager::instance().getID(entityNameIDRef_));
        }else{
             return this->entityName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EntityName>();
   }
}
std::vector<boost::shared_ptr<EntityId>> LegalEntity::getEntityId()
{
   if(!this->entityIdIsNull_){
        if(entityIdIDRef_ != ""){
             return this->entityId_;
        }else{
             return this->entityId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EntityId>>();
   }
}
}

