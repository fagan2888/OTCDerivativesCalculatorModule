// CreditCurveValuation.hpp 
#ifndef FpmlSerialized_CreditCurveValuation_hpp
#define FpmlSerialized_CreditCurveValuation_hpp

#include <fpml-riskdef-5-4/PricingStructureValuation.hpp>
#include <fpml-riskdef-5-4/QuotedAssetSet.hpp>
#include <fpml-mktenv-5-4/DefaultProbabilityCurve.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-mktenv-5-4/TermCurve.hpp>

namespace FpmlSerialized {

class CreditCurveValuation : public PricingStructureValuation { 
   public: 
       CreditCurveValuation(TiXmlNode* xmlNode);

       bool isInputs(){return this->inputsIsNull_;}
       boost::shared_ptr<QuotedAssetSet> getInputs();
      std::string getInputsIDRef(){return inputsIDRef_;}

       bool isDefaultProbabilityCurve(){return this->defaultProbabilityCurveIsNull_;}
       boost::shared_ptr<DefaultProbabilityCurve> getDefaultProbabilityCurve();
      std::string getDefaultProbabilityCurveIDRef(){return defaultProbabilityCurveIDRef_;}

       bool isRecoveryRate(){return this->recoveryRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getRecoveryRate();
      std::string getRecoveryRateIDRef(){return recoveryRateIDRef_;}

       bool isRecoveryRateCurve(){return this->recoveryRateCurveIsNull_;}
       boost::shared_ptr<TermCurve> getRecoveryRateCurve();
      std::string getRecoveryRateCurveIDRef(){return recoveryRateCurveIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!recoveryRateIsNull_){
                count += 1;
                str = "recoveryRate" ;
           }
           if(!recoveryRateCurveIsNull_){
                count += 1;
                str = "recoveryRateCurve" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<QuotedAssetSet> inputs_;
       std::string inputsIDRef_;
       bool inputsIsNull_;
       boost::shared_ptr<DefaultProbabilityCurve> defaultProbabilityCurve_;
       std::string defaultProbabilityCurveIDRef_;
       bool defaultProbabilityCurveIsNull_;
         boost::shared_ptr<XsdTypeDecimal> recoveryRate_;     //choice
       std::string recoveryRateIDRef_;
       bool recoveryRateIsNull_;
         boost::shared_ptr<TermCurve> recoveryRateCurve_;     //choice
       std::string recoveryRateCurveIDRef_;
       bool recoveryRateCurveIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

