// SinglePayment.hpp 
#ifndef FpmlSerialized_SinglePayment_hpp
#define FpmlSerialized_SinglePayment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class SinglePayment : public PaymentBase { 
   public: 
       SinglePayment(TiXmlNode* xmlNode);

       bool isAdjustablePaymentDate(){return this->adjustablePaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustablePaymentDate();
      std::string getAdjustablePaymentDateIDRef(){return adjustablePaymentDateIDRef_;}

       bool isAdjustedPaymentDate(){return this->adjustedPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedPaymentDate();
      std::string getAdjustedPaymentDateIDRef(){return adjustedPaymentDateIDRef_;}

       bool isFixedAmount(){return this->fixedAmountIsNull_;}
       boost::shared_ptr<Money> getFixedAmount();
      std::string getFixedAmountIDRef(){return fixedAmountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> adjustablePaymentDate_;
       std::string adjustablePaymentDateIDRef_;
       bool adjustablePaymentDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedPaymentDate_;
       std::string adjustedPaymentDateIDRef_;
       bool adjustedPaymentDateIsNull_;
       boost::shared_ptr<Money> fixedAmount_;
       std::string fixedAmountIDRef_;
       bool fixedAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

