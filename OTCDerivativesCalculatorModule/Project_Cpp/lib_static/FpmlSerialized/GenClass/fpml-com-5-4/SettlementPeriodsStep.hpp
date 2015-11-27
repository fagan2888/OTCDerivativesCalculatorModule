// SettlementPeriodsStep.hpp 
#ifndef FpmlSerialized_SettlementPeriodsStep_hpp
#define FpmlSerialized_SettlementPeriodsStep_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/SettlementPeriodsReference.hpp>

namespace FpmlSerialized {

class SettlementPeriodsStep : public ISerialized { 
   public: 
       SettlementPeriodsStep(TiXmlNode* xmlNode);

       bool isSettlementPeriodsReference(){return this->settlementPeriodsReferenceIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> getSettlementPeriodsReference();
      std::string getSettlementPeriodsReferenceIDRef(){return settlementPeriodsReferenceIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> settlementPeriodsReference_;
       std::string settlementPeriodsReferenceIDRef_;
       bool settlementPeriodsReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

