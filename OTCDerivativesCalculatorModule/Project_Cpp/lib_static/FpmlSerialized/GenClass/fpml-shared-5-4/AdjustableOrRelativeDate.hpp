// AdjustableOrRelativeDate.hpp 
#ifndef FpmlSerialized_AdjustableOrRelativeDate_hpp
#define FpmlSerialized_AdjustableOrRelativeDate_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>

namespace FpmlSerialized {

class AdjustableOrRelativeDate : public ISerialized { 
   public: 
       AdjustableOrRelativeDate(TiXmlNode* xmlNode);

       bool isAdjustableDate(){return this->adjustableDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getAdjustableDate();
      std::string getAdjustableDateIDRef(){return adjustableDateIDRef_;}

       bool isRelativeDate(){return this->relativeDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getRelativeDate();
      std::string getRelativeDateIDRef(){return relativeDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!adjustableDateIsNull_){
                count += 1;
                str = "adjustableDate" ;
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
         boost::shared_ptr<AdjustableDate> adjustableDate_;     //choice
       std::string adjustableDateIDRef_;
       bool adjustableDateIsNull_;
         boost::shared_ptr<RelativeDateOffset> relativeDate_;     //choice
       std::string relativeDateIDRef_;
       bool relativeDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

