// PreDefinedVariableInfo.hpp 
#ifndef FpmlSerialized_PreDefinedVariableInfo_hpp
#define FpmlSerialized_PreDefinedVariableInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixingInformation.hpp>

namespace FpmlSerialized {

class PreDefinedVariableInfo : public ISerialized { 
   public: 
       PreDefinedVariableInfo(TiXmlNode* xmlNode);

       bool isRefInstanceName(){return this->refInstanceNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefInstanceName();


       bool isFixingInformation(){return this->fixingInformationIsNull_;}
       boost::shared_ptr<FixingInformation> getFixingInformation();


   protected: 
       boost::shared_ptr<XsdTypeToken> refInstanceName_;
       
       bool refInstanceNameIsNull_;
       boost::shared_ptr<FixingInformation> fixingInformation_;
       
       bool fixingInformationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

