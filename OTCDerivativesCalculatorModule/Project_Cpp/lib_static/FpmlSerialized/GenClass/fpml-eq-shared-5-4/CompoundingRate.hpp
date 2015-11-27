// CompoundingRate.hpp 
#ifndef FpmlSerialized_CompoundingRate_hpp
#define FpmlSerialized_CompoundingRate_hpp

#include <ISerialized.hpp>
#include <fpml-eq-shared-5-4/FloatingRateCalculationReference.hpp>
#include <fpml-shared-5-4/InterestAccrualsMethod.hpp>

namespace FpmlSerialized {

class CompoundingRate : public ISerialized { 
   public: 
       CompoundingRate(TiXmlNode* xmlNode);

       bool isInterestLegRate(){return this->interestLegRateIsNull_;}
       boost::shared_ptr<FloatingRateCalculationReference> getInterestLegRate();
      std::string getInterestLegRateIDRef(){return interestLegRateIDRef_;}

       bool isSpecificRate(){return this->specificRateIsNull_;}
       boost::shared_ptr<InterestAccrualsMethod> getSpecificRate();
      std::string getSpecificRateIDRef(){return specificRateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!interestLegRateIsNull_){
                count += 1;
                str = "interestLegRate" ;
           }
           if(!specificRateIsNull_){
                count += 1;
                str = "specificRate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<FloatingRateCalculationReference> interestLegRate_;     //choice
       std::string interestLegRateIDRef_;
       bool interestLegRateIsNull_;
         boost::shared_ptr<InterestAccrualsMethod> specificRate_;     //choice
       std::string specificRateIDRef_;
       bool specificRateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

