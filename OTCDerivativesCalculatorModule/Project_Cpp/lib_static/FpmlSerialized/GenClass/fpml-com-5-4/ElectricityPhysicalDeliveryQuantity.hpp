// ElectricityPhysicalDeliveryQuantity.hpp 
#ifndef FpmlSerialized_ElectricityPhysicalDeliveryQuantity_hpp
#define FpmlSerialized_ElectricityPhysicalDeliveryQuantity_hpp

#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/SettlementPeriodsReference.hpp>

namespace FpmlSerialized {

class ElectricityPhysicalDeliveryQuantity : public CommodityNotionalQuantity { 
   public: 
       ElectricityPhysicalDeliveryQuantity(TiXmlNode* xmlNode);

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

