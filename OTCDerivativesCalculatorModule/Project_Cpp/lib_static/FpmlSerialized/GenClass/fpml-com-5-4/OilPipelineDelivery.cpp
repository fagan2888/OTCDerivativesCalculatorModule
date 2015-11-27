// OilPipelineDelivery.cpp 
#include "OilPipelineDelivery.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OilPipelineDelivery::OilPipelineDelivery(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //pipelineNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pipelineNameNode = xmlNode->FirstChildElement("pipelineName");

   if(pipelineNameNode){pipelineNameIsNull_ = false;}
   else{pipelineNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pipelineNameNode , address : " << pipelineNameNode << std::endl;
   #endif
   if(pipelineNameNode)
   {
      if(pipelineNameNode->Attribute("href") || pipelineNameNode->Attribute("id"))
      {
          if(pipelineNameNode->Attribute("id"))
          {
             pipelineNameIDRef_ = pipelineNameNode->Attribute("id");
             pipelineName_ = boost::shared_ptr<CommodityPipeline>(new CommodityPipeline(pipelineNameNode));
             pipelineName_->setID(pipelineNameIDRef_);
             IDManager::instance().setID(pipelineNameIDRef_,pipelineName_);
          }
          else if(pipelineNameNode->Attribute("href")) { pipelineNameIDRef_ = pipelineNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pipelineName_ = boost::shared_ptr<CommodityPipeline>(new CommodityPipeline(pipelineNameNode));}
   }

   //withdrawalPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* withdrawalPointNode = xmlNode->FirstChildElement("withdrawalPoint");

   if(withdrawalPointNode){withdrawalPointIsNull_ = false;}
   else{withdrawalPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- withdrawalPointNode , address : " << withdrawalPointNode << std::endl;
   #endif
   if(withdrawalPointNode)
   {
      if(withdrawalPointNode->Attribute("href") || withdrawalPointNode->Attribute("id"))
      {
          if(withdrawalPointNode->Attribute("id"))
          {
             withdrawalPointIDRef_ = withdrawalPointNode->Attribute("id");
             withdrawalPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(withdrawalPointNode));
             withdrawalPoint_->setID(withdrawalPointIDRef_);
             IDManager::instance().setID(withdrawalPointIDRef_,withdrawalPoint_);
          }
          else if(withdrawalPointNode->Attribute("href")) { withdrawalPointIDRef_ = withdrawalPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { withdrawalPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(withdrawalPointNode));}
   }

   //entryPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entryPointNode = xmlNode->FirstChildElement("entryPoint");

   if(entryPointNode){entryPointIsNull_ = false;}
   else{entryPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entryPointNode , address : " << entryPointNode << std::endl;
   #endif
   if(entryPointNode)
   {
      if(entryPointNode->Attribute("href") || entryPointNode->Attribute("id"))
      {
          if(entryPointNode->Attribute("id"))
          {
             entryPointIDRef_ = entryPointNode->Attribute("id");
             entryPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(entryPointNode));
             entryPoint_->setID(entryPointIDRef_);
             IDManager::instance().setID(entryPointIDRef_,entryPoint_);
          }
          else if(entryPointNode->Attribute("href")) { entryPointIDRef_ = entryPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { entryPoint_ = boost::shared_ptr<CommodityDeliveryPoint>(new CommodityDeliveryPoint(entryPointNode));}
   }

   //deliverableByBargeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliverableByBargeNode = xmlNode->FirstChildElement("deliverableByBarge");

   if(deliverableByBargeNode){deliverableByBargeIsNull_ = false;}
   else{deliverableByBargeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliverableByBargeNode , address : " << deliverableByBargeNode << std::endl;
   #endif
   if(deliverableByBargeNode)
   {
      if(deliverableByBargeNode->Attribute("href") || deliverableByBargeNode->Attribute("id"))
      {
          if(deliverableByBargeNode->Attribute("id"))
          {
             deliverableByBargeIDRef_ = deliverableByBargeNode->Attribute("id");
             deliverableByBarge_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deliverableByBargeNode));
             deliverableByBarge_->setID(deliverableByBargeIDRef_);
             IDManager::instance().setID(deliverableByBargeIDRef_,deliverableByBarge_);
          }
          else if(deliverableByBargeNode->Attribute("href")) { deliverableByBargeIDRef_ = deliverableByBargeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliverableByBarge_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deliverableByBargeNode));}
   }

   //riskNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* riskNode = xmlNode->FirstChildElement("risk");

   if(riskNode){riskIsNull_ = false;}
   else{riskIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- riskNode , address : " << riskNode << std::endl;
   #endif
   if(riskNode)
   {
      if(riskNode->Attribute("href") || riskNode->Attribute("id"))
      {
          if(riskNode->Attribute("id"))
          {
             riskIDRef_ = riskNode->Attribute("id");
             risk_ = boost::shared_ptr<CommodityDeliveryRisk>(new CommodityDeliveryRisk(riskNode));
             risk_->setID(riskIDRef_);
             IDManager::instance().setID(riskIDRef_,risk_);
          }
          else if(riskNode->Attribute("href")) { riskIDRef_ = riskNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { risk_ = boost::shared_ptr<CommodityDeliveryRisk>(new CommodityDeliveryRisk(riskNode));}
   }

   //cycleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cycleNode = xmlNode->FirstChildElement("cycle");

   if(cycleNode){cycleIsNull_ = false;}
   else{cycleIsNull_ = true;}

   if(cycleNode)
   {
      for(cycleNode; cycleNode; cycleNode = cycleNode->NextSiblingElement("cycle")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cycleNode , address : " << cycleNode << std::endl;
          #endif
          if(cycleNode->Attribute("href") || cycleNode->Attribute("id"))
          {
              if(cycleNode->Attribute("id"))
              {
                  cycleIDRef_ = cycleNode->Attribute("id");
                  cycle_.push_back(boost::shared_ptr<CommodityPipelineCycle>(new CommodityPipelineCycle(cycleNode)));
                  cycle_.back()->setID(cycleIDRef_);
                  IDManager::instance().setID(cycleIDRef_, cycle_.back());
              }
              else if(cycleNode->Attribute("href")) { cycleIDRef_ = cycleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { cycle_.push_back(boost::shared_ptr<CommodityPipelineCycle>(new CommodityPipelineCycle(cycleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cycleNode , address : " << cycleNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityPipeline> OilPipelineDelivery::getPipelineName()
{
   if(!this->pipelineNameIsNull_){
        if(pipelineNameIDRef_ != ""){
             return boost::shared_static_cast<CommodityPipeline>(IDManager::instance().getID(pipelineNameIDRef_));
        }else{
             return this->pipelineName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPipeline>();
   }
}
boost::shared_ptr<CommodityDeliveryPoint> OilPipelineDelivery::getWithdrawalPoint()
{
   if(!this->withdrawalPointIsNull_){
        if(withdrawalPointIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(withdrawalPointIDRef_));
        }else{
             return this->withdrawalPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
boost::shared_ptr<CommodityDeliveryPoint> OilPipelineDelivery::getEntryPoint()
{
   if(!this->entryPointIsNull_){
        if(entryPointIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryPoint>(IDManager::instance().getID(entryPointIDRef_));
        }else{
             return this->entryPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryPoint>();
   }
}
boost::shared_ptr<XsdTypeBoolean> OilPipelineDelivery::getDeliverableByBarge()
{
   if(!this->deliverableByBargeIsNull_){
        if(deliverableByBargeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(deliverableByBargeIDRef_));
        }else{
             return this->deliverableByBarge_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CommodityDeliveryRisk> OilPipelineDelivery::getRisk()
{
   if(!this->riskIsNull_){
        if(riskIDRef_ != ""){
             return boost::shared_static_cast<CommodityDeliveryRisk>(IDManager::instance().getID(riskIDRef_));
        }else{
             return this->risk_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDeliveryRisk>();
   }
}
std::vector<boost::shared_ptr<CommodityPipelineCycle>> OilPipelineDelivery::getCycle()
{
   if(!this->cycleIsNull_){
        if(cycleIDRef_ != ""){
             return this->cycle_;
        }else{
             return this->cycle_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityPipelineCycle>>();
   }
}
}

