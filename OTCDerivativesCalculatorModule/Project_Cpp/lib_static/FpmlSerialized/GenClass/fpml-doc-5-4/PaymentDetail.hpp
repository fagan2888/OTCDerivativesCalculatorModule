// PaymentDetail.hpp 
#ifndef FpmlSerialized_PaymentDetail_hpp
#define FpmlSerialized_PaymentDetail_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-doc-5-4/PaymentRule.hpp>

namespace FpmlSerialized {

class PaymentDetail : public PaymentBase { 
   public: 
       PaymentDetail(TiXmlNode* xmlNode);

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<Money> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

       bool isPaymentRule(){return this->paymentRuleIsNull_;}
       boost::shared_ptr<PaymentRule> getPaymentRule();
      std::string getPaymentRuleIDRef(){return paymentRuleIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!paymentAmountIsNull_){
                count += 1;
                str = "paymentAmount" ;
           }
           if(!paymentRuleIsNull_){
                count += 1;
                str = "paymentRule" ;
           }
           if(!paymentAmountIsNull_){
                count += 1;
                str = "paymentAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;
         boost::shared_ptr<Money> paymentAmount_;     //choice
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;
         boost::shared_ptr<PaymentRule> paymentRule_;     //choice
       std::string paymentRuleIDRef_;
       bool paymentRuleIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

