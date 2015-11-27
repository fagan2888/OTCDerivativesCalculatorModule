// RefVariable_eventOcc.hpp 
#ifndef FpmlSerialized_RefVariable_eventOcc_hpp
#define FpmlSerialized_RefVariable_eventOcc_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/VariableEventInfo.hpp>

namespace FpmlSerialized {

class RefVariable_eventOcc : public ISerialized { 
   public: 
       RefVariable_eventOcc(TiXmlNode* xmlNode);

       bool isVariableEventInfo(){return this->variableEventInfoIsNull_;}
       boost::shared_ptr<VariableEventInfo> getVariableEventInfo();


   protected: 
       boost::shared_ptr<VariableEventInfo> variableEventInfo_;
       
       bool variableEventInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

