// StubValue.hpp 
#ifndef FpmlSerialized_StubValue_hpp
#define FpmlSerialized_StubValue_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/FloatingRate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class StubValue : public ISerialized { 
   public: 
       StubValue(TiXmlNode* xmlNode);

       bool isFloatingRate(){return this->floatingRateIsNull_;}
       std::vector<boost::shared_ptr<FloatingRate>> getFloatingRate();
      std::string getFloatingRateIDRef(){return floatingRateIDRef_;}

       bool isStubRate(){return this->stubRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStubRate();
      std::string getStubRateIDRef(){return stubRateIDRef_;}

       bool isStubAmount(){return this->stubAmountIsNull_;}
       boost::shared_ptr<Money> getStubAmount();
      std::string getStubAmountIDRef(){return stubAmountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!floatingRateIsNull_){
                count += 1;
                str = "floatingRate" ;
           }
           if(!stubRateIsNull_){
                count += 1;
                str = "stubRate" ;
           }
           if(!stubAmountIsNull_){
                count += 1;
                str = "stubAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         std::vector<boost::shared_ptr<FloatingRate>> floatingRate_;     //choice
       std::string floatingRateIDRef_;
       bool floatingRateIsNull_;
         boost::shared_ptr<XsdTypeDecimal> stubRate_;     //choice
       std::string stubRateIDRef_;
       bool stubRateIsNull_;
         boost::shared_ptr<Money> stubAmount_;     //choice
       std::string stubAmountIDRef_;
       bool stubAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

