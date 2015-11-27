// Valuations.hpp 
#ifndef FpmlSerialized_Valuations_hpp
#define FpmlSerialized_Valuations_hpp

#include <ISerialized.hpp>
#include <fpml-valuation-5-4/AssetValuation.hpp>
#include <fpml-riskdef-5-4/ValuationReference.hpp>

namespace FpmlSerialized {

class Valuations : public ISerialized { 
   public: 
       Valuations(TiXmlNode* xmlNode);

       bool isValuation(){return this->valuationIsNull_;}
       boost::shared_ptr<AssetValuation> getValuation();
      std::string getValuationIDRef(){return valuationIDRef_;}

       bool isValuationReference(){return this->valuationReferenceIsNull_;}
       boost::shared_ptr<ValuationReference> getValuationReference();
      std::string getValuationReferenceIDRef(){return valuationReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!valuationIsNull_){
                count += 1;
                str = "valuation" ;
           }
           if(!valuationReferenceIsNull_){
                count += 1;
                str = "valuationReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AssetValuation> valuation_;     //choice
       std::string valuationIDRef_;
       bool valuationIsNull_;
         boost::shared_ptr<ValuationReference> valuationReference_;     //choice
       std::string valuationReferenceIDRef_;
       bool valuationReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

