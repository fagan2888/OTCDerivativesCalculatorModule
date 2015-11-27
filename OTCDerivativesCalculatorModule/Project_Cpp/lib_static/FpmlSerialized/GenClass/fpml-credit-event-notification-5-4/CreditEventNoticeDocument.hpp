// CreditEventNoticeDocument.hpp 
#ifndef FpmlSerialized_CreditEventNoticeDocument_hpp
#define FpmlSerialized_CreditEventNoticeDocument_hpp

#include <ISerialized.hpp>
#include <fpml-credit-event-notification-5-4/AffectedTransactions.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-credit-event-notification-5-4/CreditEvent.hpp>
#include <fpml-credit-event-notification-5-4/BankruptcyEvent.hpp>
#include <fpml-credit-event-notification-5-4/FailureToPayEvent.hpp>
#include <fpml-credit-event-notification-5-4/ObligationAccelerationEvent.hpp>
#include <fpml-credit-event-notification-5-4/ObligationDefaultEvent.hpp>
#include <fpml-credit-event-notification-5-4/RepudiationMoratoriumEvent.hpp>
#include <fpml-credit-event-notification-5-4/RestructuringEvent.hpp>
#include <fpml-shared-5-4/Resource.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class CreditEventNoticeDocument : public ISerialized { 
   public: 
       CreditEventNoticeDocument(TiXmlNode* xmlNode);

       bool isAffectedTransactions(){return this->affectedTransactionsIsNull_;}
       boost::shared_ptr<AffectedTransactions> getAffectedTransactions();
      std::string getAffectedTransactionsIDRef(){return affectedTransactionsIDRef_;}

       bool isReferenceEntity(){return this->referenceEntityIsNull_;}
       boost::shared_ptr<LegalEntity> getReferenceEntity();
      std::string getReferenceEntityIDRef(){return referenceEntityIDRef_;}

       bool isCreditEvent(){return this->creditEventIsNull_;}
       boost::shared_ptr<CreditEvent> getCreditEvent();
      std::string getCreditEventIDRef(){return creditEventIDRef_;}

       bool isBankruptcy(){return this->bankruptcyIsNull_;}
       boost::shared_ptr<BankruptcyEvent> getBankruptcy();
      std::string getBankruptcyIDRef(){return bankruptcyIDRef_;}

       bool isFailureToPay(){return this->failureToPayIsNull_;}
       boost::shared_ptr<FailureToPayEvent> getFailureToPay();
      std::string getFailureToPayIDRef(){return failureToPayIDRef_;}

       bool isObligationAcceleration(){return this->obligationAccelerationIsNull_;}
       boost::shared_ptr<ObligationAccelerationEvent> getObligationAcceleration();
      std::string getObligationAccelerationIDRef(){return obligationAccelerationIDRef_;}

       bool isObligationDefault(){return this->obligationDefaultIsNull_;}
       boost::shared_ptr<ObligationDefaultEvent> getObligationDefault();
      std::string getObligationDefaultIDRef(){return obligationDefaultIDRef_;}

       bool isRepudiationMoratorium(){return this->repudiationMoratoriumIsNull_;}
       boost::shared_ptr<RepudiationMoratoriumEvent> getRepudiationMoratorium();
      std::string getRepudiationMoratoriumIDRef(){return repudiationMoratoriumIDRef_;}

       bool isRestructuring(){return this->restructuringIsNull_;}
       boost::shared_ptr<RestructuringEvent> getRestructuring();
      std::string getRestructuringIDRef(){return restructuringIDRef_;}

       bool isPubliclyAvailableInformation(){return this->publiclyAvailableInformationIsNull_;}
       std::vector<boost::shared_ptr<Resource>> getPubliclyAvailableInformation();
      std::string getPubliclyAvailableInformationIDRef(){return publiclyAvailableInformationIDRef_;}

       bool isNotifyingPartyReference(){return this->notifyingPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getNotifyingPartyReference();
      std::string getNotifyingPartyReferenceIDRef(){return notifyingPartyReferenceIDRef_;}

       bool isNotifiedPartyReference(){return this->notifiedPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getNotifiedPartyReference();
      std::string getNotifiedPartyReferenceIDRef(){return notifiedPartyReferenceIDRef_;}

       bool isCreditEventNoticeDate(){return this->creditEventNoticeDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCreditEventNoticeDate();
      std::string getCreditEventNoticeDateIDRef(){return creditEventNoticeDateIDRef_;}

       bool isCreditEventDate(){return this->creditEventDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCreditEventDate();
      std::string getCreditEventDateIDRef(){return creditEventDateIDRef_;}

   protected: 
       boost::shared_ptr<AffectedTransactions> affectedTransactions_;
       std::string affectedTransactionsIDRef_;
       bool affectedTransactionsIsNull_;
       boost::shared_ptr<LegalEntity> referenceEntity_;
       std::string referenceEntityIDRef_;
       bool referenceEntityIsNull_;
       boost::shared_ptr<CreditEvent> creditEvent_;
       std::string creditEventIDRef_;
       bool creditEventIsNull_;
       boost::shared_ptr<BankruptcyEvent> bankruptcy_;     //substitude 
       std::string bankruptcyIDRef_;
       bool bankruptcyIsNull_;
       boost::shared_ptr<FailureToPayEvent> failureToPay_;     //substitude 
       std::string failureToPayIDRef_;
       bool failureToPayIsNull_;
       boost::shared_ptr<ObligationAccelerationEvent> obligationAcceleration_;     //substitude 
       std::string obligationAccelerationIDRef_;
       bool obligationAccelerationIsNull_;
       boost::shared_ptr<ObligationDefaultEvent> obligationDefault_;     //substitude 
       std::string obligationDefaultIDRef_;
       bool obligationDefaultIsNull_;
       boost::shared_ptr<RepudiationMoratoriumEvent> repudiationMoratorium_;     //substitude 
       std::string repudiationMoratoriumIDRef_;
       bool repudiationMoratoriumIsNull_;
       boost::shared_ptr<RestructuringEvent> restructuring_;     //substitude 
       std::string restructuringIDRef_;
       bool restructuringIsNull_;
       std::vector<boost::shared_ptr<Resource>> publiclyAvailableInformation_;
       std::string publiclyAvailableInformationIDRef_;
       bool publiclyAvailableInformationIsNull_;
       boost::shared_ptr<PartyReference> notifyingPartyReference_;
       std::string notifyingPartyReferenceIDRef_;
       bool notifyingPartyReferenceIsNull_;
       boost::shared_ptr<PartyReference> notifiedPartyReference_;
       std::string notifiedPartyReferenceIDRef_;
       bool notifiedPartyReferenceIsNull_;
       boost::shared_ptr<XsdTypeDate> creditEventNoticeDate_;
       std::string creditEventNoticeDateIDRef_;
       bool creditEventNoticeDateIsNull_;
       boost::shared_ptr<XsdTypeDate> creditEventDate_;
       std::string creditEventDateIDRef_;
       bool creditEventDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

