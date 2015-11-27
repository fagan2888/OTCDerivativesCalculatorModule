// MetalDelivery.hpp 
#ifndef FpmlSerialized_MetalDelivery_hpp
#define FpmlSerialized_MetalDelivery_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityDeliveryPoint.hpp>
#include <fpml-com-5-4/CommodityDeliveryRisk.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-enum-5-4/MetalTitleEnum.hpp>

namespace FpmlSerialized {

class MetalDelivery : public ISerialized { 
   public: 
       MetalDelivery(TiXmlNode* xmlNode);

       bool isDeliveryLocation(){return this->deliveryLocationIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getDeliveryLocation();
      std::string getDeliveryLocationIDRef(){return deliveryLocationIDRef_;}

       bool isRisk(){return this->riskIsNull_;}
       boost::shared_ptr<CommodityDeliveryRisk> getRisk();
      std::string getRiskIDRef(){return riskIDRef_;}

       bool isTotalQuantityTolerance(){return this->totalQuantityToleranceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getTotalQuantityTolerance();
      std::string getTotalQuantityToleranceIDRef(){return totalQuantityToleranceIDRef_;}

       bool isPeriodQuantityTolerance(){return this->periodQuantityToleranceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPeriodQuantityTolerance();
      std::string getPeriodQuantityToleranceIDRef(){return periodQuantityToleranceIDRef_;}

       bool isTitle(){return this->titleIsNull_;}
       boost::shared_ptr<MetalTitleEnum> getTitle();
      std::string getTitleIDRef(){return titleIDRef_;}

   protected: 
       boost::shared_ptr<CommodityDeliveryPoint> deliveryLocation_;
       std::string deliveryLocationIDRef_;
       bool deliveryLocationIsNull_;
       boost::shared_ptr<CommodityDeliveryRisk> risk_;
       std::string riskIDRef_;
       bool riskIsNull_;
       boost::shared_ptr<XsdTypeDecimal> totalQuantityTolerance_;
       std::string totalQuantityToleranceIDRef_;
       bool totalQuantityToleranceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> periodQuantityTolerance_;
       std::string periodQuantityToleranceIDRef_;
       bool periodQuantityToleranceIsNull_;
       boost::shared_ptr<MetalTitleEnum> title_;
       std::string titleIDRef_;
       bool titleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

