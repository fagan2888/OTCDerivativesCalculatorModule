// Excel_cashFlowResult.hpp 
#ifndef FpmlSerialized_Excel_cashFlowResult_hpp
#define FpmlSerialized_Excel_cashFlowResult_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_cashFlowResult : public ISerialized { 
   public: 
       Excel_cashFlowResult(TiXmlNode* xmlNode);

       bool isSeq(){return this->seqIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSeq();


       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isCashFlow(){return this->cashFlowIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCashFlow();


       bool isYield(){return this->yieldIsNull_;}
       boost::shared_ptr<XsdTypeToken> getYield();


       bool isDiscount(){return this->discountIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDiscount();


       bool isExProb(){return this->exProbIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExProb();


       bool isNotionalPayment(){return this->notionalPaymentIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotionalPayment();


       bool isFxRate_forward(){return this->fxRate_forwardIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFxRate_forward();


       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getValue();


   protected: 
       boost::shared_ptr<XsdTypeToken> seq_;
       
       bool seqIsNull_;
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> cashFlow_;
       
       bool cashFlowIsNull_;
       boost::shared_ptr<XsdTypeToken> yield_;
       
       bool yieldIsNull_;
       boost::shared_ptr<XsdTypeToken> discount_;
       
       bool discountIsNull_;
       boost::shared_ptr<XsdTypeToken> exProb_;
       
       bool exProbIsNull_;
       boost::shared_ptr<XsdTypeToken> notionalPayment_;
       
       bool notionalPaymentIsNull_;
       boost::shared_ptr<XsdTypeToken> fxRate_forward_;
       
       bool fxRate_forwardIsNull_;
       boost::shared_ptr<XsdTypeToken> value_;
       
       bool valueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

