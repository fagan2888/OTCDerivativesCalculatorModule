// PercentageRule.hpp 
#ifndef FpmlSerialized_PercentageRule_hpp
#define FpmlSerialized_PercentageRule_hpp

#include <fpml-doc-5-4/PaymentRule.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/NotionalAmountReference.hpp>

namespace FpmlSerialized {

class PercentageRule : public PaymentRule { 
   public: 
       PercentageRule(TiXmlNode* xmlNode);

       bool isPaymentPercent(){return this->paymentPercentIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPaymentPercent();
      std::string getPaymentPercentIDRef(){return paymentPercentIDRef_;}

       bool isNotionalAmountReference(){return this->notionalAmountReferenceIsNull_;}
       boost::shared_ptr<NotionalAmountReference> getNotionalAmountReference();
      std::string getNotionalAmountReferenceIDRef(){return notionalAmountReferenceIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> paymentPercent_;
       std::string paymentPercentIDRef_;
       bool paymentPercentIsNull_;
       boost::shared_ptr<NotionalAmountReference> notionalAmountReference_;
       std::string notionalAmountReferenceIDRef_;
       bool notionalAmountReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

