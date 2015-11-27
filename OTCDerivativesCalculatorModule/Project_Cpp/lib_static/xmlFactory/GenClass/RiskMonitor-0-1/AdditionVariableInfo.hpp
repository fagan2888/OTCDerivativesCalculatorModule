// AdditionVariableInfo.hpp 
#ifndef FpmlSerialized_AdditionVariableInfo_hpp
#define FpmlSerialized_AdditionVariableInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class AdditionVariableInfo : public ISerialized { 
   public: 
       AdditionVariableInfo(TiXmlNode* xmlNode);

       bool isUsingRefVarName(){return this->usingRefVarNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUsingRefVarName();


       bool isRefInstanceName(){return this->refInstanceNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefInstanceName();


       bool isSave(){return this->saveIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSave();


   protected: 
       boost::shared_ptr<XsdTypeToken> usingRefVarName_;
       
       bool usingRefVarNameIsNull_;
       boost::shared_ptr<XsdTypeToken> refInstanceName_;
       
       bool refInstanceNameIsNull_;
       boost::shared_ptr<XsdTypeBoolean> save_;
       
       bool saveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

