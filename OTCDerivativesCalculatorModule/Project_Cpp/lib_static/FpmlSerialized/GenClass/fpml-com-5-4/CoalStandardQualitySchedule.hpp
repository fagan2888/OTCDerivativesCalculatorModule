// CoalStandardQualitySchedule.hpp 
#ifndef FpmlSerialized_CoalStandardQualitySchedule_hpp
#define FpmlSerialized_CoalStandardQualitySchedule_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CoalStandardQuality.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>

namespace FpmlSerialized {

class CoalStandardQualitySchedule : public ISerialized { 
   public: 
       CoalStandardQualitySchedule(TiXmlNode* xmlNode);

       bool isStandardQualityStep(){return this->StandardQualityStepIsNull_;}
       std::vector<boost::shared_ptr<CoalStandardQuality>> getStandardQualityStep();
      std::string getStandardQualityStepIDRef(){return StandardQualityStepIDRef_;}

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
       std::vector<boost::shared_ptr<CoalStandardQuality>> StandardQualityStep_;
       std::string StandardQualityStepIDRef_;
       bool StandardQualityStepIsNull_;
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

