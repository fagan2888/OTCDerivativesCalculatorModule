// AdjustableRelativeOrPeriodicDates.hpp 
#ifndef FpmlSerialized_AdjustableRelativeOrPeriodicDates_hpp
#define FpmlSerialized_AdjustableRelativeOrPeriodicDates_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-shared-5-4/RelativeDateSequence.hpp>
#include <fpml-shared-5-4/PeriodicDates.hpp>

namespace FpmlSerialized {

class AdjustableRelativeOrPeriodicDates : public ISerialized { 
   public: 
       AdjustableRelativeOrPeriodicDates(TiXmlNode* xmlNode);

       bool isAdjustableDates(){return this->adjustableDatesIsNull_;}
       boost::shared_ptr<AdjustableDates> getAdjustableDates();
      std::string getAdjustableDatesIDRef(){return adjustableDatesIDRef_;}

       bool isRelativeDateSequence(){return this->relativeDateSequenceIsNull_;}
       boost::shared_ptr<RelativeDateSequence> getRelativeDateSequence();
      std::string getRelativeDateSequenceIDRef(){return relativeDateSequenceIDRef_;}

       bool isPeriodicDates(){return this->periodicDatesIsNull_;}
       boost::shared_ptr<PeriodicDates> getPeriodicDates();
      std::string getPeriodicDatesIDRef(){return periodicDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!adjustableDatesIsNull_){
                count += 1;
                str = "adjustableDates" ;
           }
           if(!relativeDateSequenceIsNull_){
                count += 1;
                str = "relativeDateSequence" ;
           }
           if(!periodicDatesIsNull_){
                count += 1;
                str = "periodicDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AdjustableDates> adjustableDates_;     //choice
       std::string adjustableDatesIDRef_;
       bool adjustableDatesIsNull_;
         boost::shared_ptr<RelativeDateSequence> relativeDateSequence_;     //choice
       std::string relativeDateSequenceIDRef_;
       bool relativeDateSequenceIsNull_;
         boost::shared_ptr<PeriodicDates> periodicDates_;     //choice
       std::string periodicDatesIDRef_;
       bool periodicDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

