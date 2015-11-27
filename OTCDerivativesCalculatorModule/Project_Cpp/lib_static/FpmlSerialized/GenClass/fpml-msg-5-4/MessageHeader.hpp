// MessageHeader.hpp 
#ifndef FpmlSerialized_MessageHeader_hpp
#define FpmlSerialized_MessageHeader_hpp

#include <ISerialized.hpp>
#include <fpml-msg-5-4/MessageId.hpp>

namespace FpmlSerialized {

class MessageHeader : public ISerialized { 
   public: 
       MessageHeader(TiXmlNode* xmlNode);

       bool isMessageId(){return this->messageIdIsNull_;}
       boost::shared_ptr<MessageId> getMessageId();
      std::string getMessageIdIDRef(){return messageIdIDRef_;}

   protected: 
       boost::shared_ptr<MessageId> messageId_;
       std::string messageIdIDRef_;
       bool messageIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif

