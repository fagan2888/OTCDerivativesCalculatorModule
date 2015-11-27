// CashflowNotional.hpp 
#ifndef FpmlSerialized_CashflowNotional_hpp
#define FpmlSerialized_CashflowNotional_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class CashflowNotional : public ISerialized { 
   public: 
       CashflowNotional(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isUnits(){return this->unitsIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getUnits();
      std::string getUnitsIDRef(){return unitsIDRef_;}

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!currencyIsNull_){
                count += 1;
                str = "currency" ;
           }
           if(!unitsIsNull_){
                count += 1;
                str = "units" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<Currency> currency_;     //choice
       std::string currencyIDRef_;
       bool currencyIsNull_;
         boost::shared_ptr<XsdTypeNormalizedString> units_;     //choice
       std::string unitsIDRef_;
       bool unitsIsNull_;
       boost::shared_ptr<XsdTypeDecimal> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

