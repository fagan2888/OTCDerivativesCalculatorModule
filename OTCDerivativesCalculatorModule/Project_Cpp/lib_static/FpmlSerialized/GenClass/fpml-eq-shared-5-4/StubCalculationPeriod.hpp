// StubCalculationPeriod.hpp 
#ifndef FpmlSerialized_StubCalculationPeriod_hpp
#define FpmlSerialized_StubCalculationPeriod_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Stub.hpp>

namespace FpmlSerialized {

class StubCalculationPeriod : public ISerialized { 
   public: 
       StubCalculationPeriod(TiXmlNode* xmlNode);

       bool isInitialStub(){return this->initialStubIsNull_;}
       boost::shared_ptr<Stub> getInitialStub();
      std::string getInitialStubIDRef(){return initialStubIDRef_;}

       bool isFinalStub(){return this->finalStubIsNull_;}
       boost::shared_ptr<Stub> getFinalStub();
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
         boost::shared_ptr<Stub> initialStub_;     //choice
       std::string initialStubIDRef_;
       bool initialStubIsNull_;
         boost::shared_ptr<Stub> finalStub_;     //choice
       std::string finalStubIDRef_;
       bool finalStubIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

