// PCDeliverableObligationCharac.hpp 
#ifndef FpmlSerialized_PCDeliverableObligationCharac_hpp
#define FpmlSerialized_PCDeliverableObligationCharac_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class PCDeliverableObligationCharac : public ISerialized { 
   public: 
       PCDeliverableObligationCharac(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isPartialCashSettlement(){return this->partialCashSettlementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPartialCashSettlement();
      std::string getPartialCashSettlementIDRef(){return partialCashSettlementIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       boost::shared_ptr<XsdTypeBoolean> partialCashSettlement_;
       std::string partialCashSettlementIDRef_;
       bool partialCashSettlementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

