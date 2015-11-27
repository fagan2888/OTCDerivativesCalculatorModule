// SettlementInstruction.hpp 
#ifndef FpmlSerialized_SettlementInstruction_hpp
#define FpmlSerialized_SettlementInstruction_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/SettlementMethod.hpp>
#include <fpml-shared-5-4/CorrespondentInformation.hpp>
#include <fpml-shared-5-4/IntermediaryInformation.hpp>
#include <fpml-shared-5-4/Beneficiary.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/SplitSettlement.hpp>

namespace FpmlSerialized {

class SettlementInstruction : public ISerialized { 
   public: 
       SettlementInstruction(TiXmlNode* xmlNode);

       bool isSettlementMethod(){return this->settlementMethodIsNull_;}
       boost::shared_ptr<SettlementMethod> getSettlementMethod();
      std::string getSettlementMethodIDRef(){return settlementMethodIDRef_;}

       bool isCorrespondentInformation(){return this->correspondentInformationIsNull_;}
       boost::shared_ptr<CorrespondentInformation> getCorrespondentInformation();
      std::string getCorrespondentInformationIDRef(){return correspondentInformationIDRef_;}

       bool isIntermediaryInformation(){return this->intermediaryInformationIsNull_;}
       std::vector<boost::shared_ptr<IntermediaryInformation>> getIntermediaryInformation();
      std::string getIntermediaryInformationIDRef(){return intermediaryInformationIDRef_;}

       bool isBeneficiaryBank(){return this->beneficiaryBankIsNull_;}
       boost::shared_ptr<Beneficiary> getBeneficiaryBank();
      std::string getBeneficiaryBankIDRef(){return beneficiaryBankIDRef_;}

       bool isBeneficiary(){return this->beneficiaryIsNull_;}
       boost::shared_ptr<Beneficiary> getBeneficiary();
      std::string getBeneficiaryIDRef(){return beneficiaryIDRef_;}

       bool isDepositoryPartyReference(){return this->depositoryPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getDepositoryPartyReference();
      std::string getDepositoryPartyReferenceIDRef(){return depositoryPartyReferenceIDRef_;}

       bool isSplitSettlement(){return this->splitSettlementIsNull_;}
       std::vector<boost::shared_ptr<SplitSettlement>> getSplitSettlement();
      std::string getSplitSettlementIDRef(){return splitSettlementIDRef_;}

   protected: 
       boost::shared_ptr<SettlementMethod> settlementMethod_;
       std::string settlementMethodIDRef_;
       bool settlementMethodIsNull_;
       boost::shared_ptr<CorrespondentInformation> correspondentInformation_;
       std::string correspondentInformationIDRef_;
       bool correspondentInformationIsNull_;
       std::vector<boost::shared_ptr<IntermediaryInformation>> intermediaryInformation_;
       std::string intermediaryInformationIDRef_;
       bool intermediaryInformationIsNull_;
       boost::shared_ptr<Beneficiary> beneficiaryBank_;
       std::string beneficiaryBankIDRef_;
       bool beneficiaryBankIsNull_;
       boost::shared_ptr<Beneficiary> beneficiary_;
       std::string beneficiaryIDRef_;
       bool beneficiaryIsNull_;
       boost::shared_ptr<PartyReference> depositoryPartyReference_;
       std::string depositoryPartyReferenceIDRef_;
       bool depositoryPartyReferenceIsNull_;
       std::vector<boost::shared_ptr<SplitSettlement>> splitSettlement_;
       std::string splitSettlementIDRef_;
       bool splitSettlementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

