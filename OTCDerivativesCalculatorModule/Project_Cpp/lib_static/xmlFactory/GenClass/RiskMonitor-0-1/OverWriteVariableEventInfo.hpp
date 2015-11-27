// OverWriteVariableEventInfo.hpp 
#ifndef FpmlSerialized_OverWriteVariableEventInfo_hpp
#define FpmlSerialized_OverWriteVariableEventInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class OverWriteVariableEventInfo : public ISerialized { 
   public: 
       OverWriteVariableEventInfo(TiXmlNode* xmlNode);

       bool isUsingRefVarName(){return this->usingRefVarNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUsingRefVarName();


       bool isRefInstanceName(){return this->refInstanceNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefInstanceName();


       bool isInitialTF(){return this->initialTFIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInitialTF();


   protected: 
       boost::shared_ptr<XsdTypeToken> usingRefVarName_;
       
       bool usingRefVarNameIsNull_;
       boost::shared_ptr<XsdTypeToken> refInstanceName_;
       
       bool refInstanceNameIsNull_;
       boost::shared_ptr<XsdTypeToken> initialTF_;
       
       bool initialTFIsNull_;

};

} //namespaceFpmlSerialized end
#endif

