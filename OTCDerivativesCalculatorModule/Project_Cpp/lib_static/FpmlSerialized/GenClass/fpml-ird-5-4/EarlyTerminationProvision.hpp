// EarlyTerminationProvision.hpp 
#ifndef FpmlSerialized_EarlyTerminationProvision_hpp
#define FpmlSerialized_EarlyTerminationProvision_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/MandatoryEarlyTermination.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-ird-5-4/OptionalEarlyTermination.hpp>
#include <fpml-ird-5-4/ExercisePeriod.hpp>

namespace FpmlSerialized {

class EarlyTerminationProvision : public ISerialized { 
   public: 
       EarlyTerminationProvision(TiXmlNode* xmlNode);

       bool isMandatoryEarlyTermination(){return this->mandatoryEarlyTerminationIsNull_;}
       boost::shared_ptr<MandatoryEarlyTermination> getMandatoryEarlyTermination();
      std::string getMandatoryEarlyTerminationIDRef(){return mandatoryEarlyTerminationIDRef_;}

       bool isMandatoryEarlyTerminationDateTenor(){return this->mandatoryEarlyTerminationDateTenorIsNull_;}
       boost::shared_ptr<Period> getMandatoryEarlyTerminationDateTenor();
      std::string getMandatoryEarlyTerminationDateTenorIDRef(){return mandatoryEarlyTerminationDateTenorIDRef_;}

       bool isOptionalEarlyTermination(){return this->optionalEarlyTerminationIsNull_;}
       boost::shared_ptr<OptionalEarlyTermination> getOptionalEarlyTermination();
      std::string getOptionalEarlyTerminationIDRef(){return optionalEarlyTerminationIDRef_;}

       bool isOptionalEarlyTerminationParameters(){return this->optionalEarlyTerminationParametersIsNull_;}
       boost::shared_ptr<ExercisePeriod> getOptionalEarlyTerminationParameters();
      std::string getOptionalEarlyTerminationParametersIDRef(){return optionalEarlyTerminationParametersIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!mandatoryEarlyTerminationIsNull_){
                count += 1;
                str = "mandatoryEarlyTermination" ;
           }
           if(!mandatoryEarlyTerminationDateTenorIsNull_){
                count += 1;
                str = "mandatoryEarlyTerminationDateTenor" ;
           }
           if(!mandatoryEarlyTerminationIsNull_){
                count += 1;
                str = "mandatoryEarlyTermination" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!optionalEarlyTerminationIsNull_){
                count += 1;
                str = "optionalEarlyTermination" ;
           }
           if(!optionalEarlyTerminationParametersIsNull_){
                count += 1;
                str = "optionalEarlyTerminationParameters" ;
           }
           if(!optionalEarlyTerminationIsNull_){
                count += 1;
                str = "optionalEarlyTermination" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
       std::string getChoiceStr_3(){
           std::string str;
           int count = 0;
           if(!optionalEarlyTerminationIsNull_){
                count += 1;
                str = "optionalEarlyTermination" ;
           }
           if(!optionalEarlyTerminationParametersIsNull_){
                count += 1;
                str = "optionalEarlyTerminationParameters" ;
           }
           if(!optionalEarlyTerminationIsNull_){
                count += 1;
                str = "optionalEarlyTermination" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_3_ = str ;
           return choiceStr_3_;
       }
   protected: 
         boost::shared_ptr<MandatoryEarlyTermination> mandatoryEarlyTermination_;     //choice
       std::string mandatoryEarlyTerminationIDRef_;
       bool mandatoryEarlyTerminationIsNull_;
         boost::shared_ptr<Period> mandatoryEarlyTerminationDateTenor_;     //choice
       std::string mandatoryEarlyTerminationDateTenorIDRef_;
       bool mandatoryEarlyTerminationDateTenorIsNull_;
         boost::shared_ptr<OptionalEarlyTermination> optionalEarlyTermination_;     //choice
       std::string optionalEarlyTerminationIDRef_;
       bool optionalEarlyTerminationIsNull_;
         boost::shared_ptr<ExercisePeriod> optionalEarlyTerminationParameters_;     //choice
       std::string optionalEarlyTerminationParametersIDRef_;
       bool optionalEarlyTerminationParametersIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;
       std::string choiceStr_3_;

};

} //namespaceFpmlSerialized end
#endif

