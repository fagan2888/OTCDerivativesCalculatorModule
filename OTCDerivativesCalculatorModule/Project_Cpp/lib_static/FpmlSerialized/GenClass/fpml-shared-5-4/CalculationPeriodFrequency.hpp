// CalculationPeriodFrequency.hpp 
#ifndef FpmlSerialized_CalculationPeriodFrequency_hpp
#define FpmlSerialized_CalculationPeriodFrequency_hpp

#include <fpml-shared-5-4/Frequency.hpp>
#include <fpml-enum-5-4/RollConventionEnum.hpp>

namespace FpmlSerialized {

class CalculationPeriodFrequency : public Frequency { 
   public: 
       CalculationPeriodFrequency(TiXmlNode* xmlNode);

       bool isRollConvention(){return this->rollConventionIsNull_;}
       boost::shared_ptr<RollConventionEnum> getRollConvention();
      std::string getRollConventionIDRef(){return rollConventionIDRef_;}

   protected: 
       boost::shared_ptr<RollConventionEnum> rollConvention_;
       std::string rollConventionIDRef_;
       bool rollConventionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

