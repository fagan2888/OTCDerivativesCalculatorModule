// ElectricityDelivery.hpp 
#ifndef FpmlSerialized_ElectricityDelivery_hpp
#define FpmlSerialized_ElectricityDelivery_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/ElectricityDeliveryPoint.hpp>
#include <fpml-com-5-4/ElectricityDeliveryType.hpp>
#include <fpml-com-5-4/ElectricityTransmissionContingency.hpp>
#include <fpml-com-5-4/CommodityDeliveryPoint.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class ElectricityDelivery : public ISerialized { 
   public: 
       ElectricityDelivery(TiXmlNode* xmlNode);

       bool isDeliveryPoint(){return this->deliveryPointIsNull_;}
       boost::shared_ptr<ElectricityDeliveryPoint> getDeliveryPoint();
      std::string getDeliveryPointIDRef(){return deliveryPointIDRef_;}

       bool isDeliveryType(){return this->deliveryTypeIsNull_;}
       boost::shared_ptr<ElectricityDeliveryType> getDeliveryType();
      std::string getDeliveryTypeIDRef(){return deliveryTypeIDRef_;}

       bool isTransmissionContingency(){return this->transmissionContingencyIsNull_;}
       boost::shared_ptr<ElectricityTransmissionContingency> getTransmissionContingency();
      std::string getTransmissionContingencyIDRef(){return transmissionContingencyIDRef_;}

       bool isDeliveryZone(){return this->deliveryZoneIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getDeliveryZone();
      std::string getDeliveryZoneIDRef(){return deliveryZoneIDRef_;}

       bool isElectingPartyReference(){return this->electingPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getElectingPartyReference();
      std::string getElectingPartyReferenceIDRef(){return electingPartyReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!deliveryPointIsNull_){
                count += 1;
                str = "deliveryPoint" ;
           }
           if(!deliveryTypeIsNull_){
                count += 1;
                str = "deliveryType" ;
           }
           if(!transmissionContingencyIsNull_){
                count += 1;
                str = "transmissionContingency" ;
           }
           if(!deliveryZoneIsNull_){
                count += 1;
                str = "deliveryZone" ;
           }
           if(!electingPartyReferenceIsNull_){
                count += 1;
                str = "electingPartyReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<ElectricityDeliveryPoint> deliveryPoint_;     //choice
       std::string deliveryPointIDRef_;
       bool deliveryPointIsNull_;
         boost::shared_ptr<ElectricityDeliveryType> deliveryType_;     //choice
       std::string deliveryTypeIDRef_;
       bool deliveryTypeIsNull_;
         boost::shared_ptr<ElectricityTransmissionContingency> transmissionContingency_;     //choice
       std::string transmissionContingencyIDRef_;
       bool transmissionContingencyIsNull_;
         boost::shared_ptr<CommodityDeliveryPoint> deliveryZone_;     //choice
       std::string deliveryZoneIDRef_;
       bool deliveryZoneIsNull_;
         boost::shared_ptr<PartyReference> electingPartyReference_;     //choice
       std::string electingPartyReferenceIDRef_;
       bool electingPartyReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

