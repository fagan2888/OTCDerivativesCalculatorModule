// RefVariable_referenceValue.hpp 
#ifndef FpmlSerialized_RefVariable_referenceValue_hpp
#define FpmlSerialized_RefVariable_referenceValue_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/VariableInfo.hpp>

namespace FpmlSerialized {

class RefVariable_referenceValue : public ISerialized { 
   public: 
       RefVariable_referenceValue(TiXmlNode* xmlNode);

       bool isVariableInfo(){return this->variableInfoIsNull_;}
       boost::shared_ptr<VariableInfo> getVariableInfo();


   protected: 
       boost::shared_ptr<VariableInfo> variableInfo_;
       
       bool variableInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

