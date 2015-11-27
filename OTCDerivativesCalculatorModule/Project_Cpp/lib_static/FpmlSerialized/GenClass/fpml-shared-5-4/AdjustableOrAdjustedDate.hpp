// AdjustableOrAdjustedDate.hpp 
#ifndef FpmlSerialized_AdjustableOrAdjustedDate_hpp
#define FpmlSerialized_AdjustableOrAdjustedDate_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>

namespace FpmlSerialized {

class AdjustableOrAdjustedDate : public ISerialized { 
   public: 
       AdjustableOrAdjustedDate(TiXmlNode* xmlNode);

       bool isUnadjustedDate(){return this->unadjustedDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getUnadjustedDate();
      std::string getUnadjustedDateIDRef(){return unadjustedDateIDRef_;}

       bool isDateAdjustments(){return this->dateAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getDateAdjustments();
      std::string getDateAdjustmentsIDRef(){return dateAdjustmentsIDRef_;}

       bool isAdjustedDate(){return this->adjustedDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getAdjustedDate();
      std::string getAdjustedDateIDRef(){return adjustedDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!unadjustedDateIsNull_){
                count += 1;
                str = "unadjustedDate" ;
           }
           if(!dateAdjustmentsIsNull_){
                count += 1;
                str = "dateAdjustments" ;
           }
           if(!adjustedDateIsNull_){
                count += 1;
                str = "adjustedDate" ;
           }
           if(!adjustedDateIsNull_){
                count += 1;
                str = "adjustedDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<IdentifiedDate> unadjustedDate_;     //choice
       std::string unadjustedDateIDRef_;
       bool unadjustedDateIsNull_;
         boost::shared_ptr<BusinessDayAdjustments> dateAdjustments_;     //choice
       std::string dateAdjustmentsIDRef_;
       bool dateAdjustmentsIsNull_;
         boost::shared_ptr<IdentifiedDate> adjustedDate_;     //choice
       std::string adjustedDateIDRef_;
       bool adjustedDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

