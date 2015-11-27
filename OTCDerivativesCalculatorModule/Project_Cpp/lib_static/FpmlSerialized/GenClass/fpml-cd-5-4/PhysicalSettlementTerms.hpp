// PhysicalSettlementTerms.hpp 
#ifndef FpmlSerialized_PhysicalSettlementTerms_hpp
#define FpmlSerialized_PhysicalSettlementTerms_hpp

#include <fpml-cd-5-4/SettlementTerms.hpp>
#include <fpml-cd-5-4/PhysicalSettlementPeriod.hpp>
#include <fpml-cd-5-4/DeliverableObligations.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class PhysicalSettlementTerms : public SettlementTerms { 
   public: 
       PhysicalSettlementTerms(TiXmlNode* xmlNode);

       bool isPhysicalSettlementPeriod(){return this->physicalSettlementPeriodIsNull_;}
       boost::shared_ptr<PhysicalSettlementPeriod> getPhysicalSettlementPeriod();
      std::string getPhysicalSettlementPeriodIDRef(){return physicalSettlementPeriodIDRef_;}

       bool isDeliverableObligations(){return this->deliverableObligationsIsNull_;}
       boost::shared_ptr<DeliverableObligations> getDeliverableObligations();
      std::string getDeliverableObligationsIDRef(){return deliverableObligationsIDRef_;}

       bool isEscrow(){return this->escrowIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getEscrow();
      std::string getEscrowIDRef(){return escrowIDRef_;}

       bool isSixtyBusinessDaySettlementCap(){return this->sixtyBusinessDaySettlementCapIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSixtyBusinessDaySettlementCap();
      std::string getSixtyBusinessDaySettlementCapIDRef(){return sixtyBusinessDaySettlementCapIDRef_;}

   protected: 
       boost::shared_ptr<PhysicalSettlementPeriod> physicalSettlementPeriod_;
       std::string physicalSettlementPeriodIDRef_;
       bool physicalSettlementPeriodIsNull_;
       boost::shared_ptr<DeliverableObligations> deliverableObligations_;
       std::string deliverableObligationsIDRef_;
       bool deliverableObligationsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> escrow_;
       std::string escrowIDRef_;
       bool escrowIsNull_;
       boost::shared_ptr<XsdTypeBoolean> sixtyBusinessDaySettlementCap_;
       std::string sixtyBusinessDaySettlementCapIDRef_;
       bool sixtyBusinessDaySettlementCapIsNull_;

};

} //namespaceFpmlSerialized end
#endif

