// OilDelivery.cpp 
#include "OilDelivery.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OilDelivery::OilDelivery(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //pipelineNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pipelineNode = xmlNode->FirstChildElement("pipeline");

   if(pipelineNode){pipelineIsNull_ = false;}
   else{pipelineIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pipelineNode , address : " << pipelineNode << std::endl;
   #endif
   if(pipelineNode)
   {
      if(pipelineNode->Attribute("href") || pipelineNode->Attribute("id"))
      {
          if(pipelineNode->Attribute("id"))
          {
             pipelineIDRef_ = pipelineNode->Attribute("id");
             pipeline_ = boost::shared_ptr<OilPipelineDelivery>(new OilPipelineDelivery(pipelineNode));
             pipeline_->setID(pipelineIDRef_);
             IDManager::instance().setID(pipelineIDRef_,pipeline_);
          }
          else if(pipelineNode->Attribute("href")) { pipelineIDRef_ = pipelineNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pipeline_ = boost::shared_ptr<OilPipelineDelivery>(new OilPipelineDelivery(pipelineNode));}
   }

   //transferNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transferNode = xmlNode->FirstChildElement("transfer");

   if(transferNode){transferIsNull_ = false;}
   else{transferIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transferNode , address : " << transferNode << std::endl;
   #endif
   if(transferNode)
   {
      if(transferNode->Attribute("href") || transferNode->Attribute("id"))
      {
          if(transferNode->Attribute("id"))
          {
             transferIDRef_ = transferNode->Attribute("id");
             transfer_ = boost::shared_ptr<OilTransferDelivery>(new OilTransferDelivery(transferNode));
             transfer_->setID(transferIDRef_);
             IDManager::instance().setID(transferIDRef_,transfer_);
          }
          else if(transferNode->Attribute("href")) { transferIDRef_ = transferNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transfer_ = boost::shared_ptr<OilTransferDelivery>(new OilTransferDelivery(transferNode));}
   }

   //importerOfRecordNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* importerOfRecordNode = xmlNode->FirstChildElement("importerOfRecord");

   if(importerOfRecordNode){importerOfRecordIsNull_ = false;}
   else{importerOfRecordIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- importerOfRecordNode , address : " << importerOfRecordNode << std::endl;
   #endif
   if(importerOfRecordNode)
   {
      if(importerOfRecordNode->Attribute("href") || importerOfRecordNode->Attribute("id"))
      {
          if(importerOfRecordNode->Attribute("id"))
          {
             importerOfRecordIDRef_ = importerOfRecordNode->Attribute("id");
             importerOfRecord_ = boost::shared_ptr<PartyReference>(new PartyReference(importerOfRecordNode));
             importerOfRecord_->setID(importerOfRecordIDRef_);
             IDManager::instance().setID(importerOfRecordIDRef_,importerOfRecord_);
          }
          else if(importerOfRecordNode->Attribute("href")) { importerOfRecordIDRef_ = importerOfRecordNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { importerOfRecord_ = boost::shared_ptr<PartyReference>(new PartyReference(importerOfRecordNode));}
   }

   //absoluteToleranceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* absoluteToleranceNode = xmlNode->FirstChildElement("absoluteTolerance");

   if(absoluteToleranceNode){absoluteToleranceIsNull_ = false;}
   else{absoluteToleranceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- absoluteToleranceNode , address : " << absoluteToleranceNode << std::endl;
   #endif
   if(absoluteToleranceNode)
   {
      if(absoluteToleranceNode->Attribute("href") || absoluteToleranceNode->Attribute("id"))
      {
          if(absoluteToleranceNode->Attribute("id"))
          {
             absoluteToleranceIDRef_ = absoluteToleranceNode->Attribute("id");
             absoluteTolerance_ = boost::shared_ptr<AbsoluteTolerance>(new AbsoluteTolerance(absoluteToleranceNode));
             absoluteTolerance_->setID(absoluteToleranceIDRef_);
             IDManager::instance().setID(absoluteToleranceIDRef_,absoluteTolerance_);
          }
          else if(absoluteToleranceNode->Attribute("href")) { absoluteToleranceIDRef_ = absoluteToleranceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { absoluteTolerance_ = boost::shared_ptr<AbsoluteTolerance>(new AbsoluteTolerance(absoluteToleranceNode));}
   }

   //percentageToleranceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* percentageToleranceNode = xmlNode->FirstChildElement("percentageTolerance");

   if(percentageToleranceNode){percentageToleranceIsNull_ = false;}
   else{percentageToleranceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- percentageToleranceNode , address : " << percentageToleranceNode << std::endl;
   #endif
   if(percentageToleranceNode)
   {
      if(percentageToleranceNode->Attribute("href") || percentageToleranceNode->Attribute("id"))
      {
          if(percentageToleranceNode->Attribute("id"))
          {
             percentageToleranceIDRef_ = percentageToleranceNode->Attribute("id");
             percentageTolerance_ = boost::shared_ptr<PercentageTolerance>(new PercentageTolerance(percentageToleranceNode));
             percentageTolerance_->setID(percentageToleranceIDRef_);
             IDManager::instance().setID(percentageToleranceIDRef_,percentageTolerance_);
          }
          else if(percentageToleranceNode->Attribute("href")) { percentageToleranceIDRef_ = percentageToleranceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { percentageTolerance_ = boost::shared_ptr<PercentageTolerance>(new PercentageTolerance(percentageToleranceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<OilPipelineDelivery> OilDelivery::getPipeline()
{
   if(!this->pipelineIsNull_){
        if(pipelineIDRef_ != ""){
             return boost::shared_static_cast<OilPipelineDelivery>(IDManager::instance().getID(pipelineIDRef_));
        }else{
             return this->pipeline_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OilPipelineDelivery>();
   }
}
boost::shared_ptr<OilTransferDelivery> OilDelivery::getTransfer()
{
   if(!this->transferIsNull_){
        if(transferIDRef_ != ""){
             return boost::shared_static_cast<OilTransferDelivery>(IDManager::instance().getID(transferIDRef_));
        }else{
             return this->transfer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OilTransferDelivery>();
   }
}
boost::shared_ptr<PartyReference> OilDelivery::getImporterOfRecord()
{
   if(!this->importerOfRecordIsNull_){
        if(importerOfRecordIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(importerOfRecordIDRef_));
        }else{
             return this->importerOfRecord_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AbsoluteTolerance> OilDelivery::getAbsoluteTolerance()
{
   if(!this->absoluteToleranceIsNull_){
        if(absoluteToleranceIDRef_ != ""){
             return boost::shared_static_cast<AbsoluteTolerance>(IDManager::instance().getID(absoluteToleranceIDRef_));
        }else{
             return this->absoluteTolerance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AbsoluteTolerance>();
   }
}
boost::shared_ptr<PercentageTolerance> OilDelivery::getPercentageTolerance()
{
   if(!this->percentageToleranceIsNull_){
        if(percentageToleranceIDRef_ != ""){
             return boost::shared_static_cast<PercentageTolerance>(IDManager::instance().getID(percentageToleranceIDRef_));
        }else{
             return this->percentageTolerance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PercentageTolerance>();
   }
}
}

