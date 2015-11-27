// CashSettlementPaymentDate.hpp 
#ifndef FpmlSerialized_CashSettlementPaymentDate_hpp
#define FpmlSerialized_CashSettlementPaymentDate_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/BusinessDateRange.hpp>

namespace FpmlSerialized {

class CashSettlementPaymentDate : public ISerialized { 
   public: 
       CashSettlementPaymentDate(TiXmlNode* xmlNode);

       bool isAdjustableDates(){return this->adjustableDatesIsNull_;}
       boost::shared_ptr<AdjustableDates> getAdjustableDates();
      std::string getAdjustableDatesIDRef(){return adjustableDatesIDRef_;}

       bool isRelativeDate(){return this->relativeDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getRelativeDate();
      std::string getRelativeDateIDRef(){return relativeDateIDRef_;}

       bool isBusinessDateRange(){return this->businessDateRangeIsNull_;}
       boost::shared_ptr<BusinessDateRange> getBusinessDateRange();
      std::string getBusinessDateRangeIDRef(){return businessDateRangeIDRef_;}

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
           if(!businessDateRangeIsNull_){
                count += 1;
                str = "businessDateRange" ;
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
         boost::shared_ptr<BusinessDateRange> businessDateRange_;     //choice
       std::string businessDateRangeIDRef_;
       bool businessDateRangeIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

