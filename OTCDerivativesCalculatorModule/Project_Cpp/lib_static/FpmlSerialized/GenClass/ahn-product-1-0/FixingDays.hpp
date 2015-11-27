// FixingDays.hpp 
#ifndef FpmlSerialized_FixingDays_hpp
#define FpmlSerialized_FixingDays_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>

namespace FpmlSerialized {

class FixingDays : public ISerialized { 
   public: 
       FixingDays(TiXmlNode* xmlNode);

       bool isDays(){return this->daysIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getDays();
      std::string getDaysIDRef(){return daysIDRef_;}

       bool isMonths(){return this->monthsIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getMonths();
      std::string getMonthsIDRef(){return monthsIDRef_;}

       bool isYears(){return this->yearsIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getYears();
      std::string getYearsIDRef(){return yearsIDRef_;}

       std::string getChoiceStr_fixingType(){
           std::string str;
           int count = 0;
           if(!daysIsNull_){
                count += 1;
                str = "days" ;
           }
           if(!monthsIsNull_){
                count += 1;
                str = "months" ;
           }
           if(!yearsIsNull_){
                count += 1;
                str = "years" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_fixingType_ = str ;
           return choiceStr_fixingType_;
       }
   protected: 
         boost::shared_ptr<XsdTypeInteger> days_;     //choice
       std::string daysIDRef_;
       bool daysIsNull_;
         boost::shared_ptr<XsdTypeInteger> months_;     //choice
       std::string monthsIDRef_;
       bool monthsIsNull_;
         boost::shared_ptr<XsdTypeInteger> years_;     //choice
       std::string yearsIDRef_;
       bool yearsIsNull_;

       //choiceStr 
       std::string choiceStr_fixingType_;

};

} //namespaceFpmlSerialized end
#endif

