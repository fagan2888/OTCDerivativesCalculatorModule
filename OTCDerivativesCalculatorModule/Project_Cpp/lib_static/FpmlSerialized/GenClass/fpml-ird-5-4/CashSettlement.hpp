// CashSettlement.hpp 
#ifndef FpmlSerialized_CashSettlement_hpp
#define FpmlSerialized_CashSettlement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-ird-5-4/CashSettlementPaymentDate.hpp>
#include <fpml-ird-5-4/CashPriceMethod.hpp>
#include <fpml-ird-5-4/YieldCurveMethod.hpp>
#include <fpml-ird-5-4/CrossCurrencyMethod.hpp>

namespace FpmlSerialized {

class CashSettlement : public ISerialized { 
   public: 
       CashSettlement(TiXmlNode* xmlNode);

       bool isCashSettlementValuationTime(){return this->cashSettlementValuationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getCashSettlementValuationTime();
      std::string getCashSettlementValuationTimeIDRef(){return cashSettlementValuationTimeIDRef_;}

       bool isCashSettlementValuationDate(){return this->cashSettlementValuationDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getCashSettlementValuationDate();
      std::string getCashSettlementValuationDateIDRef(){return cashSettlementValuationDateIDRef_;}

       bool isCashSettlementPaymentDate(){return this->cashSettlementPaymentDateIsNull_;}
       boost::shared_ptr<CashSettlementPaymentDate> getCashSettlementPaymentDate();
      std::string getCashSettlementPaymentDateIDRef(){return cashSettlementPaymentDateIDRef_;}

       bool isCashPriceMethod(){return this->cashPriceMethodIsNull_;}
       boost::shared_ptr<CashPriceMethod> getCashPriceMethod();
      std::string getCashPriceMethodIDRef(){return cashPriceMethodIDRef_;}

       bool isCashPriceAlternateMethod(){return this->cashPriceAlternateMethodIsNull_;}
       boost::shared_ptr<CashPriceMethod> getCashPriceAlternateMethod();
      std::string getCashPriceAlternateMethodIDRef(){return cashPriceAlternateMethodIDRef_;}

       bool isParYieldCurveAdjustedMethod(){return this->parYieldCurveAdjustedMethodIsNull_;}
       boost::shared_ptr<YieldCurveMethod> getParYieldCurveAdjustedMethod();
      std::string getParYieldCurveAdjustedMethodIDRef(){return parYieldCurveAdjustedMethodIDRef_;}

       bool isZeroCouponYieldAdjustedMethod(){return this->zeroCouponYieldAdjustedMethodIsNull_;}
       boost::shared_ptr<YieldCurveMethod> getZeroCouponYieldAdjustedMethod();
      std::string getZeroCouponYieldAdjustedMethodIDRef(){return zeroCouponYieldAdjustedMethodIDRef_;}

       bool isParYieldCurveUnadjustedMethod(){return this->parYieldCurveUnadjustedMethodIsNull_;}
       boost::shared_ptr<YieldCurveMethod> getParYieldCurveUnadjustedMethod();
      std::string getParYieldCurveUnadjustedMethodIDRef(){return parYieldCurveUnadjustedMethodIDRef_;}

       bool isCrossCurrencyMethod(){return this->crossCurrencyMethodIsNull_;}
       boost::shared_ptr<CrossCurrencyMethod> getCrossCurrencyMethod();
      std::string getCrossCurrencyMethodIDRef(){return crossCurrencyMethodIDRef_;}

       bool isCollateralizedCashPriceMethod(){return this->collateralizedCashPriceMethodIsNull_;}
       boost::shared_ptr<YieldCurveMethod> getCollateralizedCashPriceMethod();
      std::string getCollateralizedCashPriceMethodIDRef(){return collateralizedCashPriceMethodIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!cashPriceMethodIsNull_){
                count += 1;
                str = "cashPriceMethod" ;
           }
           if(!cashPriceAlternateMethodIsNull_){
                count += 1;
                str = "cashPriceAlternateMethod" ;
           }
           if(!parYieldCurveAdjustedMethodIsNull_){
                count += 1;
                str = "parYieldCurveAdjustedMethod" ;
           }
           if(!zeroCouponYieldAdjustedMethodIsNull_){
                count += 1;
                str = "zeroCouponYieldAdjustedMethod" ;
           }
           if(!parYieldCurveUnadjustedMethodIsNull_){
                count += 1;
                str = "parYieldCurveUnadjustedMethod" ;
           }
           if(!crossCurrencyMethodIsNull_){
                count += 1;
                str = "crossCurrencyMethod" ;
           }
           if(!collateralizedCashPriceMethodIsNull_){
                count += 1;
                str = "collateralizedCashPriceMethod" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<BusinessCenterTime> cashSettlementValuationTime_;
       std::string cashSettlementValuationTimeIDRef_;
       bool cashSettlementValuationTimeIsNull_;
       boost::shared_ptr<RelativeDateOffset> cashSettlementValuationDate_;
       std::string cashSettlementValuationDateIDRef_;
       bool cashSettlementValuationDateIsNull_;
       boost::shared_ptr<CashSettlementPaymentDate> cashSettlementPaymentDate_;
       std::string cashSettlementPaymentDateIDRef_;
       bool cashSettlementPaymentDateIsNull_;
         boost::shared_ptr<CashPriceMethod> cashPriceMethod_;     //choice
       std::string cashPriceMethodIDRef_;
       bool cashPriceMethodIsNull_;
         boost::shared_ptr<CashPriceMethod> cashPriceAlternateMethod_;     //choice
       std::string cashPriceAlternateMethodIDRef_;
       bool cashPriceAlternateMethodIsNull_;
         boost::shared_ptr<YieldCurveMethod> parYieldCurveAdjustedMethod_;     //choice
       std::string parYieldCurveAdjustedMethodIDRef_;
       bool parYieldCurveAdjustedMethodIsNull_;
         boost::shared_ptr<YieldCurveMethod> zeroCouponYieldAdjustedMethod_;     //choice
       std::string zeroCouponYieldAdjustedMethodIDRef_;
       bool zeroCouponYieldAdjustedMethodIsNull_;
         boost::shared_ptr<YieldCurveMethod> parYieldCurveUnadjustedMethod_;     //choice
       std::string parYieldCurveUnadjustedMethodIDRef_;
       bool parYieldCurveUnadjustedMethodIsNull_;
         boost::shared_ptr<CrossCurrencyMethod> crossCurrencyMethod_;     //choice
       std::string crossCurrencyMethodIDRef_;
       bool crossCurrencyMethodIsNull_;
         boost::shared_ptr<YieldCurveMethod> collateralizedCashPriceMethod_;     //choice
       std::string collateralizedCashPriceMethodIDRef_;
       bool collateralizedCashPriceMethodIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

