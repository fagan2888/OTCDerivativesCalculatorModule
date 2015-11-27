// BondOptionStrike.hpp 
#ifndef FpmlSerialized_BondOptionStrike_hpp
#define FpmlSerialized_BondOptionStrike_hpp

#include <ISerialized.hpp>
#include <fpml-bond-option-5-4/ReferenceSwapCurve.hpp>
#include <fpml-option-shared-5-4/OptionStrike.hpp>

namespace FpmlSerialized {

class BondOptionStrike : public ISerialized { 
   public: 
       BondOptionStrike(TiXmlNode* xmlNode);

       bool isReferenceSwapCurve(){return this->referenceSwapCurveIsNull_;}
       boost::shared_ptr<ReferenceSwapCurve> getReferenceSwapCurve();
      std::string getReferenceSwapCurveIDRef(){return referenceSwapCurveIDRef_;}

       bool isPrice(){return this->priceIsNull_;}
       boost::shared_ptr<OptionStrike> getPrice();
      std::string getPriceIDRef(){return priceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!referenceSwapCurveIsNull_){
                count += 1;
                str = "referenceSwapCurve" ;
           }
           if(!priceIsNull_){
                count += 1;
                str = "price" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<ReferenceSwapCurve> referenceSwapCurve_;     //choice
       std::string referenceSwapCurveIDRef_;
       bool referenceSwapCurveIsNull_;
         boost::shared_ptr<OptionStrike> price_;     //choice
       std::string priceIDRef_;
       bool priceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

