// JointFunctionEvent.hpp 
#ifndef FpmlSerialized_JointFunctionEvent_hpp
#define FpmlSerialized_JointFunctionEvent_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/JointTypeEnum.hpp>
#include <ahn-product-1-0/Functions.hpp>

namespace FpmlSerialized {

class JointFunctionEvent : public ISerialized { 
   public: 
       JointFunctionEvent(TiXmlNode* xmlNode);

       bool isJointType(){return this->jointTypeIsNull_;}
       boost::shared_ptr<JointTypeEnum> getJointType();
      std::string getJointTypeIDRef(){return jointTypeIDRef_;}

       bool isFunctions(){return this->functionsIsNull_;}
       boost::shared_ptr<Functions> getFunctions();
      std::string getFunctionsIDRef(){return functionsIDRef_;}

   protected: 
       boost::shared_ptr<JointTypeEnum> jointType_;
       std::string jointTypeIDRef_;
       bool jointTypeIsNull_;
       boost::shared_ptr<Functions> functions_;
       std::string functionsIDRef_;
       bool functionsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

