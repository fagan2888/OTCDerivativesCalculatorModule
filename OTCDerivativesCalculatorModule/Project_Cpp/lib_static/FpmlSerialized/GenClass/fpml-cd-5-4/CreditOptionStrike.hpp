// CreditOptionStrike.hpp 
#ifndef FpmlSerialized_CreditOptionStrike_hpp
#define FpmlSerialized_CreditOptionStrike_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-cd-5-4/FixedRateReference.hpp>

namespace FpmlSerialized {

class CreditOptionStrike : public ISerialized { 
   public: 
       CreditOptionStrike(TiXmlNode* xmlNode);

       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSpread();
      std::string getSpreadIDRef(){return spreadIDRef_;}

       bool isPrice(){return this->priceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPrice();
      std::string getPriceIDRef(){return priceIDRef_;}

       bool isStrikeReference(){return this->strikeReferenceIsNull_;}
       boost::shared_ptr<FixedRateReference> getStrikeReference();
      std::string getStrikeReferenceIDRef(){return strikeReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!spreadIsNull_){
                count += 1;
                str = "spread" ;
           }
           if(!priceIsNull_){
                count += 1;
                str = "price" ;
           }
           if(!strikeReferenceIsNull_){
                count += 1;
                str = "strikeReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> spread_;     //choice
       std::string spreadIDRef_;
       bool spreadIsNull_;
         boost::shared_ptr<XsdTypeDecimal> price_;     //choice
       std::string priceIDRef_;
       bool priceIsNull_;
         boost::shared_ptr<FixedRateReference> strikeReference_;     //choice
       std::string strikeReferenceIDRef_;
       bool strikeReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

