// FailureToPay.hpp 
#ifndef FpmlSerialized_FailureToPay_hpp
#define FpmlSerialized_FailureToPay_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-option-shared-5-4/GracePeriodExtension.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class FailureToPay : public ISerialized { 
   public: 
       FailureToPay(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isGracePeriodExtension(){return this->gracePeriodExtensionIsNull_;}
       boost::shared_ptr<GracePeriodExtension> getGracePeriodExtension();
      std::string getGracePeriodExtensionIDRef(){return gracePeriodExtensionIDRef_;}

       bool isPaymentRequirement(){return this->paymentRequirementIsNull_;}
       boost::shared_ptr<Money> getPaymentRequirement();
      std::string getPaymentRequirementIDRef(){return paymentRequirementIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       boost::shared_ptr<GracePeriodExtension> gracePeriodExtension_;
       std::string gracePeriodExtensionIDRef_;
       bool gracePeriodExtensionIsNull_;
       boost::shared_ptr<Money> paymentRequirement_;
       std::string paymentRequirementIDRef_;
       bool paymentRequirementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

