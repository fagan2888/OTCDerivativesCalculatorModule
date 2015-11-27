// NonCorrectableRequestMessage.cpp 
#include "NonCorrectableRequestMessage.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NonCorrectableRequestMessage::NonCorrectableRequestMessage(TiXmlNode* xmlNode)
: RequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //parentCorrelationIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parentCorrelationIdNode = xmlNode->FirstChildElement("parentCorrelationId");

   if(parentCorrelationIdNode){parentCorrelationIdIsNull_ = false;}
   else{parentCorrelationIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parentCorrelationIdNode , address : " << parentCorrelationIdNode << std::endl;
   #endif
   if(parentCorrelationIdNode)
   {
      if(parentCorrelationIdNode->Attribute("href") || parentCorrelationIdNode->Attribute("id"))
      {
          if(parentCorrelationIdNode->Attribute("id"))
          {
             parentCorrelationIdIDRef_ = parentCorrelationIdNode->Attribute("id");
             parentCorrelationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(parentCorrelationIdNode));
             parentCorrelationId_->setID(parentCorrelationIdIDRef_);
             IDManager::instance().setID(parentCorrelationIdIDRef_,parentCorrelationId_);
          }
          else if(parentCorrelationIdNode->Attribute("href")) { parentCorrelationIdIDRef_ = parentCorrelationIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parentCorrelationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(parentCorrelationIdNode));}
   }

   //correlationIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationIdNode = xmlNode->FirstChildElement("correlationId");

   if(correlationIdNode){correlationIdIsNull_ = false;}
   else{correlationIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationIdNode , address : " << correlationIdNode << std::endl;
   #endif
   if(correlationIdNode)
   {
      if(correlationIdNode->Attribute("href") || correlationIdNode->Attribute("id"))
      {
          if(correlationIdNode->Attribute("id"))
          {
             correlationIdIDRef_ = correlationIdNode->Attribute("id");
             correlationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(correlationIdNode));
             correlationId_->setID(correlationIdIDRef_);
             IDManager::instance().setID(correlationIdIDRef_,correlationId_);
          }
          else if(correlationIdNode->Attribute("href")) { correlationIdIDRef_ = correlationIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correlationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(correlationIdNode));}
   }

   //sequenceNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sequenceNumberNode = xmlNode->FirstChildElement("sequenceNumber");

   if(sequenceNumberNode){sequenceNumberIsNull_ = false;}
   else{sequenceNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sequenceNumberNode , address : " << sequenceNumberNode << std::endl;
   #endif
   if(sequenceNumberNode)
   {
      if(sequenceNumberNode->Attribute("href") || sequenceNumberNode->Attribute("id"))
      {
          if(sequenceNumberNode->Attribute("id"))
          {
             sequenceNumberIDRef_ = sequenceNumberNode->Attribute("id");
             sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));
             sequenceNumber_->setID(sequenceNumberIDRef_);
             IDManager::instance().setID(sequenceNumberIDRef_,sequenceNumber_);
          }
          else if(sequenceNumberNode->Attribute("href")) { sequenceNumberIDRef_ = sequenceNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));}
   }

   //onBehalfOfNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* onBehalfOfNode = xmlNode->FirstChildElement("onBehalfOf");

   if(onBehalfOfNode){onBehalfOfIsNull_ = false;}
   else{onBehalfOfIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- onBehalfOfNode , address : " << onBehalfOfNode << std::endl;
   #endif
   if(onBehalfOfNode)
   {
      if(onBehalfOfNode->Attribute("href") || onBehalfOfNode->Attribute("id"))
      {
          if(onBehalfOfNode->Attribute("id"))
          {
             onBehalfOfIDRef_ = onBehalfOfNode->Attribute("id");
             onBehalfOf_ = boost::shared_ptr<OnBehalfOf>(new OnBehalfOf(onBehalfOfNode));
             onBehalfOf_->setID(onBehalfOfIDRef_);
             IDManager::instance().setID(onBehalfOfIDRef_,onBehalfOf_);
          }
          else if(onBehalfOfNode->Attribute("href")) { onBehalfOfIDRef_ = onBehalfOfNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { onBehalfOf_ = boost::shared_ptr<OnBehalfOf>(new OnBehalfOf(onBehalfOfNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CorrelationId> NonCorrectableRequestMessage::getParentCorrelationId()
{
   if(!this->parentCorrelationIdIsNull_){
        if(parentCorrelationIdIDRef_ != ""){
             return boost::shared_static_cast<CorrelationId>(IDManager::instance().getID(parentCorrelationIdIDRef_));
        }else{
             return this->parentCorrelationId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationId>();
   }
}
boost::shared_ptr<CorrelationId> NonCorrectableRequestMessage::getCorrelationId()
{
   if(!this->correlationIdIsNull_){
        if(correlationIdIDRef_ != ""){
             return boost::shared_static_cast<CorrelationId>(IDManager::instance().getID(correlationIdIDRef_));
        }else{
             return this->correlationId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationId>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> NonCorrectableRequestMessage::getSequenceNumber()
{
   if(!this->sequenceNumberIsNull_){
        if(sequenceNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(sequenceNumberIDRef_));
        }else{
             return this->sequenceNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<OnBehalfOf> NonCorrectableRequestMessage::getOnBehalfOf()
{
   if(!this->onBehalfOfIsNull_){
        if(onBehalfOfIDRef_ != ""){
             return boost::shared_static_cast<OnBehalfOf>(IDManager::instance().getID(onBehalfOfIDRef_));
        }else{
             return this->onBehalfOf_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OnBehalfOf>();
   }
}
}

