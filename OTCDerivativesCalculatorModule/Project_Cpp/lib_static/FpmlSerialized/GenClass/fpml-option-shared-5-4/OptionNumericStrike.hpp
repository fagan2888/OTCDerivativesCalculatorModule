// OptionNumericStrike.hpp 
#ifndef FpmlSerialized_OptionNumericStrike_hpp
#define FpmlSerialized_OptionNumericStrike_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class OptionNumericStrike : public ISerialized { 
   public: 
       OptionNumericStrike(TiXmlNode* xmlNode);

       bool isStrikePrice(){return this->strikePriceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStrikePrice();
      std::string getStrikePriceIDRef(){return strikePriceIDRef_;}

       bool isStrikePercentage(){return this->strikePercentageIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStrikePercentage();
      std::string getStrikePercentageIDRef(){return strikePercentageIDRef_;}

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

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

