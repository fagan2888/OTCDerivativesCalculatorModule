// AdjustableDateOrRelativeDateSequence.hpp 
#ifndef FpmlSerialized_AdjustableDateOrRelativeDateSequence_hpp
#define FpmlSerialized_AdjustableDateOrRelativeDateSequence_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <fpml-shared-5-4/RelativeDateSequence.hpp>

namespace FpmlSerialized {

class AdjustableDateOrRelativeDateSequence : public ISerialized { 
   public: 
       AdjustableDateOrRelativeDateSequence(TiXmlNode* xmlNode);

       bool isAdjustableDate(){return this->adjustableDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getAdjustableDate();
      std::string getAdjustableDateIDRef(){return adjustableDateIDRef_;}

       bool isRelativeDateSequence(){return this->relativeDateSequenceIsNull_;}
       boost::shared_ptr<RelativeDateSequence> getRelativeDateSequence();
      std::string getRelativeDateSequenceIDRef(){return relativeDateSequenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!adjustableDateIsNull_){
                count += 1;
                str = "adjustableDate" ;
           }
           if(!relativeDateSequenceIsNull_){
                count += 1;
                str = "relativeDateSequence" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AdjustableDate> adjustableDate_;     //choice
       std::string adjustableDateIDRef_;
       bool adjustableDateIsNull_;
         boost::shared_ptr<RelativeDateSequence> relativeDateSequence_;     //choice
       std::string relativeDateSequenceIDRef_;
       bool relativeDateSequenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

