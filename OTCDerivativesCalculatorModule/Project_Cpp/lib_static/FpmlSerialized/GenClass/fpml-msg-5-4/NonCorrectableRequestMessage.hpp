// NonCorrectableRequestMessage.hpp 
#ifndef FpmlSerialized_NonCorrectableRequestMessage_hpp
#define FpmlSerialized_NonCorrectableRequestMessage_hpp

#include <fpml-msg-5-4/RequestMessage.hpp>
#include <fpml-msg-5-4/CorrelationId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-shared-5-4/OnBehalfOf.hpp>

namespace FpmlSerialized {

class NonCorrectableRequestMessage : public RequestMessage { 
   public: 
       NonCorrectableRequestMessage(TiXmlNode* xmlNode);

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

