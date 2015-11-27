// CalculationFromObservation.hpp 
#ifndef FpmlSerialized_CalculationFromObservation_hpp
#define FpmlSerialized_CalculationFromObservation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class CalculationFromObservation : public ISerialized { 
   public: 
       CalculationFromObservation(TiXmlNode* xmlNode);

       bool isInitialLevel(){return this->initialLevelIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getInitialLevel();
      std::string getInitialLevelIDRef(){return initialLevelIDRef_;}

       bool isClosingLevel(){return this->closingLevelIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getClosingLevel();
      std::string getClosingLevelIDRef(){return closingLevelIDRef_;}

       bool isExpiringLevel(){return this->expiringLevelIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExpiringLevel();
      std::string getExpiringLevelIDRef(){return expiringLevelIDRef_;}

       bool isExpectedN(){return this->expectedNIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getExpectedN();
      std::string getExpectedNIDRef(){return expectedNIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!initialLevelIsNull_){
                count += 1;
                str = "initialLevel" ;
           }
           if(!closingLevelIsNull_){
                count += 1;
                str = "closingLevel" ;
           }
           if(!expiringLevelIsNull_){
                count += 1;
                str = "expiringLevel" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> initialLevel_;     //choice
       std::string initialLevelIDRef_;
       bool initialLevelIsNull_;
         boost::shared_ptr<XsdTypeBoolean> closingLevel_;     //choice
       std::string closingLevelIDRef_;
       bool closingLevelIsNull_;
         boost::shared_ptr<XsdTypeBoolean> expiringLevel_;     //choice
       std::string expiringLevelIDRef_;
       bool expiringLevelIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> expectedN_;
       std::string expectedNIDRef_;
       bool expectedNIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

