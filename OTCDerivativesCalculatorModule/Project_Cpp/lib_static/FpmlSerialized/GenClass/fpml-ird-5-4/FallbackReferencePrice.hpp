// FallbackReferencePrice.hpp 
#ifndef FpmlSerialized_FallbackReferencePrice_hpp
#define FpmlSerialized_FallbackReferencePrice_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/ValuationPostponement.hpp>
#include <fpml-ird-5-4/SettlementRateOption.hpp>
#include <fpml-shared-5-4/Empty.hpp>
#include <fpml-shared-5-4/CalculationAgent.hpp>

namespace FpmlSerialized {

class FallbackReferencePrice : public ISerialized { 
   public: 
       FallbackReferencePrice(TiXmlNode* xmlNode);

       bool isValuationPostponement(){return this->valuationPostponementIsNull_;}
       boost::shared_ptr<ValuationPostponement> getValuationPostponement();
      std::string getValuationPostponementIDRef(){return valuationPostponementIDRef_;}

       bool isFallbackSettlementRateOption(){return this->fallbackSettlementRateOptionIsNull_;}
       std::vector<boost::shared_ptr<SettlementRateOption>> getFallbackSettlementRateOption();
      std::string getFallbackSettlementRateOptionIDRef(){return fallbackSettlementRateOptionIDRef_;}

       bool isFallbackSurveyValuationPostponenment(){return this->fallbackSurveyValuationPostponenmentIsNull_;}
       boost::shared_ptr<Empty> getFallbackSurveyValuationPostponenment();
      std::string getFallbackSurveyValuationPostponenmentIDRef(){return fallbackSurveyValuationPostponenmentIDRef_;}

       bool isCalculationAgentDetermination(){return this->calculationAgentDeterminationIsNull_;}
       boost::shared_ptr<CalculationAgent> getCalculationAgentDetermination();
      std::string getCalculationAgentDeterminationIDRef(){return calculationAgentDeterminationIDRef_;}

   protected: 
       boost::shared_ptr<ValuationPostponement> valuationPostponement_;
       std::string valuationPostponementIDRef_;
       bool valuationPostponementIsNull_;
       std::vector<boost::shared_ptr<SettlementRateOption>> fallbackSettlementRateOption_;
       std::string fallbackSettlementRateOptionIDRef_;
       bool fallbackSettlementRateOptionIsNull_;
       boost::shared_ptr<Empty> fallbackSurveyValuationPostponenment_;
       std::string fallbackSurveyValuationPostponenmentIDRef_;
       bool fallbackSurveyValuationPostponenmentIsNull_;
       boost::shared_ptr<CalculationAgent> calculationAgentDetermination_;
       std::string calculationAgentDeterminationIDRef_;
       bool calculationAgentDeterminationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

