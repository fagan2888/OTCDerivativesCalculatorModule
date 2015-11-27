// StartingDate.hpp 
#ifndef FpmlSerialized_StartingDate_hpp
#define FpmlSerialized_StartingDate_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/DateReference.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>

namespace FpmlSerialized {

class StartingDate : public ISerialized { 
   public: 
       StartingDate(TiXmlNode* xmlNode);

       bool isDateRelativeTo(){return this->dateRelativeToIsNull_;}
       boost::shared_ptr<DateReference> getDateRelativeTo();
      std::string getDateRelativeToIDRef(){return dateRelativeToIDRef_;}

       bool isAdjustableDate(){return this->adjustableDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getAdjustableDate();
      std::string getAdjustableDateIDRef(){return adjustableDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dateRelativeToIsNull_){
                count += 1;
                str = "dateRelativeTo" ;
           }
           if(!adjustableDateIsNull_){
                count += 1;
                str = "adjustableDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<DateReference> dateRelativeTo_;     //choice
       std::string dateRelativeToIDRef_;
       bool dateRelativeToIsNull_;
         boost::shared_ptr<AdjustableDate> adjustableDate_;     //choice
       std::string adjustableDateIDRef_;
       bool adjustableDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

