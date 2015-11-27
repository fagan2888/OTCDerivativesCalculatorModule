// FloatingAmountProvisions.hpp 
#ifndef FpmlSerialized_FloatingAmountProvisions_hpp
#define FpmlSerialized_FloatingAmountProvisions_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class FloatingAmountProvisions : public ISerialized { 
   public: 
       FloatingAmountProvisions(TiXmlNode* xmlNode);

       bool isWACCapInterestProvision(){return this->WACCapInterestProvisionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getWACCapInterestProvision();
      std::string getWACCapInterestProvisionIDRef(){return WACCapInterestProvisionIDRef_;}

       bool isStepUpProvision(){return this->stepUpProvisionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getStepUpProvision();
      std::string getStepUpProvisionIDRef(){return stepUpProvisionIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> WACCapInterestProvision_;
       std::string WACCapInterestProvisionIDRef_;
       bool WACCapInterestProvisionIsNull_;
       boost::shared_ptr<XsdTypeBoolean> stepUpProvision_;
       std::string stepUpProvisionIDRef_;
       bool stepUpProvisionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

