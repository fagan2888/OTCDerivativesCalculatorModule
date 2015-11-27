// AdjustableOrRelativeDates.hpp 
#ifndef FpmlSerialized_AdjustableOrRelativeDates_hpp
#define FpmlSerialized_AdjustableOrRelativeDates_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-shared-5-4/RelativeDates.hpp>

namespace FpmlSerialized {

class AdjustableOrRelativeDates : public ISerialized { 
   public: 
       AdjustableOrRelativeDates(TiXmlNode* xmlNode);

       bool isAdjustableDates(){return this->adjustableDatesIsNull_;}
       boost::shared_ptr<AdjustableDates> getAdjustableDates();
      std::string getAdjustableDatesIDRef(){return adjustableDatesIDRef_;}

       bool isRelativeDates(){return this->relativeDatesIsNull_;}
       boost::shared_ptr<RelativeDates> getRelativeDates();
      std::string getRelativeDatesIDRef(){return relativeDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!adjustableDatesIsNull_){
                count += 1;
                str = "adjustableDates" ;
           }
           if(!relativeDatesIsNull_){
                count += 1;
                str = "relativeDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AdjustableDates> adjustableDates_;     //choice
       std::string adjustableDatesIDRef_;
       bool adjustableDatesIsNull_;
         boost::shared_ptr<RelativeDates> relativeDates_;     //choice
       std::string relativeDatesIDRef_;
       bool relativeDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

