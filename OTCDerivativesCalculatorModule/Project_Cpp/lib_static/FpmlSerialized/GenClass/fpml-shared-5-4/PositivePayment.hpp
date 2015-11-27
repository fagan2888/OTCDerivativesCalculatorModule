// PositivePayment.hpp 
#ifndef FpmlSerialized_PositivePayment_hpp
#define FpmlSerialized_PositivePayment_hpp

#include <fpml-shared-5-4/PaymentBaseExtended.hpp>
#include <fpml-shared-5-4/PositiveMoney.hpp>

namespace FpmlSerialized {

class PositivePayment : public PaymentBaseExtended { 
   public: 
       PositivePayment(TiXmlNode* xmlNode);

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<PositiveMoney> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

   protected: 
       boost::shared_ptr<PositiveMoney> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

