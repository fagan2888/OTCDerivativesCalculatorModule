// DividendPayout.hpp 
#ifndef FpmlSerialized_DividendPayout_hpp
#define FpmlSerialized_DividendPayout_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-asset-5-4/PendingPayment.hpp>

namespace FpmlSerialized {

class DividendPayout : public ISerialized { 
   public: 
       DividendPayout(TiXmlNode* xmlNode);

       bool isDividendPayoutRatio(){return this->dividendPayoutRatioIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getDividendPayoutRatio();
      std::string getDividendPayoutRatioIDRef(){return dividendPayoutRatioIDRef_;}

       bool isDividendPayoutConditions(){return this->dividendPayoutConditionsIsNull_;}
       boost::shared_ptr<XsdTypeString> getDividendPayoutConditions();
      std::string getDividendPayoutConditionsIDRef(){return dividendPayoutConditionsIDRef_;}

       bool isDividendPayment(){return this->dividendPaymentIsNull_;}
       std::vector<boost::shared_ptr<PendingPayment>> getDividendPayment();
      std::string getDividendPaymentIDRef(){return dividendPaymentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dividendPayoutRatioIsNull_){
                count += 1;
                str = "dividendPayoutRatio" ;
           }
           if(!dividendPayoutConditionsIsNull_){
                count += 1;
                str = "dividendPayoutConditions" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> dividendPayoutRatio_;     //choice
       std::string dividendPayoutRatioIDRef_;
       bool dividendPayoutRatioIsNull_;
         boost::shared_ptr<XsdTypeString> dividendPayoutConditions_;     //choice
       std::string dividendPayoutConditionsIDRef_;
       bool dividendPayoutConditionsIsNull_;
       std::vector<boost::shared_ptr<PendingPayment>> dividendPayment_;
       std::string dividendPaymentIDRef_;
       bool dividendPaymentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

