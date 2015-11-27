// PreConditionEvent.hpp 
#ifndef FpmlSerialized_PreConditionEvent_hpp
#define FpmlSerialized_PreConditionEvent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class PreConditionEvent : public ISerialized { 
   public: 
       PreConditionEvent(TiXmlNode* xmlNode);

       bool isRefName(){return this->refNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefName();


   protected: 
       boost::shared_ptr<XsdTypeToken> refName_;
       
       bool refNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

