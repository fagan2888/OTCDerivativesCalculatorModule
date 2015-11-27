// IndexReferenceInformation.cpp 
#include "IndexReferenceInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IndexReferenceInformation::IndexReferenceInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //indexNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexNameNode = xmlNode->FirstChildElement("indexName");

   if(indexNameNode){indexNameIsNull_ = false;}
   else{indexNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexNameNode , address : " << indexNameNode << std::endl;
   #endif
   if(indexNameNode)
   {
      if(indexNameNode->Attribute("href") || indexNameNode->Attribute("id"))
      {
          if(indexNameNode->Attribute("id"))
          {
             indexNameIDRef_ = indexNameNode->Attribute("id");
             indexName_ = boost::shared_ptr<IndexName>(new IndexName(indexNameNode));
             indexName_->setID(indexNameIDRef_);
             IDManager::instance().setID(indexNameIDRef_,indexName_);
          }
          else if(indexNameNode->Attribute("href")) { indexNameIDRef_ = indexNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexName_ = boost::shared_ptr<IndexName>(new IndexName(indexNameNode));}
   }

   //indexIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexIdNode = xmlNode->FirstChildElement("indexId");

   if(indexIdNode){indexIdIsNull_ = false;}
   else{indexIdIsNull_ = true;}

   if(indexIdNode)
   {
      for(indexIdNode; indexIdNode; indexIdNode = indexIdNode->NextSiblingElement("indexId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexIdNode , address : " << indexIdNode << std::endl;
          #endif
          if(indexIdNode->Attribute("href") || indexIdNode->Attribute("id"))
          {
              if(indexIdNode->Attribute("id"))
              {
                  indexIdIDRef_ = indexIdNode->Attribute("id");
                  indexId_.push_back(boost::shared_ptr<IndexId>(new IndexId(indexIdNode)));
                  indexId_.back()->setID(indexIdIDRef_);
                  IDManager::instance().setID(indexIdIDRef_, indexId_.back());
              }
              else if(indexIdNode->Attribute("href")) { indexIdIDRef_ = indexIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { indexId_.push_back(boost::shared_ptr<IndexId>(new IndexId(indexIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexIdNode , address : " << indexIdNode << std::endl;
       #endif
   }

   //indexSeriesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexSeriesNode = xmlNode->FirstChildElement("indexSeries");

   if(indexSeriesNode){indexSeriesIsNull_ = false;}
   else{indexSeriesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexSeriesNode , address : " << indexSeriesNode << std::endl;
   #endif
   if(indexSeriesNode)
   {
      if(indexSeriesNode->Attribute("href") || indexSeriesNode->Attribute("id"))
      {
          if(indexSeriesNode->Attribute("id"))
          {
             indexSeriesIDRef_ = indexSeriesNode->Attribute("id");
             indexSeries_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(indexSeriesNode));
             indexSeries_->setID(indexSeriesIDRef_);
             IDManager::instance().setID(indexSeriesIDRef_,indexSeries_);
          }
          else if(indexSeriesNode->Attribute("href")) { indexSeriesIDRef_ = indexSeriesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexSeries_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(indexSeriesNode));}
   }

   //indexAnnexVersionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexAnnexVersionNode = xmlNode->FirstChildElement("indexAnnexVersion");

   if(indexAnnexVersionNode){indexAnnexVersionIsNull_ = false;}
   else{indexAnnexVersionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexAnnexVersionNode , address : " << indexAnnexVersionNode << std::endl;
   #endif
   if(indexAnnexVersionNode)
   {
      if(indexAnnexVersionNode->Attribute("href") || indexAnnexVersionNode->Attribute("id"))
      {
          if(indexAnnexVersionNode->Attribute("id"))
          {
             indexAnnexVersionIDRef_ = indexAnnexVersionNode->Attribute("id");
             indexAnnexVersion_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(indexAnnexVersionNode));
             indexAnnexVersion_->setID(indexAnnexVersionIDRef_);
             IDManager::instance().setID(indexAnnexVersionIDRef_,indexAnnexVersion_);
          }
          else if(indexAnnexVersionNode->Attribute("href")) { indexAnnexVersionIDRef_ = indexAnnexVersionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexAnnexVersion_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(indexAnnexVersionNode));}
   }

   //indexAnnexDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexAnnexDateNode = xmlNode->FirstChildElement("indexAnnexDate");

   if(indexAnnexDateNode){indexAnnexDateIsNull_ = false;}
   else{indexAnnexDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexAnnexDateNode , address : " << indexAnnexDateNode << std::endl;
   #endif
   if(indexAnnexDateNode)
   {
      if(indexAnnexDateNode->Attribute("href") || indexAnnexDateNode->Attribute("id"))
      {
          if(indexAnnexDateNode->Attribute("id"))
          {
             indexAnnexDateIDRef_ = indexAnnexDateNode->Attribute("id");
             indexAnnexDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(indexAnnexDateNode));
             indexAnnexDate_->setID(indexAnnexDateIDRef_);
             IDManager::instance().setID(indexAnnexDateIDRef_,indexAnnexDate_);
          }
          else if(indexAnnexDateNode->Attribute("href")) { indexAnnexDateIDRef_ = indexAnnexDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexAnnexDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(indexAnnexDateNode));}
   }

   //indexAnnexSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexAnnexSourceNode = xmlNode->FirstChildElement("indexAnnexSource");

   if(indexAnnexSourceNode){indexAnnexSourceIsNull_ = false;}
   else{indexAnnexSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexAnnexSourceNode , address : " << indexAnnexSourceNode << std::endl;
   #endif
   if(indexAnnexSourceNode)
   {
      if(indexAnnexSourceNode->Attribute("href") || indexAnnexSourceNode->Attribute("id"))
      {
          if(indexAnnexSourceNode->Attribute("id"))
          {
             indexAnnexSourceIDRef_ = indexAnnexSourceNode->Attribute("id");
             indexAnnexSource_ = boost::shared_ptr<IndexAnnexSource>(new IndexAnnexSource(indexAnnexSourceNode));
             indexAnnexSource_->setID(indexAnnexSourceIDRef_);
             IDManager::instance().setID(indexAnnexSourceIDRef_,indexAnnexSource_);
          }
          else if(indexAnnexSourceNode->Attribute("href")) { indexAnnexSourceIDRef_ = indexAnnexSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexAnnexSource_ = boost::shared_ptr<IndexAnnexSource>(new IndexAnnexSource(indexAnnexSourceNode));}
   }

   //excludedReferenceEntityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excludedReferenceEntityNode = xmlNode->FirstChildElement("excludedReferenceEntity");

   if(excludedReferenceEntityNode){excludedReferenceEntityIsNull_ = false;}
   else{excludedReferenceEntityIsNull_ = true;}

   if(excludedReferenceEntityNode)
   {
      for(excludedReferenceEntityNode; excludedReferenceEntityNode; excludedReferenceEntityNode = excludedReferenceEntityNode->NextSiblingElement("excludedReferenceEntity")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excludedReferenceEntityNode , address : " << excludedReferenceEntityNode << std::endl;
          #endif
          if(excludedReferenceEntityNode->Attribute("href") || excludedReferenceEntityNode->Attribute("id"))
          {
              if(excludedReferenceEntityNode->Attribute("id"))
              {
                  excludedReferenceEntityIDRef_ = excludedReferenceEntityNode->Attribute("id");
                  excludedReferenceEntity_.push_back(boost::shared_ptr<LegalEntity>(new LegalEntity(excludedReferenceEntityNode)));
                  excludedReferenceEntity_.back()->setID(excludedReferenceEntityIDRef_);
                  IDManager::instance().setID(excludedReferenceEntityIDRef_, excludedReferenceEntity_.back());
              }
              else if(excludedReferenceEntityNode->Attribute("href")) { excludedReferenceEntityIDRef_ = excludedReferenceEntityNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { excludedReferenceEntity_.push_back(boost::shared_ptr<LegalEntity>(new LegalEntity(excludedReferenceEntityNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excludedReferenceEntityNode , address : " << excludedReferenceEntityNode << std::endl;
       #endif
   }

   //trancheNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* trancheNode = xmlNode->FirstChildElement("tranche");

   if(trancheNode){trancheIsNull_ = false;}
   else{trancheIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- trancheNode , address : " << trancheNode << std::endl;
   #endif
   if(trancheNode)
   {
      if(trancheNode->Attribute("href") || trancheNode->Attribute("id"))
      {
          if(trancheNode->Attribute("id"))
          {
             trancheIDRef_ = trancheNode->Attribute("id");
             tranche_ = boost::shared_ptr<Tranche>(new Tranche(trancheNode));
             tranche_->setID(trancheIDRef_);
             IDManager::instance().setID(trancheIDRef_,tranche_);
          }
          else if(trancheNode->Attribute("href")) { trancheIDRef_ = trancheNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tranche_ = boost::shared_ptr<Tranche>(new Tranche(trancheNode));}
   }

   //settledEntityMatrixNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settledEntityMatrixNode = xmlNode->FirstChildElement("settledEntityMatrix");

   if(settledEntityMatrixNode){settledEntityMatrixIsNull_ = false;}
   else{settledEntityMatrixIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settledEntityMatrixNode , address : " << settledEntityMatrixNode << std::endl;
   #endif
   if(settledEntityMatrixNode)
   {
      if(settledEntityMatrixNode->Attribute("href") || settledEntityMatrixNode->Attribute("id"))
      {
          if(settledEntityMatrixNode->Attribute("id"))
          {
             settledEntityMatrixIDRef_ = settledEntityMatrixNode->Attribute("id");
             settledEntityMatrix_ = boost::shared_ptr<SettledEntityMatrix>(new SettledEntityMatrix(settledEntityMatrixNode));
             settledEntityMatrix_->setID(settledEntityMatrixIDRef_);
             IDManager::instance().setID(settledEntityMatrixIDRef_,settledEntityMatrix_);
          }
          else if(settledEntityMatrixNode->Attribute("href")) { settledEntityMatrixIDRef_ = settledEntityMatrixNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settledEntityMatrix_ = boost::shared_ptr<SettledEntityMatrix>(new SettledEntityMatrix(settledEntityMatrixNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IndexName> IndexReferenceInformation::getIndexName()
{
   if(!this->indexNameIsNull_){
        if(indexNameIDRef_ != ""){
             return boost::shared_static_cast<IndexName>(IDManager::instance().getID(indexNameIDRef_));
        }else{
             return this->indexName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexName>();
   }
}
std::vector<boost::shared_ptr<IndexId>> IndexReferenceInformation::getIndexId()
{
   if(!this->indexIdIsNull_){
        if(indexIdIDRef_ != ""){
             return this->indexId_;
        }else{
             return this->indexId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<IndexId>>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> IndexReferenceInformation::getIndexSeries()
{
   if(!this->indexSeriesIsNull_){
        if(indexSeriesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(indexSeriesIDRef_));
        }else{
             return this->indexSeries_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> IndexReferenceInformation::getIndexAnnexVersion()
{
   if(!this->indexAnnexVersionIsNull_){
        if(indexAnnexVersionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(indexAnnexVersionIDRef_));
        }else{
             return this->indexAnnexVersion_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypeDate> IndexReferenceInformation::getIndexAnnexDate()
{
   if(!this->indexAnnexDateIsNull_){
        if(indexAnnexDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(indexAnnexDateIDRef_));
        }else{
             return this->indexAnnexDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<IndexAnnexSource> IndexReferenceInformation::getIndexAnnexSource()
{
   if(!this->indexAnnexSourceIsNull_){
        if(indexAnnexSourceIDRef_ != ""){
             return boost::shared_static_cast<IndexAnnexSource>(IDManager::instance().getID(indexAnnexSourceIDRef_));
        }else{
             return this->indexAnnexSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexAnnexSource>();
   }
}
std::vector<boost::shared_ptr<LegalEntity>> IndexReferenceInformation::getExcludedReferenceEntity()
{
   if(!this->excludedReferenceEntityIsNull_){
        if(excludedReferenceEntityIDRef_ != ""){
             return this->excludedReferenceEntity_;
        }else{
             return this->excludedReferenceEntity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<LegalEntity>>();
   }
}
boost::shared_ptr<Tranche> IndexReferenceInformation::getTranche()
{
   if(!this->trancheIsNull_){
        if(trancheIDRef_ != ""){
             return boost::shared_static_cast<Tranche>(IDManager::instance().getID(trancheIDRef_));
        }else{
             return this->tranche_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Tranche>();
   }
}
boost::shared_ptr<SettledEntityMatrix> IndexReferenceInformation::getSettledEntityMatrix()
{
   if(!this->settledEntityMatrixIsNull_){
        if(settledEntityMatrixIDRef_ != ""){
             return boost::shared_static_cast<SettledEntityMatrix>(IDManager::instance().getID(settledEntityMatrixIDRef_));
        }else{
             return this->settledEntityMatrix_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettledEntityMatrix>();
   }
}
}

