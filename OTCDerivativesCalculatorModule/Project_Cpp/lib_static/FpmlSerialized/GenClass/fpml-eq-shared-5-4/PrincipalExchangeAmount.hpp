// PrincipalExchangeAmount.hpp 
#ifndef FpmlSerialized_PrincipalExchangeAmount_hpp
#define FpmlSerialized_PrincipalExchangeAmount_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AmountReference.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class PrincipalExchangeAmount : public ISerialized { 
   public: 
       PrincipalExchangeAmount(TiXmlNode* xmlNode);

       bool isAmountRelativeTo(){return this->amountRelativeToIsNull_;}
       boost::shared_ptr<AmountReference> getAmountRelativeTo();
      std::string getAmountRelativeToIDRef(){return amountRelativeToIDRef_;}

       bool isDeterminationMethod(){return this->determinationMethodIsNull_;}
       boost::shared_ptr<DeterminationMethod> getDeterminationMethod();
      std::string getDeterminationMethodIDRef(){return determinationMethodIDRef_;}

       bool isPrincipalAmount(){return this->principalAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPrincipalAmount();
      std::string getPrincipalAmountIDRef(){return principalAmountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!amountRelativeToIsNull_){
                count += 1;
                str = "amountRelativeTo" ;
           }
           if(!determinationMethodIsNull_){
                count += 1;
                str = "determinationMethod" ;
           }
           if(!principalAmountIsNull_){
                count += 1;
                str = "principalAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AmountReference> amountRelativeTo_;     //choice
       std::string amountRelativeToIDRef_;
       bool amountRelativeToIsNull_;
         boost::shared_ptr<DeterminationMethod> determinationMethod_;     //choice
       std::string determinationMethodIDRef_;
       bool determinationMethodIsNull_;
         boost::shared_ptr<NonNegativeMoney> principalAmount_;     //choice
       std::string principalAmountIDRef_;
       bool principalAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

