// PaymentDetails.hpp 
#ifndef FpmlSerialized_PaymentDetails_hpp
#define FpmlSerialized_PaymentDetails_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PaymentReference.hpp>
#include <fpml-shared-5-4/GrossCashflow.hpp>
#include <fpml-shared-5-4/SettlementInformation.hpp>

namespace FpmlSerialized {

class PaymentDetails : public ISerialized { 
   public: 
       PaymentDetails(TiXmlNode* xmlNode);

       bool isPaymentReference(){return this->paymentReferenceIsNull_;}
       boost::shared_ptr<PaymentReference> getPaymentReference();
      std::string getPaymentReferenceIDRef(){return paymentReferenceIDRef_;}

       bool isGrossCashflow(){return this->grossCashflowIsNull_;}
       std::vector<boost::shared_ptr<GrossCashflow>> getGrossCashflow();
      std::string getGrossCashflowIDRef(){return grossCashflowIDRef_;}

       bool isSettlementInformation(){return this->settlementInformationIsNull_;}
       boost::shared_ptr<SettlementInformation> getSettlementInformation();
      std::string getSettlementInformationIDRef(){return settlementInformationIDRef_;}

   protected: 
       boost::shared_ptr<PaymentReference> paymentReference_;
       std::string paymentReferenceIDRef_;
       bool paymentReferenceIsNull_;
       std::vector<boost::shared_ptr<GrossCashflow>> grossCashflow_;
       std::string grossCashflowIDRef_;
       bool grossCashflowIsNull_;
       boost::shared_ptr<SettlementInformation> settlementInformation_;
       std::string settlementInformationIDRef_;
       bool settlementInformationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

