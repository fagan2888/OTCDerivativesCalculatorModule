// JointTimeEvent.hpp 
#ifndef FpmlSerialized_JointTimeEvent_hpp
#define FpmlSerialized_JointTimeEvent_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/TriggerAtleast.hpp>

namespace FpmlSerialized {

class JointTimeEvent : public ISerialized { 
   public: 
       JointTimeEvent(TiXmlNode* xmlNode);

       bool isTriggerAtleast(){return this->triggerAtleastIsNull_;}
       boost::shared_ptr<TriggerAtleast> getTriggerAtleast();
      std::string getTriggerAtleastIDRef(){return triggerAtleastIDRef_;}

   protected: 
       boost::shared_ptr<TriggerAtleast> triggerAtleast_;
       std::string triggerAtleastIDRef_;
       bool triggerAtleastIsNull_;

};

} //namespaceFpmlSerialized end
#endif

