// BulletPayment.hpp 
#ifndef FpmlSerialized_BulletPayment_hpp
#define FpmlSerialized_BulletPayment_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/Payment.hpp>

namespace FpmlSerialized {

class BulletPayment : public Product { 
   public: 
       BulletPayment(TiXmlNode* xmlNode);

       bool isPayment(){return this->paymentIsNull_;}
       boost::shared_ptr<Payment> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

   protected: 
       boost::shared_ptr<Payment> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

