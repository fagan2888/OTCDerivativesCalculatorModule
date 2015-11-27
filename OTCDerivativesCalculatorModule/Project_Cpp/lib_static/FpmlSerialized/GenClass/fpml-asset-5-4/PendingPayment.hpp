// PendingPayment.hpp 
#ifndef FpmlSerialized_PendingPayment_hpp
#define FpmlSerialized_PendingPayment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class PendingPayment : public PaymentBase { 
   public: 
       PendingPayment(TiXmlNode* xmlNode);

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<Money> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

       bool isAccruedInterest(){return this->accruedInterestIsNull_;}
       boost::shared_ptr<Money> getAccruedInterest();
      std::string getAccruedInterestIDRef(){return accruedInterestIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;
       boost::shared_ptr<Money> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;
       boost::shared_ptr<Money> accruedInterest_;
       std::string accruedInterestIDRef_;
       bool accruedInterestIsNull_;

};

} //namespaceFpmlSerialized end
#endif

