// ValuationDate.hpp 
#ifndef FpmlSerialized_ValuationDate_hpp
#define FpmlSerialized_ValuationDate_hpp

#include <ISerialized.hpp>
#include <fpml-cd-5-4/SingleValuationDate.hpp>
#include <fpml-cd-5-4/MultipleValuationDates.hpp>

namespace FpmlSerialized {

class ValuationDate : public ISerialized { 
   public: 
       ValuationDate(TiXmlNode* xmlNode);

       bool isSingleValuationDate(){return this->singleValuationDateIsNull_;}
       boost::shared_ptr<SingleValuationDate> getSingleValuationDate();
      std::string getSingleValuationDateIDRef(){return singleValuationDateIDRef_;}

       bool isMultipleValuationDates(){return this->multipleValuationDatesIsNull_;}
       boost::shared_ptr<MultipleValuationDates> getMultipleValuationDates();
      std::string getMultipleValuationDatesIDRef(){return multipleValuationDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!singleValuationDateIsNull_){
                count += 1;
                str = "singleValuationDate" ;
           }
           if(!multipleValuationDatesIsNull_){
                count += 1;
                str = "multipleValuationDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<SingleValuationDate> singleValuationDate_;     //choice
       std::string singleValuationDateIDRef_;
       bool singleValuationDateIsNull_;
         boost::shared_ptr<MultipleValuationDates> multipleValuationDates_;     //choice
       std::string multipleValuationDatesIDRef_;
       bool multipleValuationDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

