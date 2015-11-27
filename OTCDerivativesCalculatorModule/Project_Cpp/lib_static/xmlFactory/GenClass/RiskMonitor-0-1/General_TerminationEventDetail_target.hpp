// General_TerminationEventDetail_target.hpp 
#ifndef FpmlSerialized_General_TerminationEventDetail_target_hpp
#define FpmlSerialized_General_TerminationEventDetail_target_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class General_TerminationEventDetail_target : public ISerialized { 
   public: 
       General_TerminationEventDetail_target(TiXmlNode* xmlNode);

       bool isTarget(){return this->targetIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTarget();


   protected: 
       boost::shared_ptr<XsdTypeToken> target_;
       
       bool targetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

