// OilTransferDelivery.hpp 
#ifndef FpmlSerialized_OilTransferDelivery_hpp
#define FpmlSerialized_OilTransferDelivery_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityDeliveryPoint.hpp>

namespace FpmlSerialized {

class OilTransferDelivery : public ISerialized { 
   public: 
       OilTransferDelivery(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isDeliveryLocation(){return this->deliveryLocationIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getDeliveryLocation();
      std::string getDeliveryLocationIDRef(){return deliveryLocationIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       boost::shared_ptr<CommodityDeliveryPoint> deliveryLocation_;
       std::string deliveryLocationIDRef_;
       bool deliveryLocationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

