// InterestLeg.hpp 
#ifndef FpmlSerialized_InterestLeg_hpp
#define FpmlSerialized_InterestLeg_hpp

#include <fpml-eq-shared-5-4/DirectionalLeg.hpp>
#include <fpml-eq-shared-5-4/InterestLegCalculationPeriodDates.hpp>
#include <fpml-eq-shared-5-4/ReturnSwapNotional.hpp>
#include <fpml-eq-shared-5-4/LegAmount.hpp>
#include <fpml-eq-shared-5-4/InterestCalculation.hpp>
#include <fpml-eq-shared-5-4/StubCalculationPeriod.hpp>

namespace FpmlSerialized {

class InterestLeg : public DirectionalLeg { 
   public: 
       InterestLeg(TiXmlNode* xmlNode);

       bool isInterestLegCalculationPeriodDates(){return this->interestLegCalculationPeriodDatesIsNull_;}
       boost::shared_ptr<InterestLegCalculationPeriodDates> getInterestLegCalculationPeriodDates();
      std::string getInterestLegCalculationPeriodDatesIDRef(){return interestLegCalculationPeriodDatesIDRef_;}

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<ReturnSwapNotional> getNotional();
      std::string getNotionalIDRef(){return notionalIDRef_;}

       bool isInterestAmount(){return this->interestAmountIsNull_;}
       boost::shared_ptr<LegAmount> getInterestAmount();
      std::string getInterestAmountIDRef(){return interestAmountIDRef_;}

       bool isInterestCalculation(){return this->interestCalculationIsNull_;}
       boost::shared_ptr<InterestCalculation> getInterestCalculation();
      std::string getInterestCalculationIDRef(){return interestCalculationIDRef_;}

       bool isStubCalculationPeriod(){return this->stubCalculationPeriodIsNull_;}
       boost::shared_ptr<StubCalculationPeriod> getStubCalculationPeriod();
      std::string getStubCalculationPeriodIDRef(){return stubCalculationPeriodIDRef_;}

   protected: 
       boost::shared_ptr<InterestLegCalculationPeriodDates> interestLegCalculationPeriodDates_;
       std::string interestLegCalculationPeriodDatesIDRef_;
       bool interestLegCalculationPeriodDatesIsNull_;
       boost::shared_ptr<ReturnSwapNotional> notional_;
       std::string notionalIDRef_;
       bool notionalIsNull_;
       boost::shared_ptr<LegAmount> interestAmount_;
       std::string interestAmountIDRef_;
       bool interestAmountIsNull_;
       boost::shared_ptr<InterestCalculation> interestCalculation_;
       std::string interestCalculationIDRef_;
       bool interestCalculationIsNull_;
       boost::shared_ptr<StubCalculationPeriod> stubCalculationPeriod_;
       std::string stubCalculationPeriodIDRef_;
       bool stubCalculationPeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

