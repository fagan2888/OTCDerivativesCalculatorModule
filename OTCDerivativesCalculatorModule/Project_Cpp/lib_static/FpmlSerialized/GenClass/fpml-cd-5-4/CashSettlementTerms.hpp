// CashSettlementTerms.hpp 
#ifndef FpmlSerialized_CashSettlementTerms_hpp
#define FpmlSerialized_CashSettlementTerms_hpp

#include <fpml-cd-5-4/SettlementTerms.hpp>
#include <fpml-cd-5-4/ValuationDate.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-enum-5-4/QuotationRateTypeEnum.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>
#include <fpml-shared-5-4/RestrictedPercentage.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/ValuationMethodEnum.hpp>

namespace FpmlSerialized {

class CashSettlementTerms : public SettlementTerms { 
   public: 
       CashSettlementTerms(TiXmlNode* xmlNode);

       bool isValuationDate(){return this->valuationDateIsNull_;}
       boost::shared_ptr<ValuationDate> getValuationDate();
      std::string getValuationDateIDRef(){return valuationDateIDRef_;}

       bool isValuationTime(){return this->valuationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getValuationTime();
      std::string getValuationTimeIDRef(){return valuationTimeIDRef_;}

       bool isQuotationMethod(){return this->quotationMethodIsNull_;}
       boost::shared_ptr<QuotationRateTypeEnum> getQuotationMethod();
      std::string getQuotationMethodIDRef(){return quotationMethodIDRef_;}

       bool isQuotationAmount(){return this->quotationAmountIsNull_;}
       boost::shared_ptr<Money> getQuotationAmount();
      std::string getQuotationAmountIDRef(){return quotationAmountIDRef_;}

       bool isMinimumQuotationAmount(){return this->minimumQuotationAmountIsNull_;}
       boost::shared_ptr<Money> getMinimumQuotationAmount();
      std::string getMinimumQuotationAmountIDRef(){return minimumQuotationAmountIDRef_;}

       bool isDealer(){return this->dealerIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeString>> getDealer();
      std::string getDealerIDRef(){return dealerIDRef_;}

       bool isCashSettlementBusinessDays(){return this->cashSettlementBusinessDaysIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getCashSettlementBusinessDays();
      std::string getCashSettlementBusinessDaysIDRef(){return cashSettlementBusinessDaysIDRef_;}

       bool isCashSettlementAmount(){return this->cashSettlementAmountIsNull_;}
       boost::shared_ptr<Money> getCashSettlementAmount();
      std::string getCashSettlementAmountIDRef(){return cashSettlementAmountIDRef_;}

       bool isRecoveryFactor(){return this->recoveryFactorIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getRecoveryFactor();
      std::string getRecoveryFactorIDRef(){return recoveryFactorIDRef_;}

       bool isFixedSettlement(){return this->fixedSettlementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFixedSettlement();
      std::string getFixedSettlementIDRef(){return fixedSettlementIDRef_;}

       bool isAccruedInterest(){return this->accruedInterestIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAccruedInterest();
      std::string getAccruedInterestIDRef(){return accruedInterestIDRef_;}

       bool isValuationMethod(){return this->valuationMethodIsNull_;}
       boost::shared_ptr<ValuationMethodEnum> getValuationMethod();
      std::string getValuationMethodIDRef(){return valuationMethodIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!cashSettlementAmountIsNull_){
                count += 1;
                str = "cashSettlementAmount" ;
           }
           if(!recoveryFactorIsNull_){
                count += 1;
                str = "recoveryFactor" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<ValuationDate> valuationDate_;
       std::string valuationDateIDRef_;
       bool valuationDateIsNull_;
       boost::shared_ptr<BusinessCenterTime> valuationTime_;
       std::string valuationTimeIDRef_;
       bool valuationTimeIsNull_;
       boost::shared_ptr<QuotationRateTypeEnum> quotationMethod_;
       std::string quotationMethodIDRef_;
       bool quotationMethodIsNull_;
       boost::shared_ptr<Money> quotationAmount_;
       std::string quotationAmountIDRef_;
       bool quotationAmountIsNull_;
       boost::shared_ptr<Money> minimumQuotationAmount_;
       std::string minimumQuotationAmountIDRef_;
       bool minimumQuotationAmountIsNull_;
       std::vector<boost::shared_ptr<XsdTypeString>> dealer_;
       std::string dealerIDRef_;
       bool dealerIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> cashSettlementBusinessDays_;
       std::string cashSettlementBusinessDaysIDRef_;
       bool cashSettlementBusinessDaysIsNull_;
         boost::shared_ptr<Money> cashSettlementAmount_;     //choice
       std::string cashSettlementAmountIDRef_;
       bool cashSettlementAmountIsNull_;
         boost::shared_ptr<RestrictedPercentage> recoveryFactor_;     //choice
       std::string recoveryFactorIDRef_;
       bool recoveryFactorIsNull_;
       boost::shared_ptr<XsdTypeBoolean> fixedSettlement_;
       std::string fixedSettlementIDRef_;
       bool fixedSettlementIsNull_;
       boost::shared_ptr<XsdTypeBoolean> accruedInterest_;
       std::string accruedInterestIDRef_;
       bool accruedInterestIsNull_;
       boost::shared_ptr<ValuationMethodEnum> valuationMethod_;
       std::string valuationMethodIDRef_;
       bool valuationMethodIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

