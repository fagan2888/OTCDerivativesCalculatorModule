// NotificationMessage.hpp 
#ifndef FpmlSerialized_NotificationMessage_hpp
#define FpmlSerialized_NotificationMessage_hpp

#include <fpml-msg-5-4/Message.hpp>
#include <fpml-msg-5-4/NotificationMessageHeader.hpp>
#include <fpml-doc-5-4/Validation.hpp>
#include <fpml-msg-5-4/CorrelationId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-shared-5-4/OnBehalfOf.hpp>

namespace FpmlSerialized {

class NotificationMessage : public Message { 
   public: 
       NotificationMessage(TiXmlNode* xmlNode);

       bool isHeader(){return this->headerIsNull_;}
       boost::shared_ptr<NotificationMessageHeader> getHeader();
      std::string getHeaderIDRef(){return headerIDRef_;}

       bool isValidation(){return this->validationIsNull_;}
       std::vector<boost::shared_ptr<Validation>> getValidation();
      std::string getValidationIDRef(){return validationIDRef_;}

       bool isParentCorrelationId(){return this->parentCorrelationIdIsNull_;}
       boost::shared_ptr<CorrelationId> getParentCorrelationId();
      std::string getParentCorrelationIdIDRef(){return parentCorrelationIdIDRef_;}

       bool isCorrelationId(){return this->correlationIdIsNull_;}
       boost::shared_ptr<CorrelationId> getCorrelationId();
      std::string getCorrelationIdIDRef(){return correlationIdIDRef_;}

       bool isSequenceNumber(){return this->sequenceNumberIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getSequenceNumber();
      std::string getSequenceNumberIDRef(){return sequenceNumberIDRef_;}

       bool isOnBehalfOf(){return this->onBehalfOfIsNull_;}
       boost::shared_ptr<OnBehalfOf> getOnBehalfOf();
      std::string getOnBehalfOfIDRef(){return onBehalfOfIDRef_;}

   protected: 
       boost::shared_ptr<NotificationMessageHeader> header_;
       std::string headerIDRef_;
       bool headerIsNull_;
       std::vector<boost::shared_ptr<Validation>> validation_;
       std::string validationIDRef_;
       bool validationIsNull_;
       boost::shared_ptr<CorrelationId> parentCorrelationId_;
       std::string parentCorrelationIdIDRef_;
       bool parentCorrelationIdIsNull_;
       boost::shared_ptr<CorrelationId> correlationId_;
       std::string correlationIdIDRef_;
       bool correlationIdIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> sequenceNumber_;
       std::string sequenceNumberIDRef_;
       bool sequenceNumberIsNull_;
       boost::shared_ptr<OnBehalfOf> onBehalfOf_;
       std::string onBehalfOfIDRef_;
       bool onBehalfOfIsNull_;

};

} //namespaceFpmlSerialized end
#endif

