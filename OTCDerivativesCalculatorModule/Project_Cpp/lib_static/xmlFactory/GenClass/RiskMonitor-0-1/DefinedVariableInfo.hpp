// DefinedVariableInfo.hpp 
#ifndef FpmlSerialized_DefinedVariableInfo_hpp
#define FpmlSerialized_DefinedVariableInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class DefinedVariableInfo : public ISerialized { 
   public: 
       DefinedVariableInfo(TiXmlNode* xmlNode);

       bool isRefInstanceName(){return this->refInstanceNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefInstanceName();


   protected: 
       boost::shared_ptr<XsdTypeToken> refInstanceName_;
       
       bool refInstanceNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

