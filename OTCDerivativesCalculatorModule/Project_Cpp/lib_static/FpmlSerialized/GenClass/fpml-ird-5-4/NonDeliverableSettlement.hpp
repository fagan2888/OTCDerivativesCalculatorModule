// NonDeliverableSettlement.hpp 
#ifndef FpmlSerialized_NonDeliverableSettlement_hpp
#define FpmlSerialized_NonDeliverableSettlement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-ird-5-4/FxFixingDate.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-ird-5-4/SettlementRateOption.hpp>
#include <fpml-ird-5-4/PriceSourceDisruption.hpp>

namespace FpmlSerialized {

class NonDeliverableSettlement : public ISerialized { 
   public: 
       NonDeliverableSettlement(TiXmlNode* xmlNode);

       bool isReferenceCurrency(){return this->referenceCurrencyIsNull_;}
       boost::shared_ptr<Currency> getReferenceCurrency();
      std::string getReferenceCurrencyIDRef(){return referenceCurrencyIDRef_;}

       bool isFxFixingDate(){return this->fxFixingDateIsNull_;}
       boost::shared_ptr<FxFixingDate> getFxFixingDate();
      std::string getFxFixingDateIDRef(){return fxFixingDateIDRef_;}

       bool isFxFixingSchedule(){return this->fxFixingScheduleIsNull_;}
       boost::shared_ptr<AdjustableDates> getFxFixingSchedule();
      std::string getFxFixingScheduleIDRef(){return fxFixingScheduleIDRef_;}

       bool isSettlementRateOption(){return this->settlementRateOptionIsNull_;}
       boost::shared_ptr<SettlementRateOption> getSettlementRateOption();
      std::string getSettlementRateOptionIDRef(){return settlementRateOptionIDRef_;}

       bool isPriceSourceDisruption(){return this->priceSourceDisruptionIsNull_;}
       boost::shared_ptr<PriceSourceDisruption> getPriceSourceDisruption();
      std::string getPriceSourceDisruptionIDRef(){return priceSourceDisruptionIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!fxFixingDateIsNull_){
                count += 1;
                str = "fxFixingDate" ;
           }
           if(!fxFixingScheduleIsNull_){
                count += 1;
                str = "fxFixingSchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<Currency> referenceCurrency_;
       std::string referenceCurrencyIDRef_;
       bool referenceCurrencyIsNull_;
         boost::shared_ptr<FxFixingDate> fxFixingDate_;     //choice
       std::string fxFixingDateIDRef_;
       bool fxFixingDateIsNull_;
         boost::shared_ptr<AdjustableDates> fxFixingSchedule_;     //choice
       std::string fxFixingScheduleIDRef_;
       bool fxFixingScheduleIsNull_;
       boost::shared_ptr<SettlementRateOption> settlementRateOption_;
       std::string settlementRateOptionIDRef_;
       bool settlementRateOptionIsNull_;
       boost::shared_ptr<PriceSourceDisruption> priceSourceDisruption_;
       std::string priceSourceDisruptionIDRef_;
       bool priceSourceDisruptionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

