// ReferenceEventCal.hpp 
#ifndef FpmlSerialized_ReferenceEventCal_hpp
#define FpmlSerialized_ReferenceEventCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class ReferenceEventCal : public ISerialized { 
   public: 
       ReferenceEventCal(TiXmlNode* xmlNode);

       bool isRefName(){return this->refNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefName();


   protected: 
       boost::shared_ptr<XsdTypeToken> refName_;
       
       bool refNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

