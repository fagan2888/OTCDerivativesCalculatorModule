// FixedFixingDateInfo.hpp 
#ifndef FpmlSerialized_FixedFixingDateInfo_hpp
#define FpmlSerialized_FixedFixingDateInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class FixedFixingDateInfo : public ISerialized { 
   public: 
       FixedFixingDateInfo(TiXmlNode* xmlNode);

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDate();


       bool isAutoCallFlag(){return this->autoCallFlagIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAutoCallFlag();


       bool isAutoCallFixingDate(){return this->autoCallFixingDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAutoCallFixingDate();


   protected: 
       boost::shared_ptr<XsdTypeToken> date_;
       
       bool dateIsNull_;
       boost::shared_ptr<XsdTypeBoolean> autoCallFlag_;
       
       bool autoCallFlagIsNull_;
       boost::shared_ptr<XsdTypeDate> autoCallFixingDate_;
       
       bool autoCallFixingDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

