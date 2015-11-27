// MandatoryEarlyTermination.hpp 
#ifndef FpmlSerialized_MandatoryEarlyTermination_hpp
#define FpmlSerialized_MandatoryEarlyTermination_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <fpml-shared-5-4/CalculationAgent.hpp>
#include <fpml-ird-5-4/CashSettlement.hpp>
#include <fpml-ird-5-4/MandatoryEarlyTerminationAdjustedDates.hpp>

namespace FpmlSerialized {

class MandatoryEarlyTermination : public ISerialized { 
   public: 
       MandatoryEarlyTermination(TiXmlNode* xmlNode);

       bool isMandatoryEarlyTerminationDate(){return this->mandatoryEarlyTerminationDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getMandatoryEarlyTerminationDate();
      std::string getMandatoryEarlyTerminationDateIDRef(){return mandatoryEarlyTerminationDateIDRef_;}

       bool isCalculationAgent(){return this->calculationAgentIsNull_;}
       boost::shared_ptr<CalculationAgent> getCalculationAgent();
      std::string getCalculationAgentIDRef(){return calculationAgentIDRef_;}

       bool isCashSettlement(){return this->cashSettlementIsNull_;}
       boost::shared_ptr<CashSettlement> getCashSettlement();
      std::string getCashSettlementIDRef(){return cashSettlementIDRef_;}

       bool isMandatoryEarlyTerminationAdjustedDates(){return this->mandatoryEarlyTerminationAdjustedDatesIsNull_;}
       boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates> getMandatoryEarlyTerminationAdjustedDates();
      std::string getMandatoryEarlyTerminationAdjustedDatesIDRef(){return mandatoryEarlyTerminationAdjustedDatesIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableDate> mandatoryEarlyTerminationDate_;
       std::string mandatoryEarlyTerminationDateIDRef_;
       bool mandatoryEarlyTerminationDateIsNull_;
       boost::shared_ptr<CalculationAgent> calculationAgent_;
       std::string calculationAgentIDRef_;
       bool calculationAgentIsNull_;
       boost::shared_ptr<CashSettlement> cashSettlement_;
       std::string cashSettlementIDRef_;
       bool cashSettlementIsNull_;
       boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates> mandatoryEarlyTerminationAdjustedDates_;
       std::string mandatoryEarlyTerminationAdjustedDatesIDRef_;
       bool mandatoryEarlyTerminationAdjustedDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

