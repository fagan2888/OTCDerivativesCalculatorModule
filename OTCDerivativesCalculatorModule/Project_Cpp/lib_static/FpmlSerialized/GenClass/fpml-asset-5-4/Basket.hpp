// Basket.hpp 
#ifndef FpmlSerialized_Basket_hpp
#define FpmlSerialized_Basket_hpp

#include <fpml-asset-5-4/Asset.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/BasketConstituent.hpp>
#include <fpml-asset-5-4/BasketName.hpp>
#include <fpml-asset-5-4/BasketId.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class Basket : public Asset { 
   public: 
       Basket(TiXmlNode* xmlNode);

       bool isOpenUnits(){return this->openUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOpenUnits();
      std::string getOpenUnitsIDRef(){return openUnitsIDRef_;}

       bool isBasketConstituent(){return this->basketConstituentIsNull_;}
       std::vector<boost::shared_ptr<BasketConstituent>> getBasketConstituent();
      std::string getBasketConstituentIDRef(){return basketConstituentIDRef_;}

       bool isBasketDivisor(){return this->basketDivisorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getBasketDivisor();
      std::string getBasketDivisorIDRef(){return basketDivisorIDRef_;}

       bool isBasketName(){return this->basketNameIsNull_;}
       boost::shared_ptr<BasketName> getBasketName();
      std::string getBasketNameIDRef(){return basketNameIDRef_;}

       bool isBasketId(){return this->basketIdIsNull_;}
       std::vector<boost::shared_ptr<BasketId>> getBasketId();
      std::string getBasketIdIDRef(){return basketIdIDRef_;}

       bool isBasketCurrency(){return this->basketCurrencyIsNull_;}
       boost::shared_ptr<Currency> getBasketCurrency();
      std::string getBasketCurrencyIDRef(){return basketCurrencyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!basketNameIsNull_){
                count += 1;
                str = "basketName" ;
           }
           if(!basketIdIsNull_){
                count += 1;
                str = "basketId" ;
           }
           if(!basketIdIsNull_){
                count += 1;
                str = "basketId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeDecimal> openUnits_;
       std::string openUnitsIDRef_;
       bool openUnitsIsNull_;
       std::vector<boost::shared_ptr<BasketConstituent>> basketConstituent_;
       std::string basketConstituentIDRef_;
       bool basketConstituentIsNull_;
       boost::shared_ptr<XsdTypeDecimal> basketDivisor_;
       std::string basketDivisorIDRef_;
       bool basketDivisorIsNull_;
         boost::shared_ptr<BasketName> basketName_;     //choice
       std::string basketNameIDRef_;
       bool basketNameIsNull_;
         std::vector<boost::shared_ptr<BasketId>> basketId_;     //choice
       std::string basketIdIDRef_;
       bool basketIdIsNull_;
       boost::shared_ptr<Currency> basketCurrency_;
       std::string basketCurrencyIDRef_;
       bool basketCurrencyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

