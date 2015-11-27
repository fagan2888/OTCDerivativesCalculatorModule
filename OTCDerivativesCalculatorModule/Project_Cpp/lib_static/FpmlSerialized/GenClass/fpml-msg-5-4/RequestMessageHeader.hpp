// RequestMessageHeader.hpp 
#ifndef FpmlSerialized_RequestMessageHeader_hpp
#define FpmlSerialized_RequestMessageHeader_hpp

#include <fpml-msg-5-4/MessageHeader.hpp>
#include <fpml-msg-5-4/MessageAddress.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>
#include <fpml-msg-5-4/ImplementationSpecification.hpp>
#include <fpml-msg-5-4/PartyMessageInformation.hpp>
#include <xmldsig-core-schema/SignatureType.hpp>

namespace FpmlSerialized {

class RequestMessageHeader : public MessageHeader { 
   public: 
       RequestMessageHeader(TiXmlNode* xmlNode);

       bool isSentBy(){return this->sentByIsNull_;}
       boost::shared_ptr<MessageAddress> getSentBy();
      std::string getSentByIDRef(){return sentByIDRef_;}

       bool isSendTo(){return this->sendToIsNull_;}
       std::vector<boost::shared_ptr<MessageAddress>> getSendTo();
      std::string getSendToIDRef(){return sendToIDRef_;}

       bool isCopyTo(){return this->copyToIsNull_;}
       std::vector<boost::shared_ptr<MessageAddress>> getCopyTo();
      std::string getCopyToIDRef(){return copyToIDRef_;}

       bool isCreationTimestamp(){return this->creationTimestampIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getCreationTimestamp();
      std::string getCreationTimestampIDRef(){return creationTimestampIDRef_;}

       bool isExpiryTimestamp(){return this->expiryTimestampIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getExpiryTimestamp();
      std::string getExpiryTimestampIDRef(){return expiryTimestampIDRef_;}

       bool isImplementationSpecification(){return this->implementationSpecificationIsNull_;}
       boost::shared_ptr<ImplementationSpecification> getImplementationSpecification();
      std::string getImplementationSpecificationIDRef(){return implementationSpecificationIDRef_;}

       bool isPartyMessageInformation(){return this->partyMessageInformationIsNull_;}
       std::vector<boost::shared_ptr<PartyMessageInformation>> getPartyMessageInformation();
      std::string getPartyMessageInformationIDRef(){return partyMessageInformationIDRef_;}

       bool isSignature(){return this->SignatureIsNull_;}
       boost::shared_ptr<SignatureType> getSignature();
      std::string getSignatureIDRef(){return SignatureIDRef_;}

   protected: 
       boost::shared_ptr<MessageAddress> sentBy_;
       std::string sentByIDRef_;
       bool sentByIsNull_;
       std::vector<boost::shared_ptr<MessageAddress>> sendTo_;
       std::string sendToIDRef_;
       bool sendToIsNull_;
       std::vector<boost::shared_ptr<MessageAddress>> copyTo_;
       std::string copyToIDRef_;
       bool copyToIsNull_;
       boost::shared_ptr<XsdTypeDateTime> creationTimestamp_;
       std::string creationTimestampIDRef_;
       bool creationTimestampIsNull_;
       boost::shared_ptr<XsdTypeDateTime> expiryTimestamp_;
       std::string expiryTimestampIDRef_;
       bool expiryTimestampIsNull_;
       boost::shared_ptr<ImplementationSpecification> implementationSpecification_;
       std::string implementationSpecificationIDRef_;
       bool implementationSpecificationIsNull_;
       std::vector<boost::shared_ptr<PartyMessageInformation>> partyMessageInformation_;
       std::string partyMessageInformationIDRef_;
       bool partyMessageInformationIsNull_;
       boost::shared_ptr<SignatureType> Signature_;
       std::string SignatureIDRef_;
       bool SignatureIsNull_;

};

} //namespaceFpmlSerialized end
#endif

