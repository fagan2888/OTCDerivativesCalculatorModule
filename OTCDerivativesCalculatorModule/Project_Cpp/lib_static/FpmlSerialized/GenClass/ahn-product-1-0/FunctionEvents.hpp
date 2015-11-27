// FunctionEvents.hpp 
#ifndef FpmlSerialized_FunctionEvents_hpp
#define FpmlSerialized_FunctionEvents_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/EventFunctionM.hpp>
#include <ahn-product-1-0/JointFunctionEvent.hpp>

namespace FpmlSerialized {

class FunctionEvents : public ISerialized { 
   public: 
       FunctionEvents(TiXmlNode* xmlNode);

       bool isEventFunctionM(){return this->eventFunctionMIsNull_;}
       std::vector<boost::shared_ptr<EventFunctionM>> getEventFunctionM();
      std::string getEventFunctionMIDRef(){return eventFunctionMIDRef_;}

       bool isJointFunctionEvent(){return this->jointFunctionEventIsNull_;}
       boost::shared_ptr<JointFunctionEvent> getJointFunctionEvent();
      std::string getJointFunctionEventIDRef(){return jointFunctionEventIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<EventFunctionM>> eventFunctionM_;
       std::string eventFunctionMIDRef_;
       bool eventFunctionMIsNull_;
       boost::shared_ptr<JointFunctionEvent> jointFunctionEvent_;
       std::string jointFunctionEventIDRef_;
       bool jointFunctionEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

