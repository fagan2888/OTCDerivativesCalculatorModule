// MessageHeader.hpp 
#ifndef FpmlSerialized_MessageHeader_hpp
#define FpmlSerialized_MessageHeader_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class MessageHeader : public ISerialized { 
   public: 
       MessageHeader(TiXmlNode* xmlNode);

       bool isMessageId(){return this->messageIdIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMessageId();


       bool isMessageType(){return this->messageTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMessageType();


       bool isSentBy(){return this->sentByIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSentBy();


       bool isSendTo(){return this->sendToIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSendTo();


       bool isCreationTimestamp(){return this->creationTimestampIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCreationTimestamp();


       bool isIsCorrection(){return this->isCorrectionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIsCorrection();


       bool isCorrelationId(){return this->correlationIdIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCorrelationId();


       bool isSequenceNumber(){return this->sequenceNumberIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSequenceNumber();


   protected: 
       boost::shared_ptr<XsdTypeToken> messageId_;
       
       bool messageIdIsNull_;
       boost::shared_ptr<XsdTypeToken> messageType_;
       
       bool messageTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> sentBy_;
       
       bool sentByIsNull_;
       boost::shared_ptr<XsdTypeToken> sendTo_;
       
       bool sendToIsNull_;
       boost::shared_ptr<XsdTypeToken> creationTimestamp_;
       
       bool creationTimestampIsNull_;
       boost::shared_ptr<XsdTypeToken> isCorrection_;
       
       bool isCorrectionIsNull_;
       boost::shared_ptr<XsdTypeToken> correlationId_;
       
       bool correlationIdIsNull_;
       boost::shared_ptr<XsdTypeToken> sequenceNumber_;
       
       bool sequenceNumberIsNull_;

};

} //namespaceFpmlSerialized end
#endif

