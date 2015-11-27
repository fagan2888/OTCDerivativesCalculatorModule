// StubCalculationPeriodAmount.hpp 
#ifndef FpmlSerialized_StubCalculationPeriodAmount_hpp
#define FpmlSerialized_StubCalculationPeriodAmount_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/CalculationPeriodDatesReference.hpp>
#include <fpml-shared-5-4/StubValue.hpp>

namespace FpmlSerialized {

class StubCalculationPeriodAmount : public ISerialized { 
   public: 
       StubCalculationPeriodAmount(TiXmlNode* xmlNode);

       bool isCalculationPeriodDatesReference(){return this->calculationPeriodDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodDatesReference> getCalculationPeriodDatesReference();
      std::string getCalculationPeriodDatesReferenceIDRef(){return calculationPeriodDatesReferenceIDRef_;}

       bool isInitialStub(){return this->initialStubIsNull_;}
       boost::shared_ptr<StubValue> getInitialStub();
      std::string getInitialStubIDRef(){return initialStubIDRef_;}

       bool isFinalStub(){return this->finalStubIsNull_;}
       boost::shared_ptr<StubValue> getFinalStub();
      std::string getFinalStubIDRef(){return finalStubIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!initialStubIsNull_){
                count += 1;
                str = "initialStub" ;
           }
           if(!finalStubIsNull_){
                count += 1;
                str = "finalStub" ;
           }
           if(!finalStubIsNull_){
                count += 1;
                str = "finalStub" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference_;
       std::string calculationPeriodDatesReferenceIDRef_;
       bool calculationPeriodDatesReferenceIsNull_;
         boost::shared_ptr<StubValue> initialStub_;     //choice
       std::string initialStubIDRef_;
       bool initialStubIsNull_;
         boost::shared_ptr<StubValue> finalStub_;     //choice
       std::string finalStubIDRef_;
       bool finalStubIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

