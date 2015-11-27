// SubEvent.hpp 
#ifndef FpmlSerialized_SubEvent_hpp
#define FpmlSerialized_SubEvent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class SubEvent : public ISerialized { 
   public: 
       SubEvent(TiXmlNode* xmlNode);

       bool isRefEventID(){return this->refEventIDIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefEventID();
      std::string getRefEventIDIDRef(){return refEventIDIDRef_;}

       bool isTruefalse(){return this->truefalseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getTruefalse();
      std::string getTruefalseIDRef(){return truefalseIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> refEventID_;
       std::string refEventIDIDRef_;
       bool refEventIDIsNull_;
       boost::shared_ptr<XsdTypeBoolean> truefalse_;
       std::string truefalseIDRef_;
       bool truefalseIsNull_;

};

} //namespaceFpmlSerialized end
#endif

