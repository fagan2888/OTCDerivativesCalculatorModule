// ClassifiedPayment.hpp 
#ifndef FpmlSerialized_ClassifiedPayment_hpp
#define FpmlSerialized_ClassifiedPayment_hpp

#include <fpml-shared-5-4/NonNegativePayment.hpp>
#include <fpml-shared-5-4/PaymentType.hpp>

namespace FpmlSerialized {

class ClassifiedPayment : public NonNegativePayment { 
   public: 
       ClassifiedPayment(TiXmlNode* xmlNode);

       bool isPaymentType(){return this->paymentTypeIsNull_;}
       std::vector<boost::shared_ptr<PaymentType>> getPaymentType();
      std::string getPaymentTypeIDRef(){return paymentTypeIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PaymentType>> paymentType_;
       std::string paymentTypeIDRef_;
       bool paymentTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

