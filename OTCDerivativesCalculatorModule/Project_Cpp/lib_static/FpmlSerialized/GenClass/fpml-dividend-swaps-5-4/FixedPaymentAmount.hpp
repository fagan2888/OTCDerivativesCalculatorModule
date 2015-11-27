// FixedPaymentAmount.hpp 
#ifndef FpmlSerialized_FixedPaymentAmount_hpp
#define FpmlSerialized_FixedPaymentAmount_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>

namespace FpmlSerialized {

class FixedPaymentAmount : public PaymentBase { 
   public: 
       FixedPaymentAmount(TiXmlNode* xmlNode);

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;
       boost::shared_ptr<RelativeDateOffset> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

