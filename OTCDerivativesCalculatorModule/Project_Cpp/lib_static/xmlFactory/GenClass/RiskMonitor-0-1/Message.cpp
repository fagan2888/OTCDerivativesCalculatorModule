// Message.cpp 
#include "Message.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Message::Message(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //messageHeaderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* messageHeaderNode = xmlNode->FirstChildElement("messageHeader");

   if(messageHeaderNode){messageHeaderIsNull_ = false;}
   else{messageHeaderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- messageHeaderNode , address : " << messageHeaderNode << std::endl;
   #endif
   if(messageHeaderNode)
   {
       messageHeader_ = boost::shared_ptr<MessageHeader>(new MessageHeader(messageHeaderNode));
   }

   //messageBodyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* messageBodyNode = xmlNode->FirstChildElement("messageBody");

   if(messageBodyNode){messageBodyIsNull_ = false;}
   else{messageBodyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- messageBodyNode , address : " << messageBodyNode << std::endl;
   #endif
   if(messageBodyNode)
   {
       messageBody_ = boost::shared_ptr<MessageBody>(new MessageBody(messageBodyNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MessageHeader> Message::getMessageHeader()
{
   if(!this->messageHeaderIsNull_){
        return this->messageHeader_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MessageHeader>();
   }
}
boost::shared_ptr<MessageBody> Message::getMessageBody()
{
   if(!this->messageBodyIsNull_){
        return this->messageBody_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MessageBody>();
   }
}
}

