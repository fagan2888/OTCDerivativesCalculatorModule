// NonNegativePayment.hpp 
#ifndef FpmlSerialized_NonNegativePayment_hpp
#define FpmlSerialized_NonNegativePayment_hpp

#include <fpml-shared-5-4/PaymentBaseExtended.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class NonNegativePayment : public PaymentBaseExtended { 
   public: 
       NonNegativePayment(TiXmlNode* xmlNode);

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

