// EquityValuation.hpp 
#ifndef FpmlSerialized_EquityValuation_hpp
#define FpmlSerialized_EquityValuation_hpp

#include <ISerialized.hpp>
#include <fpml-eq-shared-5-4/AdjustableDateOrRelativeDateSequence.hpp>
#include <fpml-shared-5-4/AdjustableRelativeOrPeriodicDates.hpp>
#include <fpml-enum-5-4/TimeTypeEnum.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>
#include <fpml-enum-5-4/FPVFinalPriceElectionFallbackEnum.hpp>

namespace FpmlSerialized {

class EquityValuation : public ISerialized { 
   public: 
       EquityValuation(TiXmlNode* xmlNode);

       bool isValuationDate(){return this->valuationDateIsNull_;}
       boost::shared_ptr<AdjustableDateOrRelativeDateSequence> getValuationDate();
      std::string getValuationDateIDRef(){return valuationDateIDRef_;}

       bool isValuationDates(){return this->valuationDatesIsNull_;}
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates> getValuationDates();
      std::string getValuationDatesIDRef(){return valuationDatesIDRef_;}

       bool isValuationTimeType(){return this->valuationTimeTypeIsNull_;}
       boost::shared_ptr<TimeTypeEnum> getValuationTimeType();
      std::string getValuationTimeTypeIDRef(){return valuationTimeTypeIDRef_;}

       bool isValuationTime(){return this->valuationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getValuationTime();
      std::string getValuationTimeIDRef(){return valuationTimeIDRef_;}

       bool isFuturesPriceValuation(){return this->futuresPriceValuationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFuturesPriceValuation();
      std::string getFuturesPriceValuationIDRef(){return futuresPriceValuationIDRef_;}

       bool isOptionsPriceValuation(){return this->optionsPriceValuationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getOptionsPriceValuation();
      std::string getOptionsPriceValuationIDRef(){return optionsPriceValuationIDRef_;}

       bool isNumberOfValuationDates(){return this->numberOfValuationDatesIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getNumberOfValuationDates();
      std::string getNumberOfValuationDatesIDRef(){return numberOfValuationDatesIDRef_;}

       bool isDividendValuationDates(){return this->dividendValuationDatesIsNull_;}
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates> getDividendValuationDates();
      std::string getDividendValuationDatesIDRef(){return dividendValuationDatesIDRef_;}

       bool isFPVFinalPriceElectionFallback(){return this->fPVFinalPriceElectionFallbackIsNull_;}
       boost::shared_ptr<FPVFinalPriceElectionFallbackEnum> getFPVFinalPriceElectionFallback();
      std::string getFPVFinalPriceElectionFallbackIDRef(){return fPVFinalPriceElectionFallbackIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!valuationDateIsNull_){
                count += 1;
                str = "valuationDate" ;
           }
           if(!valuationDatesIsNull_){
                count += 1;
                str = "valuationDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AdjustableDateOrRelativeDateSequence> valuationDate_;     //choice
       std::string valuationDateIDRef_;
       bool valuationDateIsNull_;
         boost::shared_ptr<AdjustableRelativeOrPeriodicDates> valuationDates_;     //choice
       std::string valuationDatesIDRef_;
       bool valuationDatesIsNull_;
       boost::shared_ptr<TimeTypeEnum> valuationTimeType_;
       std::string valuationTimeTypeIDRef_;
       bool valuationTimeTypeIsNull_;
       boost::shared_ptr<BusinessCenterTime> valuationTime_;
       std::string valuationTimeIDRef_;
       bool valuationTimeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> futuresPriceValuation_;
       std::string futuresPriceValuationIDRef_;
       bool futuresPriceValuationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> optionsPriceValuation_;
       std::string optionsPriceValuationIDRef_;
       bool optionsPriceValuationIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> numberOfValuationDates_;
       std::string numberOfValuationDatesIDRef_;
       bool numberOfValuationDatesIsNull_;
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates> dividendValuationDates_;
       std::string dividendValuationDatesIDRef_;
       bool dividendValuationDatesIsNull_;
       boost::shared_ptr<FPVFinalPriceElectionFallbackEnum> fPVFinalPriceElectionFallback_;
       std::string fPVFinalPriceElectionFallbackIDRef_;
       bool fPVFinalPriceElectionFallbackIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

