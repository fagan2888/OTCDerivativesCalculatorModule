// JointFSubEvent.hpp 
#ifndef FpmlSerialized_JointFSubEvent_hpp
#define FpmlSerialized_JointFSubEvent_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/JointTypeEnum.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class JointFSubEvent : public ISerialized { 
   public: 
       JointFSubEvent(TiXmlNode* xmlNode);

       bool isJointType(){return this->jointTypeIsNull_;}
       boost::shared_ptr<JointTypeEnum> getJointType();
      std::string getJointTypeIDRef(){return jointTypeIDRef_;}

       bool isMainEvent(){return this->mainEventIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMainEvent();
      std::string getMainEventIDRef(){return mainEventIDRef_;}

       bool isSubEvent(){return this->subEventIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSubEvent();
      std::string getSubEventIDRef(){return subEventIDRef_;}

   protected: 
       boost::shared_ptr<JointTypeEnum> jointType_;
       std::string jointTypeIDRef_;
       bool jointTypeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> mainEvent_;
       std::string mainEventIDRef_;
       bool mainEventIsNull_;
       boost::shared_ptr<XsdTypeBoolean> subEvent_;
       std::string subEventIDRef_;
       bool subEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

