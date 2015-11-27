// IndexAdjustmentEvents.cpp 
#include "IndexAdjustmentEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IndexAdjustmentEvents::IndexAdjustmentEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //indexModificationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexModificationNode = xmlNode->FirstChildElement("indexModification");

   if(indexModificationNode){indexModificationIsNull_ = false;}
   else{indexModificationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexModificationNode , address : " << indexModificationNode << std::endl;
   #endif
   if(indexModificationNode)
   {
      if(indexModificationNode->Attribute("href") || indexModificationNode->Attribute("id"))
      {
          if(indexModificationNode->Attribute("id"))
          {
             indexModificationIDRef_ = indexModificationNode->Attribute("id");
             indexModification_ = boost::shared_ptr<IndexEventConsequenceEnum>(new IndexEventConsequenceEnum(indexModificationNode));
             indexModification_->setID(indexModificationIDRef_);
             IDManager::instance().setID(indexModificationIDRef_,indexModification_);
          }
          else if(indexModificationNode->Attribute("href")) { indexModificationIDRef_ = indexModificationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexModification_ = boost::shared_ptr<IndexEventConsequenceEnum>(new IndexEventConsequenceEnum(indexModificationNode));}
   }

   //indexCancellationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexCancellationNode = xmlNode->FirstChildElement("indexCancellation");

   if(indexCancellationNode){indexCancellationIsNull_ = false;}
   else{indexCancellationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexCancellationNode , address : " << indexCancellationNode << std::endl;
   #endif
   if(indexCancellationNode)
   {
      if(indexCancellationNode->Attribute("href") || indexCancellationNode->Attribute("id"))
      {
          if(indexCancellationNode->Attribute("id"))
          {
             indexCancellationIDRef_ = indexCancellationNode->Attribute("id");
             indexCancellation_ = boost::shared_ptr<IndexEventConsequenceEnum>(new IndexEventConsequenceEnum(indexCancellationNode));
             indexCancellation_->setID(indexCancellationIDRef_);
             IDManager::instance().setID(indexCancellationIDRef_,indexCancellation_);
          }
          else if(indexCancellationNode->Attribute("href")) { indexCancellationIDRef_ = indexCancellationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexCancellation_ = boost::shared_ptr<IndexEventConsequenceEnum>(new IndexEventConsequenceEnum(indexCancellationNode));}
   }

   //indexDisruptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexDisruptionNode = xmlNode->FirstChildElement("indexDisruption");

   if(indexDisruptionNode){indexDisruptionIsNull_ = false;}
   else{indexDisruptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexDisruptionNode , address : " << indexDisruptionNode << std::endl;
   #endif
   if(indexDisruptionNode)
   {
      if(indexDisruptionNode->Attribute("href") || indexDisruptionNode->Attribute("id"))
      {
          if(indexDisruptionNode->Attribute("id"))
          {
             indexDisruptionIDRef_ = indexDisruptionNode->Attribute("id");
             indexDisruption_ = boost::shared_ptr<IndexEventConsequenceEnum>(new IndexEventConsequenceEnum(indexDisruptionNode));
             indexDisruption_->setID(indexDisruptionIDRef_);
             IDManager::instance().setID(indexDisruptionIDRef_,indexDisruption_);
          }
          else if(indexDisruptionNode->Attribute("href")) { indexDisruptionIDRef_ = indexDisruptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexDisruption_ = boost::shared_ptr<IndexEventConsequenceEnum>(new IndexEventConsequenceEnum(indexDisruptionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IndexEventConsequenceEnum> IndexAdjustmentEvents::getIndexModification()
{
   if(!this->indexModificationIsNull_){
        if(indexModificationIDRef_ != ""){
             return boost::shared_static_cast<IndexEventConsequenceEnum>(IDManager::instance().getID(indexModificationIDRef_));
        }else{
             return this->indexModification_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexEventConsequenceEnum>();
   }
}
boost::shared_ptr<IndexEventConsequenceEnum> IndexAdjustmentEvents::getIndexCancellation()
{
   if(!this->indexCancellationIsNull_){
        if(indexCancellationIDRef_ != ""){
             return boost::shared_static_cast<IndexEventConsequenceEnum>(IDManager::instance().getID(indexCancellationIDRef_));
        }else{
             return this->indexCancellation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexEventConsequenceEnum>();
   }
}
boost::shared_ptr<IndexEventConsequenceEnum> IndexAdjustmentEvents::getIndexDisruption()
{
   if(!this->indexDisruptionIsNull_){
        if(indexDisruptionIDRef_ != ""){
             return boost::shared_static_cast<IndexEventConsequenceEnum>(IDManager::instance().getID(indexDisruptionIDRef_));
        }else{
             return this->indexDisruption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexEventConsequenceEnum>();
   }
}
}

