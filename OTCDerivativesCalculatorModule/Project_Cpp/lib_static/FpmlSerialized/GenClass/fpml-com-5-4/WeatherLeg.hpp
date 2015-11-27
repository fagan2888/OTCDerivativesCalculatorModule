// WeatherLeg.hpp 
#ifndef FpmlSerialized_WeatherLeg_hpp
#define FpmlSerialized_WeatherLeg_hpp

#include <fpml-com-5-4/FinancialSwapLeg.hpp>
#include <fpml-com-5-4/WeatherIndex.hpp>
#include <fpml-com-5-4/WeatherCalculationPeriods.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-com-5-4/WeatherLegCalculation.hpp>
#include <fpml-com-5-4/CommodityRelativePaymentDates.hpp>
#include <fpml-com-5-4/WeatherIndexData.hpp>

namespace FpmlSerialized {

class WeatherLeg : public FinancialSwapLeg { 
   public: 
       WeatherLeg(TiXmlNode* xmlNode);

       bool isWeatherIndexLevel(){return this->weatherIndexLevelIsNull_;}
       boost::shared_ptr<WeatherIndex> getWeatherIndexLevel();
      std::string getWeatherIndexLevelIDRef(){return weatherIndexLevelIDRef_;}

       bool isWeatherCalculationPeriods(){return this->weatherCalculationPeriodsIsNull_;}
       boost::shared_ptr<WeatherCalculationPeriods> getWeatherCalculationPeriods();
      std::string getWeatherCalculationPeriodsIDRef(){return weatherCalculationPeriodsIDRef_;}

       bool isWeatherCalculationPeriodsReference(){return this->weatherCalculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getWeatherCalculationPeriodsReference();
      std::string getWeatherCalculationPeriodsReferenceIDRef(){return weatherCalculationPeriodsReferenceIDRef_;}

       bool isWeatherNotionalAmount(){return this->weatherNotionalAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getWeatherNotionalAmount();
      std::string getWeatherNotionalAmountIDRef(){return weatherNotionalAmountIDRef_;}

       bool isCalculation(){return this->calculationIsNull_;}
       boost::shared_ptr<WeatherLegCalculation> getCalculation();
      std::string getCalculationIDRef(){return calculationIDRef_;}

       bool isPaymentDates(){return this->paymentDatesIsNull_;}
       boost::shared_ptr<CommodityRelativePaymentDates> getPaymentDates();
      std::string getPaymentDatesIDRef(){return paymentDatesIDRef_;}

       bool isWeatherIndexData(){return this->weatherIndexDataIsNull_;}
       boost::shared_ptr<WeatherIndexData> getWeatherIndexData();
      std::string getWeatherIndexDataIDRef(){return weatherIndexDataIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!weatherCalculationPeriodsIsNull_){
                count += 1;
                str = "weatherCalculationPeriods" ;
           }
           if(!weatherCalculationPeriodsReferenceIsNull_){
                count += 1;
                str = "weatherCalculationPeriodsReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<WeatherIndex> weatherIndexLevel_;
       std::string weatherIndexLevelIDRef_;
       bool weatherIndexLevelIsNull_;
         boost::shared_ptr<WeatherCalculationPeriods> weatherCalculationPeriods_;     //choice
       std::string weatherCalculationPeriodsIDRef_;
       bool weatherCalculationPeriodsIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> weatherCalculationPeriodsReference_;     //choice
       std::string weatherCalculationPeriodsReferenceIDRef_;
       bool weatherCalculationPeriodsReferenceIsNull_;
       boost::shared_ptr<NonNegativeMoney> weatherNotionalAmount_;
       std::string weatherNotionalAmountIDRef_;
       bool weatherNotionalAmountIsNull_;
       boost::shared_ptr<WeatherLegCalculation> calculation_;
       std::string calculationIDRef_;
       bool calculationIsNull_;
       boost::shared_ptr<CommodityRelativePaymentDates> paymentDates_;
       std::string paymentDatesIDRef_;
       bool paymentDatesIsNull_;
       boost::shared_ptr<WeatherIndexData> weatherIndexData_;
       std::string weatherIndexDataIDRef_;
       bool weatherIndexDataIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

