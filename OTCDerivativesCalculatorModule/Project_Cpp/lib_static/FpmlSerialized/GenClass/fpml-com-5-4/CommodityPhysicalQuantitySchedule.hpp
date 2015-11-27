// CommodityPhysicalQuantitySchedule.hpp 
#ifndef FpmlSerialized_CommodityPhysicalQuantitySchedule_hpp
#define FpmlSerialized_CommodityPhysicalQuantitySchedule_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>

namespace FpmlSerialized {

class CommodityPhysicalQuantitySchedule : public ISerialized { 
   public: 
       CommodityPhysicalQuantitySchedule(TiXmlNode* xmlNode);

       bool isQuantityStep(){return this->quantityStepIsNull_;}
       std::vector<boost::shared_ptr<CommodityNotionalQuantity>> getQuantityStep();
      std::string getQuantityStepIDRef(){return quantityStepIDRef_;}

       bool isDeliveryPeriodsReference(){return this->deliveryPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getDeliveryPeriodsReference();
      std::string getDeliveryPeriodsReferenceIDRef(){return deliveryPeriodsReferenceIDRef_;}

       bool isDeliveryPeriodsScheduleReference(){return this->deliveryPeriodsScheduleReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsScheduleReference> getDeliveryPeriodsScheduleReference();
      std::string getDeliveryPeriodsScheduleReferenceIDRef(){return deliveryPeriodsScheduleReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!deliveryPeriodsReferenceIsNull_){
                count += 1;
                str = "deliveryPeriodsReference" ;
           }
           if(!deliveryPeriodsScheduleReferenceIsNull_){
                count += 1;
                str = "deliveryPeriodsScheduleReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       std::vector<boost::shared_ptr<CommodityNotionalQuantity>> quantityStep_;
       std::string quantityStepIDRef_;
       bool quantityStepIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> deliveryPeriodsReference_;     //choice
       std::string deliveryPeriodsReferenceIDRef_;
       bool deliveryPeriodsReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsScheduleReference> deliveryPeriodsScheduleReference_;     //choice
       std::string deliveryPeriodsScheduleReferenceIDRef_;
       bool deliveryPeriodsScheduleReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

