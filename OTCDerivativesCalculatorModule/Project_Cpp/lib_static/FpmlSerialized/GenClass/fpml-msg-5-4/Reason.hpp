// Reason.hpp 
#ifndef FpmlSerialized_Reason_hpp
#define FpmlSerialized_Reason_hpp

#include <ISerialized.hpp>
#include <fpml-msg-5-4/ReasonCode.hpp>
#include <fpml-msg-5-4/ProblemLocation.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-doc-5-4/Validation.hpp>
#include <fpml-msg-5-4/AdditionalData.hpp>

namespace FpmlSerialized {

class Reason : public ISerialized { 
   public: 
       Reason(TiXmlNode* xmlNode);

       bool isReasonCode(){return this->reasonCodeIsNull_;}
       boost::shared_ptr<ReasonCode> getReasonCode();
      std::string getReasonCodeIDRef(){return reasonCodeIDRef_;}

       bool isLocation(){return this->locationIsNull_;}
       boost::shared_ptr<ProblemLocation> getLocation();
      std::string getLocationIDRef(){return locationIDRef_;}

       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeString> getDescription();
      std::string getDescriptionIDRef(){return descriptionIDRef_;}

       bool isValidationRuleId(){return this->validationRuleIdIsNull_;}
       boost::shared_ptr<Validation> getValidationRuleId();
      std::string getValidationRuleIdIDRef(){return validationRuleIdIDRef_;}

       bool isAdditionalData(){return this->additionalDataIsNull_;}
       std::vector<boost::shared_ptr<AdditionalData>> getAdditionalData();
      std::string getAdditionalDataIDRef(){return additionalDataIDRef_;}

   protected: 
       boost::shared_ptr<ReasonCode> reasonCode_;
       std::string reasonCodeIDRef_;
       bool reasonCodeIsNull_;
       boost::shared_ptr<ProblemLocation> location_;
       std::string locationIDRef_;
       bool locationIsNull_;
       boost::shared_ptr<XsdTypeString> description_;
       std::string descriptionIDRef_;
       bool descriptionIsNull_;
       boost::shared_ptr<Validation> validationRuleId_;
       std::string validationRuleIdIDRef_;
       bool validationRuleIdIsNull_;
       std::vector<boost::shared_ptr<AdditionalData>> additionalData_;
       std::string additionalDataIDRef_;
       bool additionalDataIsNull_;

};

} //namespaceFpmlSerialized end
#endif

