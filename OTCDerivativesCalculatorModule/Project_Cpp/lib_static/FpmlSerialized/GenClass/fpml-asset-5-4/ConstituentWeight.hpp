// ConstituentWeight.hpp 
#ifndef FpmlSerialized_ConstituentWeight_hpp
#define FpmlSerialized_ConstituentWeight_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/RestrictedPercentage.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class ConstituentWeight : public ISerialized { 
   public: 
       ConstituentWeight(TiXmlNode* xmlNode);

       bool isOpenUnits(){return this->openUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOpenUnits();
      std::string getOpenUnitsIDRef(){return openUnitsIDRef_;}

       bool isBasketPercentage(){return this->basketPercentageIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getBasketPercentage();
      std::string getBasketPercentageIDRef(){return basketPercentageIDRef_;}

       bool isBasketAmount(){return this->basketAmountIsNull_;}
       boost::shared_ptr<Money> getBasketAmount();
      std::string getBasketAmountIDRef(){return basketAmountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!openUnitsIsNull_){
                count += 1;
                str = "openUnits" ;
           }
           if(!basketPercentageIsNull_){
                count += 1;
                str = "basketPercentage" ;
           }
           if(!basketAmountIsNull_){
                count += 1;
                str = "basketAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> openUnits_;     //choice
       std::string openUnitsIDRef_;
       bool openUnitsIsNull_;
         boost::shared_ptr<RestrictedPercentage> basketPercentage_;     //choice
       std::string basketPercentageIDRef_;
       bool basketPercentageIsNull_;
         boost::shared_ptr<Money> basketAmount_;     //choice
       std::string basketAmountIDRef_;
       bool basketAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

