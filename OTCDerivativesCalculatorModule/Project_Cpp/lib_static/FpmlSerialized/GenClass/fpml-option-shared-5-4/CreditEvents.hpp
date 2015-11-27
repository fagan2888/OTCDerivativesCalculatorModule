// CreditEvents.hpp 
#ifndef FpmlSerialized_CreditEvents_hpp
#define FpmlSerialized_CreditEvents_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-option-shared-5-4/FailureToPay.hpp>
#include <fpml-option-shared-5-4/Restructuring.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-option-shared-5-4/CreditEventNotice.hpp>

namespace FpmlSerialized {

class CreditEvents : public ISerialized { 
   public: 
       CreditEvents(TiXmlNode* xmlNode);

       bool isBankruptcy(){return this->bankruptcyIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getBankruptcy();
      std::string getBankruptcyIDRef(){return bankruptcyIDRef_;}

       bool isFailureToPay(){return this->failureToPayIsNull_;}
       boost::shared_ptr<FailureToPay> getFailureToPay();
      std::string getFailureToPayIDRef(){return failureToPayIDRef_;}

       bool isFailureToPayPrincipal(){return this->failureToPayPrincipalIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFailureToPayPrincipal();
      std::string getFailureToPayPrincipalIDRef(){return failureToPayPrincipalIDRef_;}

       bool isFailureToPayInterest(){return this->failureToPayInterestIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFailureToPayInterest();
      std::string getFailureToPayInterestIDRef(){return failureToPayInterestIDRef_;}

       bool isObligationDefault(){return this->obligationDefaultIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getObligationDefault();
      std::string getObligationDefaultIDRef(){return obligationDefaultIDRef_;}

       bool isObligationAcceleration(){return this->obligationAccelerationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getObligationAcceleration();
      std::string getObligationAccelerationIDRef(){return obligationAccelerationIDRef_;}

       bool isRepudiationMoratorium(){return this->repudiationMoratoriumIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getRepudiationMoratorium();
      std::string getRepudiationMoratoriumIDRef(){return repudiationMoratoriumIDRef_;}

       bool isRestructuring(){return this->restructuringIsNull_;}
       boost::shared_ptr<Restructuring> getRestructuring();
      std::string getRestructuringIDRef(){return restructuringIDRef_;}

       bool isDistressedRatingsDowngrade(){return this->distressedRatingsDowngradeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDistressedRatingsDowngrade();
      std::string getDistressedRatingsDowngradeIDRef(){return distressedRatingsDowngradeIDRef_;}

       bool isMaturityExtension(){return this->maturityExtensionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMaturityExtension();
      std::string getMaturityExtensionIDRef(){return maturityExtensionIDRef_;}

       bool isWritedown(){return this->writedownIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getWritedown();
      std::string getWritedownIDRef(){return writedownIDRef_;}

       bool isImpliedWritedown(){return this->impliedWritedownIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getImpliedWritedown();
      std::string getImpliedWritedownIDRef(){return impliedWritedownIDRef_;}

       bool isDefaultRequirement(){return this->defaultRequirementIsNull_;}
       boost::shared_ptr<Money> getDefaultRequirement();
      std::string getDefaultRequirementIDRef(){return defaultRequirementIDRef_;}

       bool isCreditEventNotice(){return this->creditEventNoticeIsNull_;}
       boost::shared_ptr<CreditEventNotice> getCreditEventNotice();
      std::string getCreditEventNoticeIDRef(){return creditEventNoticeIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> bankruptcy_;
       std::string bankruptcyIDRef_;
       bool bankruptcyIsNull_;
       boost::shared_ptr<FailureToPay> failureToPay_;
       std::string failureToPayIDRef_;
       bool failureToPayIsNull_;
       boost::shared_ptr<XsdTypeBoolean> failureToPayPrincipal_;
       std::string failureToPayPrincipalIDRef_;
       bool failureToPayPrincipalIsNull_;
       boost::shared_ptr<XsdTypeBoolean> failureToPayInterest_;
       std::string failureToPayInterestIDRef_;
       bool failureToPayInterestIsNull_;
       boost::shared_ptr<XsdTypeBoolean> obligationDefault_;
       std::string obligationDefaultIDRef_;
       bool obligationDefaultIsNull_;
       boost::shared_ptr<XsdTypeBoolean> obligationAcceleration_;
       std::string obligationAccelerationIDRef_;
       bool obligationAccelerationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> repudiationMoratorium_;
       std::string repudiationMoratoriumIDRef_;
       bool repudiationMoratoriumIsNull_;
       boost::shared_ptr<Restructuring> restructuring_;
       std::string restructuringIDRef_;
       bool restructuringIsNull_;
       boost::shared_ptr<XsdTypeBoolean> distressedRatingsDowngrade_;
       std::string distressedRatingsDowngradeIDRef_;
       bool distressedRatingsDowngradeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> maturityExtension_;
       std::string maturityExtensionIDRef_;
       bool maturityExtensionIsNull_;
       boost::shared_ptr<XsdTypeBoolean> writedown_;
       std::string writedownIDRef_;
       bool writedownIsNull_;
       boost::shared_ptr<XsdTypeBoolean> impliedWritedown_;
       std::string impliedWritedownIDRef_;
       bool impliedWritedownIsNull_;
       boost::shared_ptr<Money> defaultRequirement_;
       std::string defaultRequirementIDRef_;
       bool defaultRequirementIsNull_;
       boost::shared_ptr<CreditEventNotice> creditEventNotice_;
       std::string creditEventNoticeIDRef_;
       bool creditEventNoticeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

