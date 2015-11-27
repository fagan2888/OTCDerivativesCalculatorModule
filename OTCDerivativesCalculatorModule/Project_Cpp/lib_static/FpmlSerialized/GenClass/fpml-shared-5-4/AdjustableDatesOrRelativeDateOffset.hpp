// AdjustableDatesOrRelativeDateOffset.hpp 
#ifndef FpmlSerialized_AdjustableDatesOrRelativeDateOffset_hpp
#define FpmlSerialized_AdjustableDatesOrRelativeDateOffset_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>

namespace FpmlSerialized {

class AdjustableDatesOrRelativeDateOffset : public ISerialized { 
   public: 
       AdjustableDatesOrRelativeDateOffset(TiXmlNode* xmlNode);

       bool isAdjustableDates(){return this->adjustableDatesIsNull_;}
       boost::shared_ptr<AdjustableDates> getAdjustableDates();
      std::string getAdjustableDatesIDRef(){return adjustableDatesIDRef_;}

       bool isRelativeDate(){return this->relativeDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getRelativeDate();
      std::string getRelativeDateIDRef(){return relativeDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!adjustableDatesIsNull_){
                count += 1;
                str = "adjustableDates" ;
           }
           if(!relativeDateIsNull_){
                count += 1;
                str = "relativeDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AdjustableDates> adjustableDates_;     //choice
       std::string adjustableDatesIDRef_;
       bool adjustableDatesIsNull_;
         boost::shared_ptr<RelativeDateOffset> relativeDate_;     //choice
       std::string relativeDateIDRef_;
       bool relativeDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

