// Exception.hpp 
#ifndef FpmlSerialized_Exception_hpp
#define FpmlSerialized_Exception_hpp

#include <fpml-msg-5-4/Message.hpp>
#include <fpml-msg-5-4/ExceptionMessageHeader.hpp>
#include <fpml-doc-5-4/Validation.hpp>
#include <fpml-msg-5-4/CorrelationId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-msg-5-4/Reason.hpp>
#include <fpml-msg-5-4/AdditionalData.hpp>

namespace FpmlSerialized {

class Exception : public Message { 
   public: 
       Exception(TiXmlNode* xmlNode);

       bool isHeader(){return this->headerIsNull_;}
       boost::shared_ptr<ExceptionMessageHeader> getHeader();
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

       bool isReason(){return this->reasonIsNull_;}
       std::vector<boost::shared_ptr<Reason>> getReason();
      std::string getReasonIDRef(){return reasonIDRef_;}

       bool isAdditionalData(){return this->additionalDataIsNull_;}
       boost::shared_ptr<AdditionalData> getAdditionalData();
      std::string getAdditionalDataIDRef(){return additionalDataIDRef_;}

   protected: 
       boost::shared_ptr<ExceptionMessageHeader> header_;
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
       std::vector<boost::shared_ptr<Reason>> reason_;
       std::string reasonIDRef_;
       bool reasonIsNull_;
       boost::shared_ptr<AdditionalData> additionalData_;
       std::string additionalDataIDRef_;
       bool additionalDataIsNull_;

};

} //namespaceFpmlSerialized end
#endif

