// RateCouponCalculation.hpp 
#ifndef FpmlSerialized_RateCouponCalculation_hpp
#define FpmlSerialized_RateCouponCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixedRateCouponCalculation.hpp>

namespace FpmlSerialized {

class RateCouponCalculation : public ISerialized { 
   public: 
       RateCouponCalculation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isFixedRateCouponCalculation(){return this->fixedRateCouponCalculationIsNull_;}
       boost::shared_ptr<FixedRateCouponCalculation> getFixedRateCouponCalculation();


       std::string getChoiceStr_rateCouponCalType(){
           std::string str;
           int count = 0;
           if(!fixedRateCouponCalculationIsNull_){
                count += 1;
                str = "fixedRateCouponCalculation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_rateCouponCalType_ = str ;
           return choiceStr_rateCouponCalType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<FixedRateCouponCalculation> fixedRateCouponCalculation_;     //choice
       
       bool fixedRateCouponCalculationIsNull_;

       //choiceStr 
       std::string choiceStr_rateCouponCalType_;

};

} //namespaceFpmlSerialized end
#endif

