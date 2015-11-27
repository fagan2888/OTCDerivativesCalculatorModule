// RefVariableFixingDateInfo.hpp 
#ifndef FpmlSerialized_RefVariableFixingDateInfo_hpp
#define FpmlSerialized_RefVariableFixingDateInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class RefVariableFixingDateInfo : public ISerialized { 
   public: 
       RefVariableFixingDateInfo(TiXmlNode* xmlNode);

       bool isRefDateName(){return this->refDateNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefDateName();


       bool isAutoCallFlag(){return this->autoCallFlagIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAutoCallFlag();


       bool isAutoCallFixingDate(){return this->autoCallFixingDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAutoCallFixingDate();


   protected: 
       boost::shared_ptr<XsdTypeToken> refDateName_;
       
       bool refDateNameIsNull_;
       boost::shared_ptr<XsdTypeBoolean> autoCallFlag_;
       
       bool autoCallFlagIsNull_;
       boost::shared_ptr<XsdTypeDate> autoCallFixingDate_;
       
       bool autoCallFixingDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

