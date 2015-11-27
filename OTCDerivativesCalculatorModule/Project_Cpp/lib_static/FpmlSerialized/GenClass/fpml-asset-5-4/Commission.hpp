// Commission.hpp 
#ifndef FpmlSerialized_Commission_hpp
#define FpmlSerialized_Commission_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/CommissionDenominationEnum.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-shared-5-4/FxRate.hpp>

namespace FpmlSerialized {

class Commission : public ISerialized { 
   public: 
       Commission(TiXmlNode* xmlNode);

       bool isCommissionDenomination(){return this->commissionDenominationIsNull_;}
       boost::shared_ptr<CommissionDenominationEnum> getCommissionDenomination();
      std::string getCommissionDenominationIDRef(){return commissionDenominationIDRef_;}

       bool isCommissionAmount(){return this->commissionAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCommissionAmount();
      std::string getCommissionAmountIDRef(){return commissionAmountIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isCommissionPerTrade(){return this->commissionPerTradeIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCommissionPerTrade();
      std::string getCommissionPerTradeIDRef(){return commissionPerTradeIDRef_;}

       bool isFxRate(){return this->fxRateIsNull_;}
       std::vector<boost::shared_ptr<FxRate>> getFxRate();
      std::string getFxRateIDRef(){return fxRateIDRef_;}

   protected: 
       boost::shared_ptr<CommissionDenominationEnum> commissionDenomination_;
       std::string commissionDenominationIDRef_;
       bool commissionDenominationIsNull_;
       boost::shared_ptr<XsdTypeDecimal> commissionAmount_;
       std::string commissionAmountIDRef_;
       bool commissionAmountIsNull_;
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeDecimal> commissionPerTrade_;
       std::string commissionPerTradeIDRef_;
       bool commissionPerTradeIsNull_;
       std::vector<boost::shared_ptr<FxRate>> fxRate_;
       std::string fxRateIDRef_;
       bool fxRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

