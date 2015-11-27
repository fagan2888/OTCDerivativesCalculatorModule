// LowerBarrierEventCal.hpp 
#ifndef FpmlSerialized_LowerBarrierEventCal_hpp
#define FpmlSerialized_LowerBarrierEventCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/DateInformation.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>

namespace FpmlSerialized {

class LowerBarrierEventCal : public ISerialized { 
   public: 
       LowerBarrierEventCal(TiXmlNode* xmlNode);

       bool isDateInformation(){return this->dateInformationIsNull_;}
       std::vector<boost::shared_ptr<DateInformation>> getDateInformation();


       bool isLowerTrigger(){return this->lowerTriggerIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDouble>> getLowerTrigger();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


   protected: 
       std::vector<boost::shared_ptr<DateInformation>> dateInformation_;
       
       bool dateInformationIsNull_;
       std::vector<boost::shared_ptr<XsdTypeDouble>> lowerTrigger_;
       
       bool lowerTriggerIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

