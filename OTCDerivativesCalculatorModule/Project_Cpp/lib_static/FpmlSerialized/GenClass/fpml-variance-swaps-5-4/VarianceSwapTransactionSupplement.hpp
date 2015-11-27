// VarianceSwapTransactionSupplement.hpp 
#ifndef FpmlSerialized_VarianceSwapTransactionSupplement_hpp
#define FpmlSerialized_VarianceSwapTransactionSupplement_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-variance-swaps-5-4/VarianceLeg.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>

namespace FpmlSerialized {

class VarianceSwapTransactionSupplement : public Product { 
   public: 
       VarianceSwapTransactionSupplement(TiXmlNode* xmlNode);

       bool isVarianceLeg(){return this->varianceLegIsNull_;}
       std::vector<boost::shared_ptr<VarianceLeg>> getVarianceLeg();
      std::string getVarianceLegIDRef(){return varianceLegIDRef_;}

       bool isMultipleExchangeIndexAnnexFallback(){return this->multipleExchangeIndexAnnexFallbackIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMultipleExchangeIndexAnnexFallback();
      std::string getMultipleExchangeIndexAnnexFallbackIDRef(){return multipleExchangeIndexAnnexFallbackIDRef_;}

       bool isComponentSecurityIndexAnnexFallback(){return this->componentSecurityIndexAnnexFallbackIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getComponentSecurityIndexAnnexFallback();
      std::string getComponentSecurityIndexAnnexFallbackIDRef(){return componentSecurityIndexAnnexFallbackIDRef_;}

       bool isLocalJurisdiction(){return this->localJurisdictionIsNull_;}
       boost::shared_ptr<CountryCode> getLocalJurisdiction();
      std::string getLocalJurisdictionIDRef(){return localJurisdictionIDRef_;}

       bool isRelevantJurisdiction(){return this->relevantJurisdictionIsNull_;}
       boost::shared_ptr<CountryCode> getRelevantJurisdiction();
      std::string getRelevantJurisdictionIDRef(){return relevantJurisdictionIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!multipleExchangeIndexAnnexFallbackIsNull_){
                count += 1;
                str = "multipleExchangeIndexAnnexFallback" ;
           }
           if(!componentSecurityIndexAnnexFallbackIsNull_){
                count += 1;
                str = "componentSecurityIndexAnnexFallback" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       std::vector<boost::shared_ptr<VarianceLeg>> varianceLeg_;
       std::string varianceLegIDRef_;
       bool varianceLegIsNull_;
         boost::shared_ptr<XsdTypeBoolean> multipleExchangeIndexAnnexFallback_;     //choice
       std::string multipleExchangeIndexAnnexFallbackIDRef_;
       bool multipleExchangeIndexAnnexFallbackIsNull_;
         boost::shared_ptr<XsdTypeBoolean> componentSecurityIndexAnnexFallback_;     //choice
       std::string componentSecurityIndexAnnexFallbackIDRef_;
       bool componentSecurityIndexAnnexFallbackIsNull_;
       boost::shared_ptr<CountryCode> localJurisdiction_;
       std::string localJurisdictionIDRef_;
       bool localJurisdictionIsNull_;
       boost::shared_ptr<CountryCode> relevantJurisdiction_;
       std::string relevantJurisdictionIDRef_;
       bool relevantJurisdictionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

