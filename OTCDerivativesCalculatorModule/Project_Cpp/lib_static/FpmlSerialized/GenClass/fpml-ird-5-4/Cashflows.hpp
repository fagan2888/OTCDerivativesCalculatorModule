// Cashflows.hpp 
#ifndef FpmlSerialized_Cashflows_hpp
#define FpmlSerialized_Cashflows_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-ird-5-4/PrincipalExchange.hpp>
#include <fpml-ird-5-4/PaymentCalculationPeriod.hpp>

namespace FpmlSerialized {

class Cashflows : public ISerialized { 
   public: 
       Cashflows(TiXmlNode* xmlNode);

       bool isCashflowsMatchParameters(){return this->cashflowsMatchParametersIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getCashflowsMatchParameters();
      std::string getCashflowsMatchParametersIDRef(){return cashflowsMatchParametersIDRef_;}

       bool isPrincipalExchange(){return this->principalExchangeIsNull_;}
       std::vector<boost::shared_ptr<PrincipalExchange>> getPrincipalExchange();
      std::string getPrincipalExchangeIDRef(){return principalExchangeIDRef_;}

       bool isPaymentCalculationPeriod(){return this->paymentCalculationPeriodIsNull_;}
       std::vector<boost::shared_ptr<PaymentCalculationPeriod>> getPaymentCalculationPeriod();
      std::string getPaymentCalculationPeriodIDRef(){return paymentCalculationPeriodIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> cashflowsMatchParameters_;
       std::string cashflowsMatchParametersIDRef_;
       bool cashflowsMatchParametersIsNull_;
       std::vector<boost::shared_ptr<PrincipalExchange>> principalExchange_;
       std::string principalExchangeIDRef_;
       bool principalExchangeIsNull_;
       std::vector<boost::shared_ptr<PaymentCalculationPeriod>> paymentCalculationPeriod_;
       std::string paymentCalculationPeriodIDRef_;
       bool paymentCalculationPeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

