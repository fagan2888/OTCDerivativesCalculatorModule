// SplitSettlement.hpp 
#ifndef FpmlSerialized_SplitSettlement_hpp
#define FpmlSerialized_SplitSettlement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-shared-5-4/Routing.hpp>

namespace FpmlSerialized {

class SplitSettlement : public ISerialized { 
   public: 
       SplitSettlement(TiXmlNode* xmlNode);

       bool isSplitSettlementAmount(){return this->splitSettlementAmountIsNull_;}
       boost::shared_ptr<Money> getSplitSettlementAmount();
      std::string getSplitSettlementAmountIDRef(){return splitSettlementAmountIDRef_;}

       bool isBeneficiaryBank(){return this->beneficiaryBankIsNull_;}
       boost::shared_ptr<Routing> getBeneficiaryBank();
      std::string getBeneficiaryBankIDRef(){return beneficiaryBankIDRef_;}

       bool isBeneficiary(){return this->beneficiaryIsNull_;}
       boost::shared_ptr<Routing> getBeneficiary();
      std::string getBeneficiaryIDRef(){return beneficiaryIDRef_;}

   protected: 
       boost::shared_ptr<Money> splitSettlementAmount_;
       std::string splitSettlementAmountIDRef_;
       bool splitSettlementAmountIsNull_;
       boost::shared_ptr<Routing> beneficiaryBank_;
       std::string beneficiaryBankIDRef_;
       bool beneficiaryBankIsNull_;
       boost::shared_ptr<Routing> beneficiary_;
       std::string beneficiaryIDRef_;
       bool beneficiaryIsNull_;

};

} //namespaceFpmlSerialized end
#endif

