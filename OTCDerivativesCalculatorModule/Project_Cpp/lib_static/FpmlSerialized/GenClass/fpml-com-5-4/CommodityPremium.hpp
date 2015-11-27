// CommodityPremium.hpp 
#ifndef FpmlSerialized_CommodityPremium_hpp
#define FpmlSerialized_CommodityPremium_hpp

#include <fpml-shared-5-4/NonNegativePayment.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class CommodityPremium : public NonNegativePayment { 
   public: 
       CommodityPremium(TiXmlNode* xmlNode);

       bool isPremiumPerUnit(){return this->premiumPerUnitIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPremiumPerUnit();
      std::string getPremiumPerUnitIDRef(){return premiumPerUnitIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> premiumPerUnit_;
       std::string premiumPerUnitIDRef_;
       bool premiumPerUnitIsNull_;

};

} //namespaceFpmlSerialized end
#endif

