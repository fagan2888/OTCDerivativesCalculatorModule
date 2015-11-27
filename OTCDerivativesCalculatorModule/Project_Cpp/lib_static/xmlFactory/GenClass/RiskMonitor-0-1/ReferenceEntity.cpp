// ReferenceEntity.cpp 
#include "ReferenceEntity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceEntity::ReferenceEntity(TiXmlNode* xmlNode)
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
       entityName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(entityNameNode));
   }

   //entityIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entityIdNode = xmlNode->FirstChildElement("entityId");

   if(entityIdNode){entityIdIsNull_ = false;}
   else{entityIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entityIdNode , address : " << entityIdNode << std::endl;
   #endif
   if(entityIdNode)
   {
       entityId_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(entityIdNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ReferenceEntity::getEntityName()
{
   if(!this->entityNameIsNull_){
        return this->entityName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> ReferenceEntity::getEntityId()
{
   if(!this->entityIdIsNull_){
        return this->entityId_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

