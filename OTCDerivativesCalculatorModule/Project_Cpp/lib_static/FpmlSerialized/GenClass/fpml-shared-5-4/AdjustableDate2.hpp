// AdjustableDate2.hpp 
#ifndef FpmlSerialized_AdjustableDate2_hpp
#define FpmlSerialized_AdjustableDate2_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustmentsReference.hpp>

namespace FpmlSerialized {

class AdjustableDate2 : public ISerialized { 
   public: 
       AdjustableDate2(TiXmlNode* xmlNode);

       bool isUnadjustedDate(){return this->unadjustedDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getUnadjustedDate();
      std::string getUnadjustedDateIDRef(){return unadjustedDateIDRef_;}

       bool isDateAdjustments(){return this->dateAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getDateAdjustments();
      std::string getDateAdjustmentsIDRef(){return dateAdjustmentsIDRef_;}

       bool isDateAdjustmentsReference(){return this->dateAdjustmentsReferenceIsNull_;}
       boost::shared_ptr<BusinessDayAdjustmentsReference> getDateAdjustmentsReference();
      std::string getDateAdjustmentsReferenceIDRef(){return dateAdjustmentsReferenceIDRef_;}

       bool isAdjustedDate(){return this->adjustedDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getAdjustedDate();
      std::string getAdjustedDateIDRef(){return adjustedDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dateAdjustmentsIsNull_){
                count += 1;
                str = "dateAdjustments" ;
           }
           if(!dateAdjustmentsReferenceIsNull_){
                count += 1;
                str = "dateAdjustmentsReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<IdentifiedDate> unadjustedDate_;
       std::string unadjustedDateIDRef_;
       bool unadjustedDateIsNull_;
         boost::shared_ptr<BusinessDayAdjustments> dateAdjustments_;     //choice
       std::string dateAdjustmentsIDRef_;
       bool dateAdjustmentsIsNull_;
         boost::shared_ptr<BusinessDayAdjustmentsReference> dateAdjustmentsReference_;     //choice
       std::string dateAdjustmentsReferenceIDRef_;
       bool dateAdjustmentsReferenceIsNull_;
       boost::shared_ptr<IdentifiedDate> adjustedDate_;
       std::string adjustedDateIDRef_;
       bool adjustedDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

