// ExtraordinaryEvents.cpp 
#include "ExtraordinaryEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExtraordinaryEvents::ExtraordinaryEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //mergerEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mergerEventsNode = xmlNode->FirstChildElement("mergerEvents");

   if(mergerEventsNode){mergerEventsIsNull_ = false;}
   else{mergerEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mergerEventsNode , address : " << mergerEventsNode << std::endl;
   #endif
   if(mergerEventsNode)
   {
      if(mergerEventsNode->Attribute("href") || mergerEventsNode->Attribute("id"))
      {
          if(mergerEventsNode->Attribute("id"))
          {
             mergerEventsIDRef_ = mergerEventsNode->Attribute("id");
             mergerEvents_ = boost::shared_ptr<EquityCorporateEvents>(new EquityCorporateEvents(mergerEventsNode));
             mergerEvents_->setID(mergerEventsIDRef_);
             IDManager::instance().setID(mergerEventsIDRef_,mergerEvents_);
          }
          else if(mergerEventsNode->Attribute("href")) { mergerEventsIDRef_ = mergerEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mergerEvents_ = boost::shared_ptr<EquityCorporateEvents>(new EquityCorporateEvents(mergerEventsNode));}
   }

   //tenderOfferNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenderOfferNode = xmlNode->FirstChildElement("tenderOffer");

   if(tenderOfferNode){tenderOfferIsNull_ = false;}
   else{tenderOfferIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenderOfferNode , address : " << tenderOfferNode << std::endl;
   #endif
   if(tenderOfferNode)
   {
      if(tenderOfferNode->Attribute("href") || tenderOfferNode->Attribute("id"))
      {
          if(tenderOfferNode->Attribute("id"))
          {
             tenderOfferIDRef_ = tenderOfferNode->Attribute("id");
             tenderOffer_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(tenderOfferNode));
             tenderOffer_->setID(tenderOfferIDRef_);
             IDManager::instance().setID(tenderOfferIDRef_,tenderOffer_);
          }
          else if(tenderOfferNode->Attribute("href")) { tenderOfferIDRef_ = tenderOfferNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenderOffer_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(tenderOfferNode));}
   }

   //tenderOfferEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenderOfferEventsNode = xmlNode->FirstChildElement("tenderOfferEvents");

   if(tenderOfferEventsNode){tenderOfferEventsIsNull_ = false;}
   else{tenderOfferEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenderOfferEventsNode , address : " << tenderOfferEventsNode << std::endl;
   #endif
   if(tenderOfferEventsNode)
   {
      if(tenderOfferEventsNode->Attribute("href") || tenderOfferEventsNode->Attribute("id"))
      {
          if(tenderOfferEventsNode->Attribute("id"))
          {
             tenderOfferEventsIDRef_ = tenderOfferEventsNode->Attribute("id");
             tenderOfferEvents_ = boost::shared_ptr<EquityCorporateEvents>(new EquityCorporateEvents(tenderOfferEventsNode));
             tenderOfferEvents_->setID(tenderOfferEventsIDRef_);
             IDManager::instance().setID(tenderOfferEventsIDRef_,tenderOfferEvents_);
          }
          else if(tenderOfferEventsNode->Attribute("href")) { tenderOfferEventsIDRef_ = tenderOfferEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenderOfferEvents_ = boost::shared_ptr<EquityCorporateEvents>(new EquityCorporateEvents(tenderOfferEventsNode));}
   }

   //compositionOfCombinedConsiderationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compositionOfCombinedConsiderationNode = xmlNode->FirstChildElement("compositionOfCombinedConsideration");

   if(compositionOfCombinedConsiderationNode){compositionOfCombinedConsiderationIsNull_ = false;}
   else{compositionOfCombinedConsiderationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compositionOfCombinedConsiderationNode , address : " << compositionOfCombinedConsiderationNode << std::endl;
   #endif
   if(compositionOfCombinedConsiderationNode)
   {
      if(compositionOfCombinedConsiderationNode->Attribute("href") || compositionOfCombinedConsiderationNode->Attribute("id"))
      {
          if(compositionOfCombinedConsiderationNode->Attribute("id"))
          {
             compositionOfCombinedConsiderationIDRef_ = compositionOfCombinedConsiderationNode->Attribute("id");
             compositionOfCombinedConsideration_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(compositionOfCombinedConsiderationNode));
             compositionOfCombinedConsideration_->setID(compositionOfCombinedConsiderationIDRef_);
             IDManager::instance().setID(compositionOfCombinedConsiderationIDRef_,compositionOfCombinedConsideration_);
          }
          else if(compositionOfCombinedConsiderationNode->Attribute("href")) { compositionOfCombinedConsiderationIDRef_ = compositionOfCombinedConsiderationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compositionOfCombinedConsideration_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(compositionOfCombinedConsiderationNode));}
   }

   //indexAdjustmentEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexAdjustmentEventsNode = xmlNode->FirstChildElement("indexAdjustmentEvents");

   if(indexAdjustmentEventsNode){indexAdjustmentEventsIsNull_ = false;}
   else{indexAdjustmentEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexAdjustmentEventsNode , address : " << indexAdjustmentEventsNode << std::endl;
   #endif
   if(indexAdjustmentEventsNode)
   {
      if(indexAdjustmentEventsNode->Attribute("href") || indexAdjustmentEventsNode->Attribute("id"))
      {
          if(indexAdjustmentEventsNode->Attribute("id"))
          {
             indexAdjustmentEventsIDRef_ = indexAdjustmentEventsNode->Attribute("id");
             indexAdjustmentEvents_ = boost::shared_ptr<IndexAdjustmentEvents>(new IndexAdjustmentEvents(indexAdjustmentEventsNode));
             indexAdjustmentEvents_->setID(indexAdjustmentEventsIDRef_);
             IDManager::instance().setID(indexAdjustmentEventsIDRef_,indexAdjustmentEvents_);
          }
          else if(indexAdjustmentEventsNode->Attribute("href")) { indexAdjustmentEventsIDRef_ = indexAdjustmentEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexAdjustmentEvents_ = boost::shared_ptr<IndexAdjustmentEvents>(new IndexAdjustmentEvents(indexAdjustmentEventsNode));}
   }

   //additionalDisruptionEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalDisruptionEventsNode = xmlNode->FirstChildElement("additionalDisruptionEvents");

   if(additionalDisruptionEventsNode){additionalDisruptionEventsIsNull_ = false;}
   else{additionalDisruptionEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalDisruptionEventsNode , address : " << additionalDisruptionEventsNode << std::endl;
   #endif
   if(additionalDisruptionEventsNode)
   {
      if(additionalDisruptionEventsNode->Attribute("href") || additionalDisruptionEventsNode->Attribute("id"))
      {
          if(additionalDisruptionEventsNode->Attribute("id"))
          {
             additionalDisruptionEventsIDRef_ = additionalDisruptionEventsNode->Attribute("id");
             additionalDisruptionEvents_ = boost::shared_ptr<AdditionalDisruptionEvents>(new AdditionalDisruptionEvents(additionalDisruptionEventsNode));
             additionalDisruptionEvents_->setID(additionalDisruptionEventsIDRef_);
             IDManager::instance().setID(additionalDisruptionEventsIDRef_,additionalDisruptionEvents_);
          }
          else if(additionalDisruptionEventsNode->Attribute("href")) { additionalDisruptionEventsIDRef_ = additionalDisruptionEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalDisruptionEvents_ = boost::shared_ptr<AdditionalDisruptionEvents>(new AdditionalDisruptionEvents(additionalDisruptionEventsNode));}
   }

   //failureToDeliverNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToDeliverNode = xmlNode->FirstChildElement("failureToDeliver");

   if(failureToDeliverNode){failureToDeliverIsNull_ = false;}
   else{failureToDeliverIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToDeliverNode , address : " << failureToDeliverNode << std::endl;
   #endif
   if(failureToDeliverNode)
   {
      if(failureToDeliverNode->Attribute("href") || failureToDeliverNode->Attribute("id"))
      {
          if(failureToDeliverNode->Attribute("id"))
          {
             failureToDeliverIDRef_ = failureToDeliverNode->Attribute("id");
             failureToDeliver_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToDeliverNode));
             failureToDeliver_->setID(failureToDeliverIDRef_);
             IDManager::instance().setID(failureToDeliverIDRef_,failureToDeliver_);
          }
          else if(failureToDeliverNode->Attribute("href")) { failureToDeliverIDRef_ = failureToDeliverNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToDeliver_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToDeliverNode));}
   }

   //representationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* representationsNode = xmlNode->FirstChildElement("representations");

   if(representationsNode){representationsIsNull_ = false;}
   else{representationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- representationsNode , address : " << representationsNode << std::endl;
   #endif
   if(representationsNode)
   {
      if(representationsNode->Attribute("href") || representationsNode->Attribute("id"))
      {
          if(representationsNode->Attribute("id"))
          {
             representationsIDRef_ = representationsNode->Attribute("id");
             representations_ = boost::shared_ptr<Representations>(new Representations(representationsNode));
             representations_->setID(representationsIDRef_);
             IDManager::instance().setID(representationsIDRef_,representations_);
          }
          else if(representationsNode->Attribute("href")) { representationsIDRef_ = representationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { representations_ = boost::shared_ptr<Representations>(new Representations(representationsNode));}
   }

   //nationalisationOrInsolvencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nationalisationOrInsolvencyNode = xmlNode->FirstChildElement("nationalisationOrInsolvency");

   if(nationalisationOrInsolvencyNode){nationalisationOrInsolvencyIsNull_ = false;}
   else{nationalisationOrInsolvencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nationalisationOrInsolvencyNode , address : " << nationalisationOrInsolvencyNode << std::endl;
   #endif
   if(nationalisationOrInsolvencyNode)
   {
      if(nationalisationOrInsolvencyNode->Attribute("href") || nationalisationOrInsolvencyNode->Attribute("id"))
      {
          if(nationalisationOrInsolvencyNode->Attribute("id"))
          {
             nationalisationOrInsolvencyIDRef_ = nationalisationOrInsolvencyNode->Attribute("id");
             nationalisationOrInsolvency_ = boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum>(new NationalisationOrInsolvencyOrDelistingEventEnum(nationalisationOrInsolvencyNode));
             nationalisationOrInsolvency_->setID(nationalisationOrInsolvencyIDRef_);
             IDManager::instance().setID(nationalisationOrInsolvencyIDRef_,nationalisationOrInsolvency_);
          }
          else if(nationalisationOrInsolvencyNode->Attribute("href")) { nationalisationOrInsolvencyIDRef_ = nationalisationOrInsolvencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nationalisationOrInsolvency_ = boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum>(new NationalisationOrInsolvencyOrDelistingEventEnum(nationalisationOrInsolvencyNode));}
   }

   //delistingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* delistingNode = xmlNode->FirstChildElement("delisting");

   if(delistingNode){delistingIsNull_ = false;}
   else{delistingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- delistingNode , address : " << delistingNode << std::endl;
   #endif
   if(delistingNode)
   {
      if(delistingNode->Attribute("href") || delistingNode->Attribute("id"))
      {
          if(delistingNode->Attribute("id"))
          {
             delistingIDRef_ = delistingNode->Attribute("id");
             delisting_ = boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum>(new NationalisationOrInsolvencyOrDelistingEventEnum(delistingNode));
             delisting_->setID(delistingIDRef_);
             IDManager::instance().setID(delistingIDRef_,delisting_);
          }
          else if(delistingNode->Attribute("href")) { delistingIDRef_ = delistingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { delisting_ = boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum>(new NationalisationOrInsolvencyOrDelistingEventEnum(delistingNode));}
   }

   //relatedExchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relatedExchangeIdNode = xmlNode->FirstChildElement("relatedExchangeId");

   if(relatedExchangeIdNode){relatedExchangeIdIsNull_ = false;}
   else{relatedExchangeIdIsNull_ = true;}

   if(relatedExchangeIdNode)
   {
      for(relatedExchangeIdNode; relatedExchangeIdNode; relatedExchangeIdNode = relatedExchangeIdNode->NextSiblingElement("relatedExchangeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedExchangeIdNode , address : " << relatedExchangeIdNode << std::endl;
          #endif
          if(relatedExchangeIdNode->Attribute("href") || relatedExchangeIdNode->Attribute("id"))
          {
              if(relatedExchangeIdNode->Attribute("id"))
              {
                  relatedExchangeIdIDRef_ = relatedExchangeIdNode->Attribute("id");
                  relatedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(relatedExchangeIdNode)));
                  relatedExchangeId_.back()->setID(relatedExchangeIdIDRef_);
                  IDManager::instance().setID(relatedExchangeIdIDRef_, relatedExchangeId_.back());
              }
              else if(relatedExchangeIdNode->Attribute("href")) { relatedExchangeIdIDRef_ = relatedExchangeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { relatedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(relatedExchangeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedExchangeIdNode , address : " << relatedExchangeIdNode << std::endl;
       #endif
   }

   //optionsExchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionsExchangeIdNode = xmlNode->FirstChildElement("optionsExchangeId");

   if(optionsExchangeIdNode){optionsExchangeIdIsNull_ = false;}
   else{optionsExchangeIdIsNull_ = true;}

   if(optionsExchangeIdNode)
   {
      for(optionsExchangeIdNode; optionsExchangeIdNode; optionsExchangeIdNode = optionsExchangeIdNode->NextSiblingElement("optionsExchangeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionsExchangeIdNode , address : " << optionsExchangeIdNode << std::endl;
          #endif
          if(optionsExchangeIdNode->Attribute("href") || optionsExchangeIdNode->Attribute("id"))
          {
              if(optionsExchangeIdNode->Attribute("id"))
              {
                  optionsExchangeIdIDRef_ = optionsExchangeIdNode->Attribute("id");
                  optionsExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(optionsExchangeIdNode)));
                  optionsExchangeId_.back()->setID(optionsExchangeIdIDRef_);
                  IDManager::instance().setID(optionsExchangeIdIDRef_, optionsExchangeId_.back());
              }
              else if(optionsExchangeIdNode->Attribute("href")) { optionsExchangeIdIDRef_ = optionsExchangeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { optionsExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(optionsExchangeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionsExchangeIdNode , address : " << optionsExchangeIdNode << std::endl;
       #endif
   }

   //specifiedExchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specifiedExchangeIdNode = xmlNode->FirstChildElement("specifiedExchangeId");

   if(specifiedExchangeIdNode){specifiedExchangeIdIsNull_ = false;}
   else{specifiedExchangeIdIsNull_ = true;}

   if(specifiedExchangeIdNode)
   {
      for(specifiedExchangeIdNode; specifiedExchangeIdNode; specifiedExchangeIdNode = specifiedExchangeIdNode->NextSiblingElement("specifiedExchangeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedExchangeIdNode , address : " << specifiedExchangeIdNode << std::endl;
          #endif
          if(specifiedExchangeIdNode->Attribute("href") || specifiedExchangeIdNode->Attribute("id"))
          {
              if(specifiedExchangeIdNode->Attribute("id"))
              {
                  specifiedExchangeIdIDRef_ = specifiedExchangeIdNode->Attribute("id");
                  specifiedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(specifiedExchangeIdNode)));
                  specifiedExchangeId_.back()->setID(specifiedExchangeIdIDRef_);
                  IDManager::instance().setID(specifiedExchangeIdIDRef_, specifiedExchangeId_.back());
              }
              else if(specifiedExchangeIdNode->Attribute("href")) { specifiedExchangeIdIDRef_ = specifiedExchangeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { specifiedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(specifiedExchangeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedExchangeIdNode , address : " << specifiedExchangeIdNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EquityCorporateEvents> ExtraordinaryEvents::getMergerEvents()
{
   if(!this->mergerEventsIsNull_){
        if(mergerEventsIDRef_ != ""){
             return boost::shared_static_cast<EquityCorporateEvents>(IDManager::instance().getID(mergerEventsIDRef_));
        }else{
             return this->mergerEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityCorporateEvents>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ExtraordinaryEvents::getTenderOffer()
{
   if(!this->tenderOfferIsNull_){
        if(tenderOfferIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(tenderOfferIDRef_));
        }else{
             return this->tenderOffer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<EquityCorporateEvents> ExtraordinaryEvents::getTenderOfferEvents()
{
   if(!this->tenderOfferEventsIsNull_){
        if(tenderOfferEventsIDRef_ != ""){
             return boost::shared_static_cast<EquityCorporateEvents>(IDManager::instance().getID(tenderOfferEventsIDRef_));
        }else{
             return this->tenderOfferEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityCorporateEvents>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ExtraordinaryEvents::getCompositionOfCombinedConsideration()
{
   if(!this->compositionOfCombinedConsiderationIsNull_){
        if(compositionOfCombinedConsiderationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(compositionOfCombinedConsiderationIDRef_));
        }else{
             return this->compositionOfCombinedConsideration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<IndexAdjustmentEvents> ExtraordinaryEvents::getIndexAdjustmentEvents()
{
   if(!this->indexAdjustmentEventsIsNull_){
        if(indexAdjustmentEventsIDRef_ != ""){
             return boost::shared_static_cast<IndexAdjustmentEvents>(IDManager::instance().getID(indexAdjustmentEventsIDRef_));
        }else{
             return this->indexAdjustmentEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexAdjustmentEvents>();
   }
}
boost::shared_ptr<AdditionalDisruptionEvents> ExtraordinaryEvents::getAdditionalDisruptionEvents()
{
   if(!this->additionalDisruptionEventsIsNull_){
        if(additionalDisruptionEventsIDRef_ != ""){
             return boost::shared_static_cast<AdditionalDisruptionEvents>(IDManager::instance().getID(additionalDisruptionEventsIDRef_));
        }else{
             return this->additionalDisruptionEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionalDisruptionEvents>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ExtraordinaryEvents::getFailureToDeliver()
{
   if(!this->failureToDeliverIsNull_){
        if(failureToDeliverIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(failureToDeliverIDRef_));
        }else{
             return this->failureToDeliver_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Representations> ExtraordinaryEvents::getRepresentations()
{
   if(!this->representationsIsNull_){
        if(representationsIDRef_ != ""){
             return boost::shared_static_cast<Representations>(IDManager::instance().getID(representationsIDRef_));
        }else{
             return this->representations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Representations>();
   }
}
boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum> ExtraordinaryEvents::getNationalisationOrInsolvency()
{
   if(!this->nationalisationOrInsolvencyIsNull_){
        if(nationalisationOrInsolvencyIDRef_ != ""){
             return boost::shared_static_cast<NationalisationOrInsolvencyOrDelistingEventEnum>(IDManager::instance().getID(nationalisationOrInsolvencyIDRef_));
        }else{
             return this->nationalisationOrInsolvency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum>();
   }
}
boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum> ExtraordinaryEvents::getDelisting()
{
   if(!this->delistingIsNull_){
        if(delistingIDRef_ != ""){
             return boost::shared_static_cast<NationalisationOrInsolvencyOrDelistingEventEnum>(IDManager::instance().getID(delistingIDRef_));
        }else{
             return this->delisting_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum>();
   }
}
std::vector<boost::shared_ptr<ExchangeId>> ExtraordinaryEvents::getRelatedExchangeId()
{
   if(!this->relatedExchangeIdIsNull_){
        if(relatedExchangeIdIDRef_ != ""){
             return this->relatedExchangeId_;
        }else{
             return this->relatedExchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExchangeId>>();
   }
}
std::vector<boost::shared_ptr<ExchangeId>> ExtraordinaryEvents::getOptionsExchangeId()
{
   if(!this->optionsExchangeIdIsNull_){
        if(optionsExchangeIdIDRef_ != ""){
             return this->optionsExchangeId_;
        }else{
             return this->optionsExchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExchangeId>>();
   }
}
std::vector<boost::shared_ptr<ExchangeId>> ExtraordinaryEvents::getSpecifiedExchangeId()
{
   if(!this->specifiedExchangeIdIsNull_){
        if(specifiedExchangeIdIDRef_ != ""){
             return this->specifiedExchangeId_;
        }else{
             return this->specifiedExchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExchangeId>>();
   }
}
}

