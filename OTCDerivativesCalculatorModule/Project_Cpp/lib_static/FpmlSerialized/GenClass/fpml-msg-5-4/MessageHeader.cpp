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
      if(messageIdNode->Attribute("href") || messageIdNode->Attribute("id"))
      {
          if(messageIdNode->Attribute("id"))
          {
             messageIdIDRef_ = messageIdNode->Attribute("id");
             messageId_ = boost::shared_ptr<MessageId>(new MessageId(messageIdNode));
             messageId_->setID(messageIdIDRef_);
             IDManager::instance().setID(messageIdIDRef_,messageId_);
          }
          else if(messageIdNode->Attribute("href")) { messageIdIDRef_ = messageIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { messageId_ = boost::shared_ptr<MessageId>(new MessageId(messageIdNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MessageId> MessageHeader::getMessageId()
{
   if(!this->messageIdIsNull_){
        if(messageIdIDRef_ != ""){
             return boost::shared_static_cast<MessageId>(IDManager::instance().getID(messageIdIDRef_));
        }else{
             return this->messageId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MessageId>();
   }
}
}

