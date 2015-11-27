// ConditionOperator.hpp 
#ifndef FpmlSerialized_ConditionOperator_hpp
#define FpmlSerialized_ConditionOperator_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/RangeCondition1D.hpp>

namespace FpmlSerialized {

class ConditionOperator : public ISerialized { 
   public: 
       ConditionOperator(TiXmlNode* xmlNode);

       bool isRangeCondition1D(){return this->rangeCondition1DIsNull_;}
       std::vector<boost::shared_ptr<RangeCondition1D>> getRangeCondition1D();


   protected: 
       std::vector<boost::shared_ptr<RangeCondition1D>> rangeCondition1D_;
       
       bool rangeCondition1DIsNull_;

};

} //namespaceFpmlSerialized end
#endif

