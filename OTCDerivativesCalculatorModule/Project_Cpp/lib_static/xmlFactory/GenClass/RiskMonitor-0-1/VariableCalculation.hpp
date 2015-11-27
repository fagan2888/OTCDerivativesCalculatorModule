// VariableCalculation.hpp 
#ifndef FpmlSerialized_VariableCalculation_hpp
#define FpmlSerialized_VariableCalculation_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/Operator1DList.hpp>
#include <RiskMonitor-0-1/ConditionOperator.hpp>

namespace FpmlSerialized {

class VariableCalculation : public ISerialized { 
   public: 
       VariableCalculation(TiXmlNode* xmlNode);

       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isOperator1DList(){return this->operator1DListIsNull_;}
       boost::shared_ptr<Operator1DList> getOperator1DList();


       bool isConditionOperator(){return this->conditionOperatorIsNull_;}
       boost::shared_ptr<ConditionOperator> getConditionOperator();


   protected: 
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       boost::shared_ptr<Operator1DList> operator1DList_;
       
       bool operator1DListIsNull_;
       boost::shared_ptr<ConditionOperator> conditionOperator_;
       
       bool conditionOperatorIsNull_;

};

} //namespaceFpmlSerialized end
#endif

