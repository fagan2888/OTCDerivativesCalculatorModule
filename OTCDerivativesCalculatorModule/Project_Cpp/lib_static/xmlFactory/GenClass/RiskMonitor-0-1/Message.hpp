// Message.hpp 
#ifndef FpmlSerialized_Message_hpp
#define FpmlSerialized_Message_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/MessageHeader.hpp>
#include <RiskMonitor-0-1/MessageBody.hpp>

namespace FpmlSerialized {

class Message : public ISerialized { 
   public: 
       Message(TiXmlNode* xmlNode);

       bool isMessageHeader(){return this->messageHeaderIsNull_;}
       boost::shared_ptr<MessageHeader> getMessageHeader();


       bool isMessageBody(){return this->messageBodyIsNull_;}
       boost::shared_ptr<MessageBody> getMessageBody();


   protected: 
       boost::shared_ptr<MessageHeader> messageHeader_;
       
       bool messageHeaderIsNull_;
       boost::shared_ptr<MessageBody> messageBody_;
       
       bool messageBodyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

