// EquityStrike.hpp 
#ifndef FpmlSerialized_EquityStrike_hpp
#define FpmlSerialized_EquityStrike_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class EquityStrike : public ISerialized { 
   public: 
       EquityStrike(TiXmlNode* xmlNode);

       bool isStrikePrice(){return this->strikePriceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStrikePrice();
      std::string getStrikePriceIDRef(){return strikePriceIDRef_;}

       bool isStrikePercentage(){return this->strikePercentageIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStrikePercentage();
      std::string getStrikePercentageIDRef(){return strikePercentageIDRef_;}

       bool isStrikeDeterminationDate(){return this->strikeDeterminationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getStrikeDeterminationDate();
      std::string getStrikeDeterminationDateIDRef(){return strikeDeterminationDateIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!strikePriceIsNull_){
                count += 1;
                str = "strikePrice" ;
           }
           if(!strikePercentageIsNull_){
                count += 1;
                str = "strikePercentage" ;
           }
           if(!strikeDeterminationDateIsNull_){
                count += 1;
                str = "strikeDeterminationDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> strikePrice_;     //choice
       std::string strikePriceIDRef_;
       bool strikePriceIsNull_;
         boost::shared_ptr<XsdTypeDecimal> strikePercentage_;     //choice
       std::string strikePercentageIDRef_;
       bool strikePercentageIsNull_;
         boost::shared_ptr<AdjustableOrRelativeDate> strikeDeterminationDate_;     //choice
       std::string strikeDeterminationDateIDRef_;
       bool strikeDeterminationDateIsNull_;
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

