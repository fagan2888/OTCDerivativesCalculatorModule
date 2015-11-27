// CashSettlementReferenceBanks.hpp 
#ifndef FpmlSerialized_CashSettlementReferenceBanks_hpp
#define FpmlSerialized_CashSettlementReferenceBanks_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ReferenceBank.hpp>

namespace FpmlSerialized {

class CashSettlementReferenceBanks : public ISerialized { 
   public: 
       CashSettlementReferenceBanks(TiXmlNode* xmlNode);

       bool isReferenceBank(){return this->referenceBankIsNull_;}
       std::vector<boost::shared_ptr<ReferenceBank>> getReferenceBank();
      std::string getReferenceBankIDRef(){return referenceBankIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ReferenceBank>> referenceBank_;
       std::string referenceBankIDRef_;
       bool referenceBankIsNull_;

};

} //namespaceFpmlSerialized end
#endif

