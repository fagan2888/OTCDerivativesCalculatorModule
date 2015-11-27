// DividendPaymentDate.hpp 
#ifndef FpmlSerialized_DividendPaymentDate_hpp
#define FpmlSerialized_DividendPaymentDate_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/DividendDateReferenceEnum.hpp>
#include <fpml-shared-5-4/Offset.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>

namespace FpmlSerialized {

class DividendPaymentDate : public ISerialized { 
   public: 
       DividendPaymentDate(TiXmlNode* xmlNode);

       bool isDividendDateReference(){return this->dividendDateReferenceIsNull_;}
       boost::shared_ptr<DividendDateReferenceEnum> getDividendDateReference();
      std::string getDividendDateReferenceIDRef(){return dividendDateReferenceIDRef_;}

       bool isPaymentDateOffset(){return this->paymentDateOffsetIsNull_;}
       boost::shared_ptr<Offset> getPaymentDateOffset();
      std::string getPaymentDateOffsetIDRef(){return paymentDateOffsetIDRef_;}

       bool isAdjustableDate(){return this->adjustableDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getAdjustableDate();
      std::string getAdjustableDateIDRef(){return adjustableDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dividendDateReferenceIsNull_){
                count += 1;
                str = "dividendDateReference" ;
           }
           if(!paymentDateOffsetIsNull_){
                count += 1;
                str = "paymentDateOffset" ;
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
         boost::shared_ptr<DividendDateReferenceEnum> dividendDateReference_;     //choice
       std::string dividendDateReferenceIDRef_;
       bool dividendDateReferenceIsNull_;
         boost::shared_ptr<Offset> paymentDateOffset_;     //choice
       std::string paymentDateOffsetIDRef_;
       bool paymentDateOffsetIsNull_;
         boost::shared_ptr<AdjustableDate> adjustableDate_;     //choice
       std::string adjustableDateIDRef_;
       bool adjustableDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

