// DateRelativeToPaymentDates.hpp 
#ifndef FpmlSerialized_DateRelativeToPaymentDates_hpp
#define FpmlSerialized_DateRelativeToPaymentDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/PaymentDatesReference.hpp>

namespace FpmlSerialized {

class DateRelativeToPaymentDates : public ISerialized { 
   public: 
       DateRelativeToPaymentDates(TiXmlNode* xmlNode);

       bool isPaymentDatesReference(){return this->paymentDatesReferenceIsNull_;}
       std::vector<boost::shared_ptr<PaymentDatesReference>> getPaymentDatesReference();
      std::string getPaymentDatesReferenceIDRef(){return paymentDatesReferenceIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PaymentDatesReference>> paymentDatesReference_;
       std::string paymentDatesReferenceIDRef_;
       bool paymentDatesReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

