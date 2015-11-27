// CorrectableRequestMessage.hpp 
#ifndef FpmlSerialized_CorrectableRequestMessage_hpp
#define FpmlSerialized_CorrectableRequestMessage_hpp

#include <fpml-msg-5-4/RequestMessage.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-msg-5-4/CorrelationId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-shared-5-4/OnBehalfOf.hpp>

namespace FpmlSerialized {

class CorrectableRequestMessage : public RequestMessage { 
   public: 
       CorrectableRequestMessage(TiXmlNode* xmlNode);

       bool isIsCorrection(){return this->isCorrectionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsCorrection();
      std::string getIsCorrectionIDRef(){return isCorrectionIDRef_;}

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
       boost::shared_ptr<XsdTypeBoolean> isCorrection_;
       std::string isCorrectionIDRef_;
       bool isCorrectionIsNull_;
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

