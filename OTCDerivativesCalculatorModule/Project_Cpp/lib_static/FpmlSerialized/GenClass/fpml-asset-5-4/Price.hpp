// Price.hpp 
#ifndef FpmlSerialized_Price_hpp
#define FpmlSerialized_Price_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/Commission.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-asset-5-4/ActualPrice.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/FxConversion.hpp>
#include <fpml-shared-5-4/AmountReference.hpp>
#include <fpml-asset-5-4/QuotationCharacteristics.hpp>

namespace FpmlSerialized {

class Price : public ISerialized { 
   public: 
       Price(TiXmlNode* xmlNode);

       bool isCommission(){return this->commissionIsNull_;}
       boost::shared_ptr<Commission> getCommission();
      std::string getCommissionIDRef(){return commissionIDRef_;}

       bool isDeterminationMethod(){return this->determinationMethodIsNull_;}
       boost::shared_ptr<DeterminationMethod> getDeterminationMethod();
      std::string getDeterminationMethodIDRef(){return determinationMethodIDRef_;}

       bool isGrossPrice(){return this->grossPriceIsNull_;}
       boost::shared_ptr<ActualPrice> getGrossPrice();
      std::string getGrossPriceIDRef(){return grossPriceIDRef_;}

       bool isNetPrice(){return this->netPriceIsNull_;}
       boost::shared_ptr<ActualPrice> getNetPrice();
      std::string getNetPriceIDRef(){return netPriceIDRef_;}

       bool isAccruedInterestPrice(){return this->accruedInterestPriceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAccruedInterestPrice();
      std::string getAccruedInterestPriceIDRef(){return accruedInterestPriceIDRef_;}

       bool isFxConversion(){return this->fxConversionIsNull_;}
       boost::shared_ptr<FxConversion> getFxConversion();
      std::string getFxConversionIDRef(){return fxConversionIDRef_;}

       bool isAmountRelativeTo(){return this->amountRelativeToIsNull_;}
       boost::shared_ptr<AmountReference> getAmountRelativeTo();
      std::string getAmountRelativeToIDRef(){return amountRelativeToIDRef_;}

       bool isCleanNetPrice(){return this->cleanNetPriceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCleanNetPrice();
      std::string getCleanNetPriceIDRef(){return cleanNetPriceIDRef_;}

       bool isQuotationCharacteristics(){return this->quotationCharacteristicsIsNull_;}
       boost::shared_ptr<QuotationCharacteristics> getQuotationCharacteristics();
      std::string getQuotationCharacteristicsIDRef(){return quotationCharacteristicsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!determinationMethodIsNull_){
                count += 1;
                str = "determinationMethod" ;
           }
           if(!grossPriceIsNull_){
                count += 1;
                str = "grossPrice" ;
           }
           if(!netPriceIsNull_){
                count += 1;
                str = "netPrice" ;
           }
           if(!accruedInterestPriceIsNull_){
                count += 1;
                str = "accruedInterestPrice" ;
           }
           if(!fxConversionIsNull_){
                count += 1;
                str = "fxConversion" ;
           }
           if(!amountRelativeToIsNull_){
                count += 1;
                str = "amountRelativeTo" ;
           }
           if(!grossPriceIsNull_){
                count += 1;
                str = "grossPrice" ;
           }
           if(!netPriceIsNull_){
                count += 1;
                str = "netPrice" ;
           }
           if(!accruedInterestPriceIsNull_){
                count += 1;
                str = "accruedInterestPrice" ;
           }
           if(!fxConversionIsNull_){
                count += 1;
                str = "fxConversion" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<Commission> commission_;
       std::string commissionIDRef_;
       bool commissionIsNull_;
         boost::shared_ptr<DeterminationMethod> determinationMethod_;     //choice
       std::string determinationMethodIDRef_;
       bool determinationMethodIsNull_;
         boost::shared_ptr<ActualPrice> grossPrice_;     //choice
       std::string grossPriceIDRef_;
       bool grossPriceIsNull_;
         boost::shared_ptr<ActualPrice> netPrice_;     //choice
       std::string netPriceIDRef_;
       bool netPriceIsNull_;
         boost::shared_ptr<XsdTypeDecimal> accruedInterestPrice_;     //choice
       std::string accruedInterestPriceIDRef_;
       bool accruedInterestPriceIsNull_;
         boost::shared_ptr<FxConversion> fxConversion_;     //choice
       std::string fxConversionIDRef_;
       bool fxConversionIsNull_;
         boost::shared_ptr<AmountReference> amountRelativeTo_;     //choice
       std::string amountRelativeToIDRef_;
       bool amountRelativeToIsNull_;
       boost::shared_ptr<XsdTypeDecimal> cleanNetPrice_;
       std::string cleanNetPriceIDRef_;
       bool cleanNetPriceIsNull_;
       boost::shared_ptr<QuotationCharacteristics> quotationCharacteristics_;
       std::string quotationCharacteristicsIDRef_;
       bool quotationCharacteristicsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

