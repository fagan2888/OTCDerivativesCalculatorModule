// TradeAmendmentContent.hpp 
#ifndef FpmlSerialized_TradeAmendmentContent_hpp
#define FpmlSerialized_TradeAmendmentContent_hpp

#include <fpml-business-events-5-4/AbstractEvent.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-doc-5-4/ExecutionDateTime.hpp>
#include <fpml-shared-5-4/Payment.hpp>

namespace FpmlSerialized {

class TradeAmendmentContent : public AbstractEvent { 
   public: 
       TradeAmendmentContent(TiXmlNode* xmlNode);

       bool isTrade(){return this->tradeIsNull_;}
       boost::shared_ptr<Trade> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isAgreementDate(){return this->agreementDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAgreementDate();
      std::string getAgreementDateIDRef(){return agreementDateIDRef_;}

       bool isExecutionDateTime(){return this->executionDateTimeIsNull_;}
       boost::shared_ptr<ExecutionDateTime> getExecutionDateTime();
      std::string getExecutionDateTimeIDRef(){return executionDateTimeIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isPayment(){return this->paymentIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

   protected: 
       boost::shared_ptr<Trade> trade_;
       std::string tradeIDRef_;
       bool tradeIsNull_;
       boost::shared_ptr<XsdTypeDate> agreementDate_;
       std::string agreementDateIDRef_;
       bool agreementDateIsNull_;
       boost::shared_ptr<ExecutionDateTime> executionDateTime_;
       std::string executionDateTimeIDRef_;
       bool executionDateTimeIsNull_;
       boost::shared_ptr<XsdTypeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       std::vector<boost::shared_ptr<Payment>> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

