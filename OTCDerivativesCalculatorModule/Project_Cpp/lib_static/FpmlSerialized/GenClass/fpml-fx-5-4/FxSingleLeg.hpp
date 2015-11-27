// FxSingleLeg.hpp 
#ifndef FpmlSerialized_FxSingleLeg_hpp
#define FpmlSerialized_FxSingleLeg_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/Payment.hpp>
#include <fpml-enum-5-4/DealtCurrencyEnum.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-fx-5-4/ExchangeRate.hpp>
#include <fpml-shared-5-4/FxCashSettlement.hpp>

namespace FpmlSerialized {

class FxSingleLeg : public Product { 
   public: 
       FxSingleLeg(TiXmlNode* xmlNode);

       bool isExchangedCurrency1(){return this->exchangedCurrency1IsNull_;}
       boost::shared_ptr<Payment> getExchangedCurrency1();
      std::string getExchangedCurrency1IDRef(){return exchangedCurrency1IDRef_;}

       bool isExchangedCurrency2(){return this->exchangedCurrency2IsNull_;}
       boost::shared_ptr<Payment> getExchangedCurrency2();
      std::string getExchangedCurrency2IDRef(){return exchangedCurrency2IDRef_;}

       bool isDealtCurrency(){return this->dealtCurrencyIsNull_;}
       boost::shared_ptr<DealtCurrencyEnum> getDealtCurrency();
      std::string getDealtCurrencyIDRef(){return dealtCurrencyIDRef_;}

       bool isTenorName(){return this->tenorNameIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getTenorName();
      std::string getTenorNameIDRef(){return tenorNameIDRef_;}

       bool isTenorPeriod(){return this->tenorPeriodIsNull_;}
       boost::shared_ptr<Period> getTenorPeriod();
      std::string getTenorPeriodIDRef(){return tenorPeriodIDRef_;}

       bool isValueDate(){return this->valueDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getValueDate();
      std::string getValueDateIDRef(){return valueDateIDRef_;}

       bool isCurrency1ValueDate(){return this->currency1ValueDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCurrency1ValueDate();
      std::string getCurrency1ValueDateIDRef(){return currency1ValueDateIDRef_;}

       bool isCurrency2ValueDate(){return this->currency2ValueDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCurrency2ValueDate();
      std::string getCurrency2ValueDateIDRef(){return currency2ValueDateIDRef_;}

       bool isExchangeRate(){return this->exchangeRateIsNull_;}
       boost::shared_ptr<ExchangeRate> getExchangeRate();
      std::string getExchangeRateIDRef(){return exchangeRateIDRef_;}

       bool isNonDeliverableSettlement(){return this->nonDeliverableSettlementIsNull_;}
       boost::shared_ptr<FxCashSettlement> getNonDeliverableSettlement();
      std::string getNonDeliverableSettlementIDRef(){return nonDeliverableSettlementIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!tenorNameIsNull_){
                count += 1;
                str = "tenorName" ;
           }
           if(!tenorPeriodIsNull_){
                count += 1;
                str = "tenorPeriod" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!valueDateIsNull_){
                count += 1;
                str = "valueDate" ;
           }
           if(!currency1ValueDateIsNull_){
                count += 1;
                str = "currency1ValueDate" ;
           }
           if(!currency2ValueDateIsNull_){
                count += 1;
                str = "currency2ValueDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
       boost::shared_ptr<Payment> exchangedCurrency1_;
       std::string exchangedCurrency1IDRef_;
       bool exchangedCurrency1IsNull_;
       boost::shared_ptr<Payment> exchangedCurrency2_;
       std::string exchangedCurrency2IDRef_;
       bool exchangedCurrency2IsNull_;
       boost::shared_ptr<DealtCurrencyEnum> dealtCurrency_;
       std::string dealtCurrencyIDRef_;
       bool dealtCurrencyIsNull_;
         boost::shared_ptr<XsdTypeBoolean> tenorName_;     //choice
       std::string tenorNameIDRef_;
       bool tenorNameIsNull_;
         boost::shared_ptr<Period> tenorPeriod_;     //choice
       std::string tenorPeriodIDRef_;
       bool tenorPeriodIsNull_;
         boost::shared_ptr<XsdTypeDate> valueDate_;     //choice
       std::string valueDateIDRef_;
       bool valueDateIsNull_;
         boost::shared_ptr<XsdTypeDate> currency1ValueDate_;     //choice
       std::string currency1ValueDateIDRef_;
       bool currency1ValueDateIsNull_;
         boost::shared_ptr<XsdTypeDate> currency2ValueDate_;     //choice
       std::string currency2ValueDateIDRef_;
       bool currency2ValueDateIsNull_;
       boost::shared_ptr<ExchangeRate> exchangeRate_;
       std::string exchangeRateIDRef_;
       bool exchangeRateIsNull_;
       boost::shared_ptr<FxCashSettlement> nonDeliverableSettlement_;
       std::string nonDeliverableSettlementIDRef_;
       bool nonDeliverableSettlementIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

