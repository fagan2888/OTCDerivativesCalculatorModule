// FxFixingDate.hpp 
#ifndef FpmlSerialized_FxFixingDate_hpp
#define FpmlSerialized_FxFixingDate_hpp

#include <fpml-shared-5-4/Offset.hpp>
#include <fpml-enum-5-4/BusinessDayConventionEnum.hpp>
#include <fpml-shared-5-4/BusinessCentersReference.hpp>
#include <fpml-shared-5-4/BusinessCenters.hpp>
#include <fpml-ird-5-4/DateRelativeToPaymentDates.hpp>
#include <fpml-ird-5-4/DateRelativeToCalculationPeriodDates.hpp>

namespace FpmlSerialized {

class FxFixingDate : public Offset { 
   public: 
       FxFixingDate(TiXmlNode* xmlNode);

       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<BusinessDayConventionEnum> getBusinessDayConvention();
      std::string getBusinessDayConventionIDRef(){return businessDayConventionIDRef_;}

       bool isBusinessCentersReference(){return this->businessCentersReferenceIsNull_;}
       boost::shared_ptr<BusinessCentersReference> getBusinessCentersReference();
      std::string getBusinessCentersReferenceIDRef(){return businessCentersReferenceIDRef_;}

       bool isBusinessCenters(){return this->businessCentersIsNull_;}
       boost::shared_ptr<BusinessCenters> getBusinessCenters();
      std::string getBusinessCentersIDRef(){return businessCentersIDRef_;}

       bool isDateRelativeToPaymentDates(){return this->dateRelativeToPaymentDatesIsNull_;}
       boost::shared_ptr<DateRelativeToPaymentDates> getDateRelativeToPaymentDates();
      std::string getDateRelativeToPaymentDatesIDRef(){return dateRelativeToPaymentDatesIDRef_;}

       bool isDateRelativeToCalculationPeriodDates(){return this->dateRelativeToCalculationPeriodDatesIsNull_;}
       boost::shared_ptr<DateRelativeToCalculationPeriodDates> getDateRelativeToCalculationPeriodDates();
      std::string getDateRelativeToCalculationPeriodDatesIDRef(){return dateRelativeToCalculationPeriodDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!businessCentersReferenceIsNull_){
                count += 1;
                str = "businessCentersReference" ;
           }
           if(!businessCentersIsNull_){
                count += 1;
                str = "businessCenters" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!dateRelativeToPaymentDatesIsNull_){
                count += 1;
                str = "dateRelativeToPaymentDates" ;
           }
           if(!dateRelativeToCalculationPeriodDatesIsNull_){
                count += 1;
                str = "dateRelativeToCalculationPeriodDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
       boost::shared_ptr<BusinessDayConventionEnum> businessDayConvention_;
       std::string businessDayConventionIDRef_;
       bool businessDayConventionIsNull_;
         boost::shared_ptr<BusinessCentersReference> businessCentersReference_;     //choice
       std::string businessCentersReferenceIDRef_;
       bool businessCentersReferenceIsNull_;
         boost::shared_ptr<BusinessCenters> businessCenters_;     //choice
       std::string businessCentersIDRef_;
       bool businessCentersIsNull_;
         boost::shared_ptr<DateRelativeToPaymentDates> dateRelativeToPaymentDates_;     //choice
       std::string dateRelativeToPaymentDatesIDRef_;
       bool dateRelativeToPaymentDatesIsNull_;
         boost::shared_ptr<DateRelativeToCalculationPeriodDates> dateRelativeToCalculationPeriodDates_;     //choice
       std::string dateRelativeToCalculationPeriodDatesIDRef_;
       bool dateRelativeToCalculationPeriodDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

