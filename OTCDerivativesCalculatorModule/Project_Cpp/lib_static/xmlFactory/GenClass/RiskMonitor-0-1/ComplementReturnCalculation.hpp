// ComplementReturnCalculation.hpp 
#ifndef FpmlSerialized_ComplementReturnCalculation_hpp
#define FpmlSerialized_ComplementReturnCalculation_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ReturnCalculationInfo.hpp>

namespace FpmlSerialized {

class ComplementReturnCalculation : public ISerialized { 
   public: 
       ComplementReturnCalculation(TiXmlNode* xmlNode);

       bool isReturnCalculationInfo(){return this->returnCalculationInfoIsNull_;}
       boost::shared_ptr<ReturnCalculationInfo> getReturnCalculationInfo();


   protected: 
       boost::shared_ptr<ReturnCalculationInfo> returnCalculationInfo_;
       
       bool returnCalculationInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

