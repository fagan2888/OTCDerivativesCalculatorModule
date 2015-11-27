// DirectionalLeg.hpp 
#ifndef FpmlSerialized_DirectionalLeg_hpp
#define FpmlSerialized_DirectionalLeg_hpp

#include <fpml-shared-5-4/Leg.hpp>
#include <fpml-eq-shared-5-4/LegIdentifier.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class DirectionalLeg : public Leg { 
   public: 
       DirectionalLeg(TiXmlNode* xmlNode);

       bool isLegIdentifier(){return this->legIdentifierIsNull_;}
       std::vector<boost::shared_ptr<LegIdentifier>> getLegIdentifier();
      std::string getLegIdentifierIDRef(){return legIdentifierIDRef_;}

       bool isPayerPartyReference(){return this->payerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPayerPartyReference();
      std::string getPayerPartyReferenceIDRef(){return payerPartyReferenceIDRef_;}

       bool isPayerAccountReference(){return this->payerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getPayerAccountReference();
      std::string getPayerAccountReferenceIDRef(){return payerAccountReferenceIDRef_;}

       bool isReceiverPartyReference(){return this->receiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getReceiverPartyReference();
      std::string getReceiverPartyReferenceIDRef(){return receiverPartyReferenceIDRef_;}

       bool isReceiverAccountReference(){return this->receiverAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getReceiverAccountReference();
      std::string getReceiverAccountReferenceIDRef(){return receiverAccountReferenceIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isTerminationDate(){return this->terminationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getTerminationDate();
      std::string getTerminationDateIDRef(){return terminationDateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<LegIdentifier>> legIdentifier_;
       std::string legIdentifierIDRef_;
       bool legIdentifierIsNull_;
       boost::shared_ptr<PartyReference> payerPartyReference_;
       std::string payerPartyReferenceIDRef_;
       bool payerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> payerAccountReference_;
       std::string payerAccountReferenceIDRef_;
       bool payerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> receiverPartyReference_;
       std::string receiverPartyReferenceIDRef_;
       bool receiverPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> receiverAccountReference_;
       std::string receiverAccountReferenceIDRef_;
       bool receiverAccountReferenceIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> terminationDate_;
       std::string terminationDateIDRef_;
       bool terminationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

