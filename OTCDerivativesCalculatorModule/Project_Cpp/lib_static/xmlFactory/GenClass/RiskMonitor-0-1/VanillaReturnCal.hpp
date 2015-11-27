// VanillaReturnCal.hpp 
#ifndef FpmlSerialized_VanillaReturnCal_hpp
#define FpmlSerialized_VanillaReturnCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>

namespace FpmlSerialized {

class VanillaReturnCal : public ISerialized { 
   public: 
       VanillaReturnCal(TiXmlNode* xmlNode);

       bool isGearing(){return this->gearingIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getGearing();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getSpread();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


   protected: 
       boost::shared_ptr<XsdTypeDouble> gearing_;
       
       bool gearingIsNull_;
       boost::shared_ptr<XsdTypeDouble> spread_;
       
       bool spreadIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

