// Fx_exchangeLeg.hpp 
#ifndef FpmlSerialized_Fx_exchangeLeg_hpp
#define FpmlSerialized_Fx_exchangeLeg_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Fx_exchangeLeg : public ISerialized { 
   public: 
       Fx_exchangeLeg(TiXmlNode* xmlNode);

       bool isTargetNotional(){return this->targetNotionalIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTargetNotional();


       bool isTargetCurrency(){return this->targetCurrencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTargetCurrency();


       bool isBaseNotional(){return this->baseNotionalIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseNotional();


       bool isBaseCurrency(){return this->baseCurrencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseCurrency();


       bool isExchangeType(){return this->exchangeTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExchangeType();


       bool isExchangeRate(){return this->exchangeRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExchangeRate();


       bool isCalculationDate(){return this->calculationDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationDate();


       bool isPaymentDays(){return this->paymentDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPaymentDays();


       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPaymentDate();


       bool isForwardFlag(){return this->forwardFlagIsNull_;}
       boost::shared_ptr<XsdTypeToken> getForwardFlag();


       bool isForwardPoint(){return this->forwardPointIsNull_;}
       boost::shared_ptr<XsdTypeToken> getForwardPoint();


   protected: 
       boost::shared_ptr<XsdTypeToken> targetNotional_;
       
       bool targetNotionalIsNull_;
       boost::shared_ptr<XsdTypeToken> targetCurrency_;
       
       bool targetCurrencyIsNull_;
       boost::shared_ptr<XsdTypeToken> baseNotional_;
       
       bool baseNotionalIsNull_;
       boost::shared_ptr<XsdTypeToken> baseCurrency_;
       
       bool baseCurrencyIsNull_;
       boost::shared_ptr<XsdTypeToken> exchangeType_;
       
       bool exchangeTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> exchangeRate_;
       
       bool exchangeRateIsNull_;
       boost::shared_ptr<XsdTypeToken> calculationDate_;
       
       bool calculationDateIsNull_;
       boost::shared_ptr<XsdTypeToken> paymentDays_;
       
       bool paymentDaysIsNull_;
       boost::shared_ptr<XsdTypeToken> paymentDate_;
       
       bool paymentDateIsNull_;
       boost::shared_ptr<XsdTypeToken> forwardFlag_;
       
       bool forwardFlagIsNull_;
       boost::shared_ptr<XsdTypeToken> forwardPoint_;
       
       bool forwardPointIsNull_;

};

} //namespaceFpmlSerialized end
#endif

