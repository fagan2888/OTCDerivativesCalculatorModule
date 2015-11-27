// RequestMessage.hpp 
#ifndef FpmlSerialized_RequestMessage_hpp
#define FpmlSerialized_RequestMessage_hpp

#include <fpml-msg-5-4/Message.hpp>
#include <fpml-msg-5-4/RequestMessageHeader.hpp>
#include <fpml-doc-5-4/Validation.hpp>

namespace FpmlSerialized {

class RequestMessage : public Message { 
   public: 
       RequestMessage(TiXmlNode* xmlNode);

       bool isHeader(){return this->headerIsNull_;}
       boost::shared_ptr<RequestMessageHeader> getHeader();
      std::string getHeaderIDRef(){return headerIDRef_;}

       bool isValidation(){return this->validationIsNull_;}
       std::vector<boost::shared_ptr<Validation>> getValidation();
      std::string getValidationIDRef(){return validationIDRef_;}

   protected: 
       boost::shared_ptr<RequestMessageHeader> header_;
       std::string headerIDRef_;
       bool headerIsNull_;
       std::vector<boost::shared_ptr<Validation>> validation_;
       std::string validationIDRef_;
       bool validationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

