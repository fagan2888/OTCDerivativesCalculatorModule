// AdditionalPaymentAmount.hpp 
#ifndef FpmlSerialized_AdditionalPaymentAmount_hpp
#define FpmlSerialized_AdditionalPaymentAmount_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/Formula.hpp>

namespace FpmlSerialized {

class AdditionalPaymentAmount : public ISerialized { 
   public: 
       AdditionalPaymentAmount(TiXmlNode* xmlNode);

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

       bool isFormula(){return this->formulaIsNull_;}
       boost::shared_ptr<Formula> getFormula();
      std::string getFormulaIDRef(){return formulaIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;
       boost::shared_ptr<Formula> formula_;
       std::string formulaIDRef_;
       bool formulaIsNull_;

};

} //namespaceFpmlSerialized end
#endif

