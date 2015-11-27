// Complex1DReturnCal.hpp 
#ifndef FpmlSerialized_Complex1DReturnCal_hpp
#define FpmlSerialized_Complex1DReturnCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/VariableCalculation.hpp>

namespace FpmlSerialized {

class Complex1DReturnCal : public ISerialized { 
   public: 
       Complex1DReturnCal(TiXmlNode* xmlNode);

       bool isVariableCalculation(){return this->variableCalculationIsNull_;}
       boost::shared_ptr<VariableCalculation> getVariableCalculation();


   protected: 
       boost::shared_ptr<VariableCalculation> variableCalculation_;
       
       bool variableCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

