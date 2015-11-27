// GasDelivery.hpp 
#ifndef FpmlSerialized_GasDelivery_hpp
#define FpmlSerialized_GasDelivery_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/GasDeliveryPoint.hpp>
#include <fpml-com-5-4/CommodityDeliveryPoint.hpp>
#include <fpml-enum-5-4/DeliveryTypeEnum.hpp>
#include <fpml-com-5-4/CommodityHub.hpp>

namespace FpmlSerialized {

class GasDelivery : public ISerialized { 
   public: 
       GasDelivery(TiXmlNode* xmlNode);

       bool isDeliveryPoint(){return this->deliveryPointIsNull_;}
       boost::shared_ptr<GasDeliveryPoint> getDeliveryPoint();
      std::string getDeliveryPointIDRef(){return deliveryPointIDRef_;}

       bool isEntryPoint(){return this->entryPointIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getEntryPoint();
      std::string getEntryPointIDRef(){return entryPointIDRef_;}

       bool isWithdrawalPoint(){return this->withdrawalPointIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getWithdrawalPoint();
      std::string getWithdrawalPointIDRef(){return withdrawalPointIDRef_;}

       bool isDeliveryType(){return this->deliveryTypeIsNull_;}
       boost::shared_ptr<DeliveryTypeEnum> getDeliveryType();
      std::string getDeliveryTypeIDRef(){return deliveryTypeIDRef_;}

       bool isBuyerHub(){return this->buyerHubIsNull_;}
       boost::shared_ptr<CommodityHub> getBuyerHub();
      std::string getBuyerHubIDRef(){return buyerHubIDRef_;}

       bool isSellerHub(){return this->sellerHubIsNull_;}
       boost::shared_ptr<CommodityHub> getSellerHub();
      std::string getSellerHubIDRef(){return sellerHubIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!deliveryPointIsNull_){
                count += 1;
                str = "deliveryPoint" ;
           }
           if(!entryPointIsNull_){
                count += 1;
                str = "entryPoint" ;
           }
           if(!withdrawalPointIsNull_){
                count += 1;
                str = "withdrawalPoint" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<GasDeliveryPoint> deliveryPoint_;     //choice
       std::string deliveryPointIDRef_;
       bool deliveryPointIsNull_;
         boost::shared_ptr<CommodityDeliveryPoint> entryPoint_;     //choice
       std::string entryPointIDRef_;
       bool entryPointIsNull_;
         boost::shared_ptr<CommodityDeliveryPoint> withdrawalPoint_;     //choice
       std::string withdrawalPointIDRef_;
       bool withdrawalPointIsNull_;
       boost::shared_ptr<DeliveryTypeEnum> deliveryType_;
       std::string deliveryTypeIDRef_;
       bool deliveryTypeIsNull_;
       boost::shared_ptr<CommodityHub> buyerHub_;
       std::string buyerHubIDRef_;
       bool buyerHubIsNull_;
       boost::shared_ptr<CommodityHub> sellerHub_;
       std::string sellerHubIDRef_;
       bool sellerHubIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

