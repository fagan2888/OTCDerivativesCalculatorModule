// PricingDataPointCoordinate.hpp 
#ifndef FpmlSerialized_PricingDataPointCoordinate_hpp
#define FpmlSerialized_PricingDataPointCoordinate_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/TimeDimension.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-riskdef-5-4/GenericDimension.hpp>

namespace FpmlSerialized {

class PricingDataPointCoordinate : public ISerialized { 
   public: 
       PricingDataPointCoordinate(TiXmlNode* xmlNode);

       bool isTerm(){return this->termIsNull_;}
       boost::shared_ptr<TimeDimension> getTerm();
      std::string getTermIDRef(){return termIDRef_;}

       bool isExpiration(){return this->expirationIsNull_;}
       boost::shared_ptr<TimeDimension> getExpiration();
      std::string getExpirationIDRef(){return expirationIDRef_;}

       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStrike();
      std::string getStrikeIDRef(){return strikeIDRef_;}

       bool isGeneric(){return this->genericIsNull_;}
       boost::shared_ptr<GenericDimension> getGeneric();
      std::string getGenericIDRef(){return genericIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!termIsNull_){
                count += 1;
                str = "term" ;
           }
           if(!expirationIsNull_){
                count += 1;
                str = "expiration" ;
           }
           if(!strikeIsNull_){
                count += 1;
                str = "strike" ;
           }
           if(!genericIsNull_){
                count += 1;
                str = "generic" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<TimeDimension> term_;     //choice
       std::string termIDRef_;
       bool termIsNull_;
         boost::shared_ptr<TimeDimension> expiration_;     //choice
       std::string expirationIDRef_;
       bool expirationIsNull_;
         boost::shared_ptr<XsdTypeDecimal> strike_;     //choice
       std::string strikeIDRef_;
       bool strikeIsNull_;
         boost::shared_ptr<GenericDimension> generic_;     //choice
       std::string genericIDRef_;
       bool genericIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

