// JointSubEvent.hpp 
#ifndef FpmlSerialized_JointSubEvent_hpp
#define FpmlSerialized_JointSubEvent_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/JointTypeEnum.hpp>
#include <ahn-product-1-0/SubEvent.hpp>

namespace FpmlSerialized {

class JointSubEvent : public ISerialized { 
   public: 
       JointSubEvent(TiXmlNode* xmlNode);

       bool isJointType(){return this->jointTypeIsNull_;}
       boost::shared_ptr<JointTypeEnum> getJointType();
      std::string getJointTypeIDRef(){return jointTypeIDRef_;}

       bool isSubEvent(){return this->subEventIsNull_;}
       std::vector<boost::shared_ptr<SubEvent>> getSubEvent();
      std::string getSubEventIDRef(){return subEventIDRef_;}

   protected: 
       boost::shared_ptr<JointTypeEnum> jointType_;
       std::string jointTypeIDRef_;
       bool jointTypeIsNull_;
       std::vector<boost::shared_ptr<SubEvent>> subEvent_;
       std::string subEventIDRef_;
       bool subEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

