// MessageHeader.cpp 
#include "MessageHeader.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MessageHeader::MessageHeader(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //messageIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* messageIdNode = xmlNode->FirstChildElement("messageId");

   if(messageIdNode){messageIdIsNull_ = false;}
   else{messageIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- messageIdNode , address : " << messageIdNode << std::endl;
   #endif
   if(messageIdNode)
   {
       messageId_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(messageIdNode));
   }

   //messageTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* messageTypeNode = xmlNode->FirstChildElement("messageType");

   if(messageTypeNode){messageTypeIsNull_ = false;}
   else{messageTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- messageTypeNode , address : " << messageTypeNode << std::endl;
   #endif
   if(messageTypeNode)
   {
       messageType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(messageTypeNode));
   }

   //sentByNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sentByNode = xmlNode->FirstChildElement("sentBy");

   if(sentByNode){sentByIsNull_ = false;}
   else{sentByIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sentByNode , address : " << sentByNode << std::endl;
   #endif
   if(sentByNode)
   {
       sentBy_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(sentByNode));
   }

   //sendToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sendToNode = xmlNode->FirstChildElement("sendTo");

   if(sendToNode){sendToIsNull_ = false;}
   else{sendToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sendToNode , address : " << sendToNode << std::endl;
   #endif
   if(sendToNode)
   {
       sendTo_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(sendToNode));
   }

   //creationTimestampNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creationTimestampNode = xmlNode->FirstChildElement("creationTimestamp");

   if(creationTimestampNode){creationTimestampIsNull_ = false;}
   else{creationTimestampIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creationTimestampNode , address : " << creationTimestampNode << std::endl;
   #endif
   if(creationTimestampNode)
   {
       creationTimestamp_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(creationTimestampNode));
   }

   //isCorrectionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* isCorrectionNode = xmlNode->FirstChildElement("isCorrection");

   if(isCorrectionNode){isCorrectionIsNull_ = false;}
   else{isCorrectionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- isCorrectionNode , address : " << isCorrectionNode << std::endl;
   #endif
   if(isCorrectionNode)
   {
       isCorrection_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(isCorrectionNode));
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
       correlationId_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(correlationIdNode));
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
       sequenceNumber_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(sequenceNumberNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getMessageId()
{
   if(!this->messageIdIsNull_){
        return this->messageId_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getMessageType()
{
   if(!this->messageTypeIsNull_){
        return this->messageType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getSentBy()
{
   if(!this->sentByIsNull_){
        return this->sentBy_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getSendTo()
{
   if(!this->sendToIsNull_){
        return this->sendTo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getCreationTimestamp()
{
   if(!this->creationTimestampIsNull_){
        return this->creationTimestamp_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getIsCorrection()
{
   if(!this->isCorrectionIsNull_){
        return this->isCorrection_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getCorrelationId()
{
   if(!this->correlationIdIsNull_){
        return this->correlationId_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MessageHeader::getSequenceNumber()
{
   if(!this->sequenceNumberIsNull_){
        return this->sequenceNumber_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

