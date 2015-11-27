// WeightedAveragingObservation.hpp 
#ifndef FpmlSerialized_WeightedAveragingObservation_hpp
#define FpmlSerialized_WeightedAveragingObservation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class WeightedAveragingObservation : public ISerialized { 
   public: 
       WeightedAveragingObservation(TiXmlNode* xmlNode);

       bool isDateTime(){return this->dateTimeIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getDateTime();
      std::string getDateTimeIDRef(){return dateTimeIDRef_;}

       bool isObservationNumber(){return this->observationNumberIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getObservationNumber();
      std::string getObservationNumberIDRef(){return observationNumberIDRef_;}

       bool isWeight(){return this->weightIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getWeight();
      std::string getWeightIDRef(){return weightIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dateTimeIsNull_){
                count += 1;
                str = "dateTime" ;
           }
           if(!observationNumberIsNull_){
                count += 1;
                str = "observationNumber" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDateTime> dateTime_;     //choice
       std::string dateTimeIDRef_;
       bool dateTimeIsNull_;
         boost::shared_ptr<XsdTypePositiveInteger> observationNumber_;     //choice
       std::string observationNumberIDRef_;
       bool observationNumberIsNull_;
       boost::shared_ptr<NonNegativeDecimal> weight_;
       std::string weightIDRef_;
       bool weightIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

