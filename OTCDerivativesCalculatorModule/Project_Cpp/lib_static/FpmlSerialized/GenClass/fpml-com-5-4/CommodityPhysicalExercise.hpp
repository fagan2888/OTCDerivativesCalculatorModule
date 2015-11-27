// CommodityPhysicalExercise.hpp 
#ifndef FpmlSerialized_CommodityPhysicalExercise_hpp
#define FpmlSerialized_CommodityPhysicalExercise_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityPhysicalAmericanExercise.hpp>
#include <fpml-com-5-4/CommodityPhysicalEuropeanExercise.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class CommodityPhysicalExercise : public ISerialized { 
   public: 
       CommodityPhysicalExercise(TiXmlNode* xmlNode);

       bool isAmericanExercise(){return this->americanExerciseIsNull_;}
       boost::shared_ptr<CommodityPhysicalAmericanExercise> getAmericanExercise();
      std::string getAmericanExerciseIDRef(){return americanExerciseIDRef_;}

       bool isEuropeanExercise(){return this->europeanExerciseIsNull_;}
       boost::shared_ptr<CommodityPhysicalEuropeanExercise> getEuropeanExercise();
      std::string getEuropeanExerciseIDRef(){return europeanExerciseIDRef_;}

       bool isAutomaticExercise(){return this->automaticExerciseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAutomaticExercise();
      std::string getAutomaticExerciseIDRef(){return automaticExerciseIDRef_;}

       bool isWrittenConfirmation(){return this->writtenConfirmationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getWrittenConfirmation();
      std::string getWrittenConfirmationIDRef(){return writtenConfirmationIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!americanExerciseIsNull_){
                count += 1;
                str = "americanExercise" ;
           }
           if(!europeanExerciseIsNull_){
                count += 1;
                str = "europeanExercise" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<CommodityPhysicalAmericanExercise> americanExercise_;     //choice
       std::string americanExerciseIDRef_;
       bool americanExerciseIsNull_;
         boost::shared_ptr<CommodityPhysicalEuropeanExercise> europeanExercise_;     //choice
       std::string europeanExerciseIDRef_;
       bool europeanExerciseIsNull_;
       boost::shared_ptr<XsdTypeBoolean> automaticExercise_;
       std::string automaticExerciseIDRef_;
       bool automaticExerciseIsNull_;
       boost::shared_ptr<XsdTypeBoolean> writtenConfirmation_;
       std::string writtenConfirmationIDRef_;
       bool writtenConfirmationIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

