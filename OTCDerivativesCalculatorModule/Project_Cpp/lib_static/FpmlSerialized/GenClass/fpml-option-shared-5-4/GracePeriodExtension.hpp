// GracePeriodExtension.hpp 
#ifndef FpmlSerialized_GracePeriodExtension_hpp
#define FpmlSerialized_GracePeriodExtension_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Offset.hpp>

namespace FpmlSerialized {

class GracePeriodExtension : public ISerialized { 
   public: 
       GracePeriodExtension(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isGracePeriod(){return this->gracePeriodIsNull_;}
       boost::shared_ptr<Offset> getGracePeriod();
      std::string getGracePeriodIDRef(){return gracePeriodIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       boost::shared_ptr<Offset> gracePeriod_;
       std::string gracePeriodIDRef_;
       bool gracePeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

