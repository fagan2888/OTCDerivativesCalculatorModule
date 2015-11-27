// FloatingAmountEvents.hpp 
#ifndef FpmlSerialized_FloatingAmountEvents_hpp
#define FpmlSerialized_FloatingAmountEvents_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-cd-5-4/InterestShortFall.hpp>
#include <fpml-cd-5-4/FloatingAmountProvisions.hpp>
#include <fpml-cd-5-4/AdditionalFixedPayments.hpp>

namespace FpmlSerialized {

class FloatingAmountEvents : public ISerialized { 
   public: 
       FloatingAmountEvents(TiXmlNode* xmlNode);

       bool isFailureToPayPrincipal(){return this->failureToPayPrincipalIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFailureToPayPrincipal();
      std::string getFailureToPayPrincipalIDRef(){return failureToPayPrincipalIDRef_;}

       bool isInterestShortfall(){return this->interestShortfallIsNull_;}
       boost::shared_ptr<InterestShortFall> getInterestShortfall();
      std::string getInterestShortfallIDRef(){return interestShortfallIDRef_;}

       bool isWritedown(){return this->writedownIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getWritedown();
      std::string getWritedownIDRef(){return writedownIDRef_;}

       bool isImpliedWritedown(){return this->impliedWritedownIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getImpliedWritedown();
      std::string getImpliedWritedownIDRef(){return impliedWritedownIDRef_;}

       bool isFloatingAmountProvisions(){return this->floatingAmountProvisionsIsNull_;}
       boost::shared_ptr<FloatingAmountProvisions> getFloatingAmountProvisions();
      std::string getFloatingAmountProvisionsIDRef(){return floatingAmountProvisionsIDRef_;}

       bool isAdditionalFixedPayments(){return this->additionalFixedPaymentsIsNull_;}
       boost::shared_ptr<AdditionalFixedPayments> getAdditionalFixedPayments();
      std::string getAdditionalFixedPaymentsIDRef(){return additionalFixedPaymentsIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> failureToPayPrincipal_;
       std::string failureToPayPrincipalIDRef_;
       bool failureToPayPrincipalIsNull_;
       boost::shared_ptr<InterestShortFall> interestShortfall_;
       std::string interestShortfallIDRef_;
       bool interestShortfallIsNull_;
       boost::shared_ptr<XsdTypeBoolean> writedown_;
       std::string writedownIDRef_;
       bool writedownIsNull_;
       boost::shared_ptr<XsdTypeBoolean> impliedWritedown_;
       std::string impliedWritedownIDRef_;
       bool impliedWritedownIsNull_;
       boost::shared_ptr<FloatingAmountProvisions> floatingAmountProvisions_;
       std::string floatingAmountProvisionsIDRef_;
       bool floatingAmountProvisionsIsNull_;
       boost::shared_ptr<AdditionalFixedPayments> additionalFixedPayments_;
       std::string additionalFixedPaymentsIDRef_;
       bool additionalFixedPaymentsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

