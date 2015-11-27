// RefVariable_returnValue.hpp 
#ifndef FpmlSerialized_RefVariable_returnValue_hpp
#define FpmlSerialized_RefVariable_returnValue_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/VariableInfo.hpp>

namespace FpmlSerialized {

class RefVariable_returnValue : public ISerialized { 
   public: 
       RefVariable_returnValue(TiXmlNode* xmlNode);

       bool isVariableInfo(){return this->variableInfoIsNull_;}
       boost::shared_ptr<VariableInfo> getVariableInfo();


   protected: 
       boost::shared_ptr<VariableInfo> variableInfo_;
       
       bool variableInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

