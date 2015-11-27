// CoalDelivery.hpp 
#ifndef FpmlSerialized_CoalDelivery_hpp
#define FpmlSerialized_CoalDelivery_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CoalDeliveryPoint.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CoalTransportationEquipment.hpp>
#include <fpml-com-5-4/CommodityDeliveryRisk.hpp>

namespace FpmlSerialized {

class CoalDelivery : public ISerialized { 
   public: 
       CoalDelivery(TiXmlNode* xmlNode);

       bool isDeliveryPoint(){return this->deliveryPointIsNull_;}
       boost::shared_ptr<CoalDeliveryPoint> getDeliveryPoint();
      std::string getDeliveryPointIDRef(){return deliveryPointIDRef_;}

       bool isDeliveryAtSource(){return this->deliveryAtSourceIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDeliveryAtSource();
      std::string getDeliveryAtSourceIDRef(){return deliveryAtSourceIDRef_;}

       bool isQuantityVariationAdjustment(){return this->quantityVariationAdjustmentIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getQuantityVariationAdjustment();
      std::string getQuantityVariationAdjustmentIDRef(){return quantityVariationAdjustmentIDRef_;}

       bool isTransportationEquipment(){return this->transportationEquipmentIsNull_;}
       boost::shared_ptr<CoalTransportationEquipment> getTransportationEquipment();
      std::string getTransportationEquipmentIDRef(){return transportationEquipmentIDRef_;}

       bool isRisk(){return this->riskIsNull_;}
       boost::shared_ptr<CommodityDeliveryRisk> getRisk();
      std::string getRiskIDRef(){return riskIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!deliveryPointIsNull_){
                count += 1;
                str = "deliveryPoint" ;
           }
           if(!deliveryAtSourceIsNull_){
                count += 1;
                str = "deliveryAtSource" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<CoalDeliveryPoint> deliveryPoint_;     //choice
       std::string deliveryPointIDRef_;
       bool deliveryPointIsNull_;
         boost::shared_ptr<XsdTypeBoolean> deliveryAtSource_;     //choice
       std::string deliveryAtSourceIDRef_;
       bool deliveryAtSourceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> quantityVariationAdjustment_;
       std::string quantityVariationAdjustmentIDRef_;
       bool quantityVariationAdjustmentIsNull_;
       boost::shared_ptr<CoalTransportationEquipment> transportationEquipment_;
       std::string transportationEquipmentIDRef_;
       bool transportationEquipmentIsNull_;
       boost::shared_ptr<CommodityDeliveryRisk> risk_;
       std::string riskIDRef_;
       bool riskIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

