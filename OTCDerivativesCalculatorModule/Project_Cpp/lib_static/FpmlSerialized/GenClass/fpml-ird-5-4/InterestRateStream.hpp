// InterestRateStream.hpp 
#ifndef FpmlSerialized_InterestRateStream_hpp
#define FpmlSerialized_InterestRateStream_hpp

#include <fpml-shared-5-4/Leg.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-ird-5-4/CalculationPeriodDates.hpp>
#include <fpml-ird-5-4/PaymentDates.hpp>
#include <fpml-ird-5-4/ResetDates.hpp>
#include <fpml-ird-5-4/CalculationPeriodAmount.hpp>
#include <fpml-ird-5-4/StubCalculationPeriodAmount.hpp>
#include <fpml-shared-5-4/PrincipalExchanges.hpp>
#include <fpml-ird-5-4/Cashflows.hpp>
#include <fpml-ird-5-4/SettlementProvision.hpp>
#include <fpml-shared-5-4/Formula.hpp>

namespace FpmlSerialized {

class InterestRateStream : public Leg { 
   public: 
       InterestRateStream(TiXmlNode* xmlNode);

       bool isPayerPartyReference(){return this->payerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPayerPartyReference();
      std::string getPayerPartyReferenceIDRef(){return payerPartyReferenceIDRef_;}

       bool isPayerAccountReference(){return this->payerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getPayerAccountReference();
      std::string getPayerAccountReferenceIDRef(){return payerAccountReferenceIDRef_;}

       bool isReceiverPartyReference(){return this->receiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getReceiverPartyReference();
      std::string getReceiverPartyReferenceIDRef(){return receiverPartyReferenceIDRef_;}

       bool isReceiverAccountReference(){return this->receiverAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getReceiverAccountReference();
      std::string getReceiverAccountReferenceIDRef(){return receiverAccountReferenceIDRef_;}

       bool isCalculationPeriodDates(){return this->calculationPeriodDatesIsNull_;}
       boost::shared_ptr<CalculationPeriodDates> getCalculationPeriodDates();
      std::string getCalculationPeriodDatesIDRef(){return calculationPeriodDatesIDRef_;}

       bool isPaymentDates(){return this->paymentDatesIsNull_;}
       boost::shared_ptr<PaymentDates> getPaymentDates();
      std::string getPaymentDatesIDRef(){return paymentDatesIDRef_;}

       bool isResetDates(){return this->resetDatesIsNull_;}
       boost::shared_ptr<ResetDates> getResetDates();
      std::string getResetDatesIDRef(){return resetDatesIDRef_;}

       bool isCalculationPeriodAmount(){return this->calculationPeriodAmountIsNull_;}
       boost::shared_ptr<CalculationPeriodAmount> getCalculationPeriodAmount();
      std::string getCalculationPeriodAmountIDRef(){return calculationPeriodAmountIDRef_;}

       bool isStubCalculationPeriodAmount(){return this->stubCalculationPeriodAmountIsNull_;}
       boost::shared_ptr<StubCalculationPeriodAmount> getStubCalculationPeriodAmount();
      std::string getStubCalculationPeriodAmountIDRef(){return stubCalculationPeriodAmountIDRef_;}

       bool isPrincipalExchanges(){return this->principalExchangesIsNull_;}
       boost::shared_ptr<PrincipalExchanges> getPrincipalExchanges();
      std::string getPrincipalExchangesIDRef(){return principalExchangesIDRef_;}

       bool isCashflows(){return this->cashflowsIsNull_;}
       boost::shared_ptr<Cashflows> getCashflows();
      std::string getCashflowsIDRef(){return cashflowsIDRef_;}

       bool isSettlementProvision(){return this->settlementProvisionIsNull_;}
       boost::shared_ptr<SettlementProvision> getSettlementProvision();
      std::string getSettlementProvisionIDRef(){return settlementProvisionIDRef_;}

       bool isFormula(){return this->formulaIsNull_;}
       boost::shared_ptr<Formula> getFormula();
      std::string getFormulaIDRef(){return formulaIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> payerPartyReference_;
       std::string payerPartyReferenceIDRef_;
       bool payerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> payerAccountReference_;
       std::string payerAccountReferenceIDRef_;
       bool payerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> receiverPartyReference_;
       std::string receiverPartyReferenceIDRef_;
       bool receiverPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> receiverAccountReference_;
       std::string receiverAccountReferenceIDRef_;
       bool receiverAccountReferenceIsNull_;
       boost::shared_ptr<CalculationPeriodDates> calculationPeriodDates_;
       std::string calculationPeriodDatesIDRef_;
       bool calculationPeriodDatesIsNull_;
       boost::shared_ptr<PaymentDates> paymentDates_;
       std::string paymentDatesIDRef_;
       bool paymentDatesIsNull_;
       boost::shared_ptr<ResetDates> resetDates_;
       std::string resetDatesIDRef_;
       bool resetDatesIsNull_;
       boost::shared_ptr<CalculationPeriodAmount> calculationPeriodAmount_;
       std::string calculationPeriodAmountIDRef_;
       bool calculationPeriodAmountIsNull_;
       boost::shared_ptr<StubCalculationPeriodAmount> stubCalculationPeriodAmount_;
       std::string stubCalculationPeriodAmountIDRef_;
       bool stubCalculationPeriodAmountIsNull_;
       boost::shared_ptr<PrincipalExchanges> principalExchanges_;
       std::string principalExchangesIDRef_;
       bool principalExchangesIsNull_;
       boost::shared_ptr<Cashflows> cashflows_;
       std::string cashflowsIDRef_;
       bool cashflowsIsNull_;
       boost::shared_ptr<SettlementProvision> settlementProvision_;
       std::string settlementProvisionIDRef_;
       bool settlementProvisionIsNull_;
       boost::shared_ptr<Formula> formula_;
       std::string formulaIDRef_;
       bool formulaIsNull_;

};

} //namespaceFpmlSerialized end
#endif

