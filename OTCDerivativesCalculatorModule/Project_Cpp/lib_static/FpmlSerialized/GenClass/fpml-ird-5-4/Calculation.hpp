// Calculation.hpp 
#ifndef FpmlSerialized_Calculation_hpp
#define FpmlSerialized_Calculation_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/Notional.hpp>
#include <fpml-ird-5-4/FxLinkedNotionalSchedule.hpp>
#include <fpml-shared-5-4/Schedule.hpp>
#include <fpml-shared-5-4/FutureValueAmount.hpp>
#include <fpml-shared-5-4/Rate.hpp>
#include <fpml-shared-5-4/FloatingRateCalculation.hpp>
#include <fpml-ird-5-4/InflationRateCalculation.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>
#include <fpml-ird-5-4/Discounting.hpp>
#include <fpml-enum-5-4/CompoundingMethodEnum.hpp>

namespace FpmlSerialized {

class Calculation : public ISerialized { 
   public: 
       Calculation(TiXmlNode* xmlNode);

       bool isNotionalSchedule(){return this->notionalScheduleIsNull_;}
       boost::shared_ptr<Notional> getNotionalSchedule();
      std::string getNotionalScheduleIDRef(){return notionalScheduleIDRef_;}

       bool isFxLinkedNotionalSchedule(){return this->fxLinkedNotionalScheduleIsNull_;}
       boost::shared_ptr<FxLinkedNotionalSchedule> getFxLinkedNotionalSchedule();
      std::string getFxLinkedNotionalScheduleIDRef(){return fxLinkedNotionalScheduleIDRef_;}

       bool isFixedRateSchedule(){return this->fixedRateScheduleIsNull_;}
       boost::shared_ptr<Schedule> getFixedRateSchedule();
      std::string getFixedRateScheduleIDRef(){return fixedRateScheduleIDRef_;}

       bool isFutureValueNotional(){return this->futureValueNotionalIsNull_;}
       boost::shared_ptr<FutureValueAmount> getFutureValueNotional();
      std::string getFutureValueNotionalIDRef(){return futureValueNotionalIDRef_;}

       bool isRateCalculation(){return this->rateCalculationIsNull_;}
       boost::shared_ptr<Rate> getRateCalculation();
      std::string getRateCalculationIDRef(){return rateCalculationIDRef_;}

       bool isFloatingRateCalculation(){return this->floatingRateCalculationIsNull_;}
       boost::shared_ptr<FloatingRateCalculation> getFloatingRateCalculation();
      std::string getFloatingRateCalculationIDRef(){return floatingRateCalculationIDRef_;}

       bool isInflationRateCalculation(){return this->inflationRateCalculationIsNull_;}
       boost::shared_ptr<InflationRateCalculation> getInflationRateCalculation();
      std::string getInflationRateCalculationIDRef(){return inflationRateCalculationIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

       bool isDiscounting(){return this->discountingIsNull_;}
       boost::shared_ptr<Discounting> getDiscounting();
      std::string getDiscountingIDRef(){return discountingIDRef_;}

       bool isCompoundingMethod(){return this->compoundingMethodIsNull_;}
       boost::shared_ptr<CompoundingMethodEnum> getCompoundingMethod();
      std::string getCompoundingMethodIDRef(){return compoundingMethodIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!notionalScheduleIsNull_){
                count += 1;
                str = "notionalSchedule" ;
           }
           if(!fxLinkedNotionalScheduleIsNull_){
                count += 1;
                str = "fxLinkedNotionalSchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!fixedRateScheduleIsNull_){
                count += 1;
                str = "fixedRateSchedule" ;
           }
           if(!futureValueNotionalIsNull_){
                count += 1;
                str = "futureValueNotional" ;
           }
           if(!rateCalculationIsNull_){
                count += 1;
                str = "rateCalculation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<Notional> notionalSchedule_;     //choice
       std::string notionalScheduleIDRef_;
       bool notionalScheduleIsNull_;
         boost::shared_ptr<FxLinkedNotionalSchedule> fxLinkedNotionalSchedule_;     //choice
       std::string fxLinkedNotionalScheduleIDRef_;
       bool fxLinkedNotionalScheduleIsNull_;
         boost::shared_ptr<Schedule> fixedRateSchedule_;     //choice
       std::string fixedRateScheduleIDRef_;
       bool fixedRateScheduleIsNull_;
         boost::shared_ptr<FutureValueAmount> futureValueNotional_;     //choice
       std::string futureValueNotionalIDRef_;
       bool futureValueNotionalIsNull_;
         boost::shared_ptr<Rate> rateCalculation_;     //choice
       std::string rateCalculationIDRef_;
       bool rateCalculationIsNull_;
       boost::shared_ptr<FloatingRateCalculation> floatingRateCalculation_;     //substitude 
       std::string floatingRateCalculationIDRef_;
       bool floatingRateCalculationIsNull_;
       boost::shared_ptr<InflationRateCalculation> inflationRateCalculation_;     //substitude 
       std::string inflationRateCalculationIDRef_;
       bool inflationRateCalculationIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;
       boost::shared_ptr<Discounting> discounting_;
       std::string discountingIDRef_;
       bool discountingIsNull_;
       boost::shared_ptr<CompoundingMethodEnum> compoundingMethod_;
       std::string compoundingMethodIDRef_;
       bool compoundingMethodIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

