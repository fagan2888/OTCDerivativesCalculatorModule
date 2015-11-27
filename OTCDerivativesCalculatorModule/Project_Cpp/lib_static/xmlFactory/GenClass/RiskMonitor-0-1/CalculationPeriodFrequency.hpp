// CalculationPeriodFrequency.hpp 
#ifndef FpmlSerialized_CalculationPeriodFrequency_hpp
#define FpmlSerialized_CalculationPeriodFrequency_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CalculationPeriodFrequency : public ISerialized { 
   public: 
       CalculationPeriodFrequency(TiXmlNode* xmlNode);

       bool isPeriodMultiplier(){return this->periodMultiplierIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getPeriodMultiplier();


       bool isPeriod(){return this->periodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPeriod();


       bool isRollConvention(){return this->rollConventionIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getRollConvention();


   protected: 
       boost::shared_ptr<XsdTypeInteger> periodMultiplier_;
       
       bool periodMultiplierIsNull_;
       boost::shared_ptr<XsdTypeToken> period_;
       
       bool periodIsNull_;
       boost::shared_ptr<XsdTypeInteger> rollConvention_;
       
       bool rollConventionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

