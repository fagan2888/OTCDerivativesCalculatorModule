// VariableCalList.hpp 
#ifndef FpmlSerialized_VariableCalList_hpp
#define FpmlSerialized_VariableCalList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/VariableCalculation.hpp>

namespace FpmlSerialized {

class VariableCalList : public ISerialized { 
   public: 
       VariableCalList(TiXmlNode* xmlNode);

       bool isVariableCalculation(){return this->variableCalculationIsNull_;}
       boost::shared_ptr<VariableCalculation> getVariableCalculation();


   protected: 
       boost::shared_ptr<VariableCalculation> variableCalculation_;
       
       bool variableCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

